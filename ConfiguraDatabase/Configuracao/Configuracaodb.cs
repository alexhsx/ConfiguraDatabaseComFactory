using ConfiguraDatabase.Configuracao.Fonte;

namespace ConfiguraDatabase.Configuracao
{
    public class Configuracaodb
    {

        public FonteTipo FonteTipo { get; set; }

        public Configuracaodb(FonteTipo fonteTipo)
        {
            FonteTipo = fonteTipo;
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
