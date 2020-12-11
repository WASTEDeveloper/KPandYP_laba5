using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPandYP_laba13_1
{
    public class MyExp: Exception
    {
        public int xMessage;
        public MyExp(int num) : base("Тут Ошибка")
        {
            xMessage = num;
        }
    }

    public class MyExp2 : Exception
    {
        public string xMessage;
        public MyExp2(string num) : base("Тут Ошибка")
        {
            xMessage = num;
        }
    }
}
