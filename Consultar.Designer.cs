namespace Cupediarum
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            this.BtnEliminarCuenta = new System.Windows.Forms.Button();
            this.BtnPrecio = new System.Windows.Forms.Button();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnPagarCuenta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnDescuento = new System.Windows.Forms.Button();
            this.PnlDatosCuenta = new System.Windows.Forms.Panel();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.LblNombMesero = new System.Windows.Forms.Label();
            this.LblNombArea = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.LblPersonas = new System.Windows.Forms.Label();
            this.LblCuenta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvComanda = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RtbComentario = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblImp = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblImpuesto = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PnlDatosCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComanda)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminarCuenta
            // 
            this.BtnEliminarCuenta.BackColor = System.Drawing.Color.Plum;
            this.BtnEliminarCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarCuenta.BackgroundImage")));
            this.BtnEliminarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarCuenta.Enabled = false;
            this.BtnEliminarCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnEliminarCuenta.FlatAppearance.BorderSize = 3;
            this.BtnEliminarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarCuenta.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCuenta.Image = global::Cupediarum.Properties.Resources.EliminarCuenta48;
            this.BtnEliminarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarCuenta.Location = new System.Drawing.Point(574, 5);
            this.BtnEliminarCuenta.Name = "BtnEliminarCuenta";
            this.BtnEliminarCuenta.Size = new System.Drawing.Size(111, 60);
            this.BtnEliminarCuenta.TabIndex = 36;
            this.BtnEliminarCuenta.Text = "Elim. Cuenta";
            this.BtnEliminarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarCuenta.UseVisualStyleBackColor = false;
            // 
            // BtnPrecio
            // 
            this.BtnPrecio.BackColor = System.Drawing.Color.Plum;
            this.BtnPrecio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrecio.BackgroundImage")));
            this.BtnPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrecio.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnPrecio.FlatAppearance.BorderSize = 3;
            this.BtnPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrecio.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrecio.Image = global::Cupediarum.Properties.Resources.Precios48;
            this.BtnPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrecio.Location = new System.Drawing.Point(123, 5);
            this.BtnPrecio.Name = "BtnPrecio";
            this.BtnPrecio.Size = new System.Drawing.Size(111, 60);
            this.BtnPrecio.TabIndex = 33;
            this.BtnPrecio.Text = "Precio";
            this.BtnPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrecio.UseVisualStyleBackColor = false;
            this.BtnPrecio.Click += new System.EventHandler(this.BtnPrecio_Click);
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.Plum;
            this.BtnEliminarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarProducto.BackgroundImage")));
            this.BtnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarProducto.Enabled = false;
            this.BtnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnEliminarProducto.FlatAppearance.BorderSize = 3;
            this.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProducto.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProducto.Image = global::Cupediarum.Properties.Resources.Delete;
            this.BtnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(457, 5);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(111, 60);
            this.BtnEliminarProducto.TabIndex = 30;
            this.BtnEliminarProducto.Text = "Elim. Producto";
            this.BtnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.Plum;
            this.BtnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.BackgroundImage")));
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnImprimir.FlatAppearance.BorderSize = 3;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Image = global::Cupediarum.Properties.Resources.Imp48;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Location = new System.Drawing.Point(356, 5);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(96, 60);
            this.BtnImprimir.TabIndex = 32;
            this.BtnImprimir.Text = "IMP.";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Plum;
            this.BtnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.BackgroundImage")));
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnAgregar.FlatAppearance.BorderSize = 3;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = global::Cupediarum.Properties.Resources.tap64;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(6, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 60);
            this.BtnAgregar.TabIndex = 31;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnPagarCuenta
            // 
            this.BtnPagarCuenta.BackColor = System.Drawing.Color.Plum;
            this.BtnPagarCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPagarCuenta.BackgroundImage")));
            this.BtnPagarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPagarCuenta.Enabled = false;
            this.BtnPagarCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnPagarCuenta.FlatAppearance.BorderSize = 3;
            this.BtnPagarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagarCuenta.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagarCuenta.Image = global::Cupediarum.Properties.Resources.Cash48;
            this.BtnPagarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPagarCuenta.Location = new System.Drawing.Point(691, 5);
            this.BtnPagarCuenta.Name = "BtnPagarCuenta";
            this.BtnPagarCuenta.Size = new System.Drawing.Size(111, 60);
            this.BtnPagarCuenta.TabIndex = 34;
            this.BtnPagarCuenta.Text = "Pagar Cuenta";
            this.BtnPagarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPagarCuenta.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.BtnPrecio);
            this.panel1.Controls.Add(this.BtnEliminarCuenta);
            this.panel1.Controls.Add(this.BtnDescuento);
            this.panel1.Controls.Add(this.BtnPagarCuenta);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnEliminarProducto);
            this.panel1.Controls.Add(this.BtnImprimir);
            this.panel1.Location = new System.Drawing.Point(6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 77);
            this.panel1.TabIndex = 37;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Plum;
            this.BtnCerrar.BackgroundImage = global::Cupediarum.Properties.Resources.FondoNaranja;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnCerrar.FlatAppearance.BorderSize = 3;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Image = global::Cupediarum.Properties.Resources.Exit32;
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrar.Location = new System.Drawing.Point(1049, 1);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(44, 40);
            this.BtnCerrar.TabIndex = 37;
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnDescuento
            // 
            this.BtnDescuento.BackColor = System.Drawing.Color.Plum;
            this.BtnDescuento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDescuento.BackgroundImage")));
            this.BtnDescuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDescuento.Enabled = false;
            this.BtnDescuento.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnDescuento.FlatAppearance.BorderSize = 3;
            this.BtnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescuento.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDescuento.Image = global::Cupediarum.Properties.Resources.Descuento48;
            this.BtnDescuento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDescuento.Location = new System.Drawing.Point(240, 5);
            this.BtnDescuento.Name = "BtnDescuento";
            this.BtnDescuento.Size = new System.Drawing.Size(111, 60);
            this.BtnDescuento.TabIndex = 35;
            this.BtnDescuento.Text = "Desc.";
            this.BtnDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDescuento.UseVisualStyleBackColor = false;
            // 
            // PnlDatosCuenta
            // 
            this.PnlDatosCuenta.BackColor = System.Drawing.Color.Transparent;
            this.PnlDatosCuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlDatosCuenta.Controls.Add(this.DtpFecha);
            this.PnlDatosCuenta.Controls.Add(this.label8);
            this.PnlDatosCuenta.Controls.Add(this.LblNombMesero);
            this.PnlDatosCuenta.Controls.Add(this.LblNombArea);
            this.PnlDatosCuenta.Controls.Add(this.label16);
            this.PnlDatosCuenta.Controls.Add(this.label14);
            this.PnlDatosCuenta.Controls.Add(this.checkBox1);
            this.PnlDatosCuenta.Controls.Add(this.label21);
            this.PnlDatosCuenta.Controls.Add(this.LblPersonas);
            this.PnlDatosCuenta.Controls.Add(this.LblCuenta);
            this.PnlDatosCuenta.Controls.Add(this.label7);
            this.PnlDatosCuenta.Controls.Add(this.label4);
            this.PnlDatosCuenta.Location = new System.Drawing.Point(6, 108);
            this.PnlDatosCuenta.Name = "PnlDatosCuenta";
            this.PnlDatosCuenta.Size = new System.Drawing.Size(1100, 96);
            this.PnlDatosCuenta.TabIndex = 38;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(713, 4);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(157, 33);
            this.DtpFecha.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(633, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Fecha";
            // 
            // LblNombMesero
            // 
            this.LblNombMesero.BackColor = System.Drawing.Color.White;
            this.LblNombMesero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNombMesero.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombMesero.ForeColor = System.Drawing.Color.Black;
            this.LblNombMesero.Location = new System.Drawing.Point(399, 6);
            this.LblNombMesero.Name = "LblNombMesero";
            this.LblNombMesero.Size = new System.Drawing.Size(140, 29);
            this.LblNombMesero.TabIndex = 40;
            this.LblNombMesero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNombArea
            // 
            this.LblNombArea.BackColor = System.Drawing.Color.White;
            this.LblNombArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNombArea.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombArea.ForeColor = System.Drawing.Color.Black;
            this.LblNombArea.Location = new System.Drawing.Point(399, 47);
            this.LblNombArea.Name = "LblNombArea";
            this.LblNombArea.Size = new System.Drawing.Size(140, 29);
            this.LblNombArea.TabIndex = 39;
            this.LblNombArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(311, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 24);
            this.label16.TabIndex = 37;
            this.label16.Text = "Mesero";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(311, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 24);
            this.label14.TabIndex = 35;
            this.label14.Text = "Area";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1068, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(978, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 24);
            this.label21.TabIndex = 33;
            this.label21.Text = "Impreso";
            // 
            // LblPersonas
            // 
            this.LblPersonas.BackColor = System.Drawing.Color.White;
            this.LblPersonas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPersonas.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonas.ForeColor = System.Drawing.Color.Black;
            this.LblPersonas.Location = new System.Drawing.Point(105, 47);
            this.LblPersonas.Name = "LblPersonas";
            this.LblPersonas.Size = new System.Drawing.Size(40, 29);
            this.LblPersonas.TabIndex = 23;
            this.LblPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCuenta
            // 
            this.LblCuenta.BackColor = System.Drawing.Color.White;
            this.LblCuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCuenta.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuenta.ForeColor = System.Drawing.Color.Black;
            this.LblCuenta.Location = new System.Drawing.Point(105, 6);
            this.LblCuenta.Name = "LblCuenta";
            this.LblCuenta.Size = new System.Drawing.Size(136, 29);
            this.LblCuenta.TabIndex = 21;
            this.LblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Personas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cuenta";
            // 
            // DgvComanda
            // 
            this.DgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.Descuento,
            this.Precio,
            this.Total,
            this.Comentario});
            this.DgvComanda.Location = new System.Drawing.Point(6, 210);
            this.DgvComanda.Name = "DgvComanda";
            this.DgvComanda.RowHeadersWidth = 62;
            this.DgvComanda.RowTemplate.Height = 28;
            this.DgvComanda.Size = new System.Drawing.Size(1100, 177);
            this.DgvComanda.TabIndex = 39;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Desc.";
            this.Descuento.MinimumWidth = 8;
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 180;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.Width = 180;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 180;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.MinimumWidth = 8;
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Width = 300;
            // 
            // RtbComentario
            // 
            this.RtbComentario.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbComentario.Location = new System.Drawing.Point(6, 418);
            this.RtbComentario.Name = "RtbComentario";
            this.RtbComentario.Size = new System.Drawing.Size(388, 103);
            this.RtbComentario.TabIndex = 42;
            this.RtbComentario.Text = "";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(6, 394);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 25);
            this.label23.TabIndex = 41;
            this.label23.Text = "Comentario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.LblImp);
            this.panel3.Controls.Add(this.LblSubTotal);
            this.panel3.Controls.Add(this.LblDescuento);
            this.panel3.Controls.Add(this.LblTotal);
            this.panel3.Controls.Add(this.LblImpuesto);
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.label36);
            this.panel3.Controls.Add(this.label37);
            this.panel3.Controls.Add(this.label38);
            this.panel3.Location = new System.Drawing.Point(770, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 184);
            this.panel3.TabIndex = 40;
            // 
            // LblImp
            // 
            this.LblImp.BackColor = System.Drawing.Color.Transparent;
            this.LblImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblImp.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImp.ForeColor = System.Drawing.Color.White;
            this.LblImp.Location = new System.Drawing.Point(135, 96);
            this.LblImp.Name = "LblImp";
            this.LblImp.Size = new System.Drawing.Size(77, 30);
            this.LblImp.TabIndex = 27;
            this.LblImp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.BackColor = System.Drawing.Color.White;
            this.LblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSubTotal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.ForeColor = System.Drawing.Color.Black;
            this.LblSubTotal.Location = new System.Drawing.Point(135, 9);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(194, 30);
            this.LblSubTotal.TabIndex = 26;
            this.LblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDescuento
            // 
            this.LblDescuento.BackColor = System.Drawing.Color.Transparent;
            this.LblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDescuento.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescuento.ForeColor = System.Drawing.Color.White;
            this.LblDescuento.Location = new System.Drawing.Point(218, 51);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(111, 30);
            this.LblDescuento.TabIndex = 25;
            this.LblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTotal
            // 
            this.LblTotal.BackColor = System.Drawing.Color.White;
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Black;
            this.LblTotal.Location = new System.Drawing.Point(135, 140);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(194, 30);
            this.LblTotal.TabIndex = 24;
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblImpuesto
            // 
            this.LblImpuesto.BackColor = System.Drawing.Color.White;
            this.LblImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblImpuesto.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImpuesto.ForeColor = System.Drawing.Color.Black;
            this.LblImpuesto.Location = new System.Drawing.Point(220, 96);
            this.LblImpuesto.Name = "LblImpuesto";
            this.LblImpuesto.Size = new System.Drawing.Size(109, 30);
            this.LblImpuesto.TabIndex = 23;
            this.LblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(9, 147);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 22);
            this.label35.TabIndex = 20;
            this.label35.Text = "TOTAL";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(7, 103);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(105, 22);
            this.label36.TabIndex = 19;
            this.label36.Text = "IMPUESTO";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(7, 59);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(120, 22);
            this.label37.TabIndex = 18;
            this.label37.Text = "DESCUENTO";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(7, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(106, 22);
            this.label38.TabIndex = 17;
            this.label38.Text = "SUBTOTAL";
            // 
            // FrmConsultar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Cupediarum.Properties.Resources.FondoDg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 578);
            this.Controls.Add(this.RtbComentario);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DgvComanda);
            this.Controls.Add(this.PnlDatosCuenta);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            this.panel1.ResumeLayout(false);
            this.PnlDatosCuenta.ResumeLayout(false);
            this.PnlDatosCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComanda)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminarCuenta;
        private System.Windows.Forms.Button BtnPrecio;
        private System.Windows.Forms.Button BtnEliminarProducto;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnPagarCuenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDescuento;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel PnlDatosCuenta;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblNombMesero;
        private System.Windows.Forms.Label LblNombArea;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label LblPersonas;
        private System.Windows.Forms.Label LblCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvComanda;
        private System.Windows.Forms.RichTextBox RtbComentario;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblImp;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblDescuento;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblImpuesto;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
    }
}