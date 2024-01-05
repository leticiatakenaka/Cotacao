namespace Cotacao
{
    class ConversorDeMoeda
    {
        public static double _cotacaoDolar;

        public static void LerCotacao(double cotacaoDolar)
        {
            _cotacaoDolar = cotacaoDolar;
        }

        public static double ValorASerPago(double qtd)
        {
            double total = qtd * _cotacaoDolar;
            return total + total / 100 * 6;
        }
    }
}
