try{
    A.ProcessarA();
} catch(Exception e){
    Console.WriteLine("Tratamento na main");
}

public class A{

    public static void ProcessarA(){
        try{
            B.ProcessarB();
        } catch (Exception e){
            Console.WriteLine("Tratamento na classe A");
        }
    }

}

public class B{

    public static void ProcessarB(){
        try{
            C.ProcessarC();
        } catch (Exception e){
            Console.WriteLine("Tratamento na classe B");
            throw;
        }
    }

}

public class C{

    public static void ProcessarC(){
        throw new NotImplementedException("Método não implementado");
    }

}