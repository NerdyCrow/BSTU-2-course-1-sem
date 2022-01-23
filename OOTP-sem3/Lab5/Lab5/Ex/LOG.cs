using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Ex
{
    class LOG
    {
        public static void WriteLog(Exception ex, bool infile = true, string filePath = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab5\Lab5\LOG.txt")
        {
            if (infile)
            {
                DateTime time = DateTime.Now;
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine($"Time: {time}");
                    sw.Write($"ERROR: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
