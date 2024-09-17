namespace Exercicio_5;
public class SQLServer : DataBase{

    public override void Conectar(){
        Console.WriteLine("Conectando ao SQL Server...");
    }
    public override void Configurar(){
        Console.WriteLine("Configurando o banco de dados...");
    }

}
