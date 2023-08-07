Atividades função = new Atividades();


Console.WriteLine("\nESCOLHA DE LISTA DE EXERCICIOS");

while (true)
{
    Console.WriteLine("\nEscolha a opção desejada:");
    Console.WriteLine("1 - Exercicio 1");
    Console.WriteLine("2 - Exercicio 2");
    Console.WriteLine("0 - Sair");

    Console.Write("\nOpção: ");
    int opcao = int.Parse(Console.ReadLine());

    if (opcao == 0)
    {
        break;
    }

    switch (opcao)
    {
        case 1:
            função.Exercicio1();
            break;
    }
}
