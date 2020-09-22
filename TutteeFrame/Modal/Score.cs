using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutteeFrame.Modal
{
    class Score
    {
        public enum ScoreType { Mieng, MuoiLamPhut, MotTiet, HocKi };
        private float value;
        private ScoreType scoreType;

        public float Value { get => value; set => this.value = value; }
        public ScoreType Type { get => scoreType; set => scoreType = value; }
    }
}
