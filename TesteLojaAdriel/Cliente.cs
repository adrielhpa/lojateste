namespace TesteLojaAdriel
{
    class Cliente
    {
        private string _enderecoCliente;
        private string _telefoneCliente;
        private string _cpfCliente;
        private string _nomeCliente;

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

    }    
}
