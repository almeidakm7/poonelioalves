using System;

class Program
{
    private static void Main(string[] args)
    {
        int cod1, cod2, quant1, quant2;
        double valor1, valor2, total;

        Console.WriteLine("Digite o código, quantidade e valor da peça:");
        string[] vet = Console.ReadLine().Split(" ");

        cod1 = int.Parse(vet[0]);
        quant1 = int.Parse(vet[1]);
        valor1 = double.Parse(vet[2]);

        Console.WriteLine("Digite o código, quantidade e valor da 2º peça:");
        string[] vet2 = Console.ReadLine().Split(" ");

        cod2 = int.Parse(vet2[0]);
        quant2 = int.Parse(vet2[1]);
        valor2 = double.Parse(vet2[2]);

        total = valor1 * quant1 + valor2 * quant2;

        Console.WriteLine("Valor a pagar: R$" + total);
    }
}