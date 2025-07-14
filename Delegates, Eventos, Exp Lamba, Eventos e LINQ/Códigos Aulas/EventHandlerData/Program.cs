using EventHandlerArgs;

Console.WriteLine("Usando o evento OnCriarPedido\n\n");

var pedido = new Pedido();

// inscrevendo os assinantes 

pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido("joaovictor@gmail.com", "+55 42 9 9999-999");