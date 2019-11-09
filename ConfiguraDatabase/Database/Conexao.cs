namespace ConfiguraDatabase.Database
{
    public class Conexao
    {
        private static Conexao _instance;

        public IConfigConexaoBuilder configConexaoBuilder;
        private Context _context;

        private Conexao() { }

        public static Conexao GetInstance()
        {
            if (_instance == null)
                _instance = new Conexao();

            return _instance;
        }

        public void ConfiguracaoArquivo()
        {
            _context = configConexaoBuilder.ConfiguraConexaoArquivo();
        }

        public void ConfiguracaoMensageria()
        {
            _context = configConexaoBuilder.ConfiguraConexaoMensageria();
        }

        public void ConfiguracaoVariavelAmbiente()
        {
            _context = configConexaoBuilder.ConfiguraConexaoVariavelAmbiente();
        }

        public void Execute(string sql)
        {
            _context.Execute(sql);
        }
    }
}
