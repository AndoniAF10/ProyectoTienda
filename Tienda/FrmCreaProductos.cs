using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesTienda;
using ManejadoresTienda;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FrmCreaProductos : Form
    {
        private ManejaTienda _maneja;
        private Productos _producto;
        public string banderaGuardar;

        public static FrmProducto cc = new FrmProducto();
        public FrmCreaProductos(FrmProducto registro)
        {
            InitializeComponent();
            _maneja = new ManejaTienda();
            _producto = new Productos();
        }



        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregard()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarUsuario();
                Agregard();
                Close();
            }
            else
            {
                ActualizarUsuario();
                Close();
            }
        }

        private void GuardarUsuario()
        {
            _producto.IdProducto = int.Parse(txtID.Text);
            _producto.Nombre = txtNombre.Text;
            _producto.Descripcion = txtDescripcion.Text;
            _producto.Precio = int.Parse(txtPrecio.Text);

            var valida = _maneja.ValidarCategorias(_producto);

            if (valida.Item1)
            {
                _maneja.GuardarCategorias(_producto);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarUsuario()
        {
            _maneja.ActualizarCategorias(new Productos
            {
                IdProducto = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = int.Parse(txtPrecio.Text)
            });
        }
    }
}
