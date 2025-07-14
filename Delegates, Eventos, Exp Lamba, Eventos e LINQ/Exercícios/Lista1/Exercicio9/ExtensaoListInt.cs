using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9;

public static class ExtensaoListInt{

    public static int somaImpares(this List<int> lista){
        
        int soma = 0;

        foreach(var numero in lista){
            if(numero % 2 != 0)
                soma += numero;
        }

        return soma;
    }

}
