
using System.Data;
using TutteeFrame.Controller;

namespace TutteeFrame.Model
{
    public class BaseInforSchoolPrepareToPrint
    {
        public SchoolController schoolController = new SchoolController();

        public DataSet BaseInforSchool = new DataSet();
        public BaseInforSchoolPrepareToPrint()
        {
            schoolController.GetSchoolInfoPrepareToPrint(BaseInforSchool);
        }
    }
}
