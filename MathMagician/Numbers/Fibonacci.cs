using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class Fibonacci : Integer
    {
        //could hold 1,1,2,3,5,8,13
        private int[] BaseSequence { get; set; }

        private int First { get; set; }

        public Fibonacci()
        {
            First = 0;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            //current = Aprevious + Bprevious
            //current = current + 1;
            //return current;

            int counter = 1;
            int next = 1;
            while (next < counter)
            {
                counter++;
                next = getFiboNext(counter);
            }
            return next;
        }

        public int[] GetSequence(int how_many)
        {
            /*
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < how_many; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
            */
            int[] sequence = new int[how_many];
            sequence[0] = GetFirst(); //i = 1
            return sequence;
        }

        public string PrintNumbers(int[] sequence_array)
        {
        return String.Join(" ", sequence_array);
        }

        private int getFiboNext(int place)
        {
            if(place == 0)
            {
                return 1;
            }
            if (place <= 1)
            {
                return place;
            }
            return getFiboNext(place - 1) + getFiboNext(place - 2);
        }
    }
}
