using Modelos;

namespace ProyectoRepuestosMotos.Interfaces;

public interface IFacturaServicio
{
    
    Task<IEnumerable<FacturaNece>> GetLista();
    Task<bool> Nuevo(FacturaNece factura);
     Task<Producto> GetPorCodigo(string Codigo);
}
