using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;
using ProyectoRepuestosMotos.Data;
using ProyectoRepuestosMotos.Interfaces;

namespace ProyectoRepuestosMotos.Servicios;

public class UsuarioServicio : IUsuarioServicio
{
    private readonly ConfiguracionMySQL _configuration;
    private IUsuarioRepositorio usuarioRepositorio;

    public UsuarioServicio(ConfiguracionMySQL configuration)
    {
        _configuration = configuration;
        usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }


    public Task<bool> Actualizar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Usuario>> GetLista()
    {
        return await usuarioRepositorio.GetLista();
    }

    public async Task<Usuario> GetPorCodigo(string codigo)
    {
        return await usuarioRepositorio.GetPorCodigo(codigo);
    }

    public Task<bool> Nuevo(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}
