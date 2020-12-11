using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPandYP_laba13_2
{
    class Program
    {
        delegate void smiles();
        static void Main(string[] args)
        {
            string menu;
            smiles Smile;
            while (true)
            {
                Console.WriteLine("1. Веселый смайл");
                Console.WriteLine("2. Грустный смайл");
                Console.WriteLine("3. Задумчивый смайл");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Smile = TV.funSmile;
                        Smile();
                        break;
                    case "2":
                        Smile = TV.sadSmile;
                        Smile();
                        break;
                    case "3":
                        Smile = TV.thinkSmile;
                        Smile();
                        break;
                }
            }
        }
    }
}
