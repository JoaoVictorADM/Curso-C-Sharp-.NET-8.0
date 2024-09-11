namespace Composicao;

public class Instalador{
    public string? Local { get; set; }
    public DateTime DataHora { get; set; }

    private readonly Logger _logger;
    public Instalador(Logger logger){
        this._logger = logger;
    }
    public void Instalar(string mensagem){
       this._logger.Log($"{mensagem} - instalando em: {this.Local} em : {this.DataHora}");
    }
}
