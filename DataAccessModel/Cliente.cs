using System;

namespace DataAccessModel
{
    public class Cliente
    {

        public int IdCliente { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }        
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Cliente()
        {

        }

        public string ObtenerDatos()
        {
            return @"{this.PrimerNombre} {this.SegundoNombre} {this.ApellidoPaterno} {this.ApellidoMaterno}";
        }

    }
}
