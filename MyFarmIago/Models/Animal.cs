using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFarmIago.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        public string Observacao { get; set; }

        public virtual ICollection<Registro> Registros { get; set; }
    }
}