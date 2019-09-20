using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            // string resposta;
            

            // Console.WriteLine("Digite o número do cargo para descobrir o salário: ");
            // Console.WriteLine("1 - Diretor");
            // Console.WriteLine("2 - Gerente");
            // Console.WriteLine("3 - Professor");
            // Console.WriteLine("4 - Coordenador");
            // Console.WriteLine("5 - Atendente");
            // resposta = Console.ReadLine();

            // switch(resposta){
            //     case "1": 
            //     Console.WriteLine("O salário de diretor é de R$18.000,00.");
            //     break;

            //     case "2":
            //     Console.WriteLine("O salário de gerente é de R$12.000,00.");
            //     break;

            //     case "3":
            //     Console.WriteLine("O salário de professor é de R$2.000,00.");
            //     break;

            //     case "4":
            //     Console.WriteLine("O salário de coordenador é de R$4.500,00.");
            //     break;

            //     case "5":
            //     Console.WriteLine("O salário de atendente é de R$1.500,00.");
            //     break;

            //     default:
            //     Console.WriteLine("Digite um valor entre 1 e 5.");
            //     break;
            // }

// ------------------------------------------------------------------------------------------------------------------------------------
            // int n1;
            // int n2;
            // int resultado;
            // string opcao;

            // Console.WriteLine("Digite o primeiro número: ");
            // n1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite o segundo número: ");
            // n2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("--------- Escolha uma opção de cálculo ---------");
            // Console.WriteLine("A - Soma dos 2 números");
            // Console.WriteLine("B - Subtração do primeiro pelo segundo");
            // Console.WriteLine("C - Subtração do segundo pelo primeiro");
            // Console.WriteLine("D - Multiplicação dos dois números");
            // Console.WriteLine("E - Divisão do primeiro pelo segundo");
            // Console.WriteLine("F - Divisão do segundo pelo primeiro");

            // opcao = Console.ReadLine();

            // switch(opcao){
            //     case "a":
            //     resultado = n1 + n2;
            //     Console.WriteLine($"A soma dos números será: {resultado}");
            //     break;

            //     case "b":
            //     resultado = n1 - n2;
            //     Console.WriteLine($"A subtração do primeiro pelo segundo será: {resultado}");
            //     break;

            //     case "c":
            //     resultado = n2 - n1;
            //     Console.WriteLine($"A subtração do segundo pelo primeiro será: {resultado}");
            //     break;

            //     case "d":
            //     resultado = n1 * n2;
            //     Console.WriteLine($"A multiplicação dos números será: {resultado}");
            //     break;

            //     case "e":
            //     resultado = n1 / n2;
            //     Console.WriteLine($"A divisão do primeiro pelo segundo será: {resultado}");
            //     break;

            //     case "f":
            //     resultado = n2 / n1;
            //     Console.WriteLine($"A divisão do segundo pelo primeiro será: {resultado}");
            //     break;

            //     default:
            //     Console.WriteLine("Digite as letras que constam no menu.");
            //     break;
            // }

// ------------------------------------------------------------------------------------------------------------------------------------

            // int n1;
            // int n2;
            

            // Console.WriteLine("Digite o primeiro número: ");
            // n1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite o segundo número: ");
            // n2 = int.Parse(Console.ReadLine());

            // if(n1 % 2 == 0){
            //     Console.WriteLine("Este número é par");
            // }

            // else{
            //     Console.WriteLine("Este número é ímpar");
            // }

            // if(n2 % 2 == 0){
            //     Console.WriteLine("Este número é par");
            // }

            // else{
            //     Console.WriteLine("Este número é ímpar");
            // }

            // if (n1 > n2){
            //     Console.WriteLine("O primeiro número é maior do que o segundo.");
            // }
            // else{
            //     Console.WriteLine("O segundo número é maior do que o primeiro.");
            // }

