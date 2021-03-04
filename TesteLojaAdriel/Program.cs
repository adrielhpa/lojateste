using System;
using System.Collections.Generic;

namespace TesteLojaAdriel
{
    class CadastroProduto
    {
        public static void CadastrarProduto()
        {
            var listaProdutos = new List<Produto>();

            do
            {
                Produto produto = new Produto();
                Console.WriteLine("Digite o tipo do produto: ");
                produto.setTipoProduto(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"Digite o nome do produto: ");
                produto.setNomeProduto(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"Digite a marca do produto: ");
                produto.setMarcaProduto(Console.ReadLine());
                Console.WriteLine();

                
                
                Console.WriteLine("Digite o valor do produto: ");
                double valorReal;
                string valor = Console.ReadLine();
                valorReal = Convert.ToDouble(valor);         
                produto.setValorProduto(valorReal);

                listaProdutos.Add(produto);
                
                Console.WriteLine("Muito obrigado !! Pressione enter para fazer outro cadastro!");
                Console.WriteLine("Para ver a lista com os dados cadastrados,digite '-l'");
                Console.WriteLine("Para sair digite '-s'");

                var repetir = Console.ReadLine();

                if (repetir == "-s")
                {
                    break;
                }
                else if (repetir == "-l")
                {
                    Produto[] ListaArray = listaProdutos.ToArray();
                    int codigoProduto = 0;

                    Console.WriteLine("Lista de Produtos:");
                    foreach (var lista in ListaArray)
                    {                        
                        Console.WriteLine($"Código do Cliente: {codigoProduto}");
                        Console.WriteLine($"Tipo: {lista.getTipoProduto()}");
                        Console.WriteLine($"Nome: {lista.getNomeProduto()}");
                        Console.WriteLine($"Marca: {lista.getMarcaProduto()}");
                        Console.WriteLine($"Preço: {lista.getValorProduto()}");
                        Console.WriteLine();
                        codigoProduto++;
                    }
                    break;
                }
            } while (true);


            }
        }
    }
    class CadastroCliente
    {
        public static void CadastrarCliente()
        {
            var listaClientes = new List<Cliente>();

            do
            {
                //Coletando dados de cliente

                Console.WriteLine("Digite o nome do cliente:");

                Cliente cliente = new Cliente();

                cliente.setNomeCliente(Console.ReadLine());
                Console.WriteLine();
                
                Console.WriteLine("Digite o CPF do cliente:");
                cliente.setCpfCliente(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite o endereço do cliente:");
                cliente.setEnderecoCliente(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite um telefone para contato:");
                cliente.setTelefoneCliente(Console.ReadLine());
                Console.WriteLine();

                listaClientes.Add(cliente);

                Console.WriteLine("Muito obrigado !! Pressione enter para fazer outro cadastro!");
                Console.WriteLine("Para ver a lista com os dados cadastrados,digite '-l'");
                Console.WriteLine("Para sair digite '-s'");

                var repetir = Console.ReadLine();

                if (repetir == "-s")
                {
                    break;
                }
                else if (repetir == "-l")
                {
                    Cliente[] ListaArray = listaClientes.ToArray();
                    int codigoCliente = 0;

                    Console.WriteLine("Lista de Clientes:");
                    foreach (var lista in ListaArray)
                    {                        
                        Console.WriteLine($"Código do Cliente: {codigoCliente}");
                        Console.WriteLine($"Nome: {lista.getNomeCliente()}");
                        Console.WriteLine($"CPF: {lista.getCpfCliente()}");
                        Console.WriteLine($"Endereço: {lista.getEnderecoCliente()}");
                        Console.WriteLine($"Telefone: {lista.getTelefoneCliente()}");
                        Console.WriteLine();
                        codigoCliente++;
                    }
                    break;
                }
            } while (true);

            Console.WriteLine("Para encerrar, pressione enter...");
            Console.ReadLine();
        }         
    }

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
                    CadastroCliente.CadastrarCliente();
                    break;
                case "2":
                    //Cadastrar produto
                    break;
                default:
                    return;
            }            
        }        
    }   
}
