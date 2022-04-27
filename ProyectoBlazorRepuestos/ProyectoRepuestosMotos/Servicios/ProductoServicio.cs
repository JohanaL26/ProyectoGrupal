using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;
using ProyectoRepuestosMotos.Data;
using ProyectoRepuestosMotos.Interfaces;

namespace ProyectoRepuestosMotos.Servicios;

public class ProductoServicio: IProductoServicio
{
    private readonly ConfiguracionMySQL _configuration;
    private IProductoRepositorio productoRepositorio;


    public ProductoServicio(ConfiguracionMySQL configuration)
    {
        _configuration = configuration;
        productoRepositorio = new ProductoRepositorio(configuration.CadenaConexion);
    }

    public async Task<bool> Actualizar_Producto(Producto producto)
    {
        return await productoRepositorio.Actualizar_Producto(producto);
    }

    public async Task<bool> Eliminar_Producto(Producto producto)
    {
        return await productoRepositorio.Eliminar_Producto(producto);
    }

    public async Task<IEnumerable<Producto>> GetLista()
    {
        return await productoRepositorio.GetLista_Producto();
    }

    public async Task<Producto> GetPorCodigo(string codigo)
    {
        return await productoRepositorio.GetPorCodigo(codigo);
    }

    public async Task<bool> Nuevo_Producto(Producto producto)
    {
        return await productoRepositorio.Nuevo_Producto(producto);
    }



}
