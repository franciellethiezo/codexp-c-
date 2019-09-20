using System;

namespace Calculo_de_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            float resultado;

            Console.WriteLine("Digite a primeira nota: ");
            n1 =  int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 =  int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            n3 =  int.Parse(Console.ReadLine());

            resultado = (float)(n1 + n2 + n3)/3;

            Console.WriteLine($"O resultado da média é: {resultado}");

            if (resultado >= 7){
                Console.WriteLine("Aluno aprovado");
            }
            else{
                Console.WriteLine("Aluno reprovado");
            }
            
        }
    }
}
