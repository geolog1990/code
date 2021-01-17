using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OOP
{
    enum Color
    {
        Red,
        Green,
        Grey,
        Black
    }
    
       
    class Program
    {
        static Student GetStudent() 
        {
            Student student = new Student();

            student.firstName = "Мартин";
            student.lastName = "Лютер";
            student.middleName = "Кинг";
            student.id = Guid.NewGuid();
            student.age = 19;
            student.group = "ЙЦУКЕН-1";

            return student;
        }

        //static void Print(Student student) 
        //{
        //    Console.WriteLine("Информация о студенте:");
        //    Console.WriteLine($"Id: {student.id}"); ;
        //    Console.WriteLine($"Фамилия: {student.lastName}");
        //    Console.WriteLine($"Имя: {student.firstName}");
        //    Console.WriteLine($"Отчество: {student.middleName}");
        //    Console.WriteLine($"Возраст: {student.age}");
        //    Console.WriteLine($"Группа: {student.group}");
        //}
        
        static void Main(string[] args)
        {
            //var TypeInfo = typeof(Point).
            //    GetFields(BindingFlags.Instance | 
            //    BindingFlags.NonPublic | 
            //    BindingFlags.Public);
            //foreach (var item in TypeInfo) 
            //{
            //    Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
            //}



            //var firstStudent = GetStudent();
            //firstStudent.Print();

            //Student secondStudent = new Student();
            //secondStudent.Print();

            //string d = firstStudent.GetFullName();
            //Console.ReadLine();

            //Console.WriteLine("\t== Car 1 ==");

            //var car = new Car();
            //car.DriveForward();
            //car.PrintSpeed();
            //car.Stop();
            //car.PrintSpeed();

            //Console.WriteLine("\t== Car 2 ==");
            //var car2 = new Car();
            //car2.PrintSpeed();
            //car2.DriveBackward();
            //car2.PrintSpeed();

            Gun gun = new Gun();
            gun.Shoot();

        }
    }
}
 