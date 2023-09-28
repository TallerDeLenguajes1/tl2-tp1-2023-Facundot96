namespace TP1;

public class Cliente
{

    private string Nombre;
    private string Direccion;
    private string Telefono;
    private string DatosDeReferencia;

    public Cliente(string nombre, string direccion, string telefono, string datosDeReferencia)
    {
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        DatosDeReferencia = datosDeReferencia;
    }

    public string Nombre1
    {
        get => Nombre;
        
    }

    public string Direccion1
    {
        get => Direccion;
        
    }

    public string Telefono1
    {
        get => Telefono;
       
    }

    public string DatosDeReferencia1
    {
        get => DatosDeReferencia;
    }
    
    public void ListarDatosCliente(){
        Console.WriteLine("Nombre: " + this.Nombre);
        Console.WriteLine("Direccion: " + this.Direccion);
        Console.WriteLine("Telefono: " + this.Telefono);
        Console.WriteLine("Datos de referencia: " + this.DatosDeReferencia);
    }
    
}