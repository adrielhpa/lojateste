using System.Collections.Generic;
using TesteLoja.Models;

namespace TesteLoja.Repository
{
    public class ClienteRepositorio : IRepositorio<Cliente>
    {
        private List<Cliente> listaCliente = new List<Cliente>();

        public List<Cliente> Lista()
        {
            return listaCliente;
        }
        public Cliente RetornaPorCodigo(int codigo)
        {
            return listaCliente[codigo];
        }
        public Cliente RetornaNome(int codigo)
        {
            return listaCliente[codigo];
        }

        public void Cadastrar(Cliente objeto)
        {
            listaCliente.Add(objeto);
        }

        public void Excluir(int id)
        {
            listaCliente[id].Excluir();
        }

        public void Atualizar(int id, Cliente objeto)
        {
            listaCliente[id] = objeto;
        }

        public int ProximoId()
        {
            return listaCliente.Count;
        }    
    }
}