using System;
using ConfiguraDatabase.Configuracao;

namespace ConfiguraDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("host", "192.168.0.3");
            Environment.SetEnvironmentVariable("usuario", "usuarioAmbiente");
            Environment.SetEnvironmentVariable("senha", "senhaAmbiente");
            Environment.SetEnvironmentVariable("porta", "4202");
            Environment.SetEnvironmentVariable("bancodados", "bancoAmbiente");

            var configuracao = new Configuracaodb(FonteTipo.Arquivo);

            Console.WriteLine("Arquivo");
            Console.WriteLine(configuracao.BuscarConfiguracao());

            configuracao.FonteTipo = FonteTipo.Mensageria;
            Console.WriteLine("Mensageria");
            Console.WriteLine(configuracao.BuscarConfiguracao());

            configuracao.FonteTipo = FonteTipo.VariavelAmbiente;
            Console.WriteLine("Variavel de Ambiente");
            Console.WriteLine(configuracao.BuscarConfiguracao());

            Console.ReadKey();
        }
    }
}
