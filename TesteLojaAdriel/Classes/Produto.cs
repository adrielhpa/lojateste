using System.Globalization;
using System.Collections.Generic;
using System;

namespace TesteLojaAdriel
{
    public class Produto:Base_Id
    {
       private string NomeProduto{ get; set; }
       private string Marca{ get; set; }
       private string Descricao{ get; set; }
       private CategoriaProdutos Categoria{ get; set; }
       private double Preco{ get; set; }
       private bool Excluido{ get; set; }

       public Produto(int id, CategoriaProdutos categoria, string nomeProduto, string marca, string descricao, double preco)
       {
           this.Id = id;
           this.Categoria = categoria;
           this.NomeProduto = nomeProduto;
           this.Marca = marca;
           this.Descricao = descricao;           
           this.Preco = preco;
       }
       
       public override string ToString()
        {
            string retorno = "";
            retorno += "Categoria do produto: " + this.Categoria + Environment.NewLine;
            retorno += "Nome do produto: " + this.NomeProduto + Environment.NewLine;
            retorno += "Marca: " + this.Marca + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Preço: " + this.Preco + Environment.NewLine;
            return retorno;
        }
        public string RetornaNome()
        {
            return this.NomeProduto;
        }
        public int RetornaCodigo()
        {
            return this.Id;
        }
        public double RetorndaPreco()
        {
            return this.Preco;
        }
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}