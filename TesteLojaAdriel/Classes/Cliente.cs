using System;
using System.Collections.Generic;



namespace TesteLojaAdriel
{
    public class Cliente : Base_Id
    {
        private string Nome{ get; set;}
        private long Cpf{ get; set; }
        private long Rg{ get; set; }
        private string Endereco{ get; set; }
        private long Cep{get ; set; }
        private string DataNascimento {get; set;}
        private bool Excluido{get;set;}


        public Cliente(int id, string nome, long cpf, long rg,string dataNascimento, string endereco, long cep, string data)
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
    }   
}