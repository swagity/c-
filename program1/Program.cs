using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        

        static void Main(string[] args)
        {

           // string name = args[0];
           // Console.WriteLine("elo " + name);


            foreach (var item in args)
            {
                Console.WriteLine("elo,  " + item);
            }

        }


    }
}
