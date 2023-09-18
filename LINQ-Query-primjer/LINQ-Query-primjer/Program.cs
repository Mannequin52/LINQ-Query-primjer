using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Query_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string collection
            List<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };

            //LINQ Query syntax
            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
