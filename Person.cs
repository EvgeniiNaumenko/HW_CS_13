using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13_24_06_2024
{

    public record Person(string FName, string SName, int Age)
    {
        public override string ToString()
        {
            return $"Name: {FName}\nSecondName: {SName}\nAge: {Age}";
        }
    }
    public static class PersonExtensions
    {
        public static Person MinAge(this Person[] people)
        {
            //return people.OrderBy(p => p.Age).First(); // тут используется сортировка по возрасту по возрастанию и возвращает первое
            //тут я написал написал без сортировки а просто перебор
            int age = 0;
            for (int i = 0; i < people.Length-1; i++)
            {
                if (people[i].Age > people[i + 1].Age && i + 1 <= people.Length)
                {
                    age = i + 1;
                }
            }
            return people[age];

        }
        public static Person MaxAge(this Person[] people)
        {
            //return people.OrderByDescending(p => p.Age).First();// тоже
            int age = 0;
            for (int i = 0; i < people.Length-1; i++)
            {
                if (people[i].Age < people[i + 1].Age && i + 1 <= people.Length)
                {
                    age = i + 1;
                }
            }
            return people[age];
        }
        public static double GetAverageAge(this Person[] people)
        {
            //return people.Average(p => p.Age);// среднее по возразрасту
            int counter = 0;
            int sumAge = 0;
            foreach (Person person in people)
            {
                sumAge += person.Age;
                counter++;
            }
            return sumAge / counter;
        }
    }
}
