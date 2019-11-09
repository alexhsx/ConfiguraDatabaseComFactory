namespace ConfiguraDatabase.Database
{
    public interface IConfigConexaoBuilder
    {
        Context ConfiguraConexaoArquivo();
        Context ConfiguraConexaoMensageria();
        Context ConfiguraConexaoVariavelAmbiente();
    }
}
