﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Märkmete_haldamine
{
    class Program
    {
        static void Main(string[] args)
        {
            //IM ALIVE
            Console.WriteLine("Palun valige, mida teha soovite");
            Console.WriteLine("Commandid on: new; read; delete; exit");
            string cmd = Console.ReadLine();

            if (cmd == "new")
            {
                
                New new1 = new New();
                new1.FailiNimi = Console.ReadLine();
                Console.WriteLine("Palun lisage märkus");
                new1.Märkus = Console.ReadLine();
            }

            if (cmd == "read")
            {

            }

            if (cmd == "delete")
            {

            }

            else
            {
                Console.WriteLine("Commandid on: new; read; delete");
            }

            if (cmd == "exit")
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}
