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
        public Delete()
        {
            string input = Console.ReadLine();
            

            if (!File.Exists(input))
            {

                File.Delete(input);
            }
            else
            {
                Console.WriteLine("sisestatu on vale");
            }

        }
        


    }      
    
}
