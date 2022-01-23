using Lab14_Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Lab14
{
    [Serializable]
    public class Student
    {
        public string FIO { get; set; }
        public int Course { get; set; }
        public int Age { get; set; }
        [NonSerialized]
        public int NumOfStudentCard;

        public Student(){}
        public Student(string fio, int course, int age, int num)
        {
            FIO = fio;
            Course = course;
            Age = age;
            NumOfStudentCard = num;
        }
    }


    [Serializable]
    public class Footballer
    {
       
        public string Name { get; set; }
       
        public int Age { get; set; }
       
        public Club Club { get; set; }
        public Footballer()
        { }
        public Footballer(string name, int age, Club club)
        {
            Name = name;
            Age = age;
            Club = club;
        }
    }

    [Serializable]
    public class Club
    {
        [DataMember]
        public string Name { get; set; }
        public Club() { }
        public Club(string name)
        { Name = name; }
    }





    class Program
    {
        static void Main(string[] args)
         {

            
            



            ////CustomSerializer
            ////Student XX = new Student("xx", 4, 21, 83726);
            ////Student YY = new Student("yy", 3, 20, 73726);
            ////Student ZZ = new Student("zz", 2, 19, 63726);
            ////Student RR = new Student("rr", 1, 18, 53726);

            ////CustomSerializer.Serialize("binStu.bin", XX);
            ////CustomSerializer.Serialize("soapStu.soap", YY);
            ////CustomSerializer.Serialize("xmlStu.xml", ZZ);
            ////CustomSerializer.Serialize("jsonStu.json", RR);

            ////CustomSerializer.Deserialize("binStu.bin");
            ////CustomSerializer.Deserialize("soapStu.soap");
            ////CustomSerializer.Deserialize("xmlStu.xml");
            ////CustomSerializer.Deserialize("jsonStu.json");




            Console.ForegroundColor = ConsoleColor.DarkYellow;
            #region Binary
            Student Yura = new Student("Хованский Юрий НИколаевич", 2, 16, 723498);
            Student Dima = new Student("Пилипович ДМитрий Сергеевич", 2, 19, 7235323);
            Student[] students = new Student[] { Yura, Dima };

            Console.WriteLine("До сериализации");
            foreach (var elem in students)
            {
                Console.WriteLine($"Имя: {elem.FIO} --- Возраст: {elem.Age} --- Курс: {elem.Course} --- Номер студенческого: {elem.NumOfStudentCard}");
            }


            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("student.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
            }


            using (FileStream fs = new FileStream("student.dat", FileMode.OpenOrCreate))
            {
                Console.WriteLine("Десериализация");
                Student[] studentsNew = (Student[])formatter.Deserialize(fs);

                foreach (var elem in studentsNew)
                {
                    Console.WriteLine($"Имя: {elem.FIO} --- Возраст: {elem.Age} --- Курс: {elem.Course} --- Номер студенческого: {elem.NumOfStudentCard}");
                }
            }
            #endregion
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            #region SOAP
            Student Vitya = new Student("Слемнёв Виктор Николаевич", 2, 19, 725678);
            Student Danik = new Student("Соколовский Даниил Юрьевич", 3, 20, 723490);
            Student[] students2 = new Student[] { Vitya, Danik };

            Console.WriteLine("До сериализации");
            foreach (var elem in students2)
            {
                Console.WriteLine($"Имя: {elem.FIO} --- Возраст: {elem.Age} --- Курс: {elem.Course} --- Номер студенческого: {elem.NumOfStudentCard}");
            }


            SoapFormatter formatter2 = new SoapFormatter();
            using (FileStream fs = new FileStream("student.soap", FileMode.OpenOrCreate))
            {
                formatter2.Serialize(fs, students2);
            }


            using (FileStream fs = new FileStream("student.soap", FileMode.OpenOrCreate))
            {
                Console.WriteLine("Десериализация");
                Student[] studentsNew2 = (Student[])formatter2.Deserialize(fs);

                foreach (var elem in studentsNew2)
                {
                    Console.WriteLine($"Имя: {elem.FIO} --- Возраст: {elem.Age} --- Курс: {elem.Course} --- Номер студенческого: {elem.NumOfStudentCard}");
                }
            }
            #endregion
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            #region JSON
            Footballer Messi = new Footballer("Messi", 35, new Club("Barcelona"));
            Footballer Ronaldo = new Footballer("Ronaldo", 33, new Club("ManchesterUnited"));
            Footballer[] footballers = new Footballer[] { Messi, Ronaldo };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Footballer[]));
            using (FileStream fs = new FileStream("footballers.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, footballers);
            }
            using (FileStream fs = new FileStream("footballers.json", FileMode.OpenOrCreate))
            {
                Footballer[] footballersNew = (Footballer[])jsonFormatter.ReadObject(fs);
                foreach (var elem in footballersNew)
                {
                    Console.WriteLine($"--- Имя:{elem.Name} --- Возраст: {elem.Age} --- Клуб:{elem.Club.Name}");
                }
            }

            #endregion
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            #region XML

            Footballer Neymar = new Footballer("Neymar", 35, new Club("PSG"));
            Footballer Ibra = new Footballer("Ibrahimović", 40, new Club("Milan"));
            Footballer[] footballers2 = new Footballer[] { Neymar, Ibra };
            // передаем в конструктор тип класса
            XmlSerializer xSer = new XmlSerializer(typeof(Footballer[]));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("footballers.xml", FileMode.OpenOrCreate))
            {
                xSer.Serialize(fs, footballers2);
            }
            // десериализация
            using (FileStream fs = new FileStream("footballers.xml", FileMode.OpenOrCreate))
            {
                Footballer[] footballersNew2 = xSer.Deserialize(fs) as Footballer[];
                foreach (var elem in footballersNew2)
                {
                    Console.WriteLine($"--- Имя: {elem.Name} --- Возраст: {elem.Age} --- Клуб: {elem.Club.Name}");
                }
            }

            #endregion
            Console.WriteLine();


            List<Student> list = new List<Student>() { Dima, Vitya, Danik, Yura };
            using (FileStream fs = new FileStream("List.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
                xs.Serialize(fs, list);
                fs.Close();
                using (FileStream fsd = new FileStream("List.xml", FileMode.Open))
                {
                    List<Student> students1 = (List<Student>)xs.Deserialize(fsd);
                    foreach (var elem in students1)
                    {
                        Console.WriteLine($"Имя: {elem.FIO} --- Возраст: {elem.Age} --- Курс: {elem.Course} --- Номер студенческого: {elem.NumOfStudentCard}");
                    }
                }
            }




         





            Console.WriteLine();
            XDocument students3 = new XDocument();
            XElement root = new XElement("Students");
            XElement student = new XElement("student");
            XAttribute name = new XAttribute("name", "Dima");
            XAttribute surname = new XAttribute("surname", "Pilipovich");
            student.Add(name, surname);
            root.Add(student);
            name = new XAttribute("name", "Vitya");
            surname = new XAttribute("surname", "Slemnyov");
            student = new XElement("student");
            student.Add(name, surname);
            root.Add(student);
            students3.Add(root);
            students3.Save("Students4.xml");

            var allStudents = root.Elements("student");
            foreach (var i in allStudents)
            {
                if (i.Attribute("name").Value == "Vitya")
                    Console.WriteLine(i.Attribute("surname").Value);
            }






        }
    }
}
