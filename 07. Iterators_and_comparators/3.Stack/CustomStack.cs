namespace _03.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> list;

        public CustomStack()
        {
            this.list = new List<T>();
        }

        public void Push(params T[] input)
        {
            this.list.AddRange(input);
        }

        public T Pop()
        {
            if (this.list.Count <= 0)
            {
                throw new ArgumentException ("No elements");
            }

            int lastIndex = this.list.Count - 1;
                T last = this.list[lastIndex];
                this.list.RemoveAt(lastIndex);

                return last;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.list.Count - 1; i >= 0; i--)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
