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
using Servicios;
namespace winform_app
{
    public partial class frmEliminarArticulo : Form
    {
        public frmEliminarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloServicio servicio = new ArticuloServicio();
            Articulo articulo = new Articulo();
            try
            {
                articulo.Codigo = tbxCodigo.Text;
                servicio.eliminar(articulo);
                MessageBox.Show("Eliminado exitosamente");

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
