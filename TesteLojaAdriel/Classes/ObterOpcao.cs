using System;
using System.Data;

namespace TesteLojaAdriel
{    
    public class ObterOpcao
    {
        static ClienteRepositorio  clienteRepositorio = new ClienteRepositorio();
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        private string _obterOpcaoUsuario;
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
            
            System.Console.WriteLine();
            System.Console.WriteLine("**** Seja bem-vindo !! ****");
            System.Console.WriteLine("Sobre o que você deseja tratar hoje?");
            System.Console.WriteLine();
            System.Console.WriteLine("1- Clientes");
            System.Console.WriteLine("2- Produtos");
            System.Console.WriteLine("X- Sair");

            _obterOpcaoInicial = System.Console.ReadLine().ToUpper();
            System.Console.WriteLine(">> " + _obterOpcaoInicial);
            System.Console.WriteLine();
            return _obterOpcaoInicial;
            
        }
        public string setObterOpcaoUsuario()
        {
            
            System.Console.WriteLine();
            System.Console.WriteLine("******Informe a opção desejada******");
            System.Console.WriteLine();
            System.Console.WriteLine("1- Novo Cadastro");
            System.Console.WriteLine("2- Listar cadastros");
            System.Console.WriteLine("3- Consultar cadastro");
            System.Console.WriteLine("4- Atualizar cadastrados");
            System.Console.WriteLine("5- Excluir cadastro");
            System.Console.WriteLine("X- Voltar ao menu anterior");

            _obterOpcaoUsuario = System.Console.ReadLine().ToUpper();
            System.Console.WriteLine(">> " + _obterOpcaoUsuario);
            System.Console.WriteLine("----------------------------------------------------------------------");
            System.Console.WriteLine();
            return _obterOpcaoUsuario;            
        }
        public void ProdutoCliente()
        {
            if(_obterOpcaoInicial == "1")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("-------------------------------------------------------------------------------");
                System.Console.WriteLine("##### CLIENTE ##### CLIENTE ##### CLIENTE #####");
            }
            else if (_obterOpcaoInicial == "2")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("-------------------------------------------------------------------------------");
                System.Console.WriteLine("##### PRODUTO ##### PRODUTO ##### PRODUTO #####");
            }
        }
       //CLIENTES     
        public string getObterOpcaoUsuarioCliente()
        {           
            return this._obterOpcaoUsuario;            
        }
        public void setCadastrarCliente()
        {
        
            System.Console.WriteLine("**** Cadastrar novo cliente ****");

            System.Console.WriteLine("Digite o nome do cliente: ");
            _entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite o CPF do cliente: ");
            _cpfCliente = long.Parse(Console.ReadLine()); 

            System.Console.WriteLine("Digite o RG do cliente: ");
            _rgCliente = long.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o endereço do cliente: ");
            _enderecoCliente = Console.ReadLine();

            System.Console.WriteLine("Digite o CEP do cliente: ");
            _cepCliente = long.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a data de nascimento do cliente: ");
            _dataCliente = Console.ReadLine();

            Cliente novoCliente = new Cliente(id: clienteRepositorio.ProximoId(), nome: _entradaNome, cpf: _cpfCliente,
                                            rg: _rgCliente, dataNascimento: _dataCliente, endereco: _enderecoCliente,
                                            cep: _cepCliente, data: _dataCliente);

            clienteRepositorio.Cadastrar(novoCliente);
        }
        public void setListarClientes()
        {            
            
            System.Console.WriteLine("**** Lista de Clientes ****");

            var lista = clienteRepositorio.Lista();

            if (lista.Count == 0)
            {
                System.Console.WriteLine("*****Nenhum cliente cadastrado*****");
                return;
            }

            foreach (var cliente in lista)
            {
                var excluido = cliente.RetornaExcluido();
                System.Console.WriteLine("##### ID: {0}: {1} >> {2}", cliente.RetornaCodigo(), cliente.RetornaNome(), (excluido ? "EXCLUÍDO" : ""));
            }
            
        }
        public void setConsultarCliente()
        {
            System.Console.WriteLine("***** Consultar Cliente *****");
            System.Console.WriteLine();

            System.Console.WriteLine("Digite o ID do cliente: ");
            _indiceCliente = int.Parse(Console.ReadLine()); 
            var cliente = clienteRepositorio.RetornaPorCodigo(_indiceCliente);

            //Criar uma excessao para no caso de o 'indiceCliente' digitado não existir, retornar para nova tentativa de receber o código correto

            System.Console.WriteLine(cliente);
        }
        public void setAtualizar()
        {
            System.Console.WriteLine("**** Atualizar os dados do cliente ****");

            System.Console.WriteLine("Digite o ID do cliente: ");
            _indiceCliente = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do cliente: ");
            _entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite o CPF do cliente: ");
            //_cpfCliente = long.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o RG do cliente: ");
            _rgCliente = long.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o endereço do cliente: ");
            _enderecoCliente = Console.ReadLine();

            System.Console.WriteLine("Digite o CEP do cliente: ");
            _cepCliente = long.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a data de nascimento do cliente: ");
            _dataCliente = Console.ReadLine();

            Cliente atualizaCliente = new Cliente(id : _indiceCliente, nome:_entradaNome, cpf : _cpfCliente,
                                            rg: _rgCliente, dataNascimento: _dataCliente, endereco: _enderecoCliente,
                                            cep: _cepCliente, data: _dataCliente);
            
            clienteRepositorio.Atualizar(_indiceCliente, atualizaCliente);
        }
        public void setExcluirCliente()
        {
            System.Console.WriteLine("---------------------------------------------------------------------------------");
            System.Console.WriteLine("***** Excluir Cliente *****");
            System.Console.WriteLine("Digite o ID do cliente: ");
            _indiceCliente = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Tem certeza que deseja excluir esse cliente?");
            System.Console.WriteLine("1- SIM");
            System.Console.WriteLine("2- NÃO");
            _opcaoExcluir = int.Parse(Console.ReadLine());

            if (_opcaoExcluir == 1)
            {
                System.Console.WriteLine($"##### Excluído com sucesso! ##### {Environment.NewLine}{clienteRepositorio.RetornaNome(_indiceCliente)}##### Excluído com sucesso! #####");
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
            System.Console.WriteLine("**** Cadastrar novo produto ****");

            foreach(int i in Enum.GetValues(typeof (CategoriaProdutos)))
            {
                System.Console.WriteLine($"{i} - {Enum.GetName(typeof(CategoriaProdutos), i)}");
            }

            System.Console.WriteLine("Digite a categoria do produto, entre as opções acima: ");
            _entradaCategoria = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do produto: ");
            _entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite a marca do produto: ");
            _marca = Console.ReadLine();

            System.Console.WriteLine("Digite uma descrição para o produto: ");
            _descricao = Console.ReadLine();

            System.Console.WriteLine("Digite o preço do produto: ");
            _preco = double.Parse(Console.ReadLine());
            

            System.Console.WriteLine($"Data de cadastro: {DateTime.Today}");

            Produto novoProduto = new Produto(id: produtoRepositorio.ProximoId(), (CategoriaProdutos) _entradaCategoria, 
                                                nomeProduto: _entradaNome, marca: _marca, descricao: _descricao, 
                                                preco: _preco);

            produtoRepositorio.Cadastrar(novoProduto);
        }
        public void setListarProdutos()
        {
            System.Console.WriteLine("**** Lista de Produtos ****");

            var lista = produtoRepositorio.Lista();

            if (lista.Count == 0)
            {
                System.Console.WriteLine("*****Nenhum produto cadastrado*****");
                return;
            }

            foreach (var produto in lista)
            {
                var excluido = produto.RetornaExcluido();
                System.Console.WriteLine("##### ID: {0}: {1} {2}", produto.RetornaCodigo(), produto.RetornaNome(), (excluido ? ">> EXCLUÍDO" : ""));
                System.Console.WriteLine("##### Preço: R$ {0}", produto.RetorndaPreco());
            }
        }
        public void setConsultarProduto()
        {
            System.Console.WriteLine("***** Consultar Produto *****");
            System.Console.WriteLine();

            System.Console.WriteLine("Digite o ID do cadastro: ");
            _indiceProduto = int.Parse(Console.ReadLine()); 
            var produto = produtoRepositorio.RetornaPorCodigo(_indiceProduto);

            //Criar uma excessao para no caso de o 'indiceCliente' digitado não existir, retornar para nova tentativa de receber o código correto

            System.Console.WriteLine(produto);
        }
        public void setAtualizarProduto()
        {
            System.Console.WriteLine("**** Atualizar Produto ****");

            System.Console.WriteLine("Digite o ID do produto: ");
            _indiceCliente = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do produto: ");
            _entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite a marca do produto: ");
            _marca = Console.ReadLine();

            System.Console.WriteLine("Digite uma descrição para o produto: ");
            _descricao = Console.ReadLine();

            System.Console.WriteLine("Digite o preço do produto: ");
            _preco = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"Data da atualização do cadastro: {DateTime.Today}");

            Produto atualizarProduto = new Produto(id: produtoRepositorio.ProximoId(), (CategoriaProdutos) _entradaCategoria, 
                                                nomeProduto: _entradaNome, marca: _marca, descricao: _descricao, 
                                                preco: _preco);
            
            produtoRepositorio.Atualizar(_indiceProduto, atualizarProduto);
        }
        public void setExcluirProduto()
        {
            System.Console.WriteLine("***** Excluir Produto *****");
            System.Console.WriteLine("Digite o ID do produto: ");
            _indiceProduto = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Tem certeza que deseja excluir esse produto?");
            System.Console.WriteLine("1- SIM");
            System.Console.WriteLine("2- NÃO");
            _opcaoExcluir = int.Parse(Console.ReadLine());

            if (_opcaoExcluir == 1)
            {
                System.Console.WriteLine($"##### Excluído com sucesso! ##### {Environment.NewLine}{produtoRepositorio.RetornaNome(_indiceProduto)} ##### Excluído com sucesso! #####");
                produtoRepositorio.Excluir(_indiceProduto);
            }
            else
            {
                return;
            }
        

            
        }
    }
}