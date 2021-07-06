using System;

namespace TesteLoja.Service
{
    public class ClienteService
    {
        public string setOpcaoUsuario(string opcaoUsuario)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("##### CLIENTE ##### CLIENTE ##### CLIENTE #####");
            Console.WriteLine();
            Console.WriteLine("******Informe a opção desejada******");
            Console.WriteLine();
            Console.WriteLine("1- Novo Cadastro");
            Console.WriteLine("2- Listar cadastros");
            Console.WriteLine("3- Consultar cadastro");
            Console.WriteLine("4- Atualizar cadastrados");
            Console.WriteLine("5- Excluir cadastro");
            Console.WriteLine("X- Voltar ao menu anterior");

            opcaoUsuario = Console.ReadLine().ToUpper();

            Console.WriteLine(">> " + opcaoUsuario);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            return opcaoUsuario;
        }

    }
}