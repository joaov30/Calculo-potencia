using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        string input = Console.ReadLine();
        float numero1;
        bool sucesso = float.TryParse(input, out numero1);

        Console.WriteLine("Digite o expoente: ");
        string input2 = Console.ReadLine();
        int potencia;
        bool sucesso2 = int.TryParse(input2, out potencia);

        if (!sucesso)
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            return;
        }

        if (!sucesso2 || potencia < 0)
        {
            Console.WriteLine("Potência inválida. Por favor, digite um número inteiro não negativo.");
            return;
        }

        float resultado = 1;
        for (int i = 0; i < potencia; i++)
        {
            resultado *= numero1;
        }

        Console.WriteLine($"O resultado de {numero1} elevado a {potencia} é: {resultado}");
    }

}

    

