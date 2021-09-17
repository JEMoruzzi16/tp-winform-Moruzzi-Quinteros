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
    public partial class mainForm : Form
    {
        private List<Articulo> listaArticulo;
        public mainForm()
        {
            InitializeComponent();
        }

        private void pbxLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxLogout_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void dgbArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado = (Articulo)dgbArticulos.CurrentRow.DataBoundItem;
            cargarImagen(Seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://c.tenor.com/jwAkhSG3BWEAAAAC/error.gif");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            cargar();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void cargar()
        {
            ArticuloServicio servicio = new ArticuloServicio();
            try
            {
                listaArticulo = servicio.listar();
                dgbArticulos.DataSource = listaArticulo;
                dgbArticulos.Columns["ImagenUrl"].Visible = false;
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo1 alta = new frmAltaArticulo1();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            Articulo seleccionado;

            try
            {
                seleccionado = (Articulo)dgbArticulos.CurrentRow.DataBoundItem;

                frmAltaArticulo1 modifcar = new frmAltaArticulo1(seleccionado);
                modifcar.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgbArticulos.CurrentRow.DataBoundItem;

                frmEliminar modifcar = new frmEliminar(seleccionado);
                modifcar.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
