namespace Ada_AtividadeGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tCONVERSÃO DE MOEDAS");
            Console.WriteLine("Grupo: Laura, Paula, Charles, Luana e Yuri\n");

            YuriClasse converterEuro = new YuriClasse();
            converterEuro.ConversaoEuro();

            LauraClasse converterPesoArgentino = new LauraClasse();
            converterPesoArgentino.ConversaoPesoArgentino();          

            ConversaoRealIene conversor = new ConversaoRealIene();
            conversor.Converter();

            double real = 1;
            double euro = YuriClasse.conversaoEuro(real);
            double pesoArgentino = LauraClasse.conversaoPesoArgentino(real);

            CharlesClasse.ConverteRealParaDolarCanadense();
        }
    }
}