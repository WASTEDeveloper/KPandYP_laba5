using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPandYP_laba13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new ByteCalc("1010");
            var bytenumber1 = new ByteCalc("1110");

            calculator.Output();
            bytenumber1.Output();
            Console.WriteLine("--------------");
            calculator.byteSum(bytenumber1.ByteNum);
            Console.WriteLine("--------------");
            calculator.byteSub(bytenumber1.ByteNum);
            Console.WriteLine("--------------");
            calculator.byteMul(bytenumber1.ByteNum);
            Console.WriteLine("--------------");
            calculator.byteDiv(bytenumber1.ByteNum);
        }
    }
}
