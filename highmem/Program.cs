using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace highmem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i < 128; i++) {
                Marshal.AllocHGlobal(1024 * 1024 * 1024);
            }
        }
    }
}
