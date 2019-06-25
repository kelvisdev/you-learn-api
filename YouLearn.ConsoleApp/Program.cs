using System;
using YouLearn.Domain.Arguments.Usuario;
using YouLearn.Domain.Services;

namespace YouLearn.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AdicionarUsuarioRequest request = new AdicionarUsuarioRequest()
            {
                Email = "kelvis@gmail.com",
                PrimeiroNome = "Kelvis",
                UltimoNome = "Borges",
                Senha = "12ewq1"
            };

            var response = new ServiceUsuario().AdicionarUsuario(request);


            Console.ReadKey();
        }
    }
}
