using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleApp22
{
    class Program
    {
        static void Task1()
        {
            Type type = typeof(Console);
            var info = type.GetMethods();
            foreach (var inf in info)
            {
                Console.WriteLine(inf);
            }
        }
        static void Task2()
        {
            Test test = new Test();
            test.Name = "Pavel Durov";
            test.Age = 27;
            Type type = test.GetType();
            object t = Activator.CreateInstance(type);
            var info = type.GetProperties();
            var name = type.GetProperty("Name");
            var age = type.GetProperty("Age");
            foreach(var inf in info)
            {
                Console.WriteLine(inf);
            }
            Console.WriteLine(name.GetValue(test));
            Console.WriteLine(age.GetValue(test));

        }
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("task2");
            Task2();
            Console.ReadLine();
        }
    }
}
