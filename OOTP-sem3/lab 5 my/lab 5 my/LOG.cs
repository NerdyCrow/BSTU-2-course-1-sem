using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_my
{
    class LOG
    {
        public static void WriteLog(Exception ex, bool infile = true, string filePath = @"D:\Лабы ООП\lab 5 my\lab 5 my\log.txt")
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
