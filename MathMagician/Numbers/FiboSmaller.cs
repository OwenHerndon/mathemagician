using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    class FiboSmaller : NaturalNumber
    {
        private int[] BaseSequence { get; set; }

        public FiboSmaller()
        {
            First = 0;
            Step = 1;
        }

        public override int GetNext(int current)
        {
            int counter = 1;
            int next = 1;
            while(next < counter)
            {
                counter++;
                next = getFiboAtPlace(counter);
            }
            return next;
        }

        private int getFiboAtPlace(int place)
        {
            if (place == 0)
            {
                return 1;
            }
            if (place <= 1)
            {
                return place;
            }
            return getFiboAtPlace(place - 1) + getFiboAtPlace(place - 2);
        }
        
        public override int[] GetSequence(int how_many)
        {
            BaseSequence = new int[how_many];
            for(var i=0; i < how_many; i++)
            {
                BaseSequence[i] = getFiboAtPlace(i);
            }
            return BaseSequence;
        }
    }
}
