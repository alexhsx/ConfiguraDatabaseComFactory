using System;

namespace ConfiguraDatabase.Configuracao.Fonte
{
    public class VariavelAmbienteFonte : IFonte
    {
        public ConfiguracaoModel BuscaConfiguracao()
        {
            return new ConfiguracaoModel
            {
                Host = Environment.GetEnvironmentVariable("host"),
                Porta = Environment.GetEnvironmentVariable("porta"),
                Usuario = Environment.GetEnvironmentVariable("usuario"),
                Senha = Environment.GetEnvironmentVariable("senha"),
                BancoDados = Environment.GetEnvironmentVariable("bancodados")
            };
        }
    }
}
