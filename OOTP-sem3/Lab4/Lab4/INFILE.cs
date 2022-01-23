using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab4
{
    class INFILE
    {
        public static void WriteToFile(Str<string> str)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\Лабы ООП\Lab4\Lab4\log.txt"))
            {
                sw.Write(str.STr+" --> ");
                
            }
        }

        public static void ReadFromFile(ref Str<string> str)
        {
            using (StreamReader sw = new StreamReader(@"D:\Лабы ООП\Lab4\Lab4\log.txt"))
            {
                string[] items = sw.ReadToEnd().Split(" --> ");
                foreach (string item in items)
                {
                    str.Add(item);
                }
            }
        }
    }
}
