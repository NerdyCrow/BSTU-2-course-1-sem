using Lab14;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab14_Framework
{
    
        static class CustomSerializer
        {
            public static void Serialize(string file, Student student)
            {
                string format = file.Split('.').Last();
                switch (format)
                {
                    case "bin":
                        BinaryFormatter bf = new BinaryFormatter();
                        using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                        {
                            bf.Serialize(fs, student);
                        }
                        break;

                    case "soap":
                        SoapFormatter sf = new SoapFormatter();
                        using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                        {
                            sf.Serialize(fs, student);
                        }
                        break;

                    case "xml":
                        XmlSerializer xs = new XmlSerializer(typeof(Student));
                        using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                        {
                            xs.Serialize(fs, student);
                        }
                        break;

                    case "json":
                        DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Student));
                        using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                        {
                            js.WriteObject(fs, student);
                        }
                        break;
                }
            }

            public static void Deserialize(string file)
            {
                string format = file.Split('.').Last();
                switch (format)
                {
                    case "bin":
                        BinaryFormatter bf = new BinaryFormatter();
                        using (FileStream fs = new FileStream(file, FileMode.Open))
                        {
                            Student student = (Student)bf.Deserialize(fs);
                            Console.WriteLine($"Имя: {student.FIO} --- Возраст: {student.Age} --- Курс: {student.Course} --- Номер студенческого: {student.NumOfStudentCard}");
                        }
                        break;

                    case "soap":
                        SoapFormatter sf = new SoapFormatter();
                        using (FileStream fs = new FileStream(file, FileMode.Open))
                        {
                            Student student = (Student)sf.Deserialize(fs);
                            Console.WriteLine($"Имя: {student.FIO} --- Возраст: {student.Age} --- Курс: {student.Course} --- Номер студенческого: {student.NumOfStudentCard}");
                        }
                    break;

                    case "xml":
                        XmlSerializer xs = new XmlSerializer(typeof(Student));
                        using (FileStream fs = new FileStream(file, FileMode.Open))
                        {
                            Student student = (Student)xs.Deserialize(fs);
                            Console.WriteLine($"Имя: {student.FIO} --- Возраст: {student.Age} --- Курс: {student.Course} --- Номер студенческого: {student.NumOfStudentCard}");
                        }
                        break;

                    case "json":
                        DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Student));
                        using (FileStream fs = new FileStream(file, FileMode.Open))
                        {
                            Student student = (Student)js.ReadObject(fs);
                            Console.WriteLine($"Имя: {student.FIO} --- Возраст: {student.Age} --- Курс: {student.Course} --- Номер студенческого: {student.NumOfStudentCard}");
                        }
                        break;
                }
            }
        }
    
}
