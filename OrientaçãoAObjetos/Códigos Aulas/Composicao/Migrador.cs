namespace Composicao;
public class Migrador{
    public DateTime DataHora { get; set; }

    private readonly Logger _logger;

    public Migrador(Logger logger){
        this._logger = logger;
    }

    public void Migrar(){
        this._logger.Log($"Migrando em : {this.DataHora}");
    }

}

