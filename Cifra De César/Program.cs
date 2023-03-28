namespace Cifra_De_César
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cifra = 7;
            Console.WriteLine("Informe a frase a ser criptografada: ");
            String fraseOriginal = Console.ReadLine();
            String fraseModificada = "";
            Char aux;
            for (int i = 0; i < fraseOriginal.Length; i++)
            {
                aux = fraseOriginal[i];
                if (Char.IsLetter(aux))
                {
                    for (int j = 0; j < cifra; j++)
                    {
                        switch (aux)
                        {
                            case 'Z':aux = 'A';break;
                            case 'z':aux = 'a';break;
                            default: aux++ ;break;
                        }
                    }
                }
                fraseModificada += aux;
            }
            Console.WriteLine($"Palavra: {fraseModificada.ToString()}");
        }
    }
}