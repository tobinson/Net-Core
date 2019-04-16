using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace sistemaAspCore.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="El nombre debe tener de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(356,ErrorMessage ="La descripcion no debe exeder los 256 caracter")]
        [Display(Name ="Descripción")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
