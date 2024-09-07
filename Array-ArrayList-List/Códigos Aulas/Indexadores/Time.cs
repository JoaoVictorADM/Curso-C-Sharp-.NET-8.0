namespace Indexadores;

public class Time{

    string[] valor = new string[10];

    public string this[int index]
    {
        get{
            if(index < 0 || index >= valor.Length)
                throw new IndexOutOfRangeException("Índice fora dos limites");
            return valor[index];
        }
        set{
            if (index < 0 || index >= valor.Length)
                throw new IndexOutOfRangeException("Índice fora dos limites");
            valor[index] = value;
        }
    }

}
