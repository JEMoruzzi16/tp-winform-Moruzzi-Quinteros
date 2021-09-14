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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloServicio servicio = new ArticuloServicio();
            try
            {
                art.Codigo = tbxCodigo.Text;
                art.Nombre = tbxNombre.Text;
                art.Descripcion = tbxDescripcion.Text;
                art.IdMarca = (Marca)cboMarca.SelectedItem;
                art.IdCategoria = (Categoria)cboCategoria.SelectedItem;
                art.ImagenUrl = tbxUrlImagen.Text;
                art.Precio = decimal.Parse(tbxPrecio.Text);

                servicio.agregar(art);
                MessageBox.Show("Agregado Exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaServicio categoriaServicio = new CategoriaServicio();
            MarcaServicio marcaServicio = new MarcaServicio();
            try
            {
                cboMarca.DataSource = marcaServicio.listar();
                cboCategoria.DataSource = categoriaServicio.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
