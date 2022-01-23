using System;

namespace Lab13
{
    class Program
    {
        static void Line()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("#######################################################################################");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {

            PDSLog.Clear();
            Line();
            PDSDiskInfo Drives = new PDSDiskInfo();
            Drives.GetAllDrives();
            Console.WriteLine();
            Drives.FileSystem();

            Line();
            PDSFileInfo FInfo = new PDSFileInfo();
            FInfo.Info();

            Line();
            PDSDirInfo DirInfo = new PDSDirInfo();
            DirInfo.GetFilesAndDirect();
            DirInfo.DirInf();

            Line();
            PDSFileManager fileManager = new PDSFileManager();
            fileManager.GetFilesAndDirect();
            fileManager.CreateDirectory();
            fileManager.CreateFile();
            fileManager.CreateDirectory2();
            fileManager.MoveDirect();
            fileManager.Archive();

        }
    }
}
