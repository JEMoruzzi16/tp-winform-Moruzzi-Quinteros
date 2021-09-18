
namespace Presentacion
{
    partial class frmBuscarArticulo
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.gpbSeleccionar = new System.Windows.Forms.GroupBox();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.rbtnCategoria = new System.Windows.Forms.RadioButton();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            this.gpbSeleccionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(42, 199);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(152, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(17, 114);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 2;
            // 
            // cbxMarca
            // 
            this.cbxMarca.Enabled = false;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(17, 80);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 5;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Location = new System.Drawing.Point(18, 44);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(120, 20);
            this.txbCodigo.TabIndex = 8;
            this.txbCodigo.TextChanged += new System.EventHandler(this.txbCodigo_TextChanged);
            // 
            // gpbSeleccionar
            // 
            this.gpbSeleccionar.Controls.Add(this.rbtnMarca);
            this.gpbSeleccionar.Controls.Add(this.rbtnCategoria);
            this.gpbSeleccionar.Controls.Add(this.rbtnCodigo);
            this.gpbSeleccionar.Location = new System.Drawing.Point(152, 12);
            this.gpbSeleccionar.Name = "gpbSeleccionar";
            this.gpbSeleccionar.Size = new System.Drawing.Size(105, 138);
            this.gpbSeleccionar.TabIndex = 9;
            this.gpbSeleccionar.TabStop = false;
            this.gpbSeleccionar.Text = "Seleccione:";
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Location = new System.Drawing.Point(14, 33);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtnCodigo.TabIndex = 10;
            this.rbtnCodigo.TabStop = true;
            this.rbtnCodigo.Text = "Código";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            this.rbtnCodigo.CheckedChanged += new System.EventHandler(this.rbtnCodigo_CheckedChanged);
            // 
            // rbtnCategoria
            // 
            this.rbtnCategoria.AutoSize = true;
            this.rbtnCategoria.Location = new System.Drawing.Point(14, 69);
            this.rbtnCategoria.Name = "rbtnCategoria";
            this.rbtnCategoria.Size = new System.Drawing.Size(72, 17);
            this.rbtnCategoria.TabIndex = 11;
            this.rbtnCategoria.TabStop = true;
            this.rbtnCategoria.Text = "Categoría";
            this.rbtnCategoria.UseVisualStyleBackColor = true;
            this.rbtnCategoria.CheckedChanged += new System.EventHandler(this.rbtnCategoria_CheckedChanged);
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.Location = new System.Drawing.Point(14, 103);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(55, 17);
            this.rbtnMarca.TabIndex = 12;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            this.rbtnMarca.CheckedChanged += new System.EventHandler(this.rbtnMarca_CheckedChanged);
            // 
            // frmBuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 273);
            this.Controls.Add(this.gpbSeleccionar);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmBuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarArticulo";
            this.gpbSeleccionar.ResumeLayout(false);
            this.gpbSeleccionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.GroupBox gpbSeleccionar;
        private System.Windows.Forms.RadioButton rbtnMarca;
        private System.Windows.Forms.RadioButton rbtnCategoria;
        private System.Windows.Forms.RadioButton rbtnCodigo;
    }
}