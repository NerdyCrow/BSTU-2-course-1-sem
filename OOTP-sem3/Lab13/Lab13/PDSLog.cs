using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab13
{
    public static class PDSLog
    {
        public static void AddNote(string utility, string path, string message)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\Lab13\log.txt", true))
            {
                sw.WriteLine($"{utility}: {path}");
                sw.WriteLine($"{message}");
                sw.WriteLine("----------------------------------------------------------------------------");
            }
        }

        public static void Clear()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\Lab13\log.txt"))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine();
                sw.Close();
            }
        }
    }
}
