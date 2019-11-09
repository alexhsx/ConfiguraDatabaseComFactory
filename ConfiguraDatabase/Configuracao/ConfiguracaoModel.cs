using Newtonsoft.Json;

namespace ConfiguraDatabase.Configuracao
{
    public class ConfiguracaoModel
    {
        public string Host { get; set; }
        public string Porta { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string BancoDados { get; set; }

        public string ConvertJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
