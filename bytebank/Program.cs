using bytebank.Contas;
using bytebank.Titular;



//criando conta corrente andré
//ContaCorrente contaAndre = new ContaCorrente();
//contaAndre.titular = "André silva";
//contaAndre.numero_agencia = 15;
//contaAndre.conta = "1010-x";
//contaAndre.saldo = 1000;


//contaAndre.DemostrativoContaCorrente(contaAndre);



//// CRIANDO CONTA CORRENTE MARIA
//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Souza";
//contaMaria.numero_agencia=17;
//contaMaria.conta = "1040-G";
//contaMaria.saldo = 500;

//contaMaria.DemostrativoContaCorrente(contaMaria);



//// MOVIMENTAÇÕES E EXTRATO
//contaMaria.Sacar(50, contaMaria);

//contaMaria.Transferir(100, contaMaria, contaAndre);



//// CRIANDO CONTA PEDRO DE FORMA PARCIAL E OBSERVANDO OS RETORNO DOS PADRÕES CRIANDO NA CLASSE  ContaCorrente
//ContaCorrente contaPedro = new ContaCorrente();
//contaPedro.titular = "Pedro Silva";

//contaPedro.DemostrativoContaCorrente(contaPedro);

//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor==valor2);
//Console.WriteLine(valor);
//Console.WriteLine(valor2)


//Cliente cliente = new Cliente();
//cliente.nome = "Andre silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numero_agencia = 15;
//conta.saldo = 1000;

//conta.DemostrativoContaCorrente(conta);

//conta.Sacar(45, conta);


//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José souza";
//conta2.titular.profissao = "tester";
//conta2.titular.cpf = "987654321";
//conta2.conta = "9999-x";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//conta2.DemostrativoContaCorrente(conta2);

ContaCorrente conta3 = new ContaCorrente();
conta3.SetSaldo(250);

Console.WriteLine(conta3.GetSaldo());


//fim da execução
Console.WriteLine("\n" + "Tecle Enter para fechar..");
Console.ReadLine();