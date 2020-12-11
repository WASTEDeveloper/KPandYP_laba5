using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace KPandYP_laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Class1> list = new List<Class1>();
            int sw;
            int n = 0;
            Class1[] mass = new Class1[n];
            while (true)
            {
                Console.WriteLine("1) Ввод массива структур;");
                Console.WriteLine("2) Изменение заданной структуры;");
                Console.WriteLine("3) Удаление структуры из массива;");
                Console.WriteLine("4) Вывод на экран массива структур;");
                Console.WriteLine("5) Вывести общую численность населения по всем формам правления;");
                Console.WriteLine("6) Вывести общую занимаемую площадь по всем формам правления;");
                Console.WriteLine("7) Выход;");
                sw = int.Parse(Console.ReadLine());

                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Введите количество добовляемых элементов: ");
                        n = int.Parse(Console.ReadLine());
                        mass = new Class1[n];
                        for (int i = 0; i < n; ++i)
                        {
                            Console.WriteLine("Выбирете форму правления:");
                            Console.WriteLine("1) Монархия;");
                            Console.WriteLine("2) Республика;");
                            int sw2 = int.Parse(Console.ReadLine());
                            switch (sw2)
                            {
                                case 1:
                                    mass[i].numeric = Class2.Monarch;
                                    break;
                                case 2:
                                    mass[i].numeric = Class2.Republic;
                                    break;
                                default:
                                    break;
                            }
                            mass[i].name = Console.ReadLine();
                            mass[i].capital = Console.ReadLine();
                            mass[i].population = int.Parse(Console.ReadLine());
                            mass[i].square = float.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите название государства");
                        string StateName = Console.ReadLine();
                        for (int i = 0; i < n; ++i)
                        {
                            if (mass[i].name == StateName)
                            {
                                Console.WriteLine("Выбирете форму правления:");
                                Console.WriteLine("1) Монархия;");
                                Console.WriteLine("2) Республика;");
                                int sw2 = int.Parse(Console.ReadLine());
                                switch (sw2)
                                {
                                    case 1:
                                        mass[i].numeric = Class2.Monarch;
                                        break;
                                    case 2:
                                        mass[i].numeric = Class2.Republic;
                                        break;
                                    default:
                                        break;
                                }
                                mass[i].name = Console.ReadLine();
                                mass[i].capital = Console.ReadLine();
                                mass[i].population = int.Parse(Console.ReadLine());
                                mass[i].square = float.Parse(Console.ReadLine());
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите название удаляемого государства государства");
                        string DeleteName = Console.ReadLine();
                        for (int i = 0; i < n; ++i)
                        {
                            if (mass[i].name == DeleteName)
                            {
                                mass[i].numeric = Class2.O;
                                mass[i].name = "0";
                                mass[i].capital = "0";
                                mass[i].population = 0;
                                mass[i].square = 0;
                            }
                        }
                        break;
                    case 4:
                        for (int i = 0; i < n; ++i)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine(mass[i].numeric);
                            Console.WriteLine(mass[i].name);
                            Console.WriteLine(mass[i].capital);
                            Console.WriteLine(mass[i].population);
                            Console.WriteLine(mass[i].square);
                            Console.WriteLine("----------------------------------------");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Monarch:");
                        for (int i = 0; i < n; ++i)
                        {
                            if (mass[i].numeric == Class2.Monarch)
                            {
                                Console.WriteLine(mass[i].name);
                                Console.WriteLine(mass[i].capital);
                                Console.WriteLine(mass[i].population);
                                Console.WriteLine(mass[i].square);
                            }
                        }
                        Console.WriteLine("Republic:");
                        for (int i = 0; i < n; ++i)
                        {
                            if (mass[i].numeric == Class2.Republic)
                            {
                                Console.WriteLine(mass[i].name);
                                Console.WriteLine(mass[i].capital);
                                Console.WriteLine(mass[i].population);
                                Console.WriteLine(mass[i].square);
                            }
                        }
                        break;
                    case 6:
                        float squareSum = 0;
                        for (int i = 0; i < n; ++i)
                        {
                            if (mass[i].numeric == Class2.Monarch)
                            {
                                squareSum += mass[i].square;
                            }
                        }
                        Console.WriteLine($"Monarch square: {squareSum}");
                        squareSum = 0;
                        for (int i = 0; i < n; ++i)
                        {
                            if (mass[i].numeric == Class2.Republic)
                            {
                                squareSum += mass[i].square;
                            }
                        }
                        Console.WriteLine($"Republic square: {squareSum}");
                        break;
                    case 7:
                        
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нету!");
                        break;
                }
            }
        }
    }
}
