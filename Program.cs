using System;

namespace HW_13_24_06_2024
{
    //    Завдання 3
    //Створіть метод розширення(extension method) для
    //перевірки чи є ціле число простим.Напишіть код для
    //тестування методу.
    //    Завдання 7
    //Створіть запис Person.Необхідно зберігати інформацію про ім’я, прізвище, вік.Створіть масив записів
    //Person.Напишіть код для пошуку людини із мінімальним
    //і максимальним віком.Відобразіть середній вік людей
    //(реалізуйте за допомогою extension method).
    //Завдання 8
    //Створіть запис Point3D.Необхідно зберігати інформацію про координати точки у тривимірному просторі.
    //Створіть масив точок.Напишіть код для обчислення
    //відстані між точками.Відобразіть максимальну відстань
    //між точками та інформацію про них.
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //HT - 1 
            int num1 = 5; int num2 = 21;
            Console.WriteLine($"Is prime? - {num1.IsPrimeNum()}");
            Console.WriteLine($"Is prime? - {num2.IsPrimeNum()}");
            //HT - 2 
            Person[] people = new Person[]
            {
                new Person("John", "Doe", 25),
                new Person("Jane", "Smith", 30),
                new Person("Bob", "Johnson", 45),
                new Person("Alice", "Williams", 20),
                new Person("Tom", "Brown", 50)
            };
            Console.WriteLine($"Person with max Age:\n{people.MaxAge()}");
            Console.WriteLine($"Person with min Age:\n{people.MinAge()}");
            Console.WriteLine($"Average in person list: {people.GetAverageAge()}");
            //HT - 3 
            Point3D [] points = new Point3D[]
            {
                new Point3D(0,0,0),
                new Point3D(1,15,0),
                new Point3D(4,2,9),
                new Point3D(10,4,1),
                new Point3D(15,18,7),
                new Point3D(25,0,5),

            };
            points.Show();
            Console.WriteLine($"Max distance in points arr : {points.Distance()}");
            for (int i = 0; i < points.Length-1; i++)
            {
                Console.WriteLine($"Distance between point:{i+1} and point:{i+2} is {points[i].Distance(points[i+1])}");
            }
        }
    }
}
