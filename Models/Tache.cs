using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjecttManager.Models
{
    public class Tache
    {
        [Key]
        public int TacheId { get; set; }
        public string Titre { get; set; }
        public DateTime DateDebutT { get; set; }
        public DateTime DateFinT { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int Priorite { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}
