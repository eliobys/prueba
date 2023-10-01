using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Entidad
{
   public class Usuario
    {
        [Key]
        public decimal usuID { get; set; }
        [MaxLength (100)  ]
        public string nombre { get; set; }
        [MaxLength(100)]
        public string apellido { get; set; }
    }
}
