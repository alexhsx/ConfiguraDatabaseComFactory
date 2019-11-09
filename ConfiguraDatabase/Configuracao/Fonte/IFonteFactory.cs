namespace ConfiguraDatabase.Configuracao.Fonte
{
    public interface IFonteFactory
    {
        IFonte CriaFonteArquivo();
        IFonte CriaFonteMensageria();
        IFonte CriaFonteVariavelAmbiente();
    }
}
