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
    public partial class frmEliminar : Form
    {
        Articulo eliminado = null;
        public frmEliminar()
        {
            InitializeComponent();
        }

        public frmEliminar(Articulo eliminado)
        {
            InitializeComponent();
            this.eliminado = eliminado;
            lblArticulo.Text = eliminado.Nombre;
            Text = "Elimar Artículo";
        }

    private void btnCanelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ArticuloServicio servicio = new ArticuloServicio();
            Articulo articulo = new Articulo();
            try
            {
                
                servicio.eliminar(eliminado);
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
