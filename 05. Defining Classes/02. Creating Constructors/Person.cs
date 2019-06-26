using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {

        private string name;
        private int age;


        public Person()
        {
            this.Age = 1;
            this.Name = "No name";
        }

        public Person( int age) : this() // it takes the age of the previos i think?
        {

            this.Age = age;
            
        }

        public Person(int age, string name) : this(age)
        {
            this.Name = name;

        }
        
        public string Name
        {
            get
            {
                return this.name;

            }

            set
            {
                this.name = value; ;
            }
        }

        public int Age
        {

            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }

    }
}
