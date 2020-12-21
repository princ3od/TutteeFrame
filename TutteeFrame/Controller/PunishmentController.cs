using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame.Model;
using TutteeFrame.DataAccess;

namespace TutteeFrame.Controller
{
    class PunishmentController
    {
        PunishmentDA punishmentDA;
        public PunishmentController()
        {
            punishmentDA = new PunishmentDA();
        }
        public bool AddStudentFault(Punishment punishment)
        {
            return punishmentDA.AddFault(punishment);
        }
        public bool AddPunishment(Punishment punishment)
        {
            return punishmentDA.AddPunishment(punishment);
        }
        public bool UpdatePunishmentContent(string _punishmentID, string _content)
        {
            return punishmentDA.UpdateContent(_punishmentID, _content);
        }
    }
}
