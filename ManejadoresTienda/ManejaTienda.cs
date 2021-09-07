﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesTienda;
using AccesoDatosTienda;

namespace ManejadoresTienda
{
    public class ManejaTienda
    {
        UsuariosAccesoDatos _usuariosAccesoDatos = new UsuariosAccesoDatos();

        public Tuple<bool, string> ValidarCategorias(Productos producto)
        {
            bool error = true;
            string cadenaErrores = "";

            if (producto.IdProducto == null)
            {
                cadenaErrores = cadenaErrores + "El campo del ID no puede ser vacio \n";
                error = false;
            }

            if (producto.Nombre.Length == 0 || producto.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo del Nombre no puede ser vacio \n";
                error = false;
            }
            if (producto.Descripcion.Length == 0 || producto.Descripcion == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la descripcion no puede ser vacio \n";
                error = false;
            }

            if (producto.Precio == null)
            {
                cadenaErrores = cadenaErrores + "El campo del Precio no puede ser vacio \n";
                error = false;
            }


            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public void GuardarCategorias(Productos producto)
        {
            try
            {
                _usuariosAccesoDatos.GuardarCategorias(producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public List<Productos> ObtenerCategorias(string filtro)
        {
            var listaCategorias = _usuariosAccesoDatos.ObtenerCategorias(filtro);
            return listaCategorias;
        }

        public void EliminarCategorias(string contacto)
        {
            try
            {
                _usuariosAccesoDatos.EliminarCategorias(contacto);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void ActualizarCategorias(Productos producto)
        {
            try
            {
                _usuariosAccesoDatos.ActualizarCategorias(producto);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }
    }
}
