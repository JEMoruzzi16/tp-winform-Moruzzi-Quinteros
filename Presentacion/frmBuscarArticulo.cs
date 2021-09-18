using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using servicio;

namespace Presentacion
{
    public partial class frmBuscarArticulo : Form
    {
        public frmBuscarArticulo()
        {
            InitializeComponent();
        }
        private void rbtnCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txbCodigo.Enabled = true;
            cbxCategoria.Enabled = false;
            cbxMarca.Enabled = false;
        }

        private void rbtnCategoria_CheckedChanged(object sender, EventArgs e)
        {
            txbCodigo.Enabled = false;
            cbxCategoria.Enabled = false;
            cbxMarca.Enabled = true;
        }

        private void rbtnMarca_CheckedChanged(object sender, EventArgs e)
        {
            txbCodigo.Enabled = false;
            cbxCategoria.Enabled = true;
            cbxMarca.Enabled = false;
        }

        private void txbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloServicio servicio = new ArticuloServicio();
            Articulo articulo = new Articulo();
            try
            {
                int valor;
                if (txbCodigo.Enabled == true)
                {
                    articulo.Codigo = txbCodigo.Text;
                    valor = 1;
                }
                else if (cbxCategoria.Enabled == true)
                {
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                    valor = 2;
                }
                else
                {
                    articulo.Marca = (Marca)cbxMarca.SelectedItem;
                    valor = 3;
                }

                servicio.buscar(articulo,valor);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
