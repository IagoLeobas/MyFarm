using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFarmIago.Models
{
    public class Registro
    {
        public int RegistroID { get; set; }
        public int UsuarioID { get; set; }
        public int AnimalID { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Animal Animal { get; set; }
    }
}