using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroLibros.Entidades
{
    public class Tipos
    {
        [Key]
        public int TipoId { get; set; }
        public String Descripcion { get; set; }
        public Tipos()
        {
            TipoId = 0;
            Descripcion = String.Empty;
        }
    }
}
