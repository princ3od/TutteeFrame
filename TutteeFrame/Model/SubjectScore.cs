using System.Collections.Generic;

namespace TutteeFrame.Model
{
    class SubjectScore
    {
        private List<Score> score;
        private Subject subject;

        public List<Score> Score { get => score; set => score = value; }
        public Subject Subject { get => subject; set => subject = value; }
    }
}
