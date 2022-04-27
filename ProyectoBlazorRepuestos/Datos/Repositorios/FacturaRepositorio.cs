using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios;
public class FacturaRepositorio : IFacturarepositorio

    {

    private string CadenaConexion;

    public FacturaRepositorio(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }

    private MySqlConnection Conexion()
    {
        return new MySqlConnection(CadenaConexion);
    }
    
    public async Task<IEnumerable<FacturaNece>> GetLista()
    {
        IEnumerable<FacturaNece> lista = new List<FacturaNece>();

        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT * FROM detalleFactura;";
            lista = await conexion.QueryAsync<FacturaNece>(sql);
        }
        catch (Exception ex)
        {
        }
        return lista; 


    }

    public async Task<bool> Nuevo(FacturaNece factura)
    {
        int resultado;
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            
            string sql = "INSERT INTO detallefactura (IdFactura, CodigoProducto, Descripcion, Cantidad, Precio,Total) VALUES (@IdFactura, @CodigoProducto, @Descripcion, @Cantidad, @Precio, @Total);";
            resultado = await conexion.ExecuteAsync(sql, factura);
            return resultado > 0;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<Producto> GetPorCodigo(string codigo)
    {
        
            Producto produ = new Producto();
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT * FROM producto WHERE CodigoProducto = @CodigoProducto;";
            produ = await conexion.QueryFirstAsync<Producto>(sql, new { codigo });
            }
            catch (Exception)
            {
            }
            return produ;
        
    }

  
}
