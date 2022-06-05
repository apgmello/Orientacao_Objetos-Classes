namespace atividade_01
{
    internal class CartaoCredito
    {
        public long numeroCartao;
        public string? dataValidade;

        public void Imprimir()
        {
            Console.WriteLine("* Dados do cartão de crédito");
            Console.WriteLine($"Número: {numeroCartao}");
            Console.WriteLine($"Data de validade: {dataValidade}");
        }
    }
}
