using System;

namespace Cupediarum
{
    partial class FrmInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtClave
            // 
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(207, 301);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(177, 35);
            this.TxtClave.TabIndex = 10;
            this.TxtClave.UseSystemPasswordChar = true;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(209, 200);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(279, 35);
            this.TxtUsuario.TabIndex = 9;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Black;
            this.LblUsuario.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUsuario.Location = new System.Drawing.Point(63, 199);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(124, 44);
            this.LblUsuario.TabIndex = 7;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.BackColor = System.Drawing.Color.Black;
            this.LblClave.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblClave.Location = new System.Drawing.Point(28, 294);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(163, 44);
            this.LblClave.TabIndex = 13;
            this.LblClave.Text = "Contraseña";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Black;
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnAceptar.FlatAppearance.BorderSize = 3;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Image = global::Cupediarum.Properties.Resources.Icono_Aceptar48;
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.Location = new System.Drawing.Point(391, 464);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(179, 57);
            this.BtnAceptar.TabIndex = 12;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatAppearance.BorderSize = 3;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Image = global::Cupediarum.Properties.Resources.Icono_Cancelar32;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(12, 464);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(179, 57);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 527);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicioSesion";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.FrmInicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblClave;
    }
}

