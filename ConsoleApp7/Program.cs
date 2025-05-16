using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            CountChis countChis = new CountChis();
            Handle1 handle1 = new Handle1();
            Handle2 handle2 = new Handle2();

            //countChis.Count();
            countChis.onCount += handle1.Message;
            countChis.onCount += handle2.Message;
            countChis.onCount += countChis.Message;
            countChis.Count();
            Console.Read();
        }
    }
}
