using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    enum Color
    {
        Red,
        Green,
        Grey,
        Black
    }
    
    class Point
    {
        public int x;
        public int y;
        public Color color;
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
            //Point p = new Point();
            //p.x = 4;
            //p.y = 2;
            //p.color = Color.Green;

            //Point p2 = new Point
            //{
            //    x = 2,
            //    y = 6,
            //    color = Color.Grey
            //};

            var firstStudent = GetStudent();

            firstStudent.Print();
        }
    }
}
