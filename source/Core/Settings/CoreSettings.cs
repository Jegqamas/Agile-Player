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
namespace APlayer.Core
{
    [SettingsInfo("coresettings.ini")]
    public class CoreSettings : ISettings
    {
        public string Audio_RendererID = "";

        public int Audio_TargetFrequency = 44100;
        public int Audio_TargetAudioChannels = 2;
        public int Audio_TargetBitsPerSample = 16;
        public bool Audio_DB_Fix_Enabled = false;// Disabled by default
        public int Audio_Wave_Fix_Mode = 0;// 0 disabled, 1 wave fix shift mode
        public int Audio_Volume = 86;// 0 to 100 %

        public override void LoadSettings()
        {
            base.LoadSettings();
            // Wired settings
            Audio_TargetFrequency = 44100;
            Audio_TargetAudioChannels = 2;
            Audio_TargetBitsPerSample = 16;
            Audio_DB_Fix_Enabled = false;// Disabled by default
            Audio_Wave_Fix_Mode = 0;// 0 disabled, 1 wave fix shift mode
            Audio_Volume = 100;// 0 to 100 %
        }
    }
}
