Circulo circulo = new Circulo(20, 20);
Forma f = circulo;    //upcasting

Circulo c = (Circulo)f;   //downcasting

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);


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
