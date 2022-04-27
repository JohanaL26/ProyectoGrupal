using Modelos;
using Datos.Interfaces;
using ProyectoRepuestosMotos.Data;
using ProyectoRepuestosMotos.Interfaces;
using Datos.Repositorios;

namespace ProyectoRepuestosMotos.Servicios;

public class FacturaServicio : IFacturaServicio
{
    private readonly ConfiguracionMySQL _configuration;
    private IFacturarepositorio facturaRepositorio;

   

    public FacturaServicio(ConfiguracionMySQL configuration)
    {
        _configuration = configuration;
        facturaRepositorio = new FacturaRepositorio(configuration.CadenaConexion);
    }

    public async Task<IEnumerable<FacturaNece>> GetLista()
    {

        return await facturaRepositorio.GetLista();

    }

    public async Task<Producto> GetPorCodigo(string Codigo)
    {
        return await facturaRepositorio.GetPorCodigo(Codigo);
    }

    public async Task<bool> Nuevo(FacturaNece factura)
    {
        return await facturaRepositorio.Nuevo(factura);
       
    }

    
}

