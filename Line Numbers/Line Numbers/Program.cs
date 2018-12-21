using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfLines = new List<string>();

            using (StreamReader reader = new StreamReader(@"C:\text.txt"))
            {
                string line;
                int i = 1;

                while ((line = reader.ReadLine()) != null)
                {
                    listOfLines.Add($"Line{i}:\t" + line);

                    i++;
                }
            }

            using (StreamWriter writer = new StreamWriter(@"C:\output.txt"))
            {
                foreach (var line in listOfLines)
                {
                    writer.WriteLine(line);
                }
            }

            
        }
    }
}
