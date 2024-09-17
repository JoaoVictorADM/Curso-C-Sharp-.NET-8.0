namespace PartialClass;

[Serializable]
public partial class MinhaPartialClass
{
    public TimeSpan calculaIdade(DateTime DataNascimento)
    {
        return (DateTime.Now.Date - DataNascimento);
    }
    public TimeSpan diferencaEntreDatas(DateTime data1, DateTime data2)
    {
        var diferenca = data1.Subtract(data2);
        return diferenca;
    }
}

