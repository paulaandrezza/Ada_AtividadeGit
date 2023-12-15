namespace Ada_AtividadeGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"
        CONVERSÃO DE MOEDA
Grupo: Laura, Paula, Charles, Luana e Yuri
(Aperte qualquer tecla para continuar)");

            Console.ReadKey();
            Console.Clear();
            var menu = new InterfaceUsuario();
            menu.MenuUsuario();
        }
    }
}