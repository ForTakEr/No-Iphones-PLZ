using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Märkmete_haldamine
{
    class Uus
    {
        public string path = Directory.GetCurrentDirectory();
        public string FailiNimi { get; set; }
        public string Märkus { get; set; }
        public void New()
        {
            using (StreamWriter sw = File.CreateText(Path.Combine(path, FailiNimi + ".txt")))
            {                
                sw.WriteLine(Märkus);
            }
        }
    }
}
