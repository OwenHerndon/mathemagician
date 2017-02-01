using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        protected int First { get; set; }
        protected int Step { get; set; }
        //private List<int> sequence {get; set;}

        public NaturalNumber()
        {
            First = 1;
            Step = 1;
            //this.first = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        virtual public int GetNext(int current)
        {
            //current argument is read only
            //keep looping through numbers
            //current or first number + 1
            //return current++
            //return ++curent 
            //current = current + 1;
            return current + Step;
        }

        virtual public int[] GetSequence(int how_many)
        {
            //array set to the number entered by user to be printed out
            //push numers that fit the selected opperator
            //result of filled array.
            int[] sequence = new int[how_many];
            sequence[0] = GetFirst(); //i = 1
            for(int i = 1; i < sequence.Length; i++)
            {
               sequence[i] = GetNext(sequence[i-1]);   
            }
            return sequence;
        }

        public string PrintNumbers(int[] sequence_array)
        {
            return String.Join(" ", sequence_array);
        }
    }
}
