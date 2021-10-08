using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letterfrequentie_teller
{
    class LetterCounter
    {
        public string letter { get; set; }
        public int frequency { get; set; }

        public LetterCounter(string letter, int frequency)
        {
            this.letter = letter;
            this.frequency = frequency;
        }
    }
}
