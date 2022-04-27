using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class FacturaNece
{
    [Required(ErrorMessage = "El campo IdFactura es obligatroio")]
    public string IdFactura { get; set; }
    [Required(ErrorMessage = "El campo CodigoProductoo es obligatroio")]
    public string Codigoproducto { get; set; }
    [Required(ErrorMessage = "El campo Descripción es obligatroio")]
    public string Descripcion { get; set; }
    //[Required(ErrorMessage = "El campo CodigoUsuario es obligatroio")]
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal Total { get; set; }
}
