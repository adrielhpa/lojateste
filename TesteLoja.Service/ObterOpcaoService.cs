using System;
using System.Data;
using TesteLoja.Models;
using TesteLoja.Repository;

namespace TesteLoja.Service
{
    public class ObterOpcaoService
    {
        static ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        private ClienteService clienteService = new ClienteService();
        private ProdutoService produtoService = new ProdutoService();
        private string _opcaoUsuario;
        private string _obterOpcaoInicial;
        private string _entradaNome;
        private long _cpfCliente;
        private long _rgCliente;
        private string _enderecoCliente;
        private long _cepCliente;
        private string _dataCliente;
        private int _indiceCliente;
        private int _entradaCategoria;
        private string _marca;
        private string _descricao;
        private double _preco;
        private int _indiceProduto;
        private int _opcaoExcluir;

        public string getObterOpcaoInicial()
        {
            return this._obterOpcaoInicial;
        }
        public string setObterOpcaoInicial()
        {

            Console.WriteLine();
            Console.WriteLine("**** Seja bem-vindo !! ****");
            Console.WriteLine("Sobre o que você deseja tratar hoje?");
            Console.WriteLine();
            Console.WriteLine("1- Clientes");
            Console.WriteLine("2- Produtos");
            Console.WriteLine("X- Sair");

            _obterOpcaoInicial = Console.ReadLine().ToUpper();
            Console.WriteLine(">> " + _obterOpcaoInicial);
            Console.WriteLine();
            return _obterOpcaoInicial;

        }
        public string ProdutoOuCliente()
        {
            if (_obterOpcaoInicial == "1")
            {
                var retorno = clienteService.setOpcaoUsuario(_opcaoUsuario);
                return retorno;
            }
            else if (_obterOpcaoInicial == "2")
            {
                var retorno = produtoService.setOpcaoUsuario(_opcaoUsuario);
                return retorno;
            }
            else
            {
                return setObterOpcaoInicial();
            }
        }
        //CLIENTES     
        public string getObterOpcaoUsuarioCliente()
        {
            return this._opcaoUsuario;
        }
        public void setCadastrarCliente()
        {

            Console.WriteLine("**** Cadastrar novo cliente ****");

            Console.WriteLine("Digite o nome do cliente: ");
            _entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do cliente: ");
            _cpfCliente = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite o RG do cliente: ");
            _rgCliente = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite o endereço do cliente: ");
            _enderecoCliente = Console.ReadLine();

            Console.WriteLine("Digite o CEP do cliente: ");
            _cepCliente = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data de nascimento do cliente: ");
            _dataCliente = Console.ReadLine();

            Cliente novoCliente = new Cliente(id: clienteRepositorio.ProximoId(), nome: _entradaNome, cpf: _cpfCliente,
                                            rg: _rgCliente, dataNascimento: _dataCliente, endereco: _enderecoCliente,
                                            cep: _cepCliente, data: _dataCliente);

            clienteRepositorio.Cadastrar(novoCliente);
        }
        public void setListarClientes()
        {

            Console.WriteLine("**** Lista de Clientes ****");

            var lista = clienteRepositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("*****Nenhum cliente cadastrado*****");
                return;
            }

            foreach (var cliente in lista)
            {
                var excluido = cliente.RetornaExcluido();
                Console.WriteLine("##### ID: {0}: {1} >> {2}", cliente.RetornaCodigo(), cliente.RetornaNome(), (excluido ? "EXCLUÍDO" : ""));
            }

        }
        public void setConsultarCliente()
        {
            Console.WriteLine("***** Consultar Cliente *****");
            Console.WriteLine();

            Console.WriteLine("Digite o ID do cliente: ");
            _indiceCliente = int.Parse(Console.ReadLine());
            var cliente = clienteRepositorio.RetornaPorCodigo(_indiceCliente);

            //Criar uma excessao para no caso de o 'indiceCliente' digitado não existir, retornar para nova tentativa de receber o código correto

            Console.WriteLine(cliente);
        }
        public void setAtualizar()
        {
            Console.WriteLine("**** Atualizar os dados do cliente ****");

            Console.WriteLine("Digite o ID do cliente: ");
            _indiceCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente: ");
            _entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do cliente: ");
            //_cpfCliente = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite o RG do cliente: ");
            _rgCliente = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite o endereço do cliente: ");
            _enderecoCliente = Console.ReadLine();

            Console.WriteLine("Digite o CEP do cliente: ");
            _cepCliente = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data de nascimento do cliente: ");
            _dataCliente = Console.ReadLine();

            Cliente atualizaCliente = new Cliente(id: _indiceCliente, nome: _entradaNome, cpf: _cpfCliente,
                                            rg: _rgCliente, dataNascimento: _dataCliente, endereco: _enderecoCliente,
                                            cep: _cepCliente, data: _dataCliente);

            clienteRepositorio.Atualizar(_indiceCliente, atualizaCliente);
        }
        public void setExcluirCliente()
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("***** Excluir Cliente *****");
            Console.WriteLine("Digite o ID do cliente: ");
            _indiceCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem certeza que deseja excluir esse cliente?");
            Console.WriteLine("1- SIM");
            Console.WriteLine("2- NÃO");
            _opcaoExcluir = int.Parse(Console.ReadLine());

