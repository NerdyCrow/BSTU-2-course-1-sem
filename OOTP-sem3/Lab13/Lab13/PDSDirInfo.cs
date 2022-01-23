using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class PDSDirInfo
    {
        
        public void GetFilesAndDirect()
        {
            string dirName = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("\nПодкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }

                string[] files = Directory.GetFiles(dirName);
                Console.WriteLine($"Файлы({files.Length}):");
                
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine();

            PDSLog.AddNote("PDSDirInfo", dirName, "Списки подкаталогов и файлов директория Lab13");
        }
        public void DirInf()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13");

            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
            Console.WriteLine($"Родительский каталог: {dirInfo.Parent}");
            PDSLog.AddNote("PDSDirInfo", @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13", "Информация о директории Lab13");
        }
    }
}
