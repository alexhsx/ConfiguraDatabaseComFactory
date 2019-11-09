using ConfiguraDatabase.Configuracao;

namespace ConfiguraDatabase.Database
{
    public class ConfigConexaoBuilder : IConfigConexaoBuilder
    {
        public Context ConfiguraConexaoArquivo()
        {
            var configuracao = Configuracaodb.GetInstance(FonteTipo.Arquivo);
            return ConfiguraConexao(configuracao);
        }

        public Context ConfiguraConexaoMensageria()
        {
            var configuracao = Configuracaodb.GetInstance(FonteTipo.Arquivo);
            return ConfiguraConexao(configuracao);
        }

        public Context ConfiguraConexaoVariavelAmbiente()
        {
            var configuracao = Configuracaodb.GetInstance(FonteTipo.Arquivo);
            return ConfiguraConexao(configuracao);
        }

        private Context ConfiguraConexao(Configuracaodb config)
        {
            var context = new Context(config.BuscarConfiguracao());
            context.Ping();
            context.Open();
            return context;
        }
    }
}
