using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "El campo Código es obligatroio")]
    public string CodigoUsuario { get; set; }
    [Required(ErrorMessage = "El campo Nombre es obligatroio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El campo Rol es obligatroio")]
    public string Rol { get; set; }
    //[Required(ErrorMessage = "El campo CodigoUsuario es obligatroio")]
    public string Clave { get; set; }
    public bool EstaActivo { get; set; }
}
