using System;
using System.Collections.Generic;
using System.Runtime;

namespace KPandYP_laba6
{
    class Program
    {
        static double[] array;
        static int n;

        public static void Main(string[] args)
        {
            //Input();
            //Output();
            //Plus();
            //Console.WriteLine();
            //Output();
            //Console.WriteLine();
            //Duet();
            //SumCifr();
            Task3();
        }

        public static void Input()
        {
            Console.Write("Введите размрность массива: ");
            n = int.Parse(Console.ReadLine());

            array = new double[n];

            Console.WriteLine("Рандом - 1, Руками - 0");
            if (Console.ReadLine() == "1")
            {
                rand(array);
            }
            else
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write($"Введите [{j + 1}]: ");
                    array[j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void Output()
        {
            for (int i = 0; i < n; ++i)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void rand(double[] mas)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; ++i)
            {
                mas[i] = rnd.Next(-100, 100);
            }
        }

        public static void Plus()
        {
            for (int i = 0; i < n; ++i)
            {
                if (array[i] > 0)
                    array[i] += 0.5;
            }
        }

        public static void Duet()
        {
            double max = -12983761;
            Console.WriteLine("Введите размерность массива 1: ");
            int k = int.Parse(Console.ReadLine());
            double[] arr1 = new double[k];
            Console.WriteLine("Рандом - 1, Руками - 0");
            if (Console.ReadLine() == "1")
            {
                rand(arr1);
                for (int i = 0; i < arr1.Length; ++i)
                {
                    Console.Write(arr1[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < k; ++j)
                {
                    Console.Write($"Введите [{j + 1}]: ");
                    arr1[j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Введите размерность массива 2: ");
            int l = int.Parse(Console.ReadLine());
            double[] arr2 = new double[l];
            Console.WriteLine("Рандом - 1, Руками - 0");
            if (Console.ReadLine() == "1")
            {
                rand(arr2);
                for (int i = 0; i < arr2.Length; ++i)
                {
                    Console.Write(arr2[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < l; ++j)
                {
                    Console.Write($"Введите [{j + 1}]: ");
                    arr2[j] = int.Parse(Console.ReadLine());
                }
            }

            int temp;
            int temp2 = 0;

            if (k > l)
                temp = l;
            else
                temp = k;

            for (int i = 0; i < temp; ++i)
            {
                if (arr1[i] + arr2[i] > max)
                {
                    max = arr1[i] + arr2[i];
                    temp2 = i;
                }
            }

            Console.WriteLine($"Самая большая пара чисел - это пара #{temp2 + 1}; {arr1[temp2]} + {arr2[temp2]} = {max}");
        }

        public static void SumCifr()
        {
            Console.WriteLine("Введите размерность массива: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr1 = new int[k];
            Console.WriteLine("Рандом - 1, Руками - 0");
            if (Console.ReadLine() == "1")
            {
                Random random = new Random();
                for (int i = 0; i < arr1.Length; ++i)
                {
                    arr1[i] = random.Next(-100, 100);
                }
                for (int i = 0; i < arr1.Length; ++i)
                {
                    Console.Write(arr1[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < k; ++j)
                {
                    Console.Write($"Введите [{j + 1}]: ");
                    array[j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;
            for (int j = 0; j < k; ++j)
            {
                while (arr1[j] > 0)
                {
                    sum += arr1[j] % 10;
                    arr1[j] /= 10;
                }
            }

            Console.WriteLine($"Сумма цифр элементов массива: {sum}");
        }

        public static void Task3()
        {
            double[] mass = new double[31];
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; ++i)
            {
                mass[i] = Math.Round((double)rnd.Next(102, 355), 0);
            }

            Array.Sort(mass);
            List<double> list = new List<double>();

            for (int i = 0; i < mass.Length; ++i)
            {
                if (mass[i] * 0.1 > i)
                {
                    list.Add(mass[i]);
                }
            }

            int flag = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (flag == 0)
                    {
                        if (i + j >= mass.Length)
                        {
                            Console.Write("---------------   ");
                            //Console.Write($"| M## = [   ]  |   ");
                            //Console.Write("------   ");
                            continue;
                        }
                        else if (i >= 9)
                        {
                            Console.Write("---------------   ");
                            //Console.Write($"| M{i + j} = [{mass[i + j]}] |   ");
                            //Console.Write("------   ");
                        }
                        else if (i < 9)
                        {
                            Console.Write("---------------   ");
                            //Console.Write($"| M{i + j} = [{mass[i + j]}]  |   ");
                            //Console.Write("------   ");
                        }
                    }
                    else if (flag == 1)
                    {
                        if (i + j >= mass.Length)
                        {
                            //Console.Write("------   ");
                            Console.Write($"| M## = [   ] |   ");
                            //Console.Write("------   ");
                            continue;
                        }
                        else if (i >= 9)
                        {
                            //Console.Write("------   ");
                            Console.Write($"| M{i + j} = [{mass[i + j]}] |   ");
                            //Console.Write("------   ");
                        }
                        else if (i < 9)
                        {
                            //Console.Write("------   ");
                            Console.Write($"| M{i + j} = [{mass[i + j]}]  |   ");
                            //Console.Write("------   ");
                        }
                    }
                    else if (flag == 2)
                    {
                        if (i + j >= mass.Length)
                        {
                            //Console.Write("------   ");
                            //Console.Write($"| M## = [   ]  |   ");
                            Console.Write("---------------   ");
                            continue;
                        }
                        else if (i >= 9)
                        {
                            //Console.Write("------   ");
                            //Console.Write($"| M{i + j} = [{mass[i + j]}] |   ");
                            Console.Write("---------------   ");
                        }
                        else if (i < 9)
                        {
                            //Console.Write("------   ");
                            //Console.Write($"| M{i + j} = [{mass[i + j]}]  |   ");
                            Console.Write("---------------   ");
                        }
                    }
                }
                flag++;
                if (flag == 3)
                {
                    flag = 0;
                }
                Console.WriteLine();
            }

            //for (int i = 0; i < mass.Length; ++i)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("---------------------------------------------------------------------------------------");
            //    }
            //    if (i >= 9)
            //    {
            //        Console.Write($"| M{i + 1} = [{mass[i]}] |   ");
            //    }
            //    else
            //    {
            //        Console.Write($"| M{i + 1} = [{mass[i]}]  |   ");
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------------------------------------------");
        }
    }
}
