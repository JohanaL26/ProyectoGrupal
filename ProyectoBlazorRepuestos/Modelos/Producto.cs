using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos;

public class Producto
{
    [Required(ErrorMessage = "El campo Código de producto es obligatorio")]
    public string CodigoProducto { get; set; }
    [Required(ErrorMessage = "El campo Descripcion de producto es obligatorio")]
    public string Descripcion { get; set; }
    [Required(ErrorMessage = "El campo Precio de producto es obligatorio")]
    public decimal Precio { get; set; }
    [Required(ErrorMessage = "El campo Existencia de producto es obligatroio")]
    public int Existencia { get; set; }


}
