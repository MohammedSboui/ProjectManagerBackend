using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjecttManager.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Titre { get; set; }

        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        ICollection<Affectation> Affectations { get; set; }
    }
}
