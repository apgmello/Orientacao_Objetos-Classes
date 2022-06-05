namespace atividade_01
{
    class Program
    {
        public static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente();
            cliente1.nome = "Pedro Paulo";

            cliente1.conta = new Conta();            
            cliente1.conta.numeroConta = 555555;
            cliente1.conta.saldo = 10550f;
            cliente1.conta.limite = 1000f;

            cliente1.agencia = new Agencia();
            cliente1.agencia.numeroAg = 78;

            cliente1.cartaoCredito = new CartaoCredito();
            cliente1.cartaoCredito.numeroCartao = 5555666677778888999;
            cliente1.cartaoCredito.dataValidade = "29/11/1990";

            cliente1.Imprimir();

            Console.WriteLine("---------------------------");

            Cliente cliente2 = new Cliente();
            cliente2.nome = "Paula de Paula";

            cliente2.conta = new Conta();
            cliente2.conta.numeroConta = 777777;
            cliente2.conta.saldo = 90460f;
            cliente2.conta.limite = 700f;


            cliente2.agencia = new Agencia();
            cliente2.agencia.numeroAg = 92;

            cliente2.cartaoCredito = new CartaoCredito();
            cliente2.cartaoCredito.numeroCartao = 7777888555666999777;
            cliente2.cartaoCredito.dataValidade = "10/05/1992";

            cliente2.Imprimir();

            Console.ReadKey();
        }
    }
}