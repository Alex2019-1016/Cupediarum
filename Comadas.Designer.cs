namespace Cupediarum
{
    partial class FrmComadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComadas));
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAbrirCuenta = new System.Windows.Forms.Button();
            this.BtnComandas = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnComentario = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.BtnMas = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnBorrarTodo = new System.Windows.Forms.Button();
            this.BtnBorrarProducto = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.acercaToolStripMenuItem.Text = "Acerca de";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem,
            this.acercaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.BtnAbrirCuenta);
            this.flowLayoutPanel1.Controls.Add(this.BtnComandas);
            this.flowLayoutPanel1.Controls.Add(this.BtnAceptar);
            this.flowLayoutPanel1.Controls.Add(this.BtnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.BtnComentario);
            this.flowLayoutPanel1.Controls.Add(this.BtnMenos);
            this.flowLayoutPanel1.Controls.Add(this.BtnMas);
            this.flowLayoutPanel1.Controls.Add(this.TxtCantidad);
            this.flowLayoutPanel1.Controls.Add(this.BtnBorrarTodo);
            this.flowLayoutPanel1.Controls.Add(this.BtnBorrarProducto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(566, 274);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnAbrirCuenta
            // 
            this.BtnAbrirCuenta.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAbrirCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAbrirCuenta.BackgroundImage")));
            this.BtnAbrirCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAbrirCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnAbrirCuenta.FlatAppearance.BorderSize = 3;
            this.BtnAbrirCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirCuenta.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirCuenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrirCuenta.Image")));
            this.BtnAbrirCuenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAbrirCuenta.Location = new System.Drawing.Point(3, 3);
            this.BtnAbrirCuenta.Name = "BtnAbrirCuenta";
            this.BtnAbrirCuenta.Size = new System.Drawing.Size(134, 78);
            this.BtnAbrirCuenta.TabIndex = 10;
            this.BtnAbrirCuenta.Text = "Comandas";
            this.BtnAbrirCuenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbrirCuenta.UseVisualStyleBackColor = false;
            // 
            // BtnComandas
            // 
            this.BtnComandas.BackColor = System.Drawing.Color.LightCoral;
            this.BtnComandas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnComandas.BackgroundImage")));
            this.BtnComandas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnComandas.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnComandas.FlatAppearance.BorderSize = 3;
            this.BtnComandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComandas.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComandas.Image = ((System.Drawing.Image)(resources.GetObject("BtnComandas.Image")));
            this.BtnComandas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnComandas.Location = new System.Drawing.Point(143, 3);
            this.BtnComandas.Name = "BtnComandas";
            this.BtnComandas.Size = new System.Drawing.Size(134, 78);
            this.BtnComandas.TabIndex = 13;
            this.BtnComandas.Text = "Comandas";
            this.BtnComandas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnComandas.UseVisualStyleBackColor = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.BackgroundImage")));
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnAceptar.FlatAppearance.BorderSize = 3;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.Image")));
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAceptar.Location = new System.Drawing.Point(283, 3);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(134, 78);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnCancelar.FlatAppearance.BorderSize = 3;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(423, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 78);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnComentario
            // 
            this.BtnComentario.BackColor = System.Drawing.Color.LightCoral;
            this.BtnComentario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnComentario.BackgroundImage")));
            this.BtnComentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnComentario.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnComentario.FlatAppearance.BorderSize = 3;
            this.BtnComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComentario.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComentario.Image = ((System.Drawing.Image)(resources.GetObject("BtnComentario.Image")));
            this.BtnComentario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnComentario.Location = new System.Drawing.Point(3, 87);
            this.BtnComentario.Name = "BtnComentario";
            this.BtnComentario.Size = new System.Drawing.Size(134, 78);
            this.BtnComentario.TabIndex = 14;
            this.BtnComentario.Text = "Comentario";
            this.BtnComentario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnComentario.UseVisualStyleBackColor = false;
            // 
            // BtnMenos
            // 
            this.BtnMenos.BackColor = System.Drawing.Color.LightCoral;
            this.BtnMenos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenos.BackgroundImage")));
            this.BtnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenos.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnMenos.FlatAppearance.BorderSize = 3;
            this.BtnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenos.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenos.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenos.Image")));
            this.BtnMenos.Location = new System.Drawing.Point(143, 87);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(134, 78);
            this.BtnMenos.TabIndex = 15;
            this.BtnMenos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMenos.UseVisualStyleBackColor = false;
            // 
            // BtnMas
            // 
            this.BtnMas.BackColor = System.Drawing.Color.LightCoral;
            this.BtnMas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMas.BackgroundImage")));
            this.BtnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMas.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnMas.FlatAppearance.BorderSize = 3;
            this.BtnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMas.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMas.Image = ((System.Drawing.Image)(resources.GetObject("BtnMas.Image")));
            this.BtnMas.Location = new System.Drawing.Point(283, 87);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(134, 78);
            this.BtnMas.TabIndex = 16;
            this.BtnMas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMas.UseVisualStyleBackColor = false;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(423, 87);
            this.TxtCantidad.Multiline = true;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(134, 78);
            this.TxtCantidad.TabIndex = 17;
            // 
            // BtnBorrarTodo
            // 
            this.BtnBorrarTodo.BackColor = System.Drawing.Color.LightCoral;
            this.BtnBorrarTodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBorrarTodo.BackgroundImage")));
            this.BtnBorrarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnBorrarTodo.FlatAppearance.BorderSize = 3;
            this.BtnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarTodo.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarTodo.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorrarTodo.Image")));
            this.BtnBorrarTodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBorrarTodo.Location = new System.Drawing.Point(3, 171);
            this.BtnBorrarTodo.Name = "BtnBorrarTodo";
            this.BtnBorrarTodo.Size = new System.Drawing.Size(207, 91);
            this.BtnBorrarTodo.TabIndex = 18;
            this.BtnBorrarTodo.Text = "Borrar Todo";
            this.BtnBorrarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrarTodo.UseVisualStyleBackColor = false;
            // 
            // BtnBorrarProducto
            // 
            this.BtnBorrarProducto.BackColor = System.Drawing.Color.LightCoral;
            this.BtnBorrarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBorrarProducto.BackgroundImage")));
            this.BtnBorrarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnBorrarProducto.FlatAppearance.BorderSize = 3;
            this.BtnBorrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarProducto.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorrarProducto.Image")));
            this.BtnBorrarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBorrarProducto.Location = new System.Drawing.Point(216, 171);
            this.BtnBorrarProducto.Name = "BtnBorrarProducto";
            this.BtnBorrarProducto.Size = new System.Drawing.Size(201, 91);
            this.BtnBorrarProducto.TabIndex = 19;
            this.BtnBorrarProducto.Text = "Borrar Producto";
            this.BtnBorrarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrarProducto.UseVisualStyleBackColor = false;
            // 
            // FrmComadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1110, 749);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmComadas";
            this.Text = "Comadas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnAbrirCuenta;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnComandas;
        private System.Windows.Forms.Button BtnComentario;
        private System.Windows.Forms.Button BtnMenos;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button BtnBorrarTodo;
        private System.Windows.Forms.Button BtnBorrarProducto;
    }
}