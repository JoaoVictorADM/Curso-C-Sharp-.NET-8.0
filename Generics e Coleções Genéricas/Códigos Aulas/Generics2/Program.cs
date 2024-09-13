ClasseGenerica<int> intObj = new ClasseGenerica<int>();

intObj.Adicionar(10);
intObj.Adicionar(20);
intObj.Adicionar(30);
intObj.Adicionar(40);
intObj.Adicionar(50);

Console.WriteLine("Classe ClasseGenerica<T> de objetos int");

for(int i = 0; i < 5; i++)
    Console.WriteLine(intObj[i]);

Console.ReadKey();
public class ClasseGenerica<T>{

    T[] obj = new T[5];
    int contador = 0;

    public void Adicionar(T item){

        if(contador > 4)
            return;

        obj[contador] = item;
        contador++;
    }

    public T this[int index]{
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}