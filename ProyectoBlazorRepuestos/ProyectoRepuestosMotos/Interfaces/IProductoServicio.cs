using Modelos;

namespace ProyectoRepuestosMotos.Interfaces;

public interface IProductoServicio
{
    Task<bool> Nuevo_Producto(Producto producto);
    Task<bool> Eliminar_Producto(Producto producto);
    Task<bool> Actualizar_Producto(Producto producto);
    Task<IEnumerable<Producto>> GetLista();
    Task<Producto> GetPorCodigo(string codigo);


}
