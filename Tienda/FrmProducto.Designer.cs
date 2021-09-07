
namespace Tienda
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BtnRecargar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregaCategorias = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(25, 54);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(287, 20);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // BtnRecargar
            // 
            this.BtnRecargar.Location = new System.Drawing.Point(409, 249);
            this.BtnRecargar.Name = "BtnRecargar";
            this.BtnRecargar.Size = new System.Drawing.Size(199, 30);
            this.BtnRecargar.TabIndex = 9;
            this.BtnRecargar.Text = "Recargar tabla";
            this.BtnRecargar.UseVisualStyleBackColor = true;
            this.BtnRecargar.Click += new System.EventHandler(this.BtnRecargar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(409, 146);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(199, 30);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregaCategorias
            // 
            this.btnAgregaCategorias.Location = new System.Drawing.Point(409, 54);
            this.btnAgregaCategorias.Name = "btnAgregaCategorias";
            this.btnAgregaCategorias.Size = new System.Drawing.Size(199, 30);
            this.btnAgregaCategorias.TabIndex = 7;
            this.btnAgregaCategorias.Text = "Agregar";
            this.btnAgregaCategorias.UseVisualStyleBackColor = true;
            this.btnAgregaCategorias.Click += new System.EventHandler(this.btnAgregaCategorias_Click);
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(25, 94);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(287, 185);
            this.dtgDatos.TabIndex = 6;
            this.dtgDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellDoubleClick);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.BtnRecargar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregaCategorias);
            this.Controls.Add(this.dtgDatos);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BtnRecargar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregaCategorias;
        private System.Windows.Forms.DataGridView dtgDatos;
    }
}