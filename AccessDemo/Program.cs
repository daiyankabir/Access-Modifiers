using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo
{
    public class Program
    {
        public void Test1()
        {
            Console.WriteLine("Public Method.");
        }
        private void Test2()
        {
            Console.WriteLine("Private Method.");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected Method.");
        }
        internal void Test4()
        {
            Console.WriteLine("internal Method.");
        }
        protected internal void Test5()
        {
            Console.WriteLine("protected Internal Method.");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1(); p.Test2(); p.Test3();
            p.Test4(); p.Test5();

            Console.ReadKey();
            
        }
    }
}
