namespace Eventos;

public class Pedido{

    public event EventHandler? OnCriarPedido;

    public void CriarPedido(){

        Console.WriteLine("Pedido Criado\n");

        if(OnCriarPedido != null){
            OnCriarPedido(this, EventArgs.Empty);
        }

    }

}
