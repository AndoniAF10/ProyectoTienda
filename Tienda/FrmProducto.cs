using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesTienda;
using ManejadoresTienda;

namespace Tienda
{
    public partial class FrmProducto : Form
    {
        public static ManejaTienda _maneja;
        private Productos _producto;
        public FrmProducto()
        {
            InitializeComponent();
            _maneja = new ManejaTienda();
            _producto = new Productos();
        }

        private void btnAgregaCategorias_Click(object sender, EventArgs e)
        {
            FrmCreaProductos fp = new FrmCreaProductos(this);
            fp.banderaGuardar = "guardar";
            fp.UpdateEventHandler += Fp_UpdateEventHandler;
            fp.ShowDialog();
            fp.txtID.Focus();
        }

        private void Fp_UpdateEventHandler(object sender, FrmCreaProductos.UpdateEventArgs args)
        {
            CargarCategorias("");
        }

        public void CargarCategorias(string filtro)
        {
            dtgDatos.DataSource = _maneja.ObtenerCategorias(filtro);
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias("");
        }

        private void Eliminar()
        {
            if (MessageBox.Show("Desea eliminar el producto seleccionado", "Eliminar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoria = dtgDatos.CurrentRow.Cells["nombre"].Value.ToString();
                _maneja.EliminarCategorias(categoria);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarCategorias("");
        }

        private void dtgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCreaProductos cc = new FrmCreaProductos(this);
            cc.banderaGuardar = "actualizar";
            cc.txtID.Text = dtgDatos.CurrentRow.Cells["idproducto"].Value.ToString();
            cc.txtNombre.Text = dtgDatos.CurrentRow.Cells["nombre"].Value.ToString();
            cc.txtDescripcion.Text = dtgDatos.CurrentRow.Cells["descripcion"].Value.ToString();
            cc.txtPrecio.Text = dtgDatos.CurrentRow.Cells["precio"].Value.ToString();
            cc.txtID.Enabled = false;
            cc.ShowDialog();
        }

        private void BtnRecargar_Click(object sender, EventArgs e)
        {
            CargarCategorias("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarCategorias(txtBuscar.Text);
        }
    }
}
