namespace Exercicio_5;
public abstract class DataBase{
    public virtual void Conectar(){
        Console.WriteLine("Conectando ao banco de dados...");
    }
    public abstract void Configurar();
}
