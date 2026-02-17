namespace Cupediarum
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PnOpciones = new System.Windows.Forms.Panel();
            this.BtnCerrarTurno = new System.Windows.Forms.Button();
            this.BtnAbrirTurno = new System.Windows.Forms.Button();
            this.BtnMesas = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMesero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MnuPrincipal.SuspendLayout();
            this.PnOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.Color.White;
            this.MnuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MnuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionesToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.cajaToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(727, 33);
            this.MnuPrincipal.TabIndex = 2;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.ayudaToolStripMenuItem.Text = "Ventas";
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.cajaToolStripMenuItem.Text = "Caja";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // PnOpciones
            // 
            this.PnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.PnOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnOpciones.Controls.Add(this.BtnCerrarTurno);
            this.PnOpciones.Controls.Add(this.BtnAbrirTurno);
            this.PnOpciones.Controls.Add(this.BtnMesas);
            this.PnOpciones.Location = new System.Drawing.Point(4, 35);
            this.PnOpciones.Name = "PnOpciones";
            this.PnOpciones.Size = new System.Drawing.Size(126, 373);
            this.PnOpciones.TabIndex = 3;
            // 
            // BtnCerrarTurno
            // 
            this.BtnCerrarTurno.BackColor = System.Drawing.Color.LightCoral;
            this.BtnCerrarTurno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrarTurno.BackgroundImage")));
            this.BtnCerrarTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrarTurno.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnCerrarTurno.FlatAppearance.BorderSize = 3;
            this.BtnCerrarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarTurno.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarTurno.Image = global::Cupediarum.Properties.Resources.Icono_CerrarTurno48;
            this.BtnCerrarTurno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrarTurno.Location = new System.Drawing.Point(3, 288);
            this.BtnCerrarTurno.Name = "BtnCerrarTurno";
            this.BtnCerrarTurno.Size = new System.Drawing.Size(118, 80);
            this.BtnCerrarTurno.TabIndex = 8;
            this.BtnCerrarTurno.Text = "Cerrar Turno";
            this.BtnCerrarTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCerrarTurno.UseVisualStyleBackColor = false;
            // 
            // BtnAbrirTurno
            // 
            this.BtnAbrirTurno.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAbrirTurno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAbrirTurno.BackgroundImage")));
            this.BtnAbrirTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAbrirTurno.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnAbrirTurno.FlatAppearance.BorderSize = 3;
            this.BtnAbrirTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirTurno.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirTurno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAbrirTurno.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrirTurno.Image")));
            this.BtnAbrirTurno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAbrirTurno.Location = new System.Drawing.Point(3, 139);
            this.BtnAbrirTurno.Name = "BtnAbrirTurno";
            this.BtnAbrirTurno.Size = new System.Drawing.Size(118, 83);
            this.BtnAbrirTurno.TabIndex = 7;
            this.BtnAbrirTurno.Text = "Abrir Turno";
            this.BtnAbrirTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbrirTurno.UseVisualStyleBackColor = false;
            // 
            // BtnMesas
            // 
            this.BtnMesas.BackColor = System.Drawing.Color.LightCoral;
            this.BtnMesas.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnMesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMesas.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnMesas.FlatAppearance.BorderSize = 3;
            this.BtnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMesas.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMesas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMesas.Image = global::Cupediarum.Properties.Resources.Icono_Table48;
            this.BtnMesas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMesas.Location = new System.Drawing.Point(3, 1);
            this.BtnMesas.Name = "BtnMesas";
            this.BtnMesas.Size = new System.Drawing.Size(118, 73);
            this.BtnMesas.TabIndex = 6;
            this.BtnMesas.Text = "Mesas";
            this.BtnMesas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMesas.UseVisualStyleBackColor = false;
            this.BtnMesas.Click += new System.EventHandler(this.BtnMesas_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.BtnSalir.BackgroundImage = global::Cupediarum.Properties.Resources.FBNaranja;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnSalir.FlatAppearance.BorderSize = 5;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::Cupediarum.Properties.Resources.Icono_Exit;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.Location = new System.Drawing.Point(582, 351);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(138, 60);
            this.BtnSalir.TabIndex = 48;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.UseVisualStyleBackColor = false;
            // 
            // BtnMesero
            // 
            this.BtnMesero.BackColor = System.Drawing.Color.LightCoral;
            this.BtnMesero.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnMesero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMesero.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnMesero.FlatAppearance.BorderSize = 3;
            this.BtnMesero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMesero.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMesero.Image = global::Cupediarum.Properties.Resources.Icono_Mesero;
            this.BtnMesero.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnMesero.Location = new System.Drawing.Point(582, 38);
            this.BtnMesero.Name = "BtnMesero";
            this.BtnMesero.Size = new System.Drawing.Size(138, 73);
            this.BtnMesero.TabIndex = 8;
            this.BtnMesero.Text = "Mesero";
            this.BtnMesero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMesero.UseVisualStyleBackColor = false;
            this.BtnMesero.Click += new System.EventHandler(this.BtnMesero_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Cupediarum.Properties.Resources.CupediarumLogo;
            this.pictureBox1.Location = new System.Drawing.Point(133, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 417);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnMesero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnOpciones);
            this.Controls.Add(this.MnuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
           
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.PnOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.Panel PnOpciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrarTurno;
        private System.Windows.Forms.Button BtnAbrirTurno;
        private System.Windows.Forms.Button BtnMesas;
        private System.Windows.Forms.Button BtnMesero;
        private System.Windows.Forms.Button BtnSalir;
    }
}