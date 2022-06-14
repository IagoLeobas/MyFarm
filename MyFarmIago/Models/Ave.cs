using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFarmIago.Models
{
    public enum SexoAve
    {
        Galo, Galinha
    }
    public class Ave : Animal
    {
        [Required]
        public SexoAve? SexoAve { get; set; }
        [Required]
        public bool EhCaipira { get; set; }

    }
}