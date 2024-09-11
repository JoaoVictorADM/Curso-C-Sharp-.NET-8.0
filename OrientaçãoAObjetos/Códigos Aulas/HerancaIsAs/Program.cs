//Fazendo a conversão explícita (casting) sem usar o operador as

Object carroObj = new Carro();

try{
    var x = (string)carroObj; //System.InvalidCastException;
} catch (Exception ex){
    Console.WriteLine("\nA conversão falhou...\n");
    Console.WriteLine(ex.Message);
}

Console.ReadKey();

//-----------------------------------------------------------
//Fazendo a conversão usando o operador as

Object carroObj1 = new Carro();

var y = carroObj1 as string;  // avalia y como null

if(y != null)
    Console.WriteLine("converteu obj para string");
else
    Console.WriteLine("y é null");


Console.ReadKey();
//------------------------------------------------------------
//Fazendo o downcasting usando o operador as

Circulo circulo1 = new Circulo();
Forma forma1 = circulo1;

//Circulo c = (Circulo)forma;
Circulo c = forma1 as Circulo;   // downcasting

if(c != null)
    c.PintarCirculo();
else
    Console.WriteLine("Operação de downcasting é inválida");


Console.ReadKey();

//-----------------------------------------------------------
Circulo circulo = new Circulo();
Forma forma = circulo;

if(forma is Circulo){   //verifica se o downcast é possivel
    Console.WriteLine("Converteu Forma para Circulo\n");

    //((Circulo)forma).PintarCirculo();
    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
} else
    Console.WriteLine("Operação de downcasting não é possível");

public class Forma{

    protected int xpos, ypos;
    public Forma(){

    }

    public Forma(int x, int y){
        this.xpos = x;
        this.ypos = y;
    }

    public virtual void Desenhar(){
        Console.WriteLine($"Desenhar - Forma na posição : ({this.xpos},{this.ypos})");
    }
}

public class Circulo : Forma{
    public Circulo(){

    }

    public Circulo(int x, int y) : base(x, y){

    }

    public override void Desenhar(){
        Console.WriteLine($"Desenhar círculo na posição : ({this.xpos},{this.ypos})");
    }

    public void PintarCirculo(){
        Console.WriteLine("Pintar o Circulo");
    }
}

class Carro{ 

}