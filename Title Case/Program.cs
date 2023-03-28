using System.Globalization;

namespace Title_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var textinfo = new CultureInfo("pt-BR", false).TextInfo;
            Console.Write("Informe a frase: ");
            String frase = textinfo.ToTitleCase(Console.ReadLine());
            Console.WriteLine($"Frase em Title Case: {frase}");

        }
    }
}