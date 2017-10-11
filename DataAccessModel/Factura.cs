using System;
using System.Collections.Generic;

namespace DataAccessModel
{
    public class Factura
    {
        public DateTime FechaEmision { get; set; }
        public int NumeroDoc { get; set; }
        public int NumeroSerie {get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
    }
}