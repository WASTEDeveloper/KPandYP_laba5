using System;
using System.Collections.Generic;
using System.Text;

namespace APM_KPandYP
{
    class Runner
    {
        private int kol;
        public void Input()
        {
            Console.Write("Введите кол-во студентов: ");
            int k = int.Parse(Console.ReadLine());
            Student[] students = new Student[k];
            kol = k;

            foreach (var item in students)
            {
                item.Surname = Console.ReadLine();
                item.Name = Console.ReadLine();
                item.Group = Console.ReadLine();
                Random rnd = new Random();
                for (int i = 0; i < 5; i++)
                {
                    item.Marks[i] = rnd.Next(0, 11);
                }
            }
        }
    }
}
