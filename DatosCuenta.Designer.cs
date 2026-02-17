namespace Cupediarum
{
    partial class FrmDatosCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosCuenta));
            this.PnlDatosC = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAbrirMesa = new System.Windows.Forms.Button();
            this.BtnPersonas = new System.Windows.Forms.Button();
            this.BtnCuenta = new System.Windows.Forms.Button();
            this.PnlDatosCuenta = new System.Windows.Forms.Panel();
            this.TxtNombArea = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIDMesa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombMesero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIDArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlDatosC.SuspendLayout();
            this.PnlDatosCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDatosC
            // 
            this.PnlDatosC.BackColor = System.Drawing.Color.Transparent;
            this.PnlDatosC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlDatosC.Controls.Add(this.BtnCancelar);
            this.PnlDatosC.Controls.Add(this.BtnAbrirMesa);
            this.PnlDatosC.Controls.Add(this.BtnPersonas);
            this.PnlDatosC.Controls.Add(this.BtnCuenta);
            this.PnlDatosC.Location = new System.Drawing.Point(1, 3);
            this.PnlDatosC.Name = "PnlDatosC";
            this.PnlDatosC.Size = new System.Drawing.Size(639, 84);
            this.PnlDatosC.TabIndex = 0;
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
            this.BtnCancelar.Image = global::Cupediarum.Properties.Resources.Icono_Cancelar48;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(517, 6);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 70);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnAbrirMesa
            // 
            this.BtnAbrirMesa.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAbrirMesa.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnAbrirMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAbrirMesa.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnAbrirMesa.FlatAppearance.BorderSize = 3;
            this.BtnAbrirMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirMesa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirMesa.Image = global::Cupediarum.Properties.Resources.Icono_Aceptar48;
            this.BtnAbrirMesa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAbrirMesa.Location = new System.Drawing.Point(396, 5);
            this.BtnAbrirMesa.Name = "BtnAbrirMesa";
            this.BtnAbrirMesa.Size = new System.Drawing.Size(115, 70);
            this.BtnAbrirMesa.TabIndex = 13;
            this.BtnAbrirMesa.Text = "Abrir Mesa";
            this.BtnAbrirMesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbrirMesa.UseVisualStyleBackColor = false;
            this.BtnAbrirMesa.Click += new System.EventHandler(this.BtnAbrirMesa_Click);
            // 
            // BtnPersonas
            // 
            this.BtnPersonas.BackColor = System.Drawing.Color.LightCoral;
            this.BtnPersonas.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPersonas.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnPersonas.FlatAppearance.BorderSize = 3;
            this.BtnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonas.Image = global::Cupediarum.Properties.Resources.Icono_Personas48;
            this.BtnPersonas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPersonas.Location = new System.Drawing.Point(124, 4);
            this.BtnPersonas.Name = "BtnPersonas";
            this.BtnPersonas.Size = new System.Drawing.Size(115, 72);
            this.BtnPersonas.TabIndex = 11;
            this.BtnPersonas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPersonas.UseVisualStyleBackColor = false;
            // 
            // BtnCuenta
            // 
            this.BtnCuenta.BackColor = System.Drawing.Color.LightCoral;
            this.BtnCuenta.BackgroundImage = global::Cupediarum.Properties.Resources.FBAzul;
            this.BtnCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnCuenta.FlatAppearance.BorderSize = 3;
            this.BtnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuenta.Image = global::Cupediarum.Properties.Resources.Icono_Table48;
            this.BtnCuenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCuenta.Location = new System.Drawing.Point(3, 4);
            this.BtnCuenta.Name = "BtnCuenta";
            this.BtnCuenta.Size = new System.Drawing.Size(115, 72);
            this.BtnCuenta.TabIndex = 10;
            this.BtnCuenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCuenta.UseVisualStyleBackColor = false;
            // 
            // PnlDatosCuenta
            // 
            this.PnlDatosCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlDatosCuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlDatosCuenta.Controls.Add(this.TxtNombArea);
            this.PnlDatosCuenta.Controls.Add(this.DtpFecha);
            this.PnlDatosCuenta.Controls.Add(this.label6);
            this.PnlDatosCuenta.Controls.Add(this.TxtIDMesa);
            this.PnlDatosCuenta.Controls.Add(this.label5);
            this.PnlDatosCuenta.Controls.Add(this.TxtNombMesero);
            this.PnlDatosCuenta.Controls.Add(this.label3);
            this.PnlDatosCuenta.Controls.Add(this.TxtIDArea);
            this.PnlDatosCuenta.Controls.Add(this.label4);
            this.PnlDatosCuenta.Location = new System.Drawing.Point(5, 124);
            this.PnlDatosCuenta.Name = "PnlDatosCuenta";
            this.PnlDatosCuenta.Size = new System.Drawing.Size(635, 186);
            this.PnlDatosCuenta.TabIndex = 1;
            // 
            // TxtNombArea
            // 
            this.TxtNombArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombArea.Location = new System.Drawing.Point(237, 51);
            this.TxtNombArea.Name = "TxtNombArea";
            this.TxtNombArea.Size = new System.Drawing.Size(201, 35);
            this.TxtNombArea.TabIndex = 24;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(188, 134);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(141, 33);
            this.DtpFecha.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "FECHA :";
            // 
            // TxtIDMesa
            // 
            this.TxtIDMesa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDMesa.Location = new System.Drawing.Point(187, 93);
            this.TxtIDMesa.Name = "TxtIDMesa";
            this.TxtIDMesa.Size = new System.Drawing.Size(44, 35);
            this.TxtIDMesa.TabIndex = 21;
            this.TxtIDMesa.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "MESA :";
            // 
            // TxtNombMesero
            // 
            this.TxtNombMesero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombMesero.Location = new System.Drawing.Point(187, 8);
            this.TxtNombMesero.Name = "TxtNombMesero";
            this.TxtNombMesero.Size = new System.Drawing.Size(177, 35);
            this.TxtNombMesero.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "MESERO :";
            // 
            // TxtIDArea
            // 
            this.TxtIDArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDArea.Location = new System.Drawing.Point(187, 51);
            this.TxtIDArea.Name = "TxtIDArea";
            this.TxtIDArea.Size = new System.Drawing.Size(44, 35);
            this.TxtIDArea.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "AREA :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personas";
            // 
            // FrmDatosCuenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlDatosCuenta);
            this.Controls.Add(this.PnlDatosC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDatosCuenta";
            this.Text = "Datos de Cuenta";
          
            this.PnlDatosC.ResumeLayout(false);
            this.PnlDatosCuenta.ResumeLayout(false);
            this.PnlDatosCuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlDatosC;
        private System.Windows.Forms.Button BtnCuenta;
        private System.Windows.Forms.Button BtnAbrirMesa;
        private System.Windows.Forms.Button BtnPersonas;
        private System.Windows.Forms.Panel PnlDatosCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtNombMesero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIDArea;
        private System.Windows.Forms.TextBox TxtIDMesa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtNombArea;
    }
}