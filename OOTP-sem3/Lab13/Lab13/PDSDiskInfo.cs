using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class PDSDiskInfo
    {
        public void GetAllDrives()
        {
            foreach(var elem in DriveInfo.GetDrives())
            {
                Console.Write($"Имя диска:{elem.Name}---Свободно {Math.Round((elem.AvailableFreeSpace/Math.Pow(1024,3)),1)}_Гб из {Math.Round((elem.TotalSize / Math.Pow(1024, 3)),1)}_Гб---Метка тома:{elem.VolumeLabel}\n");
            }
            PDSLog.AddNote("PDSDiskInfo", "-", "Информация о дисках");

        }

        public void FileSystem()
        {
            foreach (var elem in DriveInfo.GetDrives())
            {
                Console.Write($"Имя файловой системы: {elem.DriveFormat}----Тип диска: {elem.DriveType}\n");
            }
            PDSLog.AddNote("PDSDiskInfo", "-", "Информация о дисках");
        }
    }
}
