using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DragonBallGuerrerosMvc.Models
{
    public class Tecnica
    {
        [Key]
        public int TecnicaId { get; set; }
       
        [Required]
        public string Nombre { get; set; }
        
        public virtual ICollection<Guerrero> Guerreros { get; set; }
    }
}