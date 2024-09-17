namespace ExercicioInterface;
public class SalvarXml: ArquivoBase, ISalvar{

    public void Salvar(){
        Console.WriteLine("Salvar arquivo em XML");
    }

    public override void Nome(){
        Console.WriteLine("Definir nome XML");
    }

}

