
using System;

namespace TesteLoja.Service
{
    public class ProdutoService
    {
        public string setOpcaoUsuario(string opcaoUsuario)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("##### PRODUTO ##### PRODUTO ##### PRODUTO #####");
            Console.WriteLine("******Informe a opção desejada******");
            Console.WriteLine();
            Console.WriteLine("1- Novo Produto");
            Console.WriteLine("2- Listar todos os produtos");
            Console.WriteLine("3- Consultar produto");
            Console.WriteLine("4- Atualizar produto");
            Console.WriteLine("5- Excluir produto");
            Console.WriteLine("X- Voltar ao menu anterior");

            opcaoUsuario = Console.ReadLine().ToUpper();

            Console.WriteLine(">> " + opcaoUsuario);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}