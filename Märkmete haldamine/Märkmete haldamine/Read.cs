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
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            Console.WriteLine("Saadaval märkmed on: ");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
