﻿using System;
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
            for (; ; )
            {
                Greeting();
                Agerestrictions();
                Consolesettings();
            }






           


        }

        private static void Consolesettings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void Agerestrictions()
        {
            Console.Write("wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("brawo mordziaty masz 18 lat");
            }
            else if (result == false)
            {
                Console.WriteLine("mordziaty cos pojebałes z tym wiekiem pzdr");
            }
            else
            {
                Console.WriteLine("mozesz pic alko ale po kryjomu");
            }
        }

        private static void Greeting()
        {
            Console.Write("WPISZ SWOJA KSYWE MORDO:");
            string name = Console.ReadLine();
            Console.WriteLine("elo " + name);
        }
    }
}
