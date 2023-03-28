namespace questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a frase: ");
            String frase = Console.ReadLine();
            Console.WriteLine(frase.ToUpper());
            Console.WriteLine(frase.ToLower());
            Console.WriteLine(frase.Replace(" ", "").Length);
            String[] fraseDividida = frase.Split(" ");
            Console.WriteLine(fraseDividida[0]);
            Console.WriteLine(fraseDividida[fraseDividida.Length-1]);

        }
    }
}