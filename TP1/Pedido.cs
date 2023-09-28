namespace TP1;

public class Pedido
{
    
    private int _numero;
    private string _observacion;
    private Cliente _cliente;
    private string _estado;

    public Pedido(int numero, string observacion, Cliente cliente, string estado)
    {
        _numero = numero;
        _observacion = observacion;
        _cliente = cliente;
        _estado = estado;
    }
    
    public int Numero
    {
        get => _numero;
        
    }

    public string Observacion
    {
        get => _observacion;
        
    }

    public string Estado
    {
        get => _estado;
        
    }

    public void ListarPedido()
    {
        Console.WriteLine($"\n Pedido : " + this.Numero);
        Console.WriteLine($"Observacion: " + this.Observacion);
        Console.WriteLine($"Nombre del cliente: " + this._cliente.Nombre);
        Console.WriteLine($"Estado: " + this.Estado);
    }
    
    
    
}