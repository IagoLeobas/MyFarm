using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFarmIago.Models
{
    public enum Nome
    {
        Febre_Aftosa, Brucelose, Raiva, Carbunculo, Clostridioses, Botulismo, Leptospirose, IBR, BVD, Outro
    }
    public class Vacina
    {
        public int ID { get; set; }
        [Required]
        public Nome? Nome { get; set; }

        public string Observacao { get; set; }

        public int BovinoID { get; set; }
        public virtual Bovino Bovino { get; set; }
    }
}