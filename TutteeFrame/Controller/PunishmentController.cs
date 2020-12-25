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
        public bool UpdateStudentFault(string _punishmnetID, string _newFault)
        {
            return punishmentDA.UpdateFault(_punishmnetID, _newFault);
        }
        public bool AddPunishment(Punishment punishment)
        {
            return punishmentDA.AddPunishment(punishment);
        }
        public bool UpdatePunishmentContent(string _punishmentID, string _content)
        {
            return punishmentDA.UpdateContent(_punishmentID, _content);
        }
        public List<Punishment> GetPunishments()
        {
            List<Punishment> punishments = new List<Punishment>();
            punishmentDA.LoadPunishments(punishments);
            return punishments;
        }
        public Punishment GetPunishment(string _punishmentID)
        {
            Punishment punishment = new Punishment();
            punishmentDA.LoadPunishment(_punishmentID, punishment);
            return punishment;
        }
        public bool DeletePunishment(string _punishmentID)
        {
            return punishmentDA.DeletePunishmnet(_punishmentID);
        }
    }
}
