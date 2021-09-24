using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person("Jonah", "Jameson", 40);

            //Console.WriteLine("ToString: {0}", p1.ToString());
            //Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            //Console.WriteLine("Type: {0}", p1.GetType());

            //Person p2 = p1;
            //object o = p2;
            //if (o.Equals(p1)&&p2.Equals(o))
            //    Console.WriteLine("Same instance!");
            //Console.WriteLine();

            //Person pers = new Person("Joseph", "Barkley", 32);
            //Console.WriteLine(pers.Equals(p1));

            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);

            Console.WriteLine($"p1.ToString() = {p1.ToString()}");
            Console.WriteLine($"p1.ToString() = {p2.ToString()}");

            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");

            Console.WriteLine($"Same hash codes?: {p1.GetHashCode()==p2.GetHashCode()}");
            Console.WriteLine();

            p2.Age = 45;
            Console.WriteLine($"p1.ToString() = {p1.ToString()}");
            Console.WriteLine($"p1.ToString() = {p2.ToString()}");

            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");

            Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");
            Console.WriteLine();
        }
    }
}
