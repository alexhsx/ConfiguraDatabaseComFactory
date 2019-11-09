using ConfiguraDatabase.Configuracao;
using ConfiguraDatabase.Database;
using System;
using Xunit;

namespace ConfiguraDatabase.Unitest
{
    public class ConexaoTest
    {
        public ConexaoTest()
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
        }

        [Fact]
        public void TesteMensageria()
        {
        }

        [Fact]
        public void TesteAmbiente()
        {
        }
    }
}
