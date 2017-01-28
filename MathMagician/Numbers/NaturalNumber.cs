using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        private int First { get; set; }

        public NaturalNumber()
        {
            First = 1;
            //this.first = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            //current argument is read only
            //keep looping through numbers
            //current or first number + 1
            //return current++
            //return ++curent 
            current = current + 1;
            return current;
        }

        public int[] GetSequence(int how_many)
        {
            //array set to the number entered by user to be printed out
            //push numers that fit the selected opperator
            //result of filled array.
            int[] Sequence = new int[how_many];
            // for(int i = 1; i < how_many; i++)
            // {
            //   GetNext(i);   
            //}
            return Sequence;
        }

        public string PrintNumbers(int[] how_many)
        {
            throw new NotImplementedException();
        }
    }
}
