using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class Even : Integer
    {
        private int First { get; set; }

        public Even()
        {
            First = 2;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            current = current + 2;
            return current;

        }

        public int[] GetSequence(int how_many)
        {
            int[] sequence = new int[how_many];
            sequence[0] = GetFirst(); //i = 1
            for (int i = 1; i < sequence.Length; i++)
            {
                sequence[i] = GetNext(sequence[i - 1]);
            }
            return sequence;
        }

        public string PrintNumbers(int[] sequence_array)
        {
            return String.Join(" ", sequence_array);
        }
    }
}
