using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øvelse_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] person = new string[5];
            person[0] = "John Smith";
            person[1] = "Jackie Jackson";
            person[2] = "Chris Jones";
            person[3] = "Amanda Cullen";
            person[4] = "Jeremy Goodwin";
            Console.WriteLine("There are 5 employees:");
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i]);
            }
            Console.Write("Enter an employee name to remove: ");
            string remove = Console.ReadLine();

            List<string> list = new List<string>(person);
            list.Remove(remove);

            list.ForEach(Console.WriteLine);
            Console.ReadLine();




        }
    }
}
