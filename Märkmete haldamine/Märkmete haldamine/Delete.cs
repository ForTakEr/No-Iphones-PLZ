using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//4. Kasutaja saab märkmeid kustutada käsuga Delete -Failinimi-

namespace Märkmete_haldamine
{
    class Delete
    {
        string path = Directory.GetCurrentDirectory();
        public void Kustuta()
        {
            Console.WriteLine("Sisesta faili nimi mida kustutada: ");
            string input = Console.ReadLine();
            if (File.Exists(Path.Combine(path, input + ".txt")))
            {
                File.Delete(Path.Combine(path, input + ".txt"));
            }
            else
            {
                Console.WriteLine("sisestatu on vale");
            }
        }
    }      
    
}
