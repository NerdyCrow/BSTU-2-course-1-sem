using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Lab13
{
    class PDSFileManager
    {
        public void GetFilesAndDirect()
        {
            Console.WriteLine("Выбирите диск\n1. C:\\ \n2. D:\\");

            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    string dirName = @"C:\";

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
                    PDSLog.AddNote("PDSFileManager", dirName, "Списки подкаталогов и файлов.");
                    Console.WriteLine(); break;
                case 2:
                    string dirName2 = @"D:\";

                    if (Directory.Exists(dirName2))
                    {
                        Console.WriteLine("\nПодкаталоги:");
                        string[] dirs = Directory.GetDirectories(dirName2);
                        foreach (string s in dirs)
                        {
                            Console.WriteLine(s);
                        }

                        string[] files = Directory.GetFiles(dirName2);
                        Console.WriteLine($"Файлы({files.Length}):");

                        foreach (string s in files)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    PDSLog.AddNote("PDSFileManager", dirName2, "Списки подкаталогов и файлов.");
                    Console.WriteLine(); break;
            }
                    
        
            
        }
        public void CreateDirectory()
        {
            string dirName = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\PDSInspect";

            if (!Directory.Exists(@"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13")) ;
            {
                Directory.CreateDirectory(dirName);
            }
            PDSLog.AddNote("PDSFileManager", dirName, "Создание директория.");
        }
        public void CreateFile()
        {
            string fileName = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\PDSInspect\PDSdirinfo.txt";
            FileInfo file = new FileInfo(fileName);
            file.Create().Close();
            File.Copy(fileName, @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\RenamedPDSdirinfo.txt", true);
            File.Delete(fileName);
            PDSLog.AddNote("PDSFileManager", fileName, "Создание файла,его копирование,удаление начального.");
        }
        public void CreateDirectory2()
        {
            string dirName = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\PDSFiles";

            if (!Directory.Exists(@"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13")) ;
            {
                Directory.CreateDirectory(dirName);
            }
            Console.WriteLine("Введите расширение файла:");
            string extension = Console.ReadLine();
            DirectoryInfo directory = new DirectoryInfo(@"D:\ПроектыКЯР\КСИС");
            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Extension == extension)
                    file.CopyTo($@"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\PDSFiles\{ file.Name}", true);
            }
            PDSLog.AddNote("PDSFileManager", dirName, "Создание директория,копирование в него файлов выбранного расширения");
        }
        public void MoveDirect()
        {
            string oldPath = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\PDSFiles";
            string newPath = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\PDSInspect\PDSFiles";
            DirectoryInfo dirInfo = new DirectoryInfo(oldPath);
            if (dirInfo.Exists && Directory.Exists(newPath) == false)
            {
                dirInfo.MoveTo(newPath);
            }
            PDSLog.AddNote("PDSFileManager",(oldPath+"-->"+newPath), "Перемещение каталога");
        }
        public void Archive()
        {
            string sourceFolder = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\PDSInspect\PDSFiles"; // исходная папка
            string zipFile = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\PDSInspect\PDSFiles.zip"; // сжатый файл
            string targetFolder = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\new"; // папка, куда распаковывается файл

            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");
            ZipFile.ExtractToDirectory(zipFile, targetFolder);


            PDSLog.AddNote("PDSFileManager", (sourceFolder+"-->"+zipFile+"-->"+targetFolder), "Архивация и разархивация");

        }
    }
}
