B b = new B("Olá Mundo...");
b.Exibir();
Console.ReadKey();
class A{

    string texto;
    public A(string s){
        this.texto = s;
    }
    public void Exibir(){
        Console.Write(texto);
    }
}
class B : A{
    public B(string s) : base(s){
        Console.Write(s);
    }
}
