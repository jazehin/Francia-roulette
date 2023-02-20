using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    internal class RouletteGameControler
    {
        private static RouletteTable table = new();
        private static Dictionary<string, decimal> stakes;
        private static int credits;
        private static MainForm main = GetMainForm;
        private static List<RtbSelection> selections = new();

        private static MainForm GetMainForm => Application.OpenForms.OfType<MainForm>().FirstOrDefault();

        public static void Start()
        {
            VisualizeTable();
            NewGame();
        }

        public static void NewGame()
        {
            credits = 1000;
            main.lblZsetonok.Text = $"{credits}";
            main.nudStake.Maximum = credits;
            stakes = new();

            selections = new();
            EraseEventBoard();
            UpdateEventBoard(new() { "Események:", "Új játék kezdődött." }, newline: true);
        }

        private static void VisualizeTable()
        {
            // Delete alr existing buttons
            foreach (Control c in main.panelTable.Controls)
            {
                c.Dispose();
            }

            // Button size:
            int btnWidth = 50/*px*/;
            int btnHeight = 30/*px*/;

            main.panelTable.Size = new(5 * btnWidth, 13 * btnHeight);

            // Beginning placement:
            Point origo = new(0, 0);

            Button leadingBtn = new();
            leadingBtn.Text = Convert.ToString(table.LeadingField.Value);
            leadingBtn.BackColor = table.LeadingField.GetColor();
            leadingBtn.ForeColor = Color.White;
            leadingBtn.Size = new(btnWidth * 3, btnHeight);
            leadingBtn.Location = new(origo.X + btnWidth, origo.Y);
            leadingBtn.Click += Bet;
            leadingBtn.Tag = "0";
            main.panelTable.Controls.Add(leadingBtn);

            for (int i = 0; i < table.Table.GetLength(0); i++)
            {
                for (int j = 0; j < table.Table.GetLength(1); j++)
                {
                    Button btn = new();
                    btn.Text = Convert.ToString(table.Table[i, j].Value);
                    btn.BackColor = table.Table[i, j].GetColor();
                    btn.ForeColor = Color.White;
                    btn.Size = new(btnWidth, btnHeight);
                    btn.Location = new(origo.X + (j + 1) * btnWidth, origo.Y + (i + 1) * btnHeight);
                    btn.Click += Bet;
                    btn.Tag = btn.Text;
                    main.panelTable.Controls.Add(btn);


                }
            }

            // passe
            Button btnPasse = new();
            btnPasse.TextAlign = ContentAlignment.MiddleCenter;
            btnPasse.UseVisualStyleBackColor = true;
            btnPasse.Paint += (s, e) =>
            {
                SizeF textSize = e.Graphics.MeasureString("PASSE", btnPasse.Font);
                e.Graphics.TranslateTransform(btnPasse.ClientSize.Width / 2 + textSize.Height / 2, btnPasse.ClientSize.Height / 2 - textSize.Width / 2);
                e.Graphics.RotateTransform(90);
                e.Graphics.DrawString("PASSE", btnPasse.Font, SystemBrushes.ControlText, 0, 0);
            };
            btnPasse.Size = new(btnWidth, btnHeight * 4);
            btnPasse.Location = new(origo.X, origo.Y + btnHeight);
            btnPasse.Click += Bet;
            btnPasse.Tag = "PASSE";
            main.panelTable.Controls.Add(btnPasse);

            // manque
            Button btnManque = new();
            btnManque.TextAlign = ContentAlignment.MiddleCenter;
            btnManque.UseVisualStyleBackColor = true;
            btnManque.Paint += (s, e) =>
            {
                SizeF textSize = e.Graphics.MeasureString("MANQUE", btnManque.Font);
                e.Graphics.TranslateTransform(btnManque.ClientSize.Width / 2 - textSize.Height / 2, btnManque.ClientSize.Height / 2 + textSize.Width / 2);
                e.Graphics.RotateTransform(270);
                e.Graphics.DrawString("MANQUE", btnManque.Font, SystemBrushes.ControlText, 0, 0);
            };
            btnManque.Size = new(btnWidth, btnHeight * 4);
            btnManque.Location = new(origo.X + 4 * btnWidth, origo.Y + btnHeight);
            btnManque.Click += Bet;
            btnManque.Tag = "MANQUE";
            main.panelTable.Controls.Add(btnManque);

            // pair
            Button btnPair = new();
            btnPair.TextAlign = ContentAlignment.MiddleCenter;
            btnPair.UseVisualStyleBackColor = true;
            btnPair.Paint += (s, e) =>
            {
                SizeF textSize = e.Graphics.MeasureString("PAIR", btnPair.Font);
                e.Graphics.TranslateTransform(btnPair.ClientSize.Width / 2 + textSize.Height / 2, btnPair.ClientSize.Height / 2 - textSize.Width / 2);
                e.Graphics.RotateTransform(90);
                e.Graphics.DrawString("PAIR", btnPair.Font, SystemBrushes.ControlText, 0, 0);
            };
            btnPair.Size = new(btnWidth, btnHeight * 4);
            btnPair.Location = new(origo.X, origo.Y + 5 * btnHeight);
            btnPair.Click += Bet;
            btnPair.Tag = "PAIR";
            main.panelTable.Controls.Add(btnPair);

            // impair
            Button btnImpair = new();
            btnImpair.TextAlign = ContentAlignment.MiddleCenter;
            btnImpair.UseVisualStyleBackColor = true;
            btnImpair.Paint += (s, e) =>
            {
                SizeF textSize = e.Graphics.MeasureString("IMPAIR", btnImpair.Font);
                e.Graphics.TranslateTransform(btnImpair.ClientSize.Width / 2 - textSize.Height / 2, btnImpair.ClientSize.Height / 2 + textSize.Width / 2);
                e.Graphics.RotateTransform(270);
                e.Graphics.DrawString("IMPAIR", btnImpair.Font, SystemBrushes.ControlText, 0, 0);
            };
            btnImpair.Size = new(btnWidth, btnHeight * 4);
            btnImpair.Location = new(origo.X + 4 * btnWidth, origo.Y + 5 * btnHeight);
            btnImpair.Click += Bet;
            btnImpair.Tag = "IMPAIR";
            main.panelTable.Controls.Add(btnImpair);

            // black
            Button btnBlack = new();
            btnBlack.BackColor = Color.Black;
            btnBlack.Size = new(btnWidth, btnHeight * 4);
            btnBlack.Location = new(origo.X, origo.Y + 9 * btnHeight);
            btnBlack.Click += Bet;
            btnBlack.Tag = "BLACK";
            main.panelTable.Controls.Add(btnBlack);

            // red
            Button btnRed = new();
            btnRed.BackColor = Color.Red;
            btnRed.Size = new(btnWidth, btnHeight * 4);
            btnRed.Location = new(origo.X + 4 * btnWidth, origo.Y + 9 * btnHeight);
            btnRed.Click += Bet;
            btnRed.Tag = "RED";
            main.panelTable.Controls.Add(btnRed);
        }

        private static void EraseEventBoard()
        {
            main.rtbEvents.Text = String.Empty;
        }

        private static void UpdateEventBoard(
            List<string> texts,
            List<Color> colours = null,
            bool newline = false)
        {
            if (colours is null)
                colours = new List<Color> { Color.Black };

            if(!string.IsNullOrWhiteSpace(main.rtbEvents.Text))
                main.rtbEvents.Text += $"\n";

            for (int i = 0; i < texts.Count; i++)
            {
                main.rtbEvents.Text += texts[i];

                if (colours.Count > i && colours[i] != Color.Black)
                {
                    int start = main.rtbEvents.Text.LastIndexOf(texts[i]);
                    int length = texts[i].Length;
                    Color colour = colours[i];
                    selections.Add(new(start, length, colour));
                }

                if (newline && i != texts.Count - 1)
                    main.rtbEvents.Text += $"\n";
            }

            foreach (RtbSelection selection in selections)
            {
                main.rtbEvents.SelectionStart = selection.Start;
                main.rtbEvents.SelectionLength = selection.Length;
                main.rtbEvents.SelectionColor = selection.Colour;
            }
        }

        private static void Bet(object? sender, EventArgs e)
        {
            if (sender is null) return;
            Button btn = sender as Button;

            string tag = Convert.ToString(btn.Tag);
            decimal value = main.nudStake.Value;

            if (credits - value < 0)
            {
                UpdateEventBoard(new() { $"Nincs ennyi zsetonja!" });
                return;
            }

            if (value == 0)
            {
                UpdateEventBoard(new() { $"0 zsetonnal nem fogadhat!" });
                return;
            }

            if (stakes.ContainsKey(tag))
            {
                stakes[tag] += value;
                UpdateEventBoard(new() { $"A {tag} mezőre tett további {value} zsetont. Így jelenleg van rajta {stakes[tag]} zseton." });
            }
            else
            {
                stakes.Add(tag, value);
                UpdateEventBoard(new() { $"A {tag} mezőre tett {value} zsetont. Így jelenleg van rajta {stakes[tag]} zseton." });
            }


            credits -= (int)value;
            main.lblZsetonok.Text = $"{credits}";
            main.nudStake.Maximum = credits;
        }

        private static Color GetColourByButtonText(string text)
        {
            return main.panelTable
                .Controls
                .Cast<Control>()
                .First(c => (c as Button).Text == text)
                .BackColor;
        }

        public static void Spin()
        {
            int random = new Random().Next(0, 37);
            Color colour = GetColourByButtonText($"{random}");
            UpdateEventBoard(
                texts: new() { $"A pörgetett szám: ", $"{random}" }, 
                colours: new() { Color.Black, colour },
                newline: false
            );

            Evaluate(random, colour);

            stakes = new();
        }

        private static void Evaluate(int random, Color colour)
        {
            if (stakes.Count == 0)
            {
                UpdateEventBoard(texts: new() { $"Nem fogadott a körben!" });
                return;
            }

            foreach (var kvp in stakes)
            {
                switch (kvp.Key)
                {
                    case "PASSE":
                        if (random >= 19)
                        {
                            credits += (int)kvp.Value;
                            UpdateEventBoard(texts: new() { $"PASSE mezőre fogadása bejött, visszanyerte zsetonjait!" });
                        }
                        break;
                    case "MANQUE":
                        if (random < 19 && random != 0)
                        {
                            credits += (int)kvp.Value;
                            UpdateEventBoard(texts: new() { $"MANQUE mezőre fogadása bejött, visszanyerte zsetonjait!" });
                        }
                        break;
                    case "PAIR":
                        if (random % 2 == 0 && random != 0)
                        {
                            credits += (int)kvp.Value;
                            UpdateEventBoard(texts: new() { $"PAIR mezőre fogadása bejött, visszanyerte zsetonjait!" });
                        }
                        break;
                    case "IMPAIR":
                        if (random % 2 == 1)
                        {
                            credits += (int)kvp.Value;
                            UpdateEventBoard(texts: new() { $"IMPAIR mezőre fogadása bejött, visszanyerte zsetonjait!" });
                        }
                        break;
                    case "RED":
                        if (colour == Color.Red)
                        {
                            credits += (int)kvp.Value;
                            UpdateEventBoard(texts: new() { $"RED mezőre fogadása bejött, visszanyerte zsetonjait!" });
                        }
                        break;
                    case "BLACK":
                        if (colour == Color.Black)
                        {
                            credits += (int)kvp.Value;
                            UpdateEventBoard(texts: new() { $"BLACK mezőre fogadása bejött, visszanyerte zsetonjait!" });
                        }
                        break;
                    default:
                        int n = int.Parse(kvp.Key);
                        if (random == n)
                        {
                            credits += (int)kvp.Value * 35;
                            UpdateEventBoard(texts: new() { $"{n} mezőre fogadása bejött, megharmincötszörözte az odahelyezett zsetonjait!" });
                        }
                        break;
                }
            }

            main.lblZsetonok.Text = $"{credits}";
            main.nudStake.Maximum = credits;
        }
    }
}
