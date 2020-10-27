using System;
using System.Collections.Generic;
using System.Text;

namespace APM_KPandYP
{
    class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int[] Marks;

        void Mark()
        {
            Random rnd = new Random();
            for (var i = 0; i < 5; ++i)
            {
                Marks[i] = rnd.Next(0, 11);
            }
        }
    }
}
