using System;

namespace agencia_de_turismo
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            int count = 0;
            string resposta;

            string[] nome = new string[2];
            string [] origem = new string[2];
            string [] destino = new string[2];
            DateTime[] data = new DateTime[2];

            do{
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Cadastrar Passagem");
                Console.WriteLine("2 - Listar Passagem");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1: //Só precisa estar entre aspas quando for string (Ex: case "1"), quando receber int deixe somente (Ex: case 1)
                 Console.WriteLine("Cadastre aqui suas passagens!");
                 
                    do{
                        if(count < 2){
                        Console.WriteLine("Digite o nome do passageiro: ");
                        nome[count] = Console.ReadLine();

                        Console.WriteLine("Digite o nome do destino: ");
                        destino[count] = Console.ReadLine();

                        Console.WriteLine("Digite a data da viagem: ");
                        data[count] = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Você deseja cadastrar mais um? S/N");
                        resposta = Console.ReadLine();
                        }
                        else{
                            Console.WriteLine("Número de passagens excedido.");
                        }


                        Console.WriteLine("Digite o nome do passageiro: ");
                        nome[count] = Console.ReadLine();

                        Console.WriteLine("Digite o nome do destino: ");
                        destino[count] = Console.ReadLine();

                        Console.WriteLine("Digite a data da viagem: ");
                        data[count] = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Você deseja cadastrar mais um? S/N");
                        resposta = Console.ReadLine();
                        count ++;
                    } 

                    while (resposta == "S");
                 break;

                case 2:
                  Console.WriteLine("Listando suas passagens:");

                //   int count = 0;
                  while(count < 2){
                      Console.WriteLine($"Passageiro nome: {nome[count]}, origem: {origem[count]}, destino: {destino[count]}, data: {data[count]}");
                      count++;
                  }
                  break;
                
                case 3:
                  Console.WriteLine("Obrigado por usar nosso sistema!");    
                  break;
                default:
                  Console.WriteLine("Opção Inválida.");
                  break;
                 }
            }

            while(opcao != 0);

            

            // Console.WriteLine("");
            // Console.ReadLine();
        }
    }
}
