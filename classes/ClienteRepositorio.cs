using System;
using System.Collections.Generic;
using DIO.CLIENTES.Interface;

namespace DIO.CLIENTES
{
    public class ClienteRepositorio : IRepositorio<Clientes>
    {
        private List<Clientes> listaClientes = new List<Clientes>();
        public void Atualizar(int id, Clientes objeto)
        {
            listaClientes[id] = objeto;
        }

        public void Excluir(int id)
        {
           listaClientes[id].Excluir();
        }

        public void Inserir(Clientes objeto)
        {
            listaClientes.Add(objeto);
        }

        public List<Clientes> Listar()
        {
           return listaClientes;
        }

        public int ProximoId()
        {
            return listaClientes.Count;
        }

        public Clientes RetornaPorId(int id)
        {
             return listaClientes[id];
        }
    }
}