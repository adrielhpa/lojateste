using System;


namespace TesteLojaAdriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Muito bem vindo!!");
            Console.WriteLine("O que você deseja fazer? \n1-Cadastrar cliente. \n2-Cadastrar produtos.");
            string jaPossuiCadastro = Console.ReadLine();

            switch (jaPossuiCadastro)
            {
                case "1":
                    Cliente.CadastrarCliente();
                    break;
                case "2":
                    Produto.CadastrarProduto();
                    break;
                default:
                    break;
            }
        }
    }    
}