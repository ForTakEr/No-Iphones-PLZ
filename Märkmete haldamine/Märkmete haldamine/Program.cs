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
            algus:
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Olemas olevad failid on: ");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine("Palun valige, mida teha soovite");
            Console.WriteLine("Commandid on: new; read; delete; exit");
            Console.WriteLine("----------------------------------------------------------");
            string cmd = Console.ReadLine();

            if (cmd == "new")
            {
                Uus new1 = new Uus();
                Console.WriteLine("Sisestage faili nimi: ");
                new1.FailiNimi = Console.ReadLine();
                Console.WriteLine("Palun lisage märkus: ");                
                new1.Märkus = Console.ReadLine();
                Console.WriteLine();
                new1.New();
                goto algus;
            }

            else if (cmd == "read")
            {
                Read lugemine = new Read();
                lugemine.Loendur();
                Console.WriteLine();
                goto algus;
            }

            else if (cmd == "delete")
            {
                Delete kustuta = new Delete();
                kustuta.Kustuta();
                Console.WriteLine();
                goto algus;
            }

            else if (cmd == "exit")
            {
                Environment.Exit(0);
            }

            else
            {
                goto algus;
            }
        }
    }
}
