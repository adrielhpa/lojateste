using System;
using System.Collections.Generic;



namespace TesteLojaAdriel
{
    public class Cliente : Base_Id
    {
        private string Nome{ get; set;}
        private string Cpf{ get; set; }
        private string Rg{ get; set; }
        private string Endereco{ get; set; }
        private string Cep{get ; set; }
        private string DataNascimento {get; set;}
        private bool Excluido{get;set;}


        public Cliente(int id, string nome, string cpf, string rg,string dataNascimento, string endereco, string cep, string data)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Endereco = endereco;
            this.Cep = cep;
            this.DataNascimento = data;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "CPF: " + this.Cpf + Environment.NewLine;
            retorno += "RG: " + this.Rg + Environment.NewLine;
            retorno += "Data de Nascimento: " + this.DataNascimento + Environment.NewLine;
            retorno += "Endereço: " + this.Endereco + Environment.NewLine;
            retorno += "CEP: " + this.Cep + Environment.NewLine;
            return retorno;
        }

        public string RetornaNome()
        {
            return this.Nome;
        }
        public int RetornaCodigo()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }















        // public static void CadastrarCliente()
        // {
        //     var listaClientes = new List<Cliente>();

        //     do
        //     {
        //         //Coletando dados de cliente

        //         Console.WriteLine("Digite o nome do cliente:");

        //         Cliente cliente = new Cliente();

        //         cliente.setNomeCliente(Console.ReadLine());
        //         Console.WriteLine();

        //         Console.WriteLine("Digite o CPF do cliente:");
        //         cliente.setCpfCliente(Console.ReadLine());
        //         Console.WriteLine();

        //         Console.WriteLine("Digite o endereço do cliente:");
        //         cliente.setEnderecoCliente(Console.ReadLine());
        //         Console.WriteLine();

        //         Console.WriteLine("Digite um telefone para contato:");
        //         cliente.setTelefoneCliente(Console.ReadLine());
        //         Console.WriteLine();

        //         listaClientes.Add(cliente);

        //         Console.WriteLine("Muito obrigado !! Pressione enter para fazer outro cadastro!");
        //         Console.WriteLine("Para ver a lista com os dados cadastrados,digite '-l'");
        //         Console.WriteLine("Para sair digite '-s'");

        //         var repetir = Console.ReadLine();

        //         if (repetir == "-s")
        //         {
        //             break;
        //         }
        //         else if (repetir == "-l")
        //         {
        //             Cliente[] ListaArray = listaClientes.ToArray();
        //             int codigoCliente = 0;

        //             Console.WriteLine("Lista de Clientes:");
        //             foreach (var lista in ListaArray)
        //             {                        
        //                 Console.WriteLine($"Código do Cliente: {codigoCliente}");
        //                 Console.WriteLine($"Nome: {lista.getNomeCliente()}");
        //                 Console.WriteLine($"CPF: {lista.getCpfCliente()}");
        //                 Console.WriteLine($"Endereço: {lista.getEnderecoCliente()}");
        //                 Console.WriteLine($"Telefone: {lista.getTelefoneCliente()}");
        //                 Console.WriteLine();
        //                 codigoCliente++;
        //             }
        //             break;
        //         }
        //     } while (true);

        //     Console.WriteLine("Para encerrar, pressione enter...");
        //     Console.ReadLine();
        // }         
















        // public static void CadastrarCliente()
        // {
        //     var listaClientes = new List<Cliente>();

        //     do
        //     {
        //         //Coletando dados de cliente

        //         Console.WriteLine("Digite o nome do cliente:");

        //         Cliente cliente = new Cliente();

        //         cliente.setNomeCliente(Console.ReadLine());
        //         Console.WriteLine();
                
        //         Console.WriteLine("Digite o CPF do cliente:");
        //         cliente.setCpfCliente(Console.ReadLine());
        //         Console.WriteLine();

        //         Console.WriteLine("Digite o endereço do cliente:");
        //         cliente.setEnderecoCliente(Console.ReadLine());
        //         Console.WriteLine();

        //         Console.WriteLine("Digite um telefone para contato:");
        //         cliente.setTelefoneCliente(Console.ReadLine());
        //         Console.WriteLine();

        //         listaClientes.Add(cliente);

        //         Console.WriteLine("Muito obrigado !! Pressione enter para fazer outro cadastro!");
        //         Console.WriteLine("Para ver a lista com os dados cadastrados,digite '-l'");
        //         Console.WriteLine("Para sair digite '-s'");

        //         var repetir = Console.ReadLine();

        //         if (repetir == "-s")
        //         {
        //             break;
        //         }
        //         else if (repetir == "-l")
        //         {
        //             Cliente[] ListaArray = listaClientes.ToArray();
        //             int codigoCliente = 0;

        //             Console.WriteLine("Lista de Clientes:");
        //             foreach (var lista in ListaArray)
        //             {                        
        //                 Console.WriteLine($"Código do Cliente: {codigoCliente}");
        //                 Console.WriteLine($"Nome: {lista.getNomeCliente()}");
        //                 Console.WriteLine($"CPF: {lista.getCpfCliente()}");
        //                 Console.WriteLine($"Endereço: {lista.getEnderecoCliente()}");
        //                 Console.WriteLine($"Telefone: {lista.getTelefoneCliente()}");
        //                 Console.WriteLine();
        //                 codigoCliente++;
        //             }
        //             break;
        //         }
        //     } while (true);

        //     Console.WriteLine("Para encerrar, pressione enter...");
        //     Console.ReadLine();
        // }         

    }   
}