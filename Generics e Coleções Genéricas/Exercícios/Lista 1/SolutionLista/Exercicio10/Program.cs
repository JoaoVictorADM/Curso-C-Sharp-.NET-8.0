Stack<char> stackParentesesAbertos = new Stack<char>();
string expressao = "((2 + 3) * 5) - 8";

Console.WriteLine($"{(VerificarParenteses(stackParentesesAbertos, expressao) ? "E" : "Não e")}stão balanceados");

static bool VerificarParenteses(Stack<char> stackParentesesAbertos, string expressao){

    foreach(char c in expressao){

        if(c == '(' || c == '{' || c == '['){
            stackParentesesAbertos.Push(c);
          
            continue;
        }

        if(c == ')' || c == '}' || c == ']'){


            if(stackParentesesAbertos.Count == 0)
                return false;
            

            char parenteseAberto = stackParentesesAbertos.Peek();

            if((c == ')' && parenteseAberto == '(') || (c == '}' && parenteseAberto == '{') || (c == ']' && parenteseAberto == '['))
                stackParentesesAbertos.Pop();

        }

    }

    return true;
}