using System;
using System.Collections.Generic;


namespace TesteLojaAdriel
{
    public class Cliente
    {
        public string _enderecoCliente;
        public string _telefoneCliente;
        public string _cpfCliente;
        public string _nomeCliente;

        public string getNomeCliente()
        {
            return this._nomeCliente;
        }
        public void setNomeCliente(string value)
        {
            this._nomeCliente = value;
        }
       
        public string getCpfCliente()
        {
            return this._cpfCliente;
        }
        public void setCpfCliente(string value)
        {
            this._cpfCliente = value;
        }

        public string getEnderecoCliente()
        {
            return this._enderecoCliente;
        }
        public void setEnderecoCliente(string value)
        {
            this._enderecoCliente = value;
        }
        public string getTelefoneCliente()
        {
            return this._telefoneCliente;
        }
        public void setTelefoneCliente(string value)
        {
            this._telefoneCliente = value;
        }

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
}