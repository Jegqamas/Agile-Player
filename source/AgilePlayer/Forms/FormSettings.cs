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
using System;
using System.Windows.Forms;
using APlayer.Core;

namespace APlayer
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            checkBox_save_list_on_exit.Checked = Program.AppSettings.SaveListOnExit;
        }
        // Cancel
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Program.AppSettings.SaveListOnExit = checkBox_save_list_on_exit.Checked;
            Close();
        }
    }
}
