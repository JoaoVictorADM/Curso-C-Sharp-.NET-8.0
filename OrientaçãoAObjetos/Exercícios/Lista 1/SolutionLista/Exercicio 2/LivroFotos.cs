namespace Exercicio_2;
public class LivroFotos{

    protected int numPaginas;
    public LivroFotos(){
        this.numPaginas = 16;
    }

    public LivroFotos(int numPaginas){
        this.numPaginas = numPaginas;
    }

    public int GetNumPaginas(){ 
        return this.numPaginas;
    }
}
