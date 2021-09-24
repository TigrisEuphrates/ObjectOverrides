using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; } = "";
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }
        public override string ToString()=>
            $"[{base.ToString()}; First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
        //public override bool Equals(object obj)
        //{
        //    if (obj is Person&&obj!=null)
        //    {
        //        Person temp;
        //        temp = (Person)obj;
        //        if(FirstName==temp.FirstName&&LastName==temp.LastName&&Age==temp.Age)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return false;
        //}
        public override bool Equals(object obj) => obj?.ToString() == ToString();
        public override int GetHashCode()
        {
            //return SSN.GetHashCode();
            return this.ToString().GetHashCode();
        }
    }
}
