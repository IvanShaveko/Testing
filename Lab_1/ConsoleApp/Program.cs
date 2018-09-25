using System;
using System.Collections.Generic;
using BLL.Entities;
using BLL.Service;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student(new List<int> {1, 6, 10}, "Ivan"),
                new Student(new List<int> {1, 6, 3}, "Timur"),
                new Student(new List<int> {10, 9, 8}, "Roma")
            };

            var group = new Group(1, students);

            Console.WriteLine("Средний балл по группе: {0}", Service.CalculateAvgOfGroup(group));
            Console.WriteLine("Средний балл студента Roma: {0}",
                Service.CalculateAvgOfSudent(group, new Student(new List<int> { 10, 9, 8 }, "Roma")));
        }
    }
}
