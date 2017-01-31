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
            First = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            //current = Aprevious + Bprevious
            current = current + 1;
            return current;
        }

        public int[] GetSequence(int how_many)
        {
            throw new NotImplementedException();
        }

        public string PrintNumbers(int[] how_many)
        {
            throw new NotImplementedException();
        }
    }
}
