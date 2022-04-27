using Modelos;

namespace Datos.Interfaces;

public interface IFacturarepositorio
{
    Task<IEnumerable<FacturaNece>> GetLista();
    Task<bool> Nuevo(FacturaNece factura);
    Task<Producto> GetPorCodigo(string codigo);
}
