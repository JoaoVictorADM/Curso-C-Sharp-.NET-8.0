try{

    Console.Write("Informe o dividendo: ");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o divisor: ");
    int divisor = Convert.ToInt32(Console.ReadLine());

    double resultado = Convert.ToDouble(dividendo / divisor);
    Console.WriteLine($"{dividendo}/{divisor} = {resultado}");

} catch(FormatException fe){
    Console.WriteLine($"Não é possível converter a entrada para int\n{fe.Message}");
} catch(DivideByZeroException dbze){
    Console.WriteLine($"Não é possivel dividir por zero\n{dbze.Message}");
} catch(OverflowException oe){
    Console.WriteLine($"O valor informado é muito grande\n{oe.Message}");
} catch (Exception e){
    Console.WriteLine(e);
}

