using System;
using System.Collections.Generic;

namespace TesteLojaAdriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Muito bem vindo!!");
            Console.WriteLine("O cliente já possui cadastro?");
            string jaPossuiCadastro = Console.ReadLine();

            if(jaPossuiCadastro == "sim")
            {
                //Vai para a seleção de produtos.
                //Lista de produtos já cadastrados.
            }
            if(jaPossuiCadastro=="não")
            {
                //Faz o cadastro.
                CadastroCliente.CadastroDeCliente();
            }
            else
            {
                //Reiniciar o app                
                return;               
            }

            
            //CadastroProduto.CadastroDeProdutos();
        }        
    }

    //Cadastrar os produtos no programa.
    //acessar as informações sem alterá-las.
    //Fazer o resumo de compra do cliente
    //Emitir um recibo.


    abstract class CadastroCliente
    {
        public static void CadastroDeCliente()
        {
            var listaClientes = new List<Cliente>();

            do
            {
                //Coletando dados de cliente

                Console.WriteLine("Digite o nome do cliente:");

                Cliente cliente = new Cliente();
                cliente.NomeCliente = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o CPF do cliente:");
                cliente.CpfCliente = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o endereço do cliente:");
                cliente.EnderecoCliente = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite um telefone para contato:");
                cliente.TelefoneCliente = Console.ReadLine();
                Console.WriteLine();


                listaClientes.Add(cliente);



                Console.WriteLine("Muito obrigado !! Pressione enter para fazer outro cadastro!");
                Console.WriteLine("Para vera lista de clientes digite '-l'");
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

                    foreach (var lista in ListaArray)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lista de Clientes:");
                        Console.WriteLine($"Código do Cliente: {codigoCliente}");
                        Console.WriteLine($"Nome: {lista.NomeCliente}");
                        Console.WriteLine($"CPF: {lista.CpfCliente}");
                        Console.WriteLine($"Endereço: {lista.EnderecoCliente}");
                        Console.WriteLine();
                        codigoCliente++;
                    }
                    break;
                }
            } while (true);

            //Console.WriteLine("Para sair, pressione enter...");
            Console.ReadLine();
        }
        
    }

    abstract class CadastroProduto
    {
        public static void CadastroDeProdutos()
        {
            var listaProdutos = new List<Produto>();

            do
            {            
                Console.WriteLine("Digite o nome do produto:");

                Produto produto = new Produto();
                produto.GetNomeProduto = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite a marca do produto :");
                produto.GetMarcaProduto = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o tipo de produto:");
                produto.GetTipoProduto = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o valor do produto:");
                produto.GetValorProduto = Console.ReadLine();
                Console.WriteLine();            

                //Transformar string para double ($)

                listaProdutos.Add(produto);



                Console.WriteLine("Pressione enter para fazer outro cadastro!");
                Console.WriteLine("Para sair digite 'sair'");
                var repetir = Console.ReadLine();

                if (repetir == "sair")
                {
                    break;
                }

            } while (true);

            Produto[] ListaArray = listaProdutos.ToArray();
            int codigoProduto = 100;

            foreach (var lista in ListaArray)
            {
                Console.WriteLine();
                Console.WriteLine("Lista de Produtos:");
                Console.WriteLine($"Código do Produto: {codigoProduto}");
                Console.WriteLine($"Nome: {lista.GetNomeProduto}");
                Console.WriteLine($"CPF: {lista.GetMarcaProduto}");
                Console.WriteLine($"Endereço: {lista.GetTipoProduto}");
                Console.WriteLine($"Valor: {lista.GetValorProduto}");
                Console.WriteLine();
                codigoProduto++;
            }
                Console.ReadLine();
        }
    }
}
