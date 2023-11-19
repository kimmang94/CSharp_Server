using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ServerCore
{
    class Program
    {
        static void MainThread()
        {
            Console.WriteLine("Hello Thread!");
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(MainThread);
            t.Start();

            Console.WriteLine("Hello World");
        }
    }
}
