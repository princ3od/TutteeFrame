using System;

namespace TutteeFrame.Model
{
    class AverageScore
    {
        public enum ScoreType { HK1, HK2, CaNam };
        private double value;
        private ScoreType scoreType;

        //public Score()
        //{

        //}

        public AverageScore(ScoreType scoreType)
        {
            this.scoreType = scoreType;
            Value = -1;
        }

        public double Value { get => Math.Round(value, 2); set => this.value = value; }
        public ScoreType Type { get => scoreType; set => scoreType = value; }

    }
    class Score
    {
        public enum ScoreType { Mieng, MuoiLamPhut, MotTiet, HocKi, TrungBinh };
        private double value;
        private ScoreType scoreType;

        //public Score()
        //{

        //}

        public Score(ScoreType scoreType)
        {
            this.scoreType = scoreType;
            this.value = -1;
        }

        private string subjectID;
        public double Value { get => Math.Round(value, 2); set => this.value = value; }
        public ScoreType Type { get => scoreType; set => scoreType = value; }
        public string SubjectID { get => subjectID; set => subjectID = value; }

        public int GetHeSo()
        {
            switch (scoreType)
            {
                case ScoreType.Mieng:
                case ScoreType.MuoiLamPhut:
                    return 1;
                case ScoreType.MotTiet:
                    return 2;
                case ScoreType.HocKi:
                    return 3;
                default:
                    return 1;
            }
        }
    }
}
