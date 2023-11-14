using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highmem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Byte[] bytes = new Byte[100000000];
            for (int ii = 0; ii < 10; ii++)
            {



                for (int i = 0; i < 100000000; i++)
                {
                    bytes[i] = new Byte();
                }
            }
            Console.Read();
        }
    }
    public class Byte
    {
        byte main = 0x1;
    }
}
