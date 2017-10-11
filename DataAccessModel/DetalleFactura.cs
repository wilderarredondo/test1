using System;

namespace DataAccessModel
{
    public class DetalleFactura
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
    }
}