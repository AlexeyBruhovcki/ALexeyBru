using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme28Lesson2
{
    internal class PasswordGenerator
    {
        Random rnd = new Random();
        public string LowerLetPassGen()
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                str += (char)rnd.Next(97, 123);
            }
            return str;
        }
        public string UpperLetPassGen()
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                str += (char)rnd.Next(65, 91);
            }
            return str;
        }
        public string SimbolPassGen()
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                int n = rnd.Next(0, 3);
                if(n==0) str +=(char)rnd.Next(33, 65);
                else if (n==1) str += (char)rnd.Next(91, 97);
                else str += (char)rnd.Next(123, 127);

            }
            return str;
        }
        public string ComplexPassGen()
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                int n = rnd.Next(0, 6);
                switch (n) 
                {
                    case 0: str +=(char)rnd.Next(33, 65);break;
                    case 1: str +=(char)rnd.Next(91, 97);break;
                    case 2: str +=(char)rnd.Next(123, 127);break;
                    case 3: str +=(char)rnd.Next(97, 123);break;
                    case 4: str +=(char)rnd.Next(65, 91);break;
                    case 5: str +=(char)rnd.Next(48, 58);break;
                }
            }
            return str;
        }
    }
}
