// using System;
// namespace inheritance {
//     class Person {
//         public string name = "";
//         public int age;

//         public void displayInfo() {
//             Console.WriteLine("Name  " + name + " Age  " + age);
//         }
//     }

//     class Student : Person {
//         public string Course = "";
//         public int id;

//         public void studentinfo() {
//            displayInfo();
//             Console.WriteLine("Course  " + Course + " ID  " + id);
//         }
//     }

//     class Teacher :Student
//     {
        

//     }

//     class executeInheritance {
//         public static void Main(string[] args) {
//             Student s = new Student();
//             s.name = "gunjan";
//             s.age = 22;
//             s.Course = "BCA";
//             s.id = 33;
//             s.studentinfo();
//             Teacher t =new Teacher();
//             t.name ="Sameer";
//             t.age=40;
//             t.Course="MCA";
//             t.id=88;
//             t.displayInfo();
//             t.studentinfo();

//         }
//     }
// }
