using ConfiguraDatabase.Configuracao;
using System;
using Xunit;

namespace ConfiguraDatabase.Unitest
{
    public class ConfiguracaoTest
    {
        public ConfiguracaoTest()
        {
            Environment.SetEnvironmentVariable("host", "192.168.0.3");
            Environment.SetEnvironmentVariable("usuario", "usuarioAmbiente");
            Environment.SetEnvironmentVariable("senha", "senhaAmbiente");
            Environment.SetEnvironmentVariable("porta", "4202");
            Environment.SetEnvironmentVariable("bancodados", "bancoAmbiente");
        }

        [Fact]
        public void TesteArquivo()
        {
            var configuracao = Configuracaodb.GetInstance(FonteTipo.Arquivo);
            Assert.Equal("{\"Host\":\"192.168.0.1\",\"Porta\":\"4200\",\"Usuario\":\"usuarioArquivo\",\"Senha\":\"senhaArquivo\",\"BancoDados\":\"bancoArquivo\"}", 
                configuracao.BuscarConfiguracao());
        }

        [Fact]
        public void TesteMensageria()
        {
            var configuracao = Configuracaodb.GetInstance(FonteTipo.Mensageria);
            Assert.Equal("{\"Host\":\"192.168.0.2\",\"Porta\":\"4201\",\"Usuario\":\"usuarioMensageria\",\"Senha\":\"senhaMensageria\",\"BancoDados\":\"bancodadosMensageria\"}", 
                configuracao.BuscarConfiguracao());
        }

        [Fact]
        public void TesteAmbiente()
        {
            var configuracao = Configuracaodb.GetInstance(FonteTipo.VariavelAmbiente);
            Assert.Equal("{\"Host\":\"192.168.0.3\",\"Porta\":\"4202\",\"Usuario\":\"usuarioAmbiente\",\"Senha\":\"senhaAmbiente\",\"BancoDados\":\"bancoAmbiente\"}", 
                configuracao.BuscarConfiguracao());
        }
    }
}
