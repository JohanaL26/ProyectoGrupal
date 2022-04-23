namespace ProyectoRepuestosMotos.Data;

public class ConfiguracionMySQL
{
    public string CadenaConexion { get; }

    public ConfiguracionMySQL(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }

}
