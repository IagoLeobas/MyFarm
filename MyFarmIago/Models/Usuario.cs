using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFarmIago.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [StringLength(200)]
        public string Funcao { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }

        public virtual ICollection<Registro> Registros { get; set; }

    }
}