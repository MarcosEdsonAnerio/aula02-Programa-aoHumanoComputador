using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static Atividades;

internal class Atividades
{
    public class Conta
    {
        public string nomeTitular;
        public int numeroAgencia;
        public int numeroConta;
        public double saldo;

        public Conta(string nomeTitular, int numeroAgencia, int numeroConta, double saldoInicial)
        {
            this.nomeTitular = nomeTitular;
            this.numeroAgencia = numeroAgencia;
            this.numeroConta = numeroConta;
            this.saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Depósito realizado");
            }
            else
            {
                //Não dá pra colocar valores negativos kkkk :\
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
            }
        }

        public double Sacar(double valor)
        {
            if (valor > 0 && saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado");
            }
            else
            {
                // Não dá pra sacar com saldo inferior ao que precisa ser sacado, só se tiver um valor a mais tipo um cheque especial
                Console.WriteLine("Saldo insuficiente ou valor inválido para saque.");
            }

            return saldo;
        }
    }
    public List<Conta> contas = new List<Conta>();
    public void Exercicio1()
    {
        //todo o cadastro do cliente, junto com as perguntas de deposito e etc

        Console.WriteLine("----------Cadastro de Contas Bancárias----------");

        while (true)
        {
            Console.Write("\nDigite o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Digite o número da agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o saldo inicial: ");
            double saldoInicial = double.Parse(Console.ReadLine());

            Conta conta = new Conta(nomeTitular, numeroAgencia, numeroConta, saldoInicial);
            contas.Add(conta);

            Console.Write("\nDeseja realizar um depósito? (s/n): ");
            string respostaDeposito = Console.ReadLine();

            if (respostaDeposito.ToLower() == "s")
            {
                Console.Write("Digite o valor do depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine());
                conta.Depositar(valorDeposito);
            }

            Console.Write("\nDeseja realizar um saque? (s/n): ");
            string respostaSaque = Console.ReadLine();

            if (respostaSaque.ToLower() == "s")
            {
                Console.Write("Digite o valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine());
                Console.WriteLine($"Saldo atualizado: {conta.Sacar(valorSaque)}");
            }

            Console.Write("\nDeseja cadastrar outra conta? (s/n): ");
            string respostaContinuar = Console.ReadLine();

            if (respostaContinuar.ToLower() == "s")
            {
                
            }
            if(respostaContinuar.ToLower() == "n")
            {
                Console.WriteLine("\nCadastro de contas concluído. Informações das contas:\n");
                foreach (var c in contas)
                {
                    Console.WriteLine($"Nome da Conta: {c.nomeTitular} \nNumero da Agencia: {c.numeroAgencia} \nNumero da Conta: {c.numeroConta} \nSaldo da Conta: {c.saldo}\n");
                    break;
                }
        }
    }

