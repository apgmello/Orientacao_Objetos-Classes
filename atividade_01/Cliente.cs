namespace atividade_01
{
    internal class Cliente
    {
        public Agencia agencia;
        public Conta conta;
        public CartaoCredito cartaoCredito;
        public string? nome;

        public void Imprimir()
        {
            Console.WriteLine("* Dados do cliente");
            Console.WriteLine($"Nome: {nome}");
            agencia.Imprimir();
            conta.Imprimir();
            cartaoCredito.Imprimir();
        }
    }
}
