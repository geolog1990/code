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
        private int y;
        public Color color;

        private void PrintX() 
        {
            Console.WriteLine($"X: {x}");
        }

        public void PrintY() 
        {
            Console.WriteLine($"Y: {y}");
        }
    }

    class Car
    {
        private int speed = 0;

        public void PrintSpeed() 
        {
            if (speed == 0)
            {
                Console.WriteLine("Стоим на месте...");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Едем вперед со скоростью {speed} км/ч");
            }
            if (speed < 0)
            {
                Console.WriteLine($"Едем назад со скоростью {-speed} км/ч");
            }
        }

        public void DriveForward() 
        {
            speed = 60;        
        }

        public void Stop()
        {
            speed = 0;
        }

        public void DriveBackward() 
        {
            speed = -5;
        }
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
            Point p = new Point();
            p.x = 4;
            p.y = 2;
            p.color = Color.Green;

            Point p2 = new Point
            {
                x = 2,
                y = 6,
                color = Color.Grey
            };

            //var firstStudent = GetStudent();
            //firstStudent.Print();

            //Student secondStudent = new Student();
            //secondStudent.Print();

            //string d = firstStudent.GetFullName();
            //Console.ReadLine();

            Console.WriteLine("\t== Car 1 ==");

            var car = new Car();
            car.DriveForward();
            car.PrintSpeed();
            car.Stop();
            car.PrintSpeed();

            Console.WriteLine("\t== Car 2 ==");
            var car2 = new Car();
            car2.PrintSpeed();
            car2.DriveBackward();
            car2.PrintSpeed();


        }
    }
}
 