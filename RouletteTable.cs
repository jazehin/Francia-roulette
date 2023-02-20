using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    internal class RouletteTable
    {
        public Field LeadingField { get; init; }
        public Field[,] Table { get; init; }

        public RouletteTable()
        {
            using StreamReader sr = new(@".\..\..\..\res\french_layout.txt", System.Text.Encoding.UTF8);
            LeadingField = new(sr.ReadLine());
            Field[,] table = new Field[12, 3];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                string[] texts = sr.ReadLine().Split(';');
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = new(texts[j]);
                }
            }
            Table = table;
        }
    }
}
