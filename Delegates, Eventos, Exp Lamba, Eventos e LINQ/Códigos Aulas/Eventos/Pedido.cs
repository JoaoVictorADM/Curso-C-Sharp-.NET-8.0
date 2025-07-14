namespace Eventos;

public delegate void PedidoEventHandler();

public class Pedido{

    public event PedidoEventHandler? OnCriarPedido;

    public void CriarPedido(){

        Console.WriteLine("Pedido Criado\n");

        if(OnCriarPedido != null){
            OnCriarPedido();
        }

    }

}
