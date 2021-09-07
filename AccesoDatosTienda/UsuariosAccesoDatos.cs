using System;
using System.Collections.Generic;
using System.Data;
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

        public void EliminarCategorias(string productos)
        {
            try
            {
                string consulta = string.Format("delete from producto where Nombre ='{0}'", productos);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public List<Productos> ObtenerCategorias(string filtro)
        {
            var ListaCategorias = new List<Productos>();
            var ds = new DataSet();
            string consulta = string.Format("select * from producto where Nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "producto");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {

                var contacto = new Productos
                {
                    IdProducto = int.Parse(row["idproducto"].ToString()),
                    Nombre = row["nombre"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Precio = int.Parse(row["precio"].ToString())
                };


                ListaCategorias.Add(contacto);

            }

            return ListaCategorias;
        }
    }
}
