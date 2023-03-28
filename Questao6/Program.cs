using System.Collections;
using System.Collections.Generic;

namespace Questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String caminhoArquivo = "C:\\Users\\Francisco\\Downloads\\Cidades.csv";
            String arquivoCSV = File.ReadAllText(caminhoArquivo);
            String[] arquivoDividido = arquivoCSV.Split(';');
            var dicionario = new Dictionary<string, string>();
            String estadoDaGambiarra;
            String opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Exibir as cidades pela primeira letra ou pelo estado que pertence? cidade/estado");
                opcao = Console.ReadLine();
            } while (!opcao.ToLower().Equals("cidade") && !opcao.ToLower().Equals("estado"));

            for (int i = 4; i < arquivoDividido.Length - 4; i += 4)
            {
                estadoDaGambiarra = arquivoDividido[i + 3] + i.ToString();
                dicionario.Add(estadoDaGambiarra, arquivoDividido[i + 2]);
            }
            var dicionarioOrdenado = opcao.ToLower() == "cidade" ? dicionario.OrderBy(x => x.Value): dicionario.OrderBy(x => x.Key);

            foreach (var cidadeEstado in dicionarioOrdenado)
            {
                Console.WriteLine($"{cidadeEstado.Value}");
            }

        }
    }
}
