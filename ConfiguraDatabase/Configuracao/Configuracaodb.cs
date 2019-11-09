using ConfiguraDatabase.Configuracao.Fonte;

namespace ConfiguraDatabase.Configuracao
{
    public class Configuracaodb
    {
        private static Configuracaodb _instance;
        public FonteTipo FonteTipo { get; set; }

        private Configuracaodb(FonteTipo fonteTipo)
        {
            FonteTipo = fonteTipo;
        }

        public static Configuracaodb GetInstance(FonteTipo fonteTipo)
        {
            if (_instance == null)
            {
                _instance = new Configuracaodb(fonteTipo);
            }
            else
            {
                _instance.FonteTipo = fonteTipo;
            }
            return _instance;
        }

        public string BuscarConfiguracao()
        {
            IFonte fonte;
            IFonteFactory factory = new FonteFactory();
            switch (FonteTipo)
            {
                case FonteTipo.Arquivo:
                    fonte = factory.CriaFonteArquivo();
                    break;
                case FonteTipo.Mensageria:
                    fonte = factory.CriaFonteMensageria();
                    break;
                case FonteTipo.VariavelAmbiente:
                    fonte = factory.CriaFonteVariavelAmbiente();
                    break;
                default:
                    fonte = factory.CriaFonteArquivo();
                    break;
            }

            return fonte.BuscaConfiguracao().ConvertJson();
        }
    }

    public enum FonteTipo
    {
        Arquivo,
        Mensageria,
        VariavelAmbiente
    }
}
