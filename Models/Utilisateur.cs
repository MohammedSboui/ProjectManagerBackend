using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjecttManager.Models
{
    public class Utilisateur
    {
        [Key]
        public int UtilisateurId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Sexe { get; set; }
        public string EtatCivil { get; set; }
        ICollection<Affectation> Affectations { get; set; }
    }
}
