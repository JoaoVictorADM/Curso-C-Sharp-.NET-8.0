Queue<Pedido> filaPedidos = new Queue<Pedido>();

filaPedidos.Enqueue(new Pedido(1, 100.0));
filaPedidos.Enqueue(new Pedido(2, 200.0));
filaPedidos.Enqueue(new Pedido(3, 300.0));

Console.WriteLine($"Número de pedidos na fila: {filaPedidos.Count}");

while(filaPedidos.Count > 0){
    Pedido pedido = filaPedidos.Dequeue();
    Console.WriteLine($"Pedido Número: {pedido.Numero} - Valor: {pedido.Valor}");
}

filaPedidos.Enqueue(new Pedido(4, 400.0));
filaPedidos.Enqueue(new Pedido(5, 500.0));

int numPedido = 5;

Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(p => p.Numero == numPedido);

if(pedidoLocalizado != null)
    Console.WriteLine($"Pedido {numPedido} localizado na fila, " +
                         $"valor {pedidoLocalizado.Valor}");

public class Pedido{

    public int Numero { get; set; }
    public double Valor { get; set; }

    public Pedido(int Numero, double Valor){
        this.Numero = Numero;
        this.Valor = Valor;
    }

}
