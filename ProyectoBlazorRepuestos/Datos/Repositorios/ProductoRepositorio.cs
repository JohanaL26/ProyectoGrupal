using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Repositorios;

public class ProductoRepositorio: IProductoRepositorio
{
    private string CadenaConexion;

    public ProductoRepositorio(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }

    private MySqlConnection Conexion()
    {
        return new MySqlConnection(CadenaConexion);
    }

    public async Task<bool> Eliminar_Producto(Producto producto)
    {

        int eliminar_product;
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "DELETE FROM producto WHERE CodigoProducto = @CodigoProducto;";
            eliminar_product = await conexion.ExecuteAsync(sql, new { producto.CodigoProducto });
            return eliminar_product > 0;
        }
        catch (Exception ex)
        {
            return false;
        }
    }


    public async Task<IEnumerable<Producto>> GetLista_Producto()
    {
        IEnumerable<Producto> lista = new List<Producto>();

        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT * FROM producto;";
            lista = await conexion.QueryAsync<Producto>(sql);
        }
        catch (Exception ex)
        {
        }
        return lista;
    }


    public async Task<Producto> GetPorCodigo(string codigo)
    {
        Producto produc = new Producto();
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT * FROM producto WHERE CodigoProducto = @CodigoProducto;";
            produc = await conexion.QueryFirstAsync<Producto>(sql, new { codigo });
        }
        catch (Exception)
        {
        }
        return produc;

    }

    public async Task<bool> Nuevo_Producto(Producto producto)
    {
        int new_product;
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "INSERT INTO producto (CodigoProducto, Descripcion, Precio, Existencia) VALUES (@CodigoProducto, @Descripcion, @Precio, @Existencia)";
            new_product = await conexion.ExecuteAsync(sql, producto);
            return new_product > 0;
        }
        catch (Exception ex)
        {
            return false;
        }
    }


    public async Task<bool> Actualizar_Producto(Producto producto)
    {
        int resultado;
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "UPDATE producto SET CodigoProducto = @CodigoProducto, Descripcion = @Descripcion, Precio = @Precio, Existencias = @Existencias WHERE CodigoProducto = @CodigoProducto ;";
            resultado = await conexion.ExecuteAsync(sql, new
            {
                producto.CodigoProducto,
                producto.Descripcion,
                producto.Precio,
                producto.Existencia

            });
            return resultado > 0;
        }
        catch (Exception ex)
        {
            return false;
        }
    }










}
