using TutteeFrame.DataAccess;

using System.Data;
using TutteeFrame.Model;
namespace TutteeFrame.Controller
{
    public class SchoolController
    {
        private SchoolDA schoolDA = new SchoolDA();
        public bool GetSchoolInfoPrepareToPrint(DataSet input)
        {
            return schoolDA.GetSchoolInfoPrepareToPrint(input);
        }
        public bool GetSchoolInfo(School school)
        {
            return schoolDA.GetSchoolInfo(school);
        }
        public bool UpdateSchoolInfo(School school)
        {
            return schoolDA.UpdateSchoolInfo(school);
        }
    }
    
}
