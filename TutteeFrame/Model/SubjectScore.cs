using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutteeFrame.Modal
{
    class SubjectScore
    {
        private List<Score> score;
        private Subject subject;

        public List<Score> Score { get => score; set => score = value; }
        public Subject Subject { get => subject; set => subject = value; }
    }
}
