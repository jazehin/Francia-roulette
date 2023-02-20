using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Roulette
{
    internal class Field
    {
        private char Colour { get; init; }
        public int Value { get; init; }

        public Field(string text)
        {
            Colour = text[0];
            Value = int.Parse(text.Substring(1, 2));
        }

        public Color GetColor() // 0: bgcolor, 1: forecolor
        {
            return Colour switch
            {
                'R' => Color.Red,
                'B' => Color.Black,
                _ => Color.Green
            };
        }
    }
}
