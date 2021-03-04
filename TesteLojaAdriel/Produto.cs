using System.Globalization;
using System.Collections.Generic;
using System;

namespace TesteLojaAdriel
{
    public class Produto
    {
        private string _nomeProduto;
        private string _marcaProduto;
        private string _tipoProduto;
        private double _valorProduto;
        public string getNomeProduto()
        {
            return this._nomeProduto;
        }
        public void setNomeProduto(string value)
        {
            this._nomeProduto = value;
        }
        public string getMarcaProduto()
        {
            return this._marcaProduto;
        }
        public void setMarcaProduto(string value)
        {
            this._marcaProduto = value;
        }
        public string getTipoProduto()
        {
            return this._tipoProduto;
        } 
        public void setTipoProduto(string value)
        {
            this._tipoProduto = value;
        }
        public double getValorProduto()
        {
            this._valorProduto.ToString("C2", CultureInfo.CurrentCulture);
            return this._valorProduto;
        }
        public void setValorProduto(double value)
        {
            this._valorProduto = value;
        }

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