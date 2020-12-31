using System.Collections.Generic;
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
        public bool UpdateStudentFault(string _punishmnetID, string _newFault, int _semester)
        {
            return punishmentDA.UpdateFault(_punishmnetID, _newFault, _semester);
        }
        public bool AddPunishment(Punishment punishment)
        {
            return punishmentDA.AddPunishment(punishment);
        }
        public bool UpdatePunishmentContent(string _punishmentID, string _content, int _semester)
        {
            return punishmentDA.UpdateContent(_punishmentID, _content, _semester);
        }
        public List<Punishment> GetPunishments(string _classID = "")
        {
            List<Punishment> punishments = new List<Punishment>();
            if (string.IsNullOrEmpty(_classID))
                punishmentDA.LoadPunishments(punishments);
            else
                punishmentDA.LoadPunishments(punishments, _classID);
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
