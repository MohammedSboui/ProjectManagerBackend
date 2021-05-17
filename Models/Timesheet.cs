using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjecttManager.Models
{
    public class Timesheet
    {
        [Key]
        public int TimesheetId { get; set; }
        public DateTime Annee { get; set; }
        public DateTime Mois { get; set; }
        public DateTime Duree { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int UtilisateurId { get; set; }
    }
}
