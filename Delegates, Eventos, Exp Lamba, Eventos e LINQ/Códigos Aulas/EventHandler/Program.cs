using Eventos;

Console.WriteLine("Usando o evento OnCriarPedido - EventHandler\n\n");

var pedido = new Pedido();

// inscrevendo os assinantes 

pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();
