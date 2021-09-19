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

namespace Presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo=null;
        public frmDetalle()
        {
            InitializeComponent();
        }
               

        public frmDetalle(Articulo _articulo )
        {
            InitializeComponent();
            this.articulo = _articulo;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            lblName.Text = articulo.Nombre.ToUpper();
            mostrarDetalle();
            cargarImagen(articulo.ImagenUrl);
            btnContinuar.Focus();

        }
        
        private void mostrarDetalle()
        {
            txtDetalle.Text= txtDetalle.Text = 
                "Código : "+ articulo.Codigo +
                "\r\nNombre : " + articulo.Nombre +
                "\r\nDescripción: " + articulo.Descripcion +
                "\r\nMarca: " + articulo.Marca.Descripcion +
                "\r\nCategoría: " + articulo.Categoria.Descripcion + 
                "\r\nPrecio: " + articulo.Precio;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImg.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImg.Load("https://c.tenor.com/jwAkhSG3BWEAAAAC/error.gif");
            }
        }
    }
}
