using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces;

public interface IProductoRepositorio
{
    Task<bool> Nuevo_Producto(Producto producto);
    Task<bool> Eliminar_Producto(Producto producto);
    Task<bool> Actualizar_Producto(Producto producto);
    Task<IEnumerable<Producto>> GetLista_Producto();
    Task<Producto> GetPorCodigo(string producto);


}
