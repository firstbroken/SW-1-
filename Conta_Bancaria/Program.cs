namespace Conta_Bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio Conta Bancaria - ETECMCM");
        Conta conta = new Conta();

        conta.limite = 500;

        conta.depositar(200);

        conta.sacar(50);

        //Vamos chamar o método ConsultaSaldo e receber em uma variavel local chamada saldo e valor disponivel em saldo desse cliente
        double saldo = conta.ConsultaSaldo();

        //Agora para visualizar:
        Console.WriteLine("Seu saldo é de: " + saldo);
    }
}
