using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Märkmete_haldamine
{
    class Read
    {
        static string path = Directory.GetCurrentDirectory();

        public void Loendur()
        {
            //Siin kirjutab välja kõik failid, mis on directorys
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            Console.WriteLine("Saadaval märkmed on: ");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine("Millist tahad avada?");
            string vastus = Console.ReadLine();
            if (File.Exists(Path.Combine(path, vastus + ".txt")))
            {
                string text = File.ReadAllText((Path.Combine(path, vastus + ".txt")));
                Console.WriteLine("Märkme sees on: {0}", text);
            }
            else
            {
                Console.WriteLine("See pole üks failidest");
            }
        }
    }
}
