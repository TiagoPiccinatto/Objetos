using Objetos;

Conta Conta1 = new Conta();
Conta Conta2 = new Conta();

Conta1.Id = 1;
Conta1.Saldo = 1500;
Conta1.limite = 2600;
Conta1.numero = 2021;
Conta1.ConsultaSaldo();

Conta2.Id = 2;
Conta2.Saldo = 2500;
Conta2.limite = 3500;
Conta2.numero = 2022;
Conta2.ConsultaSaldo();

Console.WriteLine("=============Banco Da Galera=================");
Console.WriteLine("=============================================");
Console.WriteLine("======Escolha A Conta a ser Consultada=======");
double Numerodaconta = double.Parse(Console.ReadLine());
Console.Clear();
if (Numerodaconta == Conta1.numero)
{

Console.WriteLine("===========Escolha uma Das Opcoens===========");
    Console.WriteLine("Seu Numero de Conta é " + Conta1.numero);
Console.WriteLine("=============================================");
    Console.WriteLine("1 Consulta de Saldo Dispoivel");
    Console.WriteLine("2 Consulta de Limite de Credito");
    Console.WriteLine("3 Saldo e Limite de Credito Combinado");
    Console.WriteLine("4 Deposito");
    Console.WriteLine("5 Retirada");
Console.WriteLine("=============================================");
    int es = int.Parse(Console.ReadLine());
    Console.Clear();
    
    if (es == 1)
    {
       Console.WriteLine("Seu Saldo é " + Conta1.Saldo);
    }
    if (es == 2)
    {
        Console.WriteLine("Seu Limite De Credito é " + Conta1.limite);
    }
    if (es == 3)
    {
        Console.WriteLine("Seu saldo + Credito é " + Conta1.ConsultaSaldo());
    }
    if (es == 4)
    {
        double saldo = Conta1.Saldo;

        Console.WriteLine("Qual o Valor A ser Depositato");

        double Deposito = double.Parse(Console.ReadLine());
        Console.Clear();

        Conta1.Deposita(Deposito);

        Console.WriteLine("Seu Saldo Atual é " + Conta1.Saldo );

        Console.WriteLine("Seu Saldo Anterior Era " + saldo);      
    }
    if (es == 5)
    {
        double saldo1 = Conta1.Saldo;
        Console.WriteLine("Saldo Disponivel Para Retirada " + Conta1.Saldo);
        Console.WriteLine("Digite Um Valor Para Retirar");
        double Retirada = double.Parse(Console.ReadLine());
        Console.Clear();
        Conta1.Retirada(Retirada);
        Console.WriteLine("Seu saldo atual é " + Conta1.Saldo);
        Console.WriteLine("Seu saldo anterior era " + saldo1);

    }
    
}

// sinal != e um sinal comparativo de Diferente.

else if (Numerodaconta != Conta1.numero)
{
    Console.Clear();
    Console.WriteLine("Digite Um Numero De Conta Valida");
}
// para chamar um input sempre colocar parse a frete de uma variaval de tipo numerico

