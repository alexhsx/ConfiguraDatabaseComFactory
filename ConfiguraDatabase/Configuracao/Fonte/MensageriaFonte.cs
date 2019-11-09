namespace ConfiguraDatabase.Configuracao.Fonte
{
    public class MensageriaFonte : IFonte
    {
        public ConfiguracaoModel BuscaConfiguracao()
        {
            return new ConfiguracaoModel
            {
                Host = "192.168.0.2",
                Porta = "4201",
                Usuario = "usuarioMensageria",
                Senha= "senhaMensageria",
                BancoDados = "bancodadosMensageria"
            };
        }
    }
}
