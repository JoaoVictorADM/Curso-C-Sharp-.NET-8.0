AdicionaNumeros<int> adicionaInteiros = new AdicionaNumeros<int>();

Console.WriteLine("Informe o primeiro número :");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o segundo número :");
var num2 = Convert.ToInt32(Console.ReadLine());

var resultado = adicionaInteiros.Adiciona(num1, num2);
Console.WriteLine("Resultado da adição: " + resultado);
Console.ReadKey();
public class AdicionaNumeros<T> where T : struct, IComparable, IConvertible, IFormattable{
    public T Adiciona(T num1, T num2){
        dynamic dynamicNum1 = num1;
        dynamic dynamicNum2 = num2;
        return dynamicNum1 + dynamicNum2;
    }
}
