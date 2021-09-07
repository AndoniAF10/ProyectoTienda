using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesTienda;

namespace AccesoDatosTienda
{
    public class UsuariosAccesoDatos
    {
        ConexionAccesoDatos _conexion;
        public UsuariosAccesoDatos()
        {

            try
            {
                _conexion = new ConexionAccesoDatos("localhost", "root", "123456789", "tienda3", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }

            
        }

        public void GuardarCategorias(Productos producto)
        {
            try
            {
                string consulta = string.Format("insert into producto values('{0}','{1}','{2}','{3}')",
                    producto.IdProducto, producto.Nombre,producto.Descripcion,producto.Precio);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }
    }
}
