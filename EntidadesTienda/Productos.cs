using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTienda
{
    public class Productos
    {
        private int _idProducto;
        private string _Nombre;
        private string _Descripcion;
        private int _Precio;

        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Precio { get => _Precio; set => _Precio = value; }
    }
}