// ------------------------------------------------------------------------------------------------------------------------------------
            // string nome;
            // double salario;
            // double salarioPerc;
            // string codigoCarg;

            // Console.WriteLine("Digite o nome de seu funcionário: ");
            // nome = Console.ReadLine();

            // Console.WriteLine("Digite o salário de seu funcionário: ");
            // salario = double.Parse(Console.ReadLine());

            // Console.WriteLine("Digite o código do funcionário de acordo com o menu abaixo: ");
            // Console.WriteLine("1 - Diretor");
            // Console.WriteLine("2 - Gerente");
            // Console.WriteLine("3 - Escrituário");
            // Console.WriteLine("4 - Secretário");
            // Console.WriteLine("5 - Caixa");
            // codigoCarg = (Console.ReadLine());

            // switch(codigoCarg){
            //     case "1": 
            //     Console.WriteLine($"O funcionário {nome} atualmente recebe R${salario}."); 
            //     Console.WriteLine($"Seu código de funcionário é {codigoCarg}, seu cargo é Diretor.");
            //     Console.WriteLine($"Este cargo não está apto para receber o percentual de aumento.");
            //     break;

            //     case "2":
            //     salarioPerc = (salario * 0.1) + salario;
            //     Console.WriteLine($"O funcionário {nome} atualmente recebe R${salario}."); 
            //     Console.WriteLine($"Seu código de funcionário é {codigoCarg}, seu cargo é Gerente.");
            //     Console.WriteLine($"Seu salário com percentual de aumento de 10%: R${salarioPerc}.");
            //     break;

            //     case "3":
            //     salarioPerc = (salario * 0.5) + salario;
            //     Console.WriteLine($"O funcionário {nome} atualmente recebe R${salario}."); 
            //     Console.WriteLine($"Seu código de funcionário é {codigoCarg}, seu cargo é Escrituário.");
            //     Console.WriteLine($"Seu salário com percentual de aumento de 50%: R${salarioPerc}.");
            //     break;

            //     case "4":
            //     salarioPerc = (salario * 0.35) + salario;
            //     Console.WriteLine($"O funcionário {nome} atualmente recebe R${salario}."); 
            //     Console.WriteLine($"Seu código de funcionário é {codigoCarg}, seu cargo é Secretário.");
            //     Console.WriteLine($"Seu salário com percentual de aumento de 35%: R${salarioPerc}.");
            //     break;

            //     case "5":
            //     salarioPerc = (salario * 0.2) + salario;
            //     Console.WriteLine($"O funcionário {nome} atualmente recebe R${salario}."); 
            //     Console.WriteLine($"Seu código de funcionário é {codigoCarg}, seu cargo é Caixa.");
            //     Console.WriteLine($"Seu salário com percentual de aumento de 20%: {salarioPerc}.");
            //     break;

            //     default:
            //     Console.WriteLine("Digite um valor entre 1 e 5.");
            //     break;
            // }

// ------------------------------------------------------------------------------------------------------------------------------------
            // double salarioMinimo;
            // double salarioMes;
            // double salarioBruto;
            // double salarioLiqui;
            // double valorHora;
            // double imposto;
            // double gratificacao;
            // int qtdHora;
            // int dependente;
            // double horaExtra;

            // Console.WriteLine("Digite o valor do salário mínimo: ");
            // salarioMinimo = double.Parse(Console.ReadLine());

            // Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            // qtdHora = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite a quantidade de dependentes do funcionário: ");
            // dependente = int.Parse(Console.ReadLine());

            // valorHora = salarioMinimo / 1/5;
            // salarioMes = qtdHora * valorHora;
            // dependente = dependente + 64;
            // horaExtra = (valorHora * 0.5) + valorHora;
            // salarioBruto = salarioMes + horaExtra + dependente;
            // imposto = 0;

            // if (salarioBruto < 1750){
            //     Console.WriteLine("Isento de imposto.");
            // }

            // else if (salarioBruto > 1750 && salarioBruto < 2500){
            //     imposto = (salarioBruto*0.1);
            //     Console.WriteLine($"O valor do imposto à ser pago: R${imposto}.");
            // }

            // else{
            //     imposto = (salarioBruto*0.2);
            //     Console.WriteLine($"O valor do imposto à ser pago: R${imposto}.");
            // }

            // salarioLiqui = salarioBruto - imposto;
            // Console.WriteLine($"Seu salário líquido: R${salarioLiqui}.");

            // if (salarioLiqui <= 1500){
            //     gratificacao = salarioLiqui+ 400;
            //     Console.WriteLine($"Seu salário com bonificação: R$ {gratificacao}.");
            // }
            // else{
            //     gratificacao = salarioLiqui + 250;
            //     Console.WriteLine($"Seu salário com bonificação: R$ {gratificacao}.");
            // }
        }  
    }
}
