using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame.Model;
using TutteeFrame.DataAccess;
namespace TutteeFrame.Controller
{
    class ClassController
    {
        ClassDA classDA;

        public ClassController()
        {
            classDA = new ClassDA();
        }

        public bool CountNumberOfClass(ref int number)
        {
            return classDA.CountNumberOfClass(ref number);
        }
        public List<Class> GetClass(string Khoi)
        {
            return classDA.Lops(Khoi);
        }
        public bool LoadClass(string _classID,Class _class)
        {
            return classDA.LoadClass(_classID, _class);
        }
    }
}
