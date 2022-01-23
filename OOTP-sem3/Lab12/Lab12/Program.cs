using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;


namespace OOP_Lab_12
{
    class Hi
    {
        public static void Gei(string name1, string name2) => Console.WriteLine($"{name1} and {name2} are good boys!");
    }
    class Student : ICloneable
    {
        private string _faculty;
        private string _course;

       

        public Student(string faculty, string course)
        {
            _faculty = faculty;
            _course = course;
        }

        public string Faculty
        {
            get => _faculty;
            set => _faculty = value;
        }
        public string Course => _course;

        public void GetId(int i) => Console.WriteLine(Convert.ToInt32(_course) * i);
        public object Clone() => MemberwiseClone();
    }
    public static class Reflector
    {
       

        public static string GetAssemblyVersion()
        {
            return typeof(Program).Assembly.FullName;
        }

        public static bool IncludeConstructor(object ob)
        { return Type.GetType(ob.ToString()).GetConstructors(BindingFlags.Public | BindingFlags.Instance).Length != 0;
        }


        public static void GetPublicMethods(object ob)
        {
             Type.GetType(ob.ToString()).GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).ToList().ForEach(x => Console.Write($"{x.Name} "));
        }
        public static void GetPropetry(object ob)
        {
            Type.GetType(ob.ToString()).GetProperties().ToList().ForEach(x => Console.Write($"{x.Name} "));
        }

        public static void GetFields(object ob)
        {
            Type.GetType(ob.ToString()).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).ToList().ForEach(x => Console.Write($"{x.Name} "));
        }
        public static void GetInterfaces(object ob)
        {
            Type.GetType(ob.ToString()).GetInterfaces().ToList().ForEach(x => Console.Write($"{x.Name} "));
        }

        public static void GetMethodsByParam(object ob, string par)
        {
            Type.GetType(ob.ToString()).GetMethods().Where(x => x.GetParameters().Any(n => n.ToString() == par)).ToList().ForEach(x => Console.Write($"{x.Name} "));
        }

        public static void InvokeFromFile()
        {
            StreamReader sr = new StreamReader(@"D:\Лабы ООП\Lab12\Lab12\invoke.txt");
            Type type = typeof(Hi);
            string methodName = sr.ReadLine();
            List<string> paramValue = new List<string>();
            while (!sr.EndOfStream)
                paramValue.Add(sr.ReadLine());

            MethodInfo method = type.GetMethod(methodName);
            object obj = Activator.CreateInstance(type);
            method.Invoke(obj, new object[] { paramValue[0], paramValue[1] });
        }

        public static object Create(string faculty, string course)
        {
            Type type = typeof(Student);
            ConstructorInfo info = type.GetConstructor(new Type[] { typeof(string), typeof(string) });
            object obj = info.Invoke(new object[] { faculty, course });

            return obj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Student Student = new Student("FIT", "2");
            Console.WriteLine(++i + ". " + Reflector.GetAssemblyVersion());

            Console.WriteLine(++i + ". " + (Reflector.IncludeConstructor(Student) ? "Student содержит публичные конструкторы" :
                "Student не содержит публичные конструкторы"));

            Console.Write($"{++i}. ");
            Reflector.GetPublicMethods(Student);
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.GetPropetry(Student);
            Reflector.GetFields(Student);
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.GetInterfaces(Student);
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.GetMethodsByParam(Student, "Int32 i");
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.InvokeFromFile();

            object ob = Reflector.Create("LIT", "3");
            Console.Write($"{++i}. {(ob as Student).Faculty} {(ob as Student).Course}");
        }
    }
}
