namespace Cupediarum
{
    partial class FrmPagarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagarCuenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnPropina = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.BtnNum7 = new System.Windows.Forms.Button();
            this.BtnNum8 = new System.Windows.Forms.Button();
            this.BtnNum9 = new System.Windows.Forms.Button();
            this.BtnNum4 = new System.Windows.Forms.Button();
            this.BtnNum5 = new System.Windows.Forms.Button();
            this.BtnNum6 = new System.Windows.Forms.Button();
            this.BtnNum1 = new System.Windows.Forms.Button();
            this.BtnNum2 = new System.Windows.Forms.Button();
            this.BtnNum3 = new System.Windows.Forms.Button();
            this.BtnNum0 = new System.Windows.Forms.Button();
            this.BtnPunto = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPropina = new System.Windows.Forms.TextBox();
            this.TxtConsumo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtCambio = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtTarjeta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvPagos = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtTot = new System.Windows.Forms.TextBox();
            this.TxtProp = new System.Windows.Forms.TextBox();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagos)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.BtnPropina);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(131, 444);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Cupediarum.Properties.Resources.Cash48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "EFECTIVO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnMetodo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Cupediarum.Properties.Resources.VISA48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "VISA";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnMetodo_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Plum;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Cupediarum.Properties.Resources.Mastercard48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(3, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "MASTERCARD";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtnMetodo_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Plum;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Cupediarum.Properties.Resources.American48;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(3, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 81);
            this.button4.TabIndex = 3;
            this.button4.Text = "AMERICAN EXPRESS";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnMetodo_Click);
            // 
            // BtnPropina
            // 
            this.BtnPropina.BackColor = System.Drawing.Color.Plum;
            this.BtnPropina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPropina.BackgroundImage")));
            this.BtnPropina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPropina.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnPropina.FlatAppearance.BorderSize = 3;
            this.BtnPropina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPropina.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPropina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPropina.Location = new System.Drawing.Point(3, 351);
            this.BtnPropina.Name = "BtnPropina";
            this.BtnPropina.Size = new System.Drawing.Size(119, 81);
            this.BtnPropina.TabIndex = 5;
            this.BtnPropina.Text = "PROPINA";
            this.BtnPropina.UseVisualStyleBackColor = false;
            this.BtnPropina.Click += new System.EventHandler(this.BtnPropina_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.TxtMonto);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum7);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum8);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum9);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum4);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum5);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum6);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum1);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum2);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum3);
            this.flowLayoutPanel2.Controls.Add(this.BtnNum0);
            this.flowLayoutPanel2.Controls.Add(this.BtnPunto);
            this.flowLayoutPanel2.Controls.Add(this.BtnBorrar);
            this.flowLayoutPanel2.Controls.Add(this.BtnEnter);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(153, 59);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(285, 419);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // TxtMonto
            // 
            this.TxtMonto.BackColor = System.Drawing.Color.Black;
            this.TxtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMonto.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.ForeColor = System.Drawing.Color.Lime;
            this.TxtMonto.Location = new System.Drawing.Point(3, 3);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(273, 53);
            this.TxtMonto.TabIndex = 0;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnNum7
            // 
            this.BtnNum7.BackColor = System.Drawing.Color.Plum;
            this.BtnNum7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum7.BackgroundImage")));
            this.BtnNum7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum7.FlatAppearance.BorderSize = 3;
            this.BtnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum7.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum7.Location = new System.Drawing.Point(3, 62);
            this.BtnNum7.Name = "BtnNum7";
            this.BtnNum7.Size = new System.Drawing.Size(87, 65);
            this.BtnNum7.TabIndex = 20;
            this.BtnNum7.Text = "7";
            this.BtnNum7.UseVisualStyleBackColor = false;
            this.BtnNum7.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnNum8
            // 
            this.BtnNum8.BackColor = System.Drawing.Color.Plum;
            this.BtnNum8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum8.BackgroundImage")));
            this.BtnNum8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum8.FlatAppearance.BorderSize = 3;
            this.BtnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum8.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum8.Location = new System.Drawing.Point(96, 62);
            this.BtnNum8.Name = "BtnNum8";
            this.BtnNum8.Size = new System.Drawing.Size(87, 65);
            this.BtnNum8.TabIndex = 21;
            this.BtnNum8.Text = "8";
            this.BtnNum8.UseVisualStyleBackColor = false;
            this.BtnNum8.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnNum9
            // 
            this.BtnNum9.BackColor = System.Drawing.Color.Plum;
            this.BtnNum9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum9.BackgroundImage")));
            this.BtnNum9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum9.FlatAppearance.BorderSize = 3;
            this.BtnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum9.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum9.Location = new System.Drawing.Point(189, 62);
            this.BtnNum9.Name = "BtnNum9";
            this.BtnNum9.Size = new System.Drawing.Size(87, 65);
            this.BtnNum9.TabIndex = 22;
            this.BtnNum9.Text = "9";
            this.BtnNum9.UseVisualStyleBackColor = false;
            this.BtnNum9.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnNum4
            // 
            this.BtnNum4.BackColor = System.Drawing.Color.Plum;
            this.BtnNum4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum4.BackgroundImage")));
            this.BtnNum4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum4.FlatAppearance.BorderSize = 3;
            this.BtnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum4.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum4.Location = new System.Drawing.Point(3, 133);
            this.BtnNum4.Name = "BtnNum4";
            this.BtnNum4.Size = new System.Drawing.Size(87, 65);
            this.BtnNum4.TabIndex = 23;
            this.BtnNum4.Text = "4";
            this.BtnNum4.UseVisualStyleBackColor = false;
            this.BtnNum4.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnNum5
            // 
            this.BtnNum5.BackColor = System.Drawing.Color.Plum;
            this.BtnNum5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum5.BackgroundImage")));
            this.BtnNum5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum5.FlatAppearance.BorderSize = 3;
            this.BtnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum5.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum5.Location = new System.Drawing.Point(96, 133);
            this.BtnNum5.Name = "BtnNum5";
            this.BtnNum5.Size = new System.Drawing.Size(87, 65);
            this.BtnNum5.TabIndex = 24;
            this.BtnNum5.Text = "5";
            this.BtnNum5.UseVisualStyleBackColor = false;
            this.BtnNum5.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnNum6
            // 
            this.BtnNum6.BackColor = System.Drawing.Color.Plum;
            this.BtnNum6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum6.BackgroundImage")));
            this.BtnNum6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum6.FlatAppearance.BorderSize = 3;
            this.BtnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum6.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum6.Location = new System.Drawing.Point(189, 133);
            this.BtnNum6.Name = "BtnNum6";
            this.BtnNum6.Size = new System.Drawing.Size(87, 65);
            this.BtnNum6.TabIndex = 25;
            this.BtnNum6.Text = "6";
            this.BtnNum6.UseVisualStyleBackColor = false;
            this.BtnNum6.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnNum1
            // 
            this.BtnNum1.BackColor = System.Drawing.Color.Plum;
            this.BtnNum1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum1.BackgroundImage")));
            this.BtnNum1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum1.FlatAppearance.BorderSize = 3;
            this.BtnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum1.Location = new System.Drawing.Point(3, 204);
            this.BtnNum1.Name = "BtnNum1";
            this.BtnNum1.Size = new System.Drawing.Size(87, 65);
            this.BtnNum1.TabIndex = 26;
            this.BtnNum1.Text = "1";
            this.BtnNum1.UseVisualStyleBackColor = false;
            this.BtnNum1.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnNum2
            // 
            this.BtnNum2.BackColor = System.Drawing.Color.Plum;
            this.BtnNum2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum2.BackgroundImage")));
            this.BtnNum2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum2.FlatAppearance.BorderSize = 3;
            this.BtnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum2.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum2.Location = new System.Drawing.Point(96, 204);
            this.BtnNum2.Name = "BtnNum2";
            this.BtnNum2.Size = new System.Drawing.Size(87, 65);
            this.BtnNum2.TabIndex = 27;
            this.BtnNum2.Text = "2";
            this.BtnNum2.UseVisualStyleBackColor = false;
            this.BtnNum2.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnNum3
            // 
            this.BtnNum3.BackColor = System.Drawing.Color.Plum;
            this.BtnNum3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum3.BackgroundImage")));
            this.BtnNum3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum3.FlatAppearance.BorderSize = 3;
            this.BtnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum3.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum3.Location = new System.Drawing.Point(189, 204);
            this.BtnNum3.Name = "BtnNum3";
            this.BtnNum3.Size = new System.Drawing.Size(87, 65);
            this.BtnNum3.TabIndex = 28;
            this.BtnNum3.Text = "3";
            this.BtnNum3.UseVisualStyleBackColor = false;
            this.BtnNum3.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnNum0
            // 
            this.BtnNum0.BackColor = System.Drawing.Color.Plum;
            this.BtnNum0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNum0.BackgroundImage")));
            this.BtnNum0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNum0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNum0.FlatAppearance.BorderSize = 3;
            this.BtnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum0.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum0.Location = new System.Drawing.Point(3, 275);
            this.BtnNum0.Name = "BtnNum0";
            this.BtnNum0.Size = new System.Drawing.Size(87, 65);
            this.BtnNum0.TabIndex = 48;
            this.BtnNum0.Text = "0";
            this.BtnNum0.UseVisualStyleBackColor = false;
            this.BtnNum0.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnPunto
            // 
            this.BtnPunto.BackColor = System.Drawing.Color.Plum;
            this.BtnPunto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPunto.BackgroundImage")));
            this.BtnPunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPunto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPunto.FlatAppearance.BorderSize = 3;
            this.BtnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPunto.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPunto.Location = new System.Drawing.Point(96, 275);
            this.BtnPunto.Name = "BtnPunto";
            this.BtnPunto.Size = new System.Drawing.Size(87, 65);
            this.BtnPunto.TabIndex = 49;
            this.BtnPunto.Text = ".";
            this.BtnPunto.UseVisualStyleBackColor = false;
            this.BtnPunto.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.Plum;
            this.BtnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBorrar.BackgroundImage")));
            this.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBorrar.FlatAppearance.BorderSize = 3;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(189, 275);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(87, 65);
            this.BtnBorrar.TabIndex = 50;
            this.BtnBorrar.Text = "BORRAR";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.Plum;
            this.BtnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEnter.BackgroundImage")));
            this.BtnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEnter.FlatAppearance.BorderSize = 3;
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.Location = new System.Drawing.Point(3, 346);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(273, 65);
            this.BtnEnter.TabIndex = 51;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxtPropina);
            this.panel1.Controls.Add(this.TxtConsumo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(451, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 76);
            this.panel1.TabIndex = 53;
            // 
            // TxtPropina
            // 
            this.TxtPropina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPropina.Location = new System.Drawing.Point(186, 32);
            this.TxtPropina.Name = "TxtPropina";
            this.TxtPropina.ReadOnly = true;
            this.TxtPropina.Size = new System.Drawing.Size(168, 35);
            this.TxtPropina.TabIndex = 3;
            // 
            // TxtConsumo
            // 
            this.TxtConsumo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConsumo.Location = new System.Drawing.Point(3, 32);
            this.TxtConsumo.Name = "TxtConsumo";
            this.TxtConsumo.ReadOnly = true;
            this.TxtConsumo.Size = new System.Drawing.Size(168, 35);
            this.TxtConsumo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROPINA";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSUMO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtCambio);
            this.panel2.Controls.Add(this.TxtTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(451, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 76);
            this.panel2.TabIndex = 54;
            // 
            // TxtCambio
            // 
            this.TxtCambio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCambio.ForeColor = System.Drawing.Color.Red;
            this.TxtCambio.Location = new System.Drawing.Point(186, 31);
            this.TxtCambio.Name = "TxtCambio";
            this.TxtCambio.Size = new System.Drawing.Size(168, 35);
            this.TxtCambio.TabIndex = 3;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.Red;
            this.TxtTotal.Location = new System.Drawing.Point(3, 31);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(168, 35);
            this.TxtTotal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(182, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "CAMBIO";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "TOTAL M.N";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.TxtTarjeta);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(451, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 50);
            this.panel3.TabIndex = 55;
            // 
            // TxtTarjeta
            // 
            this.TxtTarjeta.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTarjeta.Location = new System.Drawing.Point(110, 10);
            this.TxtTarjeta.Name = "TxtTarjeta";
            this.TxtTarjeta.ReadOnly = true;
            this.TxtTarjeta.Size = new System.Drawing.Size(244, 30);
            this.TxtTarjeta.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "TARJETA";
            // 
            // DgvPagos
            // 
            this.DgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Descripcion,
            this.Importe,
            this.Propina,
            this.Total});
            this.DgvPagos.Location = new System.Drawing.Point(451, 258);
            this.DgvPagos.Name = "DgvPagos";
            this.DgvPagos.ReadOnly = true;
            this.DgvPagos.RowHeadersVisible = false;
            this.DgvPagos.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvPagos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPagos.RowTemplate.Height = 28;
            this.DgvPagos.Size = new System.Drawing.Size(625, 211);
            this.DgvPagos.TabIndex = 56;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 8;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 8;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 130;
            // 
            // Propina
            // 
            this.Propina.HeaderText = "Propina";
            this.Propina.MinimumWidth = 8;
            this.Propina.Name = "Propina";
            this.Propina.ReadOnly = true;
            this.Propina.Width = 130;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 130;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaldo.Location = new System.Drawing.Point(567, 481);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.ReadOnly = true;
            this.TxtSaldo.Size = new System.Drawing.Size(117, 30);
            this.TxtSaldo.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(483, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "SALDO";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.TxtTot);
            this.panel4.Controls.Add(this.TxtProp);
            this.panel4.Controls.Add(this.TxtImporte);
            this.panel4.Location = new System.Drawing.Point(694, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 40);
            this.panel4.TabIndex = 59;
            // 
            // TxtTot
            // 
            this.TxtTot.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTot.Location = new System.Drawing.Point(260, 3);
            this.TxtTot.Name = "TxtTot";
            this.TxtTot.ReadOnly = true;
            this.TxtTot.Size = new System.Drawing.Size(112, 30);
            this.TxtTot.TabIndex = 61;
            this.TxtTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtProp
            // 
            this.TxtProp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProp.Location = new System.Drawing.Point(129, 3);
            this.TxtProp.Name = "TxtProp";
            this.TxtProp.ReadOnly = true;
            this.TxtProp.Size = new System.Drawing.Size(125, 30);
            this.TxtProp.TabIndex = 60;
            this.TxtProp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporte.Location = new System.Drawing.Point(3, 3);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.ReadOnly = true;
            this.TxtImporte.Size = new System.Drawing.Size(120, 30);
            this.TxtImporte.TabIndex = 59;
            this.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Plum;
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatAppearance.BorderSize = 3;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Cupediarum.Properties.Resources.Cancelar32;
            this.BtnCancelar.Location = new System.Drawing.Point(1037, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(51, 38);
            this.BtnCancelar.TabIndex = 52;
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Plum;
            this.BtnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.BackgroundImage")));
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnAceptar.FlatAppearance.BorderSize = 3;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Image = global::Cupediarum.Properties.Resources.Aceptar32;
            this.BtnAceptar.Location = new System.Drawing.Point(983, 5);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(51, 38);
            this.BtnAceptar.TabIndex = 51;
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmPagarCuenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 524);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvPagos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmPagarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagarCuenta";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Button BtnNum7;
        private System.Windows.Forms.Button BtnNum8;
        private System.Windows.Forms.Button BtnNum9;
        private System.Windows.Forms.Button BtnNum4;
        private System.Windows.Forms.Button BtnNum5;
        private System.Windows.Forms.Button BtnNum6;
        private System.Windows.Forms.Button BtnNum1;
        private System.Windows.Forms.Button BtnNum2;
        private System.Windows.Forms.Button BtnNum3;
        private System.Windows.Forms.Button BtnNum0;
        private System.Windows.Forms.Button BtnPunto;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtPropina;
        private System.Windows.Forms.TextBox TxtConsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtCambio;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtTarjeta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvPagos;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtTot;
        private System.Windows.Forms.TextBox TxtProp;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.Button BtnPropina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}