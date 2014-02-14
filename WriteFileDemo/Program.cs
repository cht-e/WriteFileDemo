using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFileDemo {
    class Program {
        static void Main(string[] args) {                        
            var log = args.Length > 0 ? string.Join(", ", args) : "Empty";

            File.WriteAllText(
                @"D:/_writeFileDemo.txt", 
                string.Format("Last Update Time: {0}, {1}", DateTime.Now, log)
            );
        }
    }
}
