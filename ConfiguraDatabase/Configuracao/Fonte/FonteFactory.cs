namespace ConfiguraDatabase.Configuracao.Fonte
{
    public class FonteFactory : IFonteFactory
    {
        public IFonte CriaFonteArquivo()
        {
            return new ArquivoFonte();
        }

        public IFonte CriaFonteMensageria()
        {
            return new MensageriaFonte();
        }

        public IFonte CriaFonteVariavelAmbiente()
        {
            return new VariavelAmbienteFonte();
        }
    }
}
