using System;
using System.Text;

namespace KPandYP_laba7
{
    class Program
    {
        public static void Task1()
        {
            //Tsk1
            Console.WriteLine("Строку из слов разделенную какими-то символами");
            string message = Console.ReadLine();

            Console.WriteLine("Введите строку с сомволами которые могут разделать слова в перовй строке");
            string splitter = Console.ReadLine();

            char[] splt = new char[splitter.Length];
            for (var i = 0; i < splitter.Length; ++i)
            {
                splt[i] = Convert.ToChar(splitter[i]);
            }

            foreach (var item in message.Split(splt))
            {
                Console.WriteLine(item);
            }
        }

        public static void Task2()
        {
            //Tsk2
            Console.WriteLine("Строку из слов разделенную пробелами");
            string msg = Console.ReadLine();

            Console.WriteLine("Ввдеите нужную длину строки");
            int lng = int.Parse(Console.ReadLine());

            StringBuilder strBuild = new StringBuilder(msg);
            while (strBuild.Length < lng)
            {
                for (int i = 0; i < strBuild.Length; ++i)
                {
                    if (strBuild.Length == lng)
                        break;
                    else if (strBuild[i] == ' ')
                    {
                        strBuild.Insert(i, ' ');
                        i += 2;
                    }
                }
                if (strBuild.Length == lng)
                    break;
            }

            Console.WriteLine(strBuild);
        }

        public static void TaskK()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            string[] temp = str.Split(' ');
            string[] result = new string[temp.Length];
            int j = 0;
            for (int i = 0; i < temp.Length; ++i)
            {
                if (temp[i] == "")
                {
                    
                }
                else
                {
                    result[j] = temp[i];
                    j++;
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //TaskK();
            Poem.Zam();
        }
    }
}
