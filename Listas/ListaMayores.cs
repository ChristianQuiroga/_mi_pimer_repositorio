using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class ListaMayores
    {
        private List<Cliente> _clienteMayores;

        public ListaMayores() 
        {
            _clienteMayores= new List<Cliente>();
        }

        public void InsertaEnLista(Cliente[] clientes )
        {
            for ( int i = 0; i < clientes.Length; i++ ) 
            { 
                _clienteMayores.Add(new Cliente(clientes[i].Nombre,
                                                clientes[i].Id,
                                                clientes[i].Direccion,
                                                clientes[i].Edad));

            }
        }

        //método para que me devuelva la lista. lista de objeto.
        public List<Cliente> GetListaMayores()
        {
            return _clienteMayores;
        }

        //método borrar.
        public bool Borrar(Cliente cliente)
        {
            if(!_clienteMayores.Contains(cliente))
            {
                return false;
            }
           return _clienteMayores.Remove(cliente);
        }

        //Método Buscar
        public int Buscar(Cliente cliente)
        {
            return _clienteMayores.IndexOf(cliente);
        }

        //Método Modificar
        public bool Modificar(Cliente actual, Cliente nuevo)
        {
            int posicion = Buscar(actual);
            if (posicion == -1)
            {
                return false;
            }
            _clienteMayores[posicion] = nuevo;
            return true;
        }

        //Método Limpiar
        public void Limpiar()
        {
            _clienteMayores.Clear();
        }

        //Método Ordenar
        private int CompararClientes(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.Id.CompareTo(cliente2.Id);
        }
        public void Ordenar()
        {
            _clienteMayores.Sort(CompararClientes);
        }
    }
}
