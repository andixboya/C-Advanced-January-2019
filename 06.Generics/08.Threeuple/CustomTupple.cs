using System;
using System.Collections.Generic;
using System.Text;

namespace Tupple
{
    public class CustomTupple<T1, T2, T3>
    {

        public CustomTupple(T1 itemOne, T2 itemTwo,T3 itemThree )
        {
            this.Item1 = itemOne;
            this.Item2 = itemTwo;
            this.Item3 = itemThree;
        }


        public T1 Item1 { get; set; }

        public T2 Item2 { get; set; }

        public T3 Item3 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }

    }
}
