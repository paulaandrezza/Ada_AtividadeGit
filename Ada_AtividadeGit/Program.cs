namespace Ada_AtividadeGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Laurinha");
            Console.WriteLine("Luana Daorinha");
            Console.WriteLine("Yuri");
            Console.WriteLine("Charles!");
            Console.WriteLine("Paulinha!");

            ConversaoRealIene conversor = new ConversaoRealIene();
            conversor.Converter();

            double real = 1;
            double euro = YuriClasse.conversaoEuro(real);
            double pesoArgentino = LauraClasse.conversaoPesoArgentino(real);
        }
    }
}