using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFarmIago.Models
{
    public enum SexoBovino
    {
        Boi, Vaca
    }

    public class Bovino : Animal
    {
        [Required]
        public SexoBovino? SexoBovino { get; set; }
        [Required]
        public bool EhLeiteira { get; set; }
        [Required]
        public double Peso { get; set; }
        [Required]
        [StringLength(30)]
        public string Cor { get; set; }

        public virtual ICollection<Vacina> Vacinas { get; set; }
    }
}