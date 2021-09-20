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
            this.ControlBox = false;
            this.Text = string.Empty;
        }

        //private void pbxLogout_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void pbxLogout_MouseEnter(object sender, EventArgs e)
        //{
            
        //}

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            //Articulo Seleccionado = (Articulo)dgbArticulos.CurrentRow.DataBoundItem;
            //cargarImagen(Seleccionado.ImagenUrl);
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
            cargarDatos();
            hideColumns();
            prenderBotones();
            
        }

        private void prenderBotones()
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnDetalle.Enabled = true;
        }

        private void cargarDatos()
        {
            ArticuloServicio servicio = new ArticuloServicio();
            try
            {
                listaArticulo = servicio.listar();
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                cargarImagen(listaArticulo[0].ImagenUrl);
                hideColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataLoad()
        {
            ArticuloServicio servicio = new ArticuloServicio();
            try
            {
                listaArticulo = servicio.listar();                                
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
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            Articulo seleccionado;

            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmAltaArticulo1 modifcar = new frmAltaArticulo1(seleccionado);
                modifcar.ShowDialog();
                cargarDatos();
            }
            catch (Exception ex)
            {
                msjError();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmEliminar modifcar = new frmEliminar(seleccionado);
                modifcar.StartPosition = FormStartPosition.CenterScreen;
                modifcar.ShowDialog();
                cargarDatos();
            }
            catch (Exception ex)
            {
                msjError();
            }
        }
                
        private void hideColumns()
        {            
            dgvArticulos.Columns["Id"].Visible = false;
            //dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void buscar()
        {
            dataLoad();
            List<Articulo> listaCoincidente;
            if (txtSearch.Text != "")
            {
                listaCoincidente = listaArticulo.FindAll(item => item.Codigo.ToUpper().Contains(txtSearch.Text.ToUpper()) || item.Nombre.ToUpper().Contains(txtSearch.Text.ToUpper()) || item.Marca.Descripcion.ToUpper().Contains(txtSearch.Text.ToUpper()) || item.Categoria.Descripcion.ToUpper().Contains(txtSearch.Text.ToUpper()));
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaCoincidente;                
                hideColumns();
                prenderBotones();
                
            }
            else
            {

                //hideColumns();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            buscar();
        }

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(Seleccionado.ImagenUrl);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo Seleccionado;           

            try
            {
                Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalle detallado = new frmDetalle(Seleccionado);
                detallado.ShowDialog();


                
                
            }
            catch (Exception ex)
            {

                msjError(); ;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msjError()
        {
            MessageBox.Show("¡ERROR! Debe seleccionar un articulo de la lista antes de \r\n" +
                "realizar la acción deseada.");
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                buscar();
            }
        }
    }
}


