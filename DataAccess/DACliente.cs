using System;
using System.Collections.Generic;
using DataAccessModel;

namespace DataAccess
{
    public class DACliente
    {
        private List<Cliente> clientes = new List<Cliente>();
        
        public DACliente()
        {
            Cliente carlos = new Cliente();
            carlos.IdCliente = 1;
            carlos.PrimerNombre = "Carlos";
            carlos.ApellidoPaterno = "Ugarte";

            Cliente maria = new Cliente();
            maria.IdCliente = 2;
            maria.PrimerNombre = "Maria";
            maria.ApellidoPaterno = "Sanchez";
            
            Cliente ana = new Cliente();
            ana.IdCliente = 3;
            ana.PrimerNombre = "Cesar";
            ana.ApellidoPaterno = "Martin";

            clientes.Add(carlos);
            clientes.Add(maria);
            clientes.Add(ana);
        }

        public void test()
        {
            Cliente carlos = new Cliente();
            carlos.PrimerNombre = "Carlos";
            carlos.ApellidoPaterno = "Ugarte";
            Console.WriteLine(carlos.ObtenerDatos());
        }

        public List<Cliente> Listar()
        {
            return this.clientes;
        }

        public Cliente Buscar(int _idCliente)
        {
            Cliente clienteBuscado = this.clientes.Find(item => item.IdCliente == _idCliente);
            return clienteBuscado;
        }
    }
}
