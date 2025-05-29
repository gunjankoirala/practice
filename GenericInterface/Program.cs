using System;

namespace SimpleNotificationService
{
    public interface INotifier<T>
    {
        void Send(T notification);
    }

    public class EmailNotification
    {
        public required string To{get; set;}
        public required string Subject{get; set;}
        public  required string Body{get; set;}
    }

    public class SMSNotification
    {
        public required string PhoneNumber{get; set;}
        public required string Message{get; set;}
        
    }

    public class EmailNotifier : INotifier<EmailNotification>
    {
        public void Send(EmailNotification n)
        {
            Console.WriteLine($"Email to {n.To}: {n.Subject} - {n.Body}");
        }
    }

    public class SMSNotifier : INotifier<SMSNotification>
    {
        public void Send(SMSNotification n)
        {
            Console.WriteLine($"SMS to {n.PhoneNumber}: {n.Message}");
        }
    }

    class Program
    {
        static void Main()
        {
            var email = new EmailNotification
            {
                To = "gunjan@gmail.com",
                Subject = "Greetings",
                Body = "Welcome to our system"
            };

            var sms = new SMSNotification
            {
                PhoneNumber = "980348592",
                Message = "You have been appointed"
            };

            new EmailNotifier().Send(email);
            new SMSNotifier().Send(sms);
        }
    }
}
