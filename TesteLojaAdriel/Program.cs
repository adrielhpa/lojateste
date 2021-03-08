using System;


namespace TesteLojaAdriel
{
    class Program
    {
        static ClienteRepositorio  clienteRepositorio = new ClienteRepositorio();
        private static string opcaoUsuario;              
        private static string opcaoUsuarioInicial;
    
        static void Main(string[] args)
        {   
            
            do
            {
                opcaoUsuarioInicial = ObterOpcaoInicial();

                do
                {
                    if(opcaoUsuarioInicial == "1")
                    {
                        opcaoUsuario = ObterOpcaoUsuario();
                        
                        switch(opcaoUsuario)
                        {
                            case "1":
                                CadastrarCliente();
                                break;
                            case "2":
                                ConsultarCliente();
                                break;
                            case "3":
                                Atualizar();
                                break;
                            case "4":
                                ListarClientes();
                                break;
                            case "5":
                                ExcluirCliente();
                                break;
                            case "X":   //volta ao menu anterior
                                break;                                
                        }
                    }
                }while(opcaoUsuario != "X");
                
            }while(opcaoUsuarioInicial != "X");                  
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("******Informe a opção desejada******");
            System.Console.WriteLine();
            System.Console.WriteLine("1- Cadastrar cliente");
            System.Console.WriteLine("2- Consultar clientes");
            System.Console.WriteLine("3- Atualizar cadastro");
            System.Console.WriteLine("4- Listar clientes cadastrados");
            System.Console.WriteLine("5- Excluir cliente");
            System.Console.WriteLine("X- Voltar ao menu anterior");

            string opcaoUsuario = System.Console.ReadLine().ToUpper();
            System.Console.WriteLine(">> " + opcaoUsuario);
            System.Console.WriteLine();
            return opcaoUsuario;
        }
        private static string ObterOpcaoInicial()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("**** Seja bem-vindo !! ****");
            System.Console.WriteLine("Sobre o que você deseja tratar hoje?");
            System.Console.WriteLine();
            System.Console.WriteLine("1- Clientes");
            System.Console.WriteLine("2- Produtos");
            System.Console.WriteLine("X- Sair");

            string opcaoUsuarioInicial = System.Console.ReadLine().ToUpper();
            System.Console.WriteLine(">> " + opcaoUsuarioInicial);
            System.Console.WriteLine();
            return opcaoUsuarioInicial;
        }
        private static void CadastrarCliente()
        {
            System.Console.WriteLine("**** Cadastrar novo cliente ****");

            System.Console.WriteLine("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite o CPF do cliente: ");
            string cpfCliente = Console.ReadLine();

            System.Console.WriteLine("Digite o RG do cliente: ");
            string rgCliente = Console.ReadLine();

            System.Console.WriteLine("Digite o endereço do cliente: ");
            string enderecoCliente = Console.ReadLine();

            System.Console.WriteLine("Digite o CEP do cliente: ");
            string cepCliente = Console.ReadLine();

            System.Console.WriteLine("Digite a data de nascimento do cliente: ");
            string dataCliente = Console.ReadLine();

            Cliente novoCliente = new Cliente(id : clienteRepositorio.ProximoId(), nome:entradaNome, cpf : cpfCliente,
                                            rg: rgCliente, dataNascimento: dataCliente, endereco: enderecoCliente,
                                            cep: cepCliente, data: dataCliente);
            
            clienteRepositorio.Cadastrar(novoCliente);
        }
        private static void ListarClientes()
        {
            System.Console.WriteLine("**** Lista de Clientes ****");

            var lista = clienteRepositorio.Lista();

            if(lista.Count == 0)
            {
                System.Console.WriteLine("*****Nenhum cliente cadastrado*****");
                return;
            }

            foreach(var cliente in lista)
            {
                var excluido = cliente.RetornaExcluido();
                System.Console.WriteLine("##### ID: {0}: {1} >> {2}", cliente.RetornaCodigo(), cliente.RetornaNome(), (excluido ? "EXCLUÍDO" : ""));
            }
        }
        private static void Atualizar()
        {
            System.Console.WriteLine("**** Cadastrar novo cliente ****");

            System.Console.WriteLine("Digite o ID do cliente: ");
            int indiceCliente = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite o CPF do cliente: ");
            string cpfCliente = Console.ReadLine();

            System.Console.WriteLine("Digite o RG do cliente: ");
            string rgCliente = Console.ReadLine();

            System.Console.WriteLine("Digite o endereço do cliente: ");
            string enderecoCliente = Console.ReadLine();

            System.Console.WriteLine("Digite o CEP do cliente: ");
            string cepCliente = Console.ReadLine();

            System.Console.WriteLine("Digite a data de nascimento do cliente: ");
            string dataCliente = Console.ReadLine();

            Cliente atualizaCliente = new Cliente(id : indiceCliente, nome:entradaNome, cpf : cpfCliente,
                                            rg: rgCliente, dataNascimento: dataCliente, endereco: enderecoCliente,
                                            cep: cepCliente, data: dataCliente);
            
            clienteRepositorio.Atualizar(indiceCliente, atualizaCliente);
        }
        private static void ConsultarCliente()
        {
            System.Console.WriteLine("Digite o ID do cliente: ");
            int indiceCliente = int.Parse(Console.ReadLine()); 
            var cliente = clienteRepositorio.RetornaPorCodigo(indiceCliente);

            System.Console.WriteLine(cliente);
        }
        private static void ExcluirCliente()
        {
            System.Console.WriteLine("Digite o ID do cliente: ");
            int indiceCliente = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Cliente de nome: {0} excluído com sucesso!", clienteRepositorio.RetornaNome(indiceCliente));
            clienteRepositorio.Excluir(indiceCliente);

        }
    }    
}