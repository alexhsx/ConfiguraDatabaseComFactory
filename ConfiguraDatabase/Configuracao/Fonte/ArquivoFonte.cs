namespace ConfiguraDatabase.Configuracao.Fonte
{
    public class ArquivoFonte : IFonte
    {
        public ConfiguracaoModel BuscaConfiguracao()
        {
            var fakeArquivo = "192.168.0.1;4200;usuarioArquivo;senhaArquivo;bancoArquivo";
            var fakeArquivoQuebrado = fakeArquivo.Split(';');
            var configuracaoModel = new ConfiguracaoModel
            {
                Host = fakeArquivoQuebrado[0],
                Porta = fakeArquivoQuebrado[1],
                Usuario = fakeArquivoQuebrado[2],
                Senha = fakeArquivoQuebrado[3],
                BancoDados = fakeArquivoQuebrado[4]
            };

            return configuracaoModel;
        }
    }
}
