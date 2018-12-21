using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfLines = new List<string>();

            using (StreamReader reader = new StreamReader(@"C:\text.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    listOfLines.Add(line);
                }
            }

            for (int i = 0; i < listOfLines.Count; i++)
            {
                if (i%2 > 0)
                    Console.WriteLine(listOfLines[i]);
                else
                    continue;
            }
        }
    }
}
