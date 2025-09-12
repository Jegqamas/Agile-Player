using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APlayer.Core
{
    public class FrequencyPoint
    {
        public int LeftSample;
        public int RightSample;
        public double Ratio;
        public double Timer;
        public int LeftAv;
        public int RightAv;
        public int Clocks;

        public double Frequency;

        public bool ZeroIt;
    }
}
