using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    internal class RtbSelection
    {
        public int Start { get; set; }
        public int Length { get; set; }
        public Color Colour { get; set; }

        public RtbSelection(int start, int length, Color colour)
        {
            Start = start;
            Length = length;
            Colour = colour;
        }
    }
}
