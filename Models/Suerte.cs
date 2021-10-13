using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace parical_2.Models
{
    public class Suerte
    {
        [Key]
        public string SuerteID  { get; set; }
        [Required]
        public string Detalle { get; set; }
        [Required(AllowEmptyStrings =false)]
        [Url]
      
        public string Imagen { get; set; }

    }
}
