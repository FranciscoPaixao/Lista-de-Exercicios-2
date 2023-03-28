namespace ContadorPalavras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a frase: ");
            String frase = Console.ReadLine();
            int count = frase.Split(" ").Length;
            Console.WriteLine($"Quantidade de palavras: {count}");
        }
    }
}