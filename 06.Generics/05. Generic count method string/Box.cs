using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01Box
{
    public class Box<T> 
        where T : IComparable
    {

        private readonly List<T> values;


        public Box()
        {
            this.values = new List<T> { };
        }

        public IReadOnlyCollection<T> Values => this.values.AsReadOnly();

        public void AddValue(T value)
        {
            this.values.Add(value);

        }

        public void SwapElements(int firstIndex, int secondIndex)
        {
            var firstElement = values[firstIndex];
            values[firstIndex] = values[secondIndex];
            values[secondIndex] = firstElement;
        }

        public int GreaterThan(List<T> listOfValues, T valueCondition)

        {
            int countOfOccurences = listOfValues
                .Where(t => t.CompareTo(valueCondition) == 1)
                .ToArray().Length;

            return countOfOccurences;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var value in this.values)
            {

                sb.AppendLine($"{value.GetType().FullName}: {value.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
