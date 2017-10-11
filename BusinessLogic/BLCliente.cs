using System;
using System.Collections.Generic;
using DataAccess;
using DataAccessModel;
using BusinessLogicModel;

namespace BusinessLogic
{
    public class BLCliente
    {


        public List<BLMCliente> ListarClientes()
        {
            DACliente daCliente = new DACliente();
            List<Cliente> clientes = daCliente.Listar();
            List<BLMCliente> clientesBLM = new List<BLMCliente>();

            foreach (Cliente item in clientes)
            {
                BLMCliente blmCliente = new BLMCliente();
                blmCliente.ID = item.IdCliente;
                blmCliente.Nombres = string.Format("{0} {1}", item.PrimerNombre, item.SegundoNombre);
                blmCliente.Apellidos = string.Format("{0} {1}", item.ApellidoPaterno, item.ApellidoMaterno);
                blmCliente.Direccion = item.Direccion;
                clientesBLM.Add(blmCliente);
            }
            return clientesBLM;

        }

        public BLMCliente Buscar(int _ID)
        {
            DACliente daCliente = new DACliente();
            Cliente cliente = daCliente.Buscar(_ID);
            BLMCliente blmCliente = new BLMCliente();
            blmCliente.ID = cliente.IdCliente;
            blmCliente.Nombres = string.Format("{0} {1}", cliente.PrimerNombre, cliente.SegundoNombre);
            blmCliente.Apellidos = string.Format("{0} {1}", cliente.ApellidoPaterno, cliente.ApellidoMaterno);
            blmCliente.Direccion = cliente.Direccion;
            return blmCliente;
        }
    }
}
