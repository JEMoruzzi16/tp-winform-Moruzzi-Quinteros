
namespace Presentacion
{
    partial class frmEliminar
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCanelar = new System.Windows.Forms.Button();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(21, 34);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(319, 18);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "¿Esta seguro que desea eliminar el articulo?";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfirmar.Image = global::Presentacion.Properties.Resources.Accept;
            this.btnConfirmar.Location = new System.Drawing.Point(81, 122);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 60);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCanelar
            // 
            this.btnCanelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnCanelar.FlatAppearance.BorderSize = 0;
            this.btnCanelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCanelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanelar.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCanelar.Image = global::Presentacion.Properties.Resources.Cancel;
            this.btnCanelar.Location = new System.Drawing.Point(218, 122);
            this.btnCanelar.Name = "btnCanelar";
            this.btnCanelar.Size = new System.Drawing.Size(72, 60);
            this.btnCanelar.TabIndex = 2;
            this.btnCanelar.Text = "Cancelar";
            this.btnCanelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCanelar.UseVisualStyleBackColor = false;
            this.btnCanelar.Click += new System.EventHandler(this.btnCanelar_Click);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblArticulo.ForeColor = System.Drawing.Color.White;
            this.lblArticulo.Location = new System.Drawing.Point(149, 76);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(51, 19);
            this.lblArticulo.TabIndex = 3;
            this.lblArticulo.Text = "label1";
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(362, 194);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.btnCanelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblMensaje);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 233);
            this.MinimumSize = new System.Drawing.Size(378, 233);
            this.Name = "frmEliminar";
            this.Text = "frmEliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCanelar;
        private System.Windows.Forms.Label lblArticulo;
    }
}