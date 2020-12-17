using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutteeFrame.Model
{
    class Conduct
    {
        public enum ConductType { Tot = 0, Kha = 1, TrungBinh = 2, Yeu = 3, ChuaXet = 4 };
        public enum Type { HK1 = 0, HK2 = 1, CaNam = 2 };
        public ConductType conductType;
        public Type type;

        public Conduct()
        {
            this.conductType = ConductType.ChuaXet;
        }
        public Conduct(ConductType conductType, Type type)
        {
            this.conductType = conductType;
            this.type = type;
        }
        public string GetReadableValue()
        {
            switch (conductType)
            {
                case ConductType.Tot:
                    return "Tốt";
                case ConductType.Kha:
                    return "Khá";
                case ConductType.TrungBinh:
                    return "Trung bình";
                case ConductType.Yeu:
                    return "Yếu";
                case ConductType.ChuaXet:
                    return "Chưa xét";
                default:
                    return string.Empty;
            }
        }
        public override string ToString()
        {
            switch (conductType)
            {
                case ConductType.Tot:
                    return "Tot";
                case ConductType.Kha:
                    return "Kha";
                case ConductType.TrungBinh:
                    return "TB";
                case ConductType.Yeu:
                    return "Yeu";
                case ConductType.ChuaXet:
                    return string.Empty;
                default:
                    return string.Empty;
            }
        }
    }
    class StudentConduct
    {
        private string studentID;
        List<Conduct> conducts = new List<Conduct>(3);

        public string StudentID { get => studentID; set => studentID = value; }
        public List<Conduct> Conducts { get => conducts; set => Conducts = value; }
        public StudentConduct()
        {
            for (int i = 0; i < 3; i++)
                this.Conducts.Add(new Conduct());
        }
    }
}
