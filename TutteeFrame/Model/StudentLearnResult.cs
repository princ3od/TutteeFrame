using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutteeFrame.Model
{
    abstract class AbstractLearn
    {
        public enum Type { HK1 = 0, HK2 = 1, CaNam = 2 };
        public Type type;
    }
    class LearniningCapacity : AbstractLearn
    {
        public enum HocLuc { Gioi = 0, Kha = 1, TrungBinh = 2, Yeu = 3, Kem = 4, ChuaXet = 5 };
        public HocLuc LearnCapacity;

        public LearniningCapacity()
        {
            this.LearnCapacity = HocLuc.ChuaXet;
        }
        public override string ToString()
        {
            switch (LearnCapacity)
            {
                case HocLuc.Gioi:
                    return "Giỏi";
                case HocLuc.Kha:
                    return "Khá";
                case HocLuc.TrungBinh:
                    return "Trung bình";
                case HocLuc.Yeu:
                    return "Yếu";
                case HocLuc.Kem:
                    return "Kém";
                case HocLuc.ChuaXet:
                    return "Chưa xét";
                default:
                    return string.Empty;
            }
        }
    }
    class Conduct : AbstractLearn
    {
        public enum ConductType { Tot = 0, Kha = 1, TrungBinh = 2, Yeu = 3, ChuaXet = 4 };
        
        public ConductType conductType;

        public Conduct()
        {
            this.conductType = ConductType.ChuaXet;
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
                this.conducts.Add(new Conduct());
        }
    }
}
