using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab13
{
    class PDSFileInfo
    {
        public void Info()
        {
            string path = @"D:\ПроектыКЯР\ООП\ЛАБЫ\Lab13\FInfo.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("\nИмя файла: {0}", fileInf.Name);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0} Кб", fileInf.Length );
                Console.WriteLine("Разрешение: {0}", fileInf.Extension);
                Console.WriteLine("Путь: {0}", fileInf.FullName);
                PDSLog.AddNote("PDSFileInfo", fileInf.Name+"-->"+path, "Информация о файле");

            }
        }
    }
}
