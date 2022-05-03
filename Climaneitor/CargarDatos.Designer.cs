namespace Climaneitor
{
    partial class CargarDatos
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
            Main.cd = false;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarDatos));
            this.ckLlovio = new System.Windows.Forms.CheckBox();
            this.btn_CargarDatos = new System.Windows.Forms.Button();
            this.btn_Entrenar = new System.Windows.Forms.Button();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTempMax = new System.Windows.Forms.TextBox();
            this.tbTempMin = new System.Windows.Forms.TextBox();
            this.tbPreMax = new System.Windows.Forms.TextBox();
            this.tbPreMin = new System.Windows.Forms.TextBox();
            this.tbHumMax = new System.Windows.Forms.TextBox();
            this.tbHumMin = new System.Windows.Forms.TextBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ckLlovio
            // 
            this.ckLlovio.AutoSize = true;
            this.ckLlovio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckLlovio.Location = new System.Drawing.Point(250, 12);
            this.ckLlovio.Name = "ckLlovio";
            this.ckLlovio.Size = new System.Drawing.Size(69, 20);
            this.ckLlovio.TabIndex = 8;
            this.ckLlovio.Text = "Llovio";
            this.ckLlovio.UseVisualStyleBackColor = true;
            // 
            // btn_CargarDatos
            // 
            this.btn_CargarDatos.Location = new System.Drawing.Point(250, 39);
            this.btn_CargarDatos.Name = "btn_CargarDatos";
            this.btn_CargarDatos.Size = new System.Drawing.Size(267, 44);
            this.btn_CargarDatos.TabIndex = 9;
            this.btn_CargarDatos.Text = "Cargar Datos";
            this.btn_CargarDatos.UseVisualStyleBackColor = true;
            this.btn_CargarDatos.Click += new System.EventHandler(this.btn_CargarDatos_Click);
            // 
            // btn_Entrenar
            // 
            this.btn_Entrenar.Location = new System.Drawing.Point(250, 87);
            this.btn_Entrenar.Name = "btn_Entrenar";
            this.btn_Entrenar.Size = new System.Drawing.Size(267, 44);
            this.btn_Entrenar.TabIndex = 10;
            this.btn_Entrenar.Text = "Entrenar";
            this.btn_Entrenar.UseVisualStyleBackColor = true;
            this.btn_Entrenar.Click += new System.EventHandler(this.btn_Entrenar_Click);
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAclaracion.Location = new System.Drawing.Point(247, 144);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(280, 39);
            this.lblAclaracion.TabIndex = 11;
            this.lblAclaracion.Text = "Escriba el valor porcentual de la humedad.\r\nEscriba el valor de la presion en hec" +
                "topascales.\r\nEsciba el valor de la temperatura en C°.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Temperatura Maxima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Presion Minima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Presion Maxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Humedad Minima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Humedad Maxima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Temperatura Minima";
            // 
            // tbTempMax
            // 
            this.tbTempMax.Location = new System.Drawing.Point(12, 37);
            this.tbTempMax.Name = "tbTempMax";
            this.tbTempMax.Size = new System.Drawing.Size(117, 20);
            this.tbTempMax.TabIndex = 32;
            // 
            // tbTempMin
            // 
            this.tbTempMin.Location = new System.Drawing.Point(12, 63);
            this.tbTempMin.Name = "tbTempMin";
            this.tbTempMin.Size = new System.Drawing.Size(117, 20);
            this.tbTempMin.TabIndex = 33;
            // 
            // tbPreMax
            // 
            this.tbPreMax.Location = new System.Drawing.Point(12, 141);
            this.tbPreMax.Name = "tbPreMax";
            this.tbPreMax.Size = new System.Drawing.Size(117, 20);
            this.tbPreMax.TabIndex = 30;
            // 
            // tbPreMin
            // 
            this.tbPreMin.Location = new System.Drawing.Point(12, 167);
            this.tbPreMin.Name = "tbPreMin";
            this.tbPreMin.Size = new System.Drawing.Size(117, 20);
            this.tbPreMin.TabIndex = 31;
            // 
            // tbHumMax
            // 
            this.tbHumMax.Location = new System.Drawing.Point(12, 89);
            this.tbHumMax.Name = "tbHumMax";
            this.tbHumMax.Size = new System.Drawing.Size(117, 20);
            this.tbHumMax.TabIndex = 28;
            // 
            // tbHumMin
            // 
            this.tbHumMin.Location = new System.Drawing.Point(12, 115);
            this.tbHumMin.Name = "tbHumMin";
            this.tbHumMin.Size = new System.Drawing.Size(117, 20);
            this.tbHumMin.TabIndex = 29;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(12, 8);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(117, 21);
            this.cbMes.TabIndex = 41;
            // 
            // CargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(531, 197);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTempMax);
            this.Controls.Add(this.tbTempMin);
            this.Controls.Add(this.tbPreMax);
            this.Controls.Add(this.tbPreMin);
            this.Controls.Add(this.tbHumMax);
            this.Controls.Add(this.tbHumMin);
            this.Controls.Add(this.lblAclaracion);
            this.Controls.Add(this.btn_Entrenar);
            this.Controls.Add(this.btn_CargarDatos);
            this.Controls.Add(this.ckLlovio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CargarDatos";
            this.Text = "Cargar Datos";
            this.Load += new System.EventHandler(this.CargarDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckLlovio;
        private System.Windows.Forms.Button btn_CargarDatos;
        private System.Windows.Forms.Button btn_Entrenar;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTempMax;
        private System.Windows.Forms.TextBox tbTempMin;
        private System.Windows.Forms.TextBox tbPreMax;
        private System.Windows.Forms.TextBox tbPreMin;
        private System.Windows.Forms.TextBox tbHumMax;
        private System.Windows.Forms.TextBox tbHumMin;
        private System.Windows.Forms.ComboBox cbMes;
    }
}