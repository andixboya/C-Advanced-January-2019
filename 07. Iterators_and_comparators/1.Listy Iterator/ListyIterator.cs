

using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class ListyIterator<T>

    {
        private readonly List<T> items;

        private int currentIndex;

        public ListyIterator(params T [] items)
        {
            this.items = new List<T>(items);
            this.Reset();
        }

        public IReadOnlyCollection<T> Items => this.items;

        

        public bool Move()
        {
            if (currentIndex <this.Items.Count-1)
            {
                currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (currentIndex+1==this.Items.Count-1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.items.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.items[currentIndex]);
        }

        private void Reset()
        {
            this.currentIndex = 0;
        }

        public static ListyIterator<T> Create(params T[] items)
        {

            var result = new ListyIterator<T>(items);

            return result;

        }

    }
}
