using System.Runtime.Serialization;

namespace Exercicio6;

public class SaldoInsuficienteException : ApplicationException{
    public SaldoInsuficienteException(){

    }

    public SaldoInsuficienteException(string? message) : base(message){

    }

    public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException){

    }

}
    