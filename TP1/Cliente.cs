namespace TP1;

public class Cliente
{

    private string _nombre;
    private string _direccion;
    private string _telefono;
    private string _datosDeReferencia;

    public Cliente(string nombre, string direccion, string telefono, string datosDeReferencia)
    {
        _nombre = nombre;
        _direccion = direccion;
        _telefono = telefono;
        _datosDeReferencia = datosDeReferencia;
    }

    public string Nombre
    {
        get => _nombre;
       
    }

    public string Direccion
    {
        get => _direccion;
        
    }

    public string Telefono
    {
        get => _telefono;
        
    }

    public string DatosDeReferencia
    {
        get => _datosDeReferencia;
        
    }

    public void ListarDatosCliente(){
        Console.WriteLine("Nombre: " + this._nombre);
        Console.WriteLine("Direccion: " + this._direccion);
        Console.WriteLine("Telefono: " + this._telefono);
        Console.WriteLine("Datos de referencia: " + this._datosDeReferencia);
    }
    
}