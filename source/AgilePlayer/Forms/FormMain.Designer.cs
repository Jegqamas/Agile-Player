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
namespace APlayer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button_record = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_toggle_mute = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_play_pause = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_save_list = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.panel_media_bar = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label_song_name = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.timer_per_ind = new System.Windows.Forms.Timer(this.components);
            this.timer_meter = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spectrumAnalyzer1 = new APlayer.SpectrumAnalyzer();
            this.groupBox_main.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_record
            // 
            this.button_record.Image = global::APlayer.Properties.Resources.bullet_red;
            this.button_record.Location = new System.Drawing.Point(825, 14);
            this.button_record.Margin = new System.Windows.Forms.Padding(2);
            this.button_record.Name = "button_record";
            this.button_record.Size = new System.Drawing.Size(37, 30);
            this.button_record.TabIndex = 10;
            this.toolTip1.SetToolTip(this.button_record, "Record\r\n (i.e. convert into target settings)\r\n(F8)");
            this.button_record.UseVisualStyleBackColor = true;
            this.button_record.Click += new System.EventHandler(this.button_record_Click);
            // 
            // button1
            // 
            this.button1.Image = global::APlayer.Properties.Resources.control_eject;
            this.button1.Location = new System.Drawing.Point(4, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 30);
            this.button1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button1, "Open File(s)\r\n(CTRL + O)");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // button_prev
            // 
            this.button_prev.Image = global::APlayer.Properties.Resources.control_start;
            this.button_prev.Location = new System.Drawing.Point(303, 14);
            this.button_prev.Margin = new System.Windows.Forms.Padding(2);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(37, 30);
            this.button_prev.TabIndex = 8;
            this.toolTip1.SetToolTip(this.button_prev, "Previous \r\n(F5)");
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.Image = global::APlayer.Properties.Resources.control_end;
            this.button_next.Location = new System.Drawing.Point(344, 14);
            this.button_next.Margin = new System.Windows.Forms.Padding(2);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(37, 30);
            this.button_next.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_next, "Next \r\n(F6)");
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_toggle_mute
            // 
            this.button_toggle_mute.Image = global::APlayer.Properties.Resources.sound;
            this.button_toggle_mute.Location = new System.Drawing.Point(866, 14);
            this.button_toggle_mute.Margin = new System.Windows.Forms.Padding(2);
            this.button_toggle_mute.Name = "button_toggle_mute";
            this.button_toggle_mute.Size = new System.Drawing.Size(37, 30);
            this.button_toggle_mute.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_toggle_mute, "Toggle Mute\r\n(F9)");
            this.button_toggle_mute.UseVisualStyleBackColor = true;
            this.button_toggle_mute.Click += new System.EventHandler(this.button_toggle_mute_Click);
            // 
            // button_pause
            // 
            this.button_pause.Image = global::APlayer.Properties.Resources.control_pause;
            this.button_pause.Location = new System.Drawing.Point(246, 14);
            this.button_pause.Margin = new System.Windows.Forms.Padding(2);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(37, 30);
            this.button_pause.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_pause, "Pause\r\n(Space)");
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_play_pause
            // 
            this.button_play_pause.Image = global::APlayer.Properties.Resources.control_play;
            this.button_play_pause.Location = new System.Drawing.Point(152, 14);
            this.button_play_pause.Margin = new System.Windows.Forms.Padding(2);
            this.button_play_pause.Name = "button_play_pause";
            this.button_play_pause.Size = new System.Drawing.Size(90, 30);
            this.button_play_pause.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_play_pause, "Play \r\n(Space)");
            this.button_play_pause.UseVisualStyleBackColor = true;
            this.button_play_pause.Click += new System.EventHandler(this.button_play_pause_Click);
            // 
            // button_stop
            // 
            this.button_stop.Image = global::APlayer.Properties.Resources.control_stop;
            this.button_stop.Location = new System.Drawing.Point(111, 14);
            this.button_stop.Margin = new System.Windows.Forms.Padding(2);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(37, 30);
            this.button_stop.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_stop, "Stop \r\n(CTRL + Space)");
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label_time
            // 
            this.label_time.BackColor = System.Drawing.SystemColors.Control;
            this.label_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_time.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.Black;
            this.label_time.Location = new System.Drawing.Point(2, 36);
            this.label_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(323, 44);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "00:00:00 - 00:00:00";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_time.Click += new System.EventHandler(this.label_time_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Image = global::APlayer.Properties.Resources.folder;
            this.button2.Location = new System.Drawing.Point(303, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 30);
            this.button2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button2, "Open folder \r\n(scan a folder for audio files with supported formats)\r\n(CTRL + F)");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Image = global::APlayer.Properties.Resources.folder_explore;
            this.button3.Location = new System.Drawing.Point(111, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 30);
            this.button3.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button3, "Open folder including sub folders\r\n(scan folder(s) for audio files with supported" +
        " formats)\r\n(CTRL + D)");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.openFolderIncludeSubFoldersToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Image = global::APlayer.Properties.Resources.folder_table;
            this.button4.Location = new System.Drawing.Point(152, 13);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button4, "Open Playlist\r\n(CTRL + L)");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.openListToolStripMenuItem_Click);
            // 
            // button_save_list
            // 
            this.button_save_list.Image = global::APlayer.Properties.Resources.table_save;
            this.button_save_list.Location = new System.Drawing.Point(246, 13);
            this.button_save_list.Margin = new System.Windows.Forms.Padding(2);
            this.button_save_list.Name = "button_save_list";
            this.button_save_list.Size = new System.Drawing.Size(37, 30);
            this.button_save_list.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button_save_list, "Save Playlist\r\n(CTRL + S)");
            this.button_save_list.UseVisualStyleBackColor = true;
            this.button_save_list.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.Image = global::APlayer.Properties.Resources.door_in;
            this.button6.Location = new System.Drawing.Point(866, 13);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 30);
            this.button6.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button6, "Exit\r\n(ALT + F4)");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.DimGray;
            this.button8.Location = new System.Drawing.Point(825, 13);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 30);
            this.button8.TabIndex = 9;
            this.button8.Text = "A";
            this.toolTip1.SetToolTip(this.button8, "About Agile Player\r\n(F3)");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.Image = global::APlayer.Properties.Resources.page_add;
            this.button7.Location = new System.Drawing.Point(4, 13);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 30);
            this.button7.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button7, "Add files\r\n(CTRL + A)");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.panel_media_bar);
            this.groupBox_main.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_main.Location = new System.Drawing.Point(11, 65);
            this.groupBox_main.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_main.Size = new System.Drawing.Size(575, 291);
            this.groupBox_main.TabIndex = 7;
            this.groupBox_main.TabStop = false;
            // 
            // panel_media_bar
            // 
            this.panel_media_bar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_media_bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_media_bar.Location = new System.Drawing.Point(2, 264);
            this.panel_media_bar.Margin = new System.Windows.Forms.Padding(2);
            this.panel_media_bar.Name = "panel_media_bar";
            this.panel_media_bar.Size = new System.Drawing.Size(571, 25);
            this.panel_media_bar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.label_time);
            this.groupBox6.Controls.Add(this.label_song_name);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(591, 274);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(327, 82);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // label_song_name
            // 
            this.label_song_name.BackColor = System.Drawing.SystemColors.Control;
            this.label_song_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_song_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_song_name.ForeColor = System.Drawing.Color.Black;
            this.label_song_name.Location = new System.Drawing.Point(2, 15);
            this.label_song_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_song_name.Name = "label_song_name";
            this.label_song_name.Size = new System.Drawing.Size(323, 21);
            this.label_song_name.TabIndex = 3;
            this.label_song_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_record);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.button_stop);
            this.groupBox7.Controls.Add(this.button_prev);
            this.groupBox7.Controls.Add(this.button_play_pause);
            this.groupBox7.Controls.Add(this.button_next);
            this.groupBox7.Controls.Add(this.button_pause);
            this.groupBox7.Controls.Add(this.button_toggle_mute);
            this.groupBox7.Location = new System.Drawing.Point(11, 360);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(907, 50);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            // 
            // timer_per_ind
            // 
            this.timer_per_ind.Enabled = true;
            this.timer_per_ind.Interval = 700;
            this.timer_per_ind.Tick += new System.EventHandler(this.timer_per_ind_Tick);
            // 
            // timer_meter
            // 
            this.timer_meter.Enabled = true;
            this.timer_meter.Tick += new System.EventHandler(this.timer_meter_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.button_save_list);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(11, 11);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(907, 50);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spectrumAnalyzer1);
            this.groupBox1.Location = new System.Drawing.Point(591, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // spectrumAnalyzer1
            // 
            this.spectrumAnalyzer1.BackColor = System.Drawing.Color.LightSlateGray;
            this.spectrumAnalyzer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrumAnalyzer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spectrumAnalyzer1.Location = new System.Drawing.Point(3, 16);
            this.spectrumAnalyzer1.MaxDB = 94.308733622833984D;
            this.spectrumAnalyzer1.Name = "spectrumAnalyzer1";
            this.spectrumAnalyzer1.Size = new System.Drawing.Size(321, 185);
            this.spectrumAnalyzer1.TabIndex = 0;
            this.spectrumAnalyzer1.Text = "spectrumAnalyzer1";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Agile Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.FormMain_DragOver);
            this.DragLeave += new System.EventHandler(this.FormMain_DragLeave);
            this.groupBox_main.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_play_pause;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button button_toggle_mute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_media_bar;
        private System.Windows.Forms.Button button_record;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label_song_name;
        private System.Windows.Forms.Timer timer_per_ind;
        private System.Windows.Forms.Timer timer_meter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_save_list;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private SpectrumAnalyzer spectrumAnalyzer1;
        private System.Windows.Forms.Button button7;
    }
}

