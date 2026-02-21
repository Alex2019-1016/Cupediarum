namespace Cupediarum
{
    partial class FrmCapturaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapturaProductos));
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FlpComanda = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnComentario = new System.Windows.Forms.Button();
            this.BtnComandas = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnDescuento = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.BtnMas = new System.Windows.Forms.Button();
            this.TxtCantProducto = new System.Windows.Forms.TextBox();
            this.BtnBorrarTodo = new System.Windows.Forms.Button();
            this.BtnBorrarProducto = new System.Windows.Forms.Button();
            this.DgvComanda = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTotal = new System.Windows.Forms.Label();
            this.FlpCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPostres = new System.Windows.Forms.Button();
            this.BtnComida = new System.Windows.Forms.Button();
            this.BtnBebidas = new System.Windows.Forms.Button();
            this.BtnOtros = new System.Windows.Forms.Button();
            this.FlpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.FlpSubCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.FlpComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComanda)).BeginInit();
            this.FlpCategorias.SuspendLayout();
            this.FlpProductos.SuspendLayout();
            this.FlpSubCategorias.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1207, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FlpComanda
            // 
            this.FlpComanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlpComanda.Controls.Add(this.BtnComentario);
            this.FlpComanda.Controls.Add(this.BtnComandas);
            this.FlpComanda.Controls.Add(this.BtnAceptar);
            this.FlpComanda.Controls.Add(this.BtnCancelar);
            this.FlpComanda.Controls.Add(this.BtnDescuento);
            this.FlpComanda.Controls.Add(this.BtnMenos);
            this.FlpComanda.Controls.Add(this.BtnMas);
            this.FlpComanda.Controls.Add(this.TxtCantProducto);
            this.FlpComanda.Controls.Add(this.BtnBorrarTodo);
            this.FlpComanda.Controls.Add(this.BtnBorrarProducto);
            this.FlpComanda.Controls.Add(this.DgvComanda);
            this.FlpComanda.Controls.Add(this.LblTotal);
            this.FlpComanda.Location = new System.Drawing.Point(0, 36);
            this.FlpComanda.Name = "FlpComanda";
            this.FlpComanda.Size = new System.Drawing.Size(406, 572);
            this.FlpComanda.TabIndex = 1;
            // 
            // BtnComentario
            // 
            this.BtnComentario.BackColor = System.Drawing.Color.LightCoral;
            this.BtnComentario.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnComentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnComentario.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnComentario.FlatAppearance.BorderSize = 3;
            this.BtnComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComentario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComentario.Image = global::Cupediarum.Properties.Resources.Icono_Comentario;
            this.BtnComentario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnComentario.Location = new System.Drawing.Point(3, 3);
            this.BtnComentario.Name = "BtnComentario";
            this.BtnComentario.Size = new System.Drawing.Size(101, 56);
            this.BtnComentario.TabIndex = 14;
            this.BtnComentario.Text = "Comentario";
            this.BtnComentario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnComentario.UseVisualStyleBackColor = false;
            // 
            // BtnComandas
            // 
            this.BtnComandas.BackColor = System.Drawing.Color.LightCoral;
            this.BtnComandas.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnComandas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnComandas.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnComandas.FlatAppearance.BorderSize = 3;
            this.BtnComandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComandas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComandas.Image = global::Cupediarum.Properties.Resources.Icono_Comandas;
            this.BtnComandas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnComandas.Location = new System.Drawing.Point(110, 3);
            this.BtnComandas.Name = "BtnComandas";
            this.BtnComandas.Size = new System.Drawing.Size(101, 56);
            this.BtnComandas.TabIndex = 13;
            this.BtnComandas.Text = "Comandas";
            this.BtnComandas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnComandas.UseVisualStyleBackColor = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAceptar.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnAceptar.FlatAppearance.BorderSize = 3;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Image = global::Cupediarum.Properties.Resources.Icono_RDAceptar32;
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAceptar.Location = new System.Drawing.Point(217, 3);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(86, 56);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.BtnCancelar.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatAppearance.BorderSize = 3;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Cupediarum.Properties.Resources.Icono_RDCancelar32;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(309, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(86, 56);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnDescuento
            // 
            this.BtnDescuento.BackColor = System.Drawing.Color.LightCoral;
            this.BtnDescuento.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnDescuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDescuento.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnDescuento.FlatAppearance.BorderSize = 3;
            this.BtnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescuento.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDescuento.Location = new System.Drawing.Point(3, 65);
            this.BtnDescuento.Name = "BtnDescuento";
            this.BtnDescuento.Size = new System.Drawing.Size(101, 56);
            this.BtnDescuento.TabIndex = 21;
            this.BtnDescuento.Text = "0 % Descuento";
            this.BtnDescuento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDescuento.UseVisualStyleBackColor = false;
            // 
            // BtnMenos
            // 
            this.BtnMenos.BackColor = System.Drawing.Color.LightCoral;
            this.BtnMenos.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenos.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnMenos.FlatAppearance.BorderSize = 3;
            this.BtnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenos.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenos.Image = global::Cupediarum.Properties.Resources.Icono_Menos32;
            this.BtnMenos.Location = new System.Drawing.Point(110, 65);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(101, 56);
            this.BtnMenos.TabIndex = 15;
            this.BtnMenos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMenos.UseVisualStyleBackColor = false;
            this.BtnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // BtnMas
            // 
            this.BtnMas.BackColor = System.Drawing.Color.LightCoral;
            this.BtnMas.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMas.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnMas.FlatAppearance.BorderSize = 3;
            this.BtnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMas.Image = global::Cupediarum.Properties.Resources.Icono_Mas32;
            this.BtnMas.Location = new System.Drawing.Point(217, 65);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(86, 56);
            this.BtnMas.TabIndex = 16;
            this.BtnMas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMas.UseVisualStyleBackColor = false;
            this.BtnMas.Click += new System.EventHandler(this.BtnMas_Click);
            // 
            // TxtCantProducto
            // 
            this.TxtCantProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtCantProducto.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantProducto.Location = new System.Drawing.Point(309, 65);
            this.TxtCantProducto.Multiline = true;
            this.TxtCantProducto.Name = "TxtCantProducto";
            this.TxtCantProducto.Size = new System.Drawing.Size(85, 56);
            this.TxtCantProducto.TabIndex = 17;
            // 
            // BtnBorrarTodo
            // 
            this.BtnBorrarTodo.BackColor = System.Drawing.Color.LightCoral;
            this.BtnBorrarTodo.BackgroundImage = global::Cupediarum.Properties.Resources.FBNaranja;
            this.BtnBorrarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnBorrarTodo.FlatAppearance.BorderSize = 3;
            this.BtnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarTodo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarTodo.Image = global::Cupediarum.Properties.Resources.Icono_Delete;
            this.BtnBorrarTodo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrarTodo.Location = new System.Drawing.Point(3, 127);
            this.BtnBorrarTodo.Name = "BtnBorrarTodo";
            this.BtnBorrarTodo.Size = new System.Drawing.Size(147, 68);
            this.BtnBorrarTodo.TabIndex = 18;
            this.BtnBorrarTodo.Text = "Borrar Todo";
            this.BtnBorrarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrarTodo.UseVisualStyleBackColor = false;
            this.BtnBorrarTodo.Click += new System.EventHandler(this.BtnBorrarTodo_Click);
            // 
            // BtnBorrarProducto
            // 
            this.BtnBorrarProducto.BackColor = System.Drawing.Color.LightCoral;
            this.BtnBorrarProducto.BackgroundImage = global::Cupediarum.Properties.Resources.FBNaranja;
            this.BtnBorrarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnBorrarProducto.FlatAppearance.BorderSize = 3;
            this.BtnBorrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarProducto.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarProducto.Image = global::Cupediarum.Properties.Resources.Icono_Delete;
            this.BtnBorrarProducto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrarProducto.Location = new System.Drawing.Point(156, 127);
            this.BtnBorrarProducto.Name = "BtnBorrarProducto";
            this.BtnBorrarProducto.Size = new System.Drawing.Size(147, 68);
            this.BtnBorrarProducto.TabIndex = 19;
            this.BtnBorrarProducto.Text = "Borrar Producto";
            this.BtnBorrarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrarProducto.UseVisualStyleBackColor = false;
            this.BtnBorrarProducto.Click += new System.EventHandler(this.BtnBorrarProducto_Click);
            // 
            // DgvComanda
            // 
            this.DgvComanda.AllowUserToAddRows = false;
            this.DgvComanda.AllowUserToDeleteRows = false;
            this.DgvComanda.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTO,
            this.COMANDA,
            this.CANT,
            this.DESCRIPCION,
            this.PRECIO,
            this.DESCUENTO});
            this.DgvComanda.GridColor = System.Drawing.Color.Black;
            this.DgvComanda.Location = new System.Drawing.Point(3, 201);
            this.DgvComanda.MultiSelect = false;
            this.DgvComanda.Name = "DgvComanda";
            this.DgvComanda.ReadOnly = true;
            this.DgvComanda.RowHeadersVisible = false;
            this.DgvComanda.RowHeadersWidth = 62;
            this.DgvComanda.RowTemplate.Height = 28;
            this.DgvComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvComanda.Size = new System.Drawing.Size(392, 337);
            this.DgvComanda.TabIndex = 20;
            // 
            // IDPRODUCTO
            // 
            this.IDPRODUCTO.HeaderText = "IDPRODUCTO";
            this.IDPRODUCTO.MinimumWidth = 8;
            this.IDPRODUCTO.Name = "IDPRODUCTO";
            this.IDPRODUCTO.ReadOnly = true;
            this.IDPRODUCTO.Visible = false;
            this.IDPRODUCTO.Width = 150;
            // 
            // COMANDA
            // 
            this.COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.COMANDA.HeaderText = "COMANDA";
            this.COMANDA.MinimumWidth = 8;
            this.COMANDA.Name = "COMANDA";
            this.COMANDA.ReadOnly = true;
            this.COMANDA.Width = 126;
            // 
            // CANT
            // 
            this.CANT.HeaderText = "CANT";
            this.CANT.MinimumWidth = 8;
            this.CANT.Name = "CANT";
            this.CANT.ReadOnly = true;
            this.CANT.Width = 150;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 8;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 156;
            // 
            // PRECIO
            // 
            this.PRECIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 8;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 106;
            // 
            // DESCUENTO
            // 
            this.DESCUENTO.HeaderText = "DESCUENTO";
            this.DESCUENTO.MinimumWidth = 8;
            this.DESCUENTO.Name = "DESCUENTO";
            this.DESCUENTO.ReadOnly = true;
            this.DESCUENTO.Width = 80;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotal.Location = new System.Drawing.Point(3, 541);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(85, 23);
            this.LblTotal.TabIndex = 22;
            this.LblTotal.Text = "TOTAL:";
            // 
            // FlpCategorias
            // 
            this.FlpCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlpCategorias.Controls.Add(this.BtnPostres);
            this.FlpCategorias.Controls.Add(this.BtnComida);
            this.FlpCategorias.Controls.Add(this.BtnBebidas);
            this.FlpCategorias.Controls.Add(this.BtnOtros);
            this.FlpCategorias.Location = new System.Drawing.Point(546, 41);
            this.FlpCategorias.Name = "FlpCategorias";
            this.FlpCategorias.Size = new System.Drawing.Size(516, 82);
            this.FlpCategorias.TabIndex = 2;
            // 
            // BtnPostres
            // 
            this.BtnPostres.BackColor = System.Drawing.Color.LightCoral;
            this.BtnPostres.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnPostres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPostres.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnPostres.FlatAppearance.BorderSize = 3;
            this.BtnPostres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPostres.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPostres.Image = global::Cupediarum.Properties.Resources.Icono_Postres;
            this.BtnPostres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPostres.Location = new System.Drawing.Point(3, 3);
            this.BtnPostres.Name = "BtnPostres";
            this.BtnPostres.Size = new System.Drawing.Size(115, 67);
            this.BtnPostres.TabIndex = 11;
            this.BtnPostres.Text = "POSTRES";
            this.BtnPostres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPostres.UseVisualStyleBackColor = false;
            // 
            // BtnComida
            // 
            this.BtnComida.BackColor = System.Drawing.Color.LightCoral;
            this.BtnComida.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnComida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnComida.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnComida.FlatAppearance.BorderSize = 3;
            this.BtnComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComida.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComida.Image = global::Cupediarum.Properties.Resources.Icono_Food;
            this.BtnComida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComida.Location = new System.Drawing.Point(124, 3);
            this.BtnComida.Name = "BtnComida";
            this.BtnComida.Size = new System.Drawing.Size(133, 67);
            this.BtnComida.TabIndex = 13;
            this.BtnComida.Text = "COMIDAS";
            this.BtnComida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnComida.UseVisualStyleBackColor = false;
            // 
            // BtnBebidas
            // 
            this.BtnBebidas.BackColor = System.Drawing.Color.LightCoral;
            this.BtnBebidas.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnBebidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBebidas.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnBebidas.FlatAppearance.BorderSize = 3;
            this.BtnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBebidas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBebidas.Image = global::Cupediarum.Properties.Resources.Icono_Drink;
            this.BtnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBebidas.Location = new System.Drawing.Point(263, 3);
            this.BtnBebidas.Name = "BtnBebidas";
            this.BtnBebidas.Size = new System.Drawing.Size(125, 67);
            this.BtnBebidas.TabIndex = 12;
            this.BtnBebidas.Text = "BEBIDAS";
            this.BtnBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBebidas.UseVisualStyleBackColor = false;
            // 
            // BtnOtros
            // 
            this.BtnOtros.BackColor = System.Drawing.Color.LightCoral;
            this.BtnOtros.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnOtros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOtros.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnOtros.FlatAppearance.BorderSize = 3;
            this.BtnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOtros.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOtros.Image = global::Cupediarum.Properties.Resources.Icono_Otros;
            this.BtnOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOtros.Location = new System.Drawing.Point(394, 3);
            this.BtnOtros.Name = "BtnOtros";
            this.BtnOtros.Size = new System.Drawing.Size(111, 67);
            this.BtnOtros.TabIndex = 14;
            this.BtnOtros.Text = "OTROS";
            this.BtnOtros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOtros.UseVisualStyleBackColor = false;
            // 
            // FlpProductos
            // 
            this.FlpProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlpProductos.Controls.Add(this.button20);
            this.FlpProductos.Controls.Add(this.button21);
            this.FlpProductos.Controls.Add(this.button22);
            this.FlpProductos.Controls.Add(this.button23);
            this.FlpProductos.Controls.Add(this.button24);
            this.FlpProductos.Controls.Add(this.button25);
            this.FlpProductos.Controls.Add(this.button26);
            this.FlpProductos.Controls.Add(this.button27);
            this.FlpProductos.Controls.Add(this.button28);
            this.FlpProductos.Controls.Add(this.button29);
            this.FlpProductos.Controls.Add(this.button30);
            this.FlpProductos.Controls.Add(this.button31);
            this.FlpProductos.Controls.Add(this.button32);
            this.FlpProductos.Controls.Add(this.button33);
            this.FlpProductos.Controls.Add(this.button34);
            this.FlpProductos.Location = new System.Drawing.Point(420, 346);
            this.FlpProductos.Margin = new System.Windows.Forms.Padding(6);
            this.FlpProductos.Name = "FlpProductos";
            this.FlpProductos.Size = new System.Drawing.Size(787, 262);
            this.FlpProductos.TabIndex = 4;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button20.FlatAppearance.BorderSize = 3;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button20.Location = new System.Drawing.Point(3, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(150, 80);
            this.button20.TabIndex = 13;
            this.button20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button21.FlatAppearance.BorderSize = 3;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button21.Location = new System.Drawing.Point(159, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(150, 80);
            this.button21.TabIndex = 14;
            this.button21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button22.FlatAppearance.BorderSize = 3;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button22.Location = new System.Drawing.Point(315, 3);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(150, 80);
            this.button22.TabIndex = 15;
            this.button22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Transparent;
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button23.FlatAppearance.BorderSize = 3;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button23.Location = new System.Drawing.Point(471, 3);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(150, 80);
            this.button23.TabIndex = 16;
            this.button23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button24.FlatAppearance.BorderSize = 3;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button24.Location = new System.Drawing.Point(627, 3);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(150, 80);
            this.button24.TabIndex = 17;
            this.button24.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Transparent;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button25.FlatAppearance.BorderSize = 3;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button25.Location = new System.Drawing.Point(3, 89);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(150, 80);
            this.button25.TabIndex = 18;
            this.button25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button26.FlatAppearance.BorderSize = 3;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button26.Location = new System.Drawing.Point(159, 89);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(150, 80);
            this.button26.TabIndex = 19;
            this.button26.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Transparent;
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button27.FlatAppearance.BorderSize = 3;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button27.Location = new System.Drawing.Point(315, 89);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(150, 80);
            this.button27.TabIndex = 20;
            this.button27.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Transparent;
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button28.FlatAppearance.BorderSize = 3;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button28.Location = new System.Drawing.Point(471, 89);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(150, 80);
            this.button28.TabIndex = 21;
            this.button28.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Transparent;
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button29.FlatAppearance.BorderSize = 3;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button29.Location = new System.Drawing.Point(627, 89);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(150, 80);
            this.button29.TabIndex = 22;
            this.button29.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Transparent;
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button30.FlatAppearance.BorderSize = 3;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button30.Location = new System.Drawing.Point(3, 175);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(150, 80);
            this.button30.TabIndex = 23;
            this.button30.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Transparent;
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button31.FlatAppearance.BorderSize = 3;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button31.Location = new System.Drawing.Point(159, 175);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(150, 80);
            this.button31.TabIndex = 24;
            this.button31.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Transparent;
            this.button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button32.FlatAppearance.BorderSize = 3;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button32.Location = new System.Drawing.Point(315, 175);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(150, 80);
            this.button32.TabIndex = 25;
            this.button32.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Transparent;
            this.button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button33.FlatAppearance.BorderSize = 3;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button33.Location = new System.Drawing.Point(471, 175);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(150, 80);
            this.button33.TabIndex = 26;
            this.button33.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Transparent;
            this.button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button34.FlatAppearance.BorderSize = 3;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button34.Location = new System.Drawing.Point(627, 175);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(150, 80);
            this.button34.TabIndex = 27;
            this.button34.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button34.UseVisualStyleBackColor = false;
            // 
            // FlpSubCategorias
            // 
            this.FlpSubCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlpSubCategorias.Controls.Add(this.button8);
            this.FlpSubCategorias.Controls.Add(this.button7);
            this.FlpSubCategorias.Controls.Add(this.button9);
            this.FlpSubCategorias.Controls.Add(this.button10);
            this.FlpSubCategorias.Controls.Add(this.button13);
            this.FlpSubCategorias.Controls.Add(this.button14);
            this.FlpSubCategorias.Controls.Add(this.button15);
            this.FlpSubCategorias.Controls.Add(this.button16);
            this.FlpSubCategorias.Controls.Add(this.button1);
            this.FlpSubCategorias.Controls.Add(this.button2);
            this.FlpSubCategorias.Controls.Add(this.button3);
            this.FlpSubCategorias.Controls.Add(this.button4);
            this.FlpSubCategorias.Controls.Add(this.button5);
            this.FlpSubCategorias.Controls.Add(this.button6);
            this.FlpSubCategorias.Controls.Add(this.button11);
            this.FlpSubCategorias.Location = new System.Drawing.Point(450, 138);
            this.FlpSubCategorias.Name = "FlpSubCategorias";
            this.FlpSubCategorias.Size = new System.Drawing.Size(721, 195);
            this.FlpSubCategorias.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 55);
            this.button8.TabIndex = 50;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(142, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 55);
            this.button7.TabIndex = 51;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.BorderSize = 3;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(281, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 55);
            this.button9.TabIndex = 52;
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button10.FlatAppearance.BorderSize = 3;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(420, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 55);
            this.button10.TabIndex = 53;
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button13.FlatAppearance.BorderSize = 3;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button13.Location = new System.Drawing.Point(559, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(133, 55);
            this.button13.TabIndex = 56;
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button14.FlatAppearance.BorderSize = 3;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button14.Location = new System.Drawing.Point(3, 64);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(133, 55);
            this.button14.TabIndex = 57;
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button15.FlatAppearance.BorderSize = 3;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button15.Location = new System.Drawing.Point(142, 64);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(133, 55);
            this.button15.TabIndex = 58;
            this.button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button16.FlatAppearance.BorderSize = 3;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button16.Location = new System.Drawing.Point(281, 64);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(133, 55);
            this.button16.TabIndex = 59;
            this.button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(420, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 55);
            this.button1.TabIndex = 60;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(559, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 55);
            this.button2.TabIndex = 61;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(3, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 55);
            this.button3.TabIndex = 62;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(142, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 55);
            this.button4.TabIndex = 63;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(281, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 55);
            this.button5.TabIndex = 64;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(420, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 55);
            this.button6.TabIndex = 65;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button11.FlatAppearance.BorderSize = 3;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.Location = new System.Drawing.Point(559, 125);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 55);
            this.button11.TabIndex = 66;
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(448, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 11;
            // 
            // FrmCapturaProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1207, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlpProductos);
            this.Controls.Add(this.FlpSubCategorias);
            this.Controls.Add(this.FlpCategorias);
            this.Controls.Add(this.FlpComanda);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmCapturaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura de Productos";
            this.Load += new System.EventHandler(this.FrmCapturaProductos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FlpComanda.ResumeLayout(false);
            this.FlpComanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComanda)).EndInit();
            this.FlpCategorias.ResumeLayout(false);
            this.FlpProductos.ResumeLayout(false);
            this.FlpSubCategorias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel FlpComanda;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnComandas;
        private System.Windows.Forms.Button BtnComentario;
        private System.Windows.Forms.Button BtnMenos;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.TextBox TxtCantProducto;
        private System.Windows.Forms.Button BtnBorrarTodo;
        private System.Windows.Forms.Button BtnBorrarProducto;
        private System.Windows.Forms.FlowLayoutPanel FlpCategorias;
        private System.Windows.Forms.Button BtnPostres;
        private System.Windows.Forms.FlowLayoutPanel FlpProductos;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.DataGridView DgvComanda;
        private System.Windows.Forms.Button BtnDescuento;
        private System.Windows.Forms.Button BtnBebidas;
        private System.Windows.Forms.Button BtnComida;
        private System.Windows.Forms.Button BtnOtros;
        private System.Windows.Forms.FlowLayoutPanel FlpSubCategorias;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMANDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
    }
}