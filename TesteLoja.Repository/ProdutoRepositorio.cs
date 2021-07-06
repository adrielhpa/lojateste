using System.Collections.Generic;
using TesteLoja.Models;

namespace TesteLoja.Repository
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {
        private List<Produto> listaProduto = new List<Produto>();
        public void Atualizar(int id, Produto objeto)
        {
            listaProduto[id] = objeto;
        }

        public void Cadastrar(Produto objeto)
        {
            listaProduto.Add(objeto);
        }

        public void Excluir(int id)
        {
            listaProduto[id].Excluir();
        }

        public List<Produto> Lista()
        {
            return listaProduto;
        }

        public Produto RetornaPorCodigo(int codigo)
        {
            return listaProduto[codigo];
        }
        public Produto RetornaNome(int codigo)
        {
            return listaProduto[codigo];
        }
        public int ProximoId()
        {
            return listaProduto.Count;
        }
    }
}