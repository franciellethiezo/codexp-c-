using System;

namespace calculo_de_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int meses;
            int dias;
            int horas;
            int minutos;

            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());
        
            meses = idade * 12;
            dias = (30*12) * idade;
            horas = (idade * 24) * 365;
            minutos = ((24*60) * 365) * idade;

            Console.WriteLine($"Sua idade é: {idade} anos e você já viveu {meses} meses, {dias} dias, {horas} horas ou {minutos} minutos.");
        }
    }
}
