using System;

namespace laco_wile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // int count = 0;
            // int limite;

            // Console.WriteLine("Digite o valor inicial");
            // count = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite o valor final");
            // limite = int.Parse(Console.ReadLine());

            // while(count <= limite)
            // {
            //     Console.WriteLine(count);
            //     count = count + 1;
            // }

            // -------------------------------------------------------------------------------------------------------------------------

          int count = 0;
          int limite = 10; 

          Console.WriteLine("Digite o valor inicial");
          count = int.Parse(Console.ReadLine());

        //   Console.WriteLine("Digite o valor final");
        //   limite = int.Parse(Console.ReadLine());

          while(count <= limite)
          {
            Console.WriteLine($"{count} X {limite} = {count * limite}");
            count = count + 1;
          }
        }
    }
}
