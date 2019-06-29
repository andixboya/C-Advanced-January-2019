
using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake  :IEnumerable<int>
    {
        private List<int> numbers;

        public Lake(params int[] numbers)
        {
            this.numbers = new List<int>(numbers);
        }

        public IReadOnlyCollection<int> Numbers => this.numbers;

        public IEnumerator<int> GetEnumerator()
        {
            int countOfElements = this.numbers.Count;

                for (int i = 0; i < countOfElements; i++)
                {
                    if (i%2==0)
                    {
                        yield return this.numbers[i];
                    }
                }


                for (int i = countOfElements - 1; i >= 0; i--)
                {
                    if (i%2==1)
                    {
                        yield return this.numbers[i];
                    }
                }


        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        
    }
}
