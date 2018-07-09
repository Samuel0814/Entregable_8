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
        public int Descripcion { get; set; }
        public Tipos()
        {

        }
    }
}
