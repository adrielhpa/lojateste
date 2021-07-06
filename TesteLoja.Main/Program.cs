using System;
using TesteLoja.Service;

namespace TesteLoja
{
    class Program
    {
        static ObterOpcaoService obter = new ObterOpcaoService();
        private ClienteService clienteService;
        private static string opcaoUsuario;
        private static string opcaoUsuarioInicial;

        static void Main(string[] args)
        {
            do
            {
                opcaoUsuarioInicial = obter.setObterOpcaoInicial();

                do
                {
                    if (opcaoUsuarioInicial == "1")
                    {
                        opcaoUsuario = obter.ProdutoOuCliente();

                        switch (opcaoUsuario)
                        {
                            case "1":
                                obter.setCadastrarCliente();
                                break;
                            case "2":
                                obter.setListarClientes();
                                break;
                            case "3":
                                obter.setConsultarCliente();
                                break;
                            case "4":
                                obter.setAtualizar();
                                break;
                            case "5":
                                obter.setExcluirCliente();
                                break;
                            case "X":   //volta ao menu anterior
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                    else if (opcaoUsuarioInicial == "2")
                    {
                        opcaoUsuario = obter.ProdutoOuCliente();

                        switch (opcaoUsuario)
                        {
                            case "1":
                                obter.setCadastrarProduto();
                                break;
                            case "2":
                                obter.setListarProdutos();
                                break;
                            case "3":
                                obter.setConsultarProduto();
                                break;
                            case "4":
                                obter.setAtualizarProduto();
                                break;
                            case "5":
                                obter.setExcluirProduto();
                                break;
                            case "X":   //volta ao menu anterior
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                    
                } while (opcaoUsuario != "X");

            } while (opcaoUsuarioInicial != "X");

            if (opcaoUsuarioInicial == "X")
            {
                System.Console.WriteLine("Muito obrigado por utilizar nossos serviços !");
                System.Console.WriteLine("Até a próxima !! :D");
                System.Console.WriteLine("Pressione enter para sair");
                Console.ReadLine();
            }
        }
    }
}