using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    class Four : AccessDemo.Program
    {
        static void Main(string[] args)
        {
            Four f = new Four();
            f.Test1(); f.Test3(); f.Test5();
            Console.ReadKey();
        }
    }
}
