using System;

namespace CoberturaDeCodigo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa() { Nome = "Anderson", Sobrenome="Serra" };

            Console.WriteLine(pessoa.ToString());
            Console.ReadKey();
        }
    }
}
