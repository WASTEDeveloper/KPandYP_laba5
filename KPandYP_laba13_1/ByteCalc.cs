using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPandYP_laba13_1
{
    class ByteCalc
    {
        public string ByteNum { get; set; }
        public ByteCalc(string ByteNum)
        {
            this.ByteNum = ByteNum;
        }

        public void Output()
        {
            Console.WriteLine(ByteNum);
        }

        public void byteMul(string byteNumber)
        {
            int b = Convert.ToInt32(this.ByteNum, 2);
            int b2 = Convert.ToInt32(byteNumber, 2);
            int b3 = b * b2;
            string s3 = Convert.ToString(b3, 2);
            try
            {
                if (s3.Length <= 8)
                    Console.WriteLine("mul: " + s3);
                else
                {
                    throw new MyExp2(s3);
                }
            }
            catch (MyExp e)
            {
                Console.WriteLine("Ощибка");
            }
        }

        public void byteDiv(string byteNumber)
        {
            int b = Convert.ToInt32(this.ByteNum, 2);
            int b2 = Convert.ToInt32(byteNumber, 2);
            int b3 = b / b2;
            try
            {
                if (b3 > 0)
                {
                    string s3 = Convert.ToString(b3, 2);
                    if (s3.Length <= 8)
                        Console.WriteLine("div: " + s3);
                }
                else
                {
                    throw new MyExp(b3);
                }
            }
            catch (MyExp e)
            {
                Console.WriteLine("Ощибка");
            }
        }

        public void byteSum(string byteNumber)
        {
            int b = Convert.ToInt32(this.ByteNum, 2);
            int b2 = Convert.ToInt32(byteNumber, 2);
            int b3 = b + b2;
            string s3 = Convert.ToString(b3, 2);
            if (s3.Length <= 8)
                Console.WriteLine("sum: " + s3);
            else
            {
                throw new MyExp2(s3);
            }
        }

        public void byteSub(string byteNumber)
        {
            int b = Convert.ToInt32(this.ByteNum, 2);
            int b2 = Convert.ToInt32(byteNumber, 2);
            int b3 = b - b2;
            try
            {
                if (b3 > 0)
                {
                    string s3 = Convert.ToString(b3, 2);
                    if (s3.Length <= 8)
                        Console.WriteLine("sub: " + s3);
                }
                else
                {
                    throw new MyExp(b3);
                }
            }
            catch (MyExp e)
            {
                Console.WriteLine(e.xMessage);
                Console.WriteLine(e.StackTrace);

            } 
        }
    }
}
