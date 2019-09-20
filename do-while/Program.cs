using System;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            string senha;
         
            //Email:

            do{
                Console.WriteLine("Digite seu email: ");
                email = Console.ReadLine();
            }

            while(!email.Contains("@") && !email.Contains("."));

            //Senha:

            do{
                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();
            }

            while(senha.Length <= 6);
        }
    }
}
