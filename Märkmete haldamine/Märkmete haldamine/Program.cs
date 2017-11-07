using System;
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
                Uus new1 = new Uus();
                Console.WriteLine("Sisestage faili nimi: ");
                new1.FailiNimi = Console.ReadLine();
                Console.WriteLine("Palun lisage märkus: ");
                new1.Märkus = Console.ReadLine();
                new1.New();
            }

            else if (cmd == "read")
            {

            }

            else if (cmd == "delete")
            {

            }

            else if (cmd == "exit")
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Commandid on: new; read; delete");
            }

            Console.ReadLine();
        }
    }
}
