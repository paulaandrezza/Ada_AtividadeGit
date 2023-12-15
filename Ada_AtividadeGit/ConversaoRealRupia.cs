namespace Ada_AtividadeGit
{
    internal class ConversaoRealRupia
    {
        private double taxaConversaoParaRupia = 16.86;
        public double Converter(double valorEmReal)
        {
            return valorEmReal * taxaConversaoParaRupia;
        }

    }
}