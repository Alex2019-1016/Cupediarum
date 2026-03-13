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
            this.BtnPrecios = new System.Windows.Forms.Button();
            this.BtnCerrarTurno = new System.Windows.Forms.Button();
            this.BtnAbrirTurno = new System.Windows.Forms.Button();
            this.BtnMesas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMesero = new System.Windows.Forms.Button();
            this.MnuPrincipal.SuspendLayout();
            this.PnOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.MnuPrincipal.Size = new System.Drawing.Size(921, 33);
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
            this.PnOpciones.Controls.Add(this.BtnPrecios);
            this.PnOpciones.Controls.Add(this.BtnCerrarTurno);
            this.PnOpciones.Controls.Add(this.BtnAbrirTurno);
            this.PnOpciones.Controls.Add(this.BtnMesas);
            this.PnOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnOpciones.Location = new System.Drawing.Point(0, 33);
            this.PnOpciones.Name = "PnOpciones";
            this.PnOpciones.Size = new System.Drawing.Size(122, 602);
            this.PnOpciones.TabIndex = 3;
            // 
            // BtnPrecios
            // 
            this.BtnPrecios.BackColor = System.Drawing.Color.Plum;
            this.BtnPrecios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrecios.BackgroundImage")));
            this.BtnPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrecios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPrecios.FlatAppearance.BorderSize = 3;
            this.BtnPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrecios.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrecios.Image = global::Cupediarum.Properties.Resources.Precios48;
            this.BtnPrecios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPrecios.Location = new System.Drawing.Point(3, 175);
            this.BtnPrecios.Name = "BtnPrecios";
            this.BtnPrecios.Size = new System.Drawing.Size(112, 64);
            this.BtnPrecios.TabIndex = 12;
            this.BtnPrecios.Text = "PRECIOS";
            this.BtnPrecios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPrecios.UseVisualStyleBackColor = false;
            this.BtnPrecios.Click += new System.EventHandler(this.BtnPrecios_Click);
            // 
            // BtnCerrarTurno
            // 
            this.BtnCerrarTurno.BackColor = System.Drawing.Color.Plum;
            this.BtnCerrarTurno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrarTurno.BackgroundImage")));
            this.BtnCerrarTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrarTurno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCerrarTurno.FlatAppearance.BorderSize = 3;
            this.BtnCerrarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrarTurno.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarTurno.Image = global::Cupediarum.Properties.Resources.CerrarTurno48;
            this.BtnCerrarTurno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrarTurno.Location = new System.Drawing.Point(3, 519);
            this.BtnCerrarTurno.Name = "BtnCerrarTurno";
            this.BtnCerrarTurno.Size = new System.Drawing.Size(112, 66);
            this.BtnCerrarTurno.TabIndex = 8;
            this.BtnCerrarTurno.Text = "CERRAR TURNO";
            this.BtnCerrarTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCerrarTurno.UseVisualStyleBackColor = false;
            // 
            // BtnAbrirTurno
            // 
            this.BtnAbrirTurno.BackColor = System.Drawing.Color.Plum;
            this.BtnAbrirTurno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAbrirTurno.BackgroundImage")));
            this.BtnAbrirTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAbrirTurno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAbrirTurno.FlatAppearance.BorderSize = 3;
            this.BtnAbrirTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAbrirTurno.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirTurno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAbrirTurno.Image = global::Cupediarum.Properties.Resources.AbrirTurno48;
            this.BtnAbrirTurno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAbrirTurno.Location = new System.Drawing.Point(3, 340);
            this.BtnAbrirTurno.Name = "BtnAbrirTurno";
            this.BtnAbrirTurno.Size = new System.Drawing.Size(112, 78);
            this.BtnAbrirTurno.TabIndex = 7;
            this.BtnAbrirTurno.Text = "ABRIR TURNO";
            this.BtnAbrirTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbrirTurno.UseVisualStyleBackColor = false;
            // 
            // BtnMesas
            // 
            this.BtnMesas.BackColor = System.Drawing.Color.Plum;
            this.BtnMesas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMesas.BackgroundImage")));
            this.BtnMesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMesas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMesas.FlatAppearance.BorderSize = 3;
            this.BtnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMesas.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMesas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMesas.Image = global::Cupediarum.Properties.Resources.Mesa48;
            this.BtnMesas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMesas.Location = new System.Drawing.Point(3, 1);
            this.BtnMesas.Name = "BtnMesas";
            this.BtnMesas.Size = new System.Drawing.Size(112, 61);
            this.BtnMesas.TabIndex = 6;
            this.BtnMesas.Text = "MESAS";
            this.BtnMesas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMesas.UseVisualStyleBackColor = false;
            this.BtnMesas.Click += new System.EventHandler(this.BtnMesas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnMesero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(789, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 602);
            this.panel1.TabIndex = 49;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Plum;
            this.BtnSalir.BackgroundImage = global::Cupediarum.Properties.Resources.FondoNaranja;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnSalir.FlatAppearance.BorderSize = 2;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::Cupediarum.Properties.Resources.Exit32;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.Location = new System.Drawing.Point(1, 550);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(124, 42);
            this.BtnSalir.TabIndex = 49;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMesero
            // 
            this.BtnMesero.BackColor = System.Drawing.Color.Plum;
            this.BtnMesero.BackgroundImage = global::Cupediarum.Properties.Resources.FondoAzul;
            this.BtnMesero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMesero.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnMesero.FlatAppearance.BorderSize = 3;
            this.BtnMesero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMesero.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMesero.Image = global::Cupediarum.Properties.Resources.Mesero64;
            this.BtnMesero.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnMesero.Location = new System.Drawing.Point(3, 3);
            this.BtnMesero.Name = "BtnMesero";
            this.BtnMesero.Size = new System.Drawing.Size(122, 59);
            this.BtnMesero.TabIndex = 9;
            this.BtnMesero.Text = "MESERO";
            this.BtnMesero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMesero.UseVisualStyleBackColor = false;
            this.BtnMesero.Click += new System.EventHandler(this.BtnMesero_Click_1);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Cupediarum.Properties.Resources.CupediarumLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(921, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnOpciones);
            this.Controls.Add(this.MnuPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.PnOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button BtnCerrarTurno;
        private System.Windows.Forms.Button BtnAbrirTurno;
        private System.Windows.Forms.Button BtnMesas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMesero;
        private System.Windows.Forms.Button BtnPrecios;
    }
}