using MySql.Data.MySqlClient;

namespace ProyectoRepuestosMotos.Data;

public class ConfiguracionMySQL
{
    public string CadenaConexion { get; }

    public ConfiguracionMySQL(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }

    public static implicit operator MySqlConfiguration(ConfiguracionMySQL v)
    {
        throw new NotImplementedException();
    }

    //public static implicit operator MySqlConfiguration(ConfiguracionMySQL v)
    //{
    //    throw new NotImplementedException();
    //}


}
