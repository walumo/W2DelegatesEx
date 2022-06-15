using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2DelegatesEx
{
    class Program
    {
        static int number = 458;

        public delegate int Del(int num);
        public static int TimesTen(int num)
        {
            return num * 10;
        }
        public static int TimesHundred(int num)
        {
            return num * 100;
        }
        public static int TimesThousand(int num)
        {
            return num * 1000;
        }
        static void Main(string[] args)
        {

            Del loader1 = new Del(TimesTen);
            Del loader2 = new Del(TimesHundred);
            Del loader3 = new Del(TimesThousand);

            Console.WriteLine(loader1(number));
            Console.WriteLine(loader2(number));
            Console.WriteLine(loader3(number));
        }
    }
}
