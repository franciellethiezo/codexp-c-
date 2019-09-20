using System;

namespace estrutura_de_decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            // double salario;

            // Console.WriteLine("Digite seu salário: ");
            // salario = double.Parse(Console.ReadLine());

            // if (salario <= 990){
            //     salario = (salario * 0.3) + salario;
            //     Console.WriteLine ($"Seu novo salário será de R${salario}");
            // }
            // else{
            //     Console.WriteLine("Você não está apto para receber aumento.");
            // }
// -------------------------------------------------------------------------------------------
            // int idade;

            // Console.WriteLine("Digite sua idade: ");
            // idade = int.Parse(Console.ReadLine());

            // if (idade <= 7){
            //     Console.WriteLine("Você faz parte do Infantil A");
            // }

            // else if (idade <=10){
            //     Console.WriteLine("Você faz parte do Infantil B");
            // }

            // else if (idade <=13){
            //     Console.WriteLine("Você faz parte do Juvenil A");
            // }
            // else if (idade <=17){
            //     Console.WriteLine("Você faz parte do Juvenil B");
            // }
            // else{
            //     Console.WriteLine("Você faz parte do Adulto");
            // }
// ------------------------------------------------------------------------------------------------------
            // int n1;
            // int n2;
            // int faltas;
            // double media;

            // Console.WriteLine("Digite a primeira nota: ");
            // n1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite a segunda nota: ");
            // n2 = int.Parse(Console.ReadLine());
            
            // Console.WriteLine("Digite as faltas ");
            // faltas = int.Parse(Console.ReadLine());

            // media = (n1+n2)/2;

            // if (media >= 7 && faltas <= 30){
            //     Console.WriteLine ("Aluno aprovado!");
            // }

            // else{
            //     Console.WriteLine ("Aluno reprovado!");
            // }
// ----------------------------------------------------------------------------------

            // int idade;

            // Console.WriteLine("Digite sua idade: ");
            // idade = int.Parse(Console.ReadLine());

            // if (idade <= 18 || idade >= 60){
            //     Console.WriteLine("Você tem direito à meia entrada!");
            // }

            // else{
            //     Console.WriteLine("Você deverá pagar a entrada integral!");
            // }

// -----------------------------------------------------------------------------------

            string placa;
            int finalPlaca;
            int caracteres;

            Console.WriteLine("Digite sua placa veicular: ");
            placa = Console.ReadLine();

            caracteres = placa.Length;
            finalPlaca = int.Parse(placa.Substring(caracteres - 1));

            if (finalPlaca == 0 || finalPlaca == 1){
                Console.WriteLine("Seu rodízio é segunda-feira.");
            }

            else if(finalPlaca == 2 || finalPlaca == 3){
                Console.WriteLine("Seu rodízio é terça-feira.");
            }

            else if(finalPlaca == 4 || finalPlaca == 5){
                Console.WriteLine("Seu rodízio é quarta-feira.");
            }

            else if(finalPlaca == 6 || finalPlaca == 7){
                Console.WriteLine("Seu rodízio é quinta-feira.");
            }

            else{
                Console.WriteLine("Seu rodízio é sexta-feira.");
            }
        }
    }
}
