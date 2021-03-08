using System.Collections.Generic;

namespace TesteLojaAdriel
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorCodigo(int codigo);
        void Cadastrar(T objeto);
        void Excluir(int id);
        void Atualizar(int id, T objeto);

    }
}