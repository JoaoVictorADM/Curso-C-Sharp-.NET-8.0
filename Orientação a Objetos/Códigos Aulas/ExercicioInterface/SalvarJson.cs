namespace ExercicioInterface;
public class SalvarJson: ArquivoBase, ISalvar{
    public void Salvar(){
        Console.WriteLine("Salvar arquivo em JSON");
    }

    public override void Nome(){
        Console.WriteLine("Definir nome JSON");
    }

}
