using System.Net.Mime;

namespace atividade;

class Program
{
    static void Main()
    {
        //Variáveis
        string palavra = " ";
        int cont = 0;

        //entrada de dados
        Console.WriteLine("Digite uma palavra: ");
        palavra = Console.ReadLine()!;

        //loop para verificar se possui letra a
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] == 'a' || palavra[i] == 'A')
            {
                cont ++;
            }
        }

        //saída de dados
        if (cont == 0)
        {
            Console.WriteLine($"A palavra {palavra} não possui letra A em sua composição");
        }
        else
        {
            Console.WriteLine($"A palavra {palavra} possui {cont} letra A");
        }
    }
}
