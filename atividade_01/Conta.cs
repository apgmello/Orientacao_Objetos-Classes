namespace atividade_01
{
    internal class Conta
    {
        public int numeroConta;
        public float saldo;
        public float limite;

        public void Imprimir()
        {
            Console.WriteLine("* Dados da conta");
            Console.WriteLine($"Número da conta: {numeroConta}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Limite: {limite}");
        }
    }
}