            if (_opcaoExcluir == 1)
            {
                Console.WriteLine($"##### Excluído com sucesso! ##### {Environment.NewLine}{clienteRepositorio.RetornaNome(_indiceCliente)}##### Excluído com sucesso! #####");
                clienteRepositorio.Excluir(_indiceCliente);
            }
            else
            {
                return;
            }


        }

        public static string FormatarCpf(string numero)
        {
            return long.Parse(numero).ToString(@"000.000.000-00");
        }


        //PRODUTOS

        public void setCadastrarProduto()
        {
            Console.WriteLine("**** Cadastrar novo produto ****");

            foreach (int i in Enum.GetValues(typeof(CategoriaProdutos)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(CategoriaProdutos), i)}");
            }

            Console.WriteLine("Digite a categoria do produto, entre as opções acima: ");
            _entradaCategoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto: ");
            _entradaNome = Console.ReadLine();

            Console.WriteLine("Digite a marca do produto: ");
            _marca = Console.ReadLine();

            Console.WriteLine("Digite uma descrição para o produto: ");
            _descricao = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: ");
            _preco = double.Parse(Console.ReadLine());


            Console.WriteLine($"Data de cadastro: {DateTime.Today}");

            Produto novoProduto = new Produto(id: produtoRepositorio.ProximoId(), (CategoriaProdutos)_entradaCategoria,
                                                nomeProduto: _entradaNome, marca: _marca, descricao: _descricao,
                                                preco: _preco);

            produtoRepositorio.Cadastrar(novoProduto);
        }
        public void setListarProdutos()
        {
            Console.WriteLine("**** Lista de Produtos ****");

            var lista = produtoRepositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("*****Nenhum produto cadastrado*****");
                return;
            }

            foreach (var produto in lista)
            {
                var excluido = produto.RetornaExcluido();
                Console.WriteLine("##### ID: {0}: {1} {2}", produto.RetornaCodigo(), produto.RetornaNome(), (excluido ? ">> EXCLUÍDO" : ""));
                Console.WriteLine("##### Preço: R$ {0}", produto.RetorndaPreco());
            }
        }
        public void setConsultarProduto()
        {
            Console.WriteLine("***** Consultar Produto *****");
            Console.WriteLine();

            Console.WriteLine("Digite o ID do cadastro: ");
            _indiceProduto = int.Parse(Console.ReadLine());
            var produto = produtoRepositorio.RetornaPorCodigo(_indiceProduto);

            //Criar uma excessao para no caso de o 'indiceCliente' digitado não existir, retornar para nova tentativa de receber o código correto

            Console.WriteLine(produto);
        }
        public void setAtualizarProduto()
        {
            Console.WriteLine("**** Atualizar Produto ****");

            Console.WriteLine("Digite o ID do produto: ");
            _indiceCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto: ");
            _entradaNome = Console.ReadLine();

            Console.WriteLine("Digite a marca do produto: ");
            _marca = Console.ReadLine();

            Console.WriteLine("Digite uma descrição para o produto: ");
            _descricao = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: ");
            _preco = double.Parse(Console.ReadLine());

            Console.WriteLine($"Data da atualização do cadastro: {DateTime.Today}");

            Produto atualizarProduto = new Produto(id: produtoRepositorio.ProximoId(), (CategoriaProdutos)_entradaCategoria,
                                                nomeProduto: _entradaNome, marca: _marca, descricao: _descricao,
                                                preco: _preco);

            produtoRepositorio.Atualizar(_indiceProduto, atualizarProduto);
        }
        public void setExcluirProduto()
        {
            Console.WriteLine("***** Excluir Produto *****");
            Console.WriteLine("Digite o ID do produto: ");
            _indiceProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem certeza que deseja excluir esse produto?");
            Console.WriteLine("1- SIM");
            Console.WriteLine("2- NÃO");
            _opcaoExcluir = int.Parse(Console.ReadLine());

            if (_opcaoExcluir == 1)
            {
                Console.WriteLine($"##### Excluído com sucesso! ##### {Environment.NewLine}{produtoRepositorio.RetornaNome(_indiceProduto)} ##### Excluído com sucesso! #####");
                produtoRepositorio.Excluir(_indiceProduto);
            }
            else
            {
                return;
            }



        }
    }
}