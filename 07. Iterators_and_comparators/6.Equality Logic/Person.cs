

namespace EqualityLogic
{

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public override int GetHashCode()
        {
            return this.Age.GetHashCode() + this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var person = (Person)obj;

            return this.Age == person.Age && this.Name == person.Name;
        }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result==0)
            {
                result= this.Age.CompareTo(other.Age);
            }

            return result;
        }
    }
}
