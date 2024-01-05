using System.Globalization;

namespace Cotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ConversorDeMoeda.LerCotacao(cotacao);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O valor a ser pago é {ConversorDeMoeda.ValorASerPago(quantia)}");
        }
    }
}