// This file is part of Agile Player
// An Audio player with downsampler, upsampler and bit-converter
// written in C#.
// 
// Copyright © Alaa Ibrahim Hadid 2022 - 2025
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
// Author email: mailto:alahadid@gmail.com
//
using APlayer.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APlayer
{
    public partial class SpectrumAnalyzer : Control
    {
        public SpectrumAnalyzer()
        {
            InitializeComponent();

            ControlStyles flag = ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint;
            this.SetStyle(flag, true);

            MaxDB = -20 * Math.Log10(short.MaxValue);

            bar_coloring_sp = 42;
        }
        private double[] Freuquencies;
        private int barWidth;
        private int freqIndex;
        private int bar_coloring_sp;
        public double MaxDB { get; set; }
        public void SetFrequencies(double[] frequencies)
        {
            Freuquencies = new double[frequencies.Length];
            for (int i = 0; i < frequencies.Length; i++)
            {
                Freuquencies[i] = frequencies[i];
            }
            // Set them in the player
            APCore.SetFrequencyPoints(frequencies);

            barWidth = this.Width / frequencies.Length;
        }
        private int dbToPixel(double db)
        {
            return (int)(-((db * Height) / MaxDB));
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            freqIndex = 0;
            // Draw the bar lines first
            for (int i = 0; i < Width; i += barWidth)
            {
                if (freqIndex >= Freuquencies.Length)
                    break;
                // Get the frequency
                int level = dbToPixel(-20 * Math.Log10(Math.Abs(APCore.Frequencies[freqIndex].LeftSample)));
                level += dbToPixel(-20 * Math.Log10(Math.Abs(APCore.Frequencies[freqIndex].RightSample)));
                level /= 2;

                //int sample = APCore.Frequencies[freqIndex].LeftSample + APCore.Frequencies[freqIndex].RightSample / 2;
                //int level = sample * Height / short.MaxValue;

                // pe.Graphics.FillRectangle(Brushes.MediumSeaGreen, i, Height - level, barWidth, level);
                // Draw the level
                for (int h = 0; h < level; h++)
                {
                    int y = Height - h;

                    if (y < bar_coloring_sp - 6)
                    {
                        pe.Graphics.DrawLine(Pens.Red, i, y, i + barWidth, y);
                    }
                    else if (y > Height - bar_coloring_sp)
                    {
                        pe.Graphics.DrawLine(Pens.YellowGreen, i, y, i + barWidth, y);
                    }
                    else
                    {
                        pe.Graphics.DrawLine(Pens.MediumSeaGreen, i, y, i + barWidth, y);
                    }
                }
                /* for (int h = 0; h < level; h++)
                 {
                     int y = Height - h;

                     pe.Graphics.DrawLine(Pens.MediumSeaGreen, i, y, i + barWidth, y);

                 }*/
                // Draw text
                if (Freuquencies[freqIndex] < 1000)
                    pe.Graphics.DrawString(Freuquencies[freqIndex].ToString() + "\nHz", Font, Brushes.Black, i + 1, Height - 17);
                else
                    pe.Graphics.DrawString((Freuquencies[freqIndex] / 1000).ToString() + "k" + "\nHz", Font, Brushes.Black, i + 1, Height - 17);

                // Draw line
                pe.Graphics.DrawLine(Pens.Black, i, 0, i, this.Height);

                //  i += barWidth;
                freqIndex++;
            }

            //pe.Graphics.DrawString(APCore.audio_clocks_left.ToString(), Font, Brushes.Black, 0, 0);
            // Draw db texts
            /*int space = 10;
            for (double i = 0; i <= MaxDB; i++)
            {
                int dd = (int)((i * Height) / MaxDB);

                if (dd - space >= 0)
                {
                    if (Height - dd - 13 >= 0)
                        pe.Graphics.DrawString(((int)i).ToString("D2") + " dB", Font, Brushes.Black, 0, Height - dd - 13);

                    space = dd + 10;
                }
            }*/
            // pe.Graphics.DrawLine(Pens.Black, 0, Height - 18, Width, this.Height-18);
            pe.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);

           // APCore.UpdateFrequencyPoints();
        }
    }
}
