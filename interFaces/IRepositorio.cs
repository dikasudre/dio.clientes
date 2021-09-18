using System.Collections.Generic;

namespace DIO.CLIENTES.Interface
{
    public interface IRepositorio<T>
    {
        List<T> Listar();
        T RetornaPorId(int id);
        void Inserir(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
        
    }
}

