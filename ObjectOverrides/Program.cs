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
            Person p1 = new Person("Jonah", "Jameson", 40);

            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            Person p2 = p1;
            object o = p2;
            if (o.Equals(p1)&&p2.Equals(o))
                Console.WriteLine("Same instance!");
            Console.WriteLine();

            Person pers = new Person("Joseph", "Barkley", 32);
            Console.WriteLine(pers.Equals(p1));
        }
    }
}
