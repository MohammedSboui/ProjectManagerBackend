using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjecttManager.Models
{
    public class Affectation
    {
        public int AffectationId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
