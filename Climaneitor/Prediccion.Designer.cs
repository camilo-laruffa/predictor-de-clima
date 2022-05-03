namespace Climaneitor
{
    partial class Prediccion
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
            Main.pre = false;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prediccion));
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.tbTempMax = new System.Windows.Forms.TextBox();
            this.tbTempMin = new System.Windows.Forms.TextBox();
            this.tbPreMax = new System.Windows.Forms.TextBox();
            this.tbPreMin = new System.Windows.Forms.TextBox();
            this.tbHumMax = new System.Windows.Forms.TextBox();
            this.tbHumMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.btn_Prediccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAclaracion.Location = new System.Drawing.Point(7, 191);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(280, 39);
            this.lblAclaracion.TabIndex = 12;
            this.lblAclaracion.Text = "Escriba el valor porcentual de la humedad.\r\nEscriba el valor de la presion en hec" +
                "topascales.\r\nEsciba el valor de la temperatura en C°.";
            // 
            // tbTempMax
            // 
            this.tbTempMax.Location = new System.Drawing.Point(10, 33);
            this.tbTempMax.Name = "tbTempMax";
            this.tbTempMax.Size = new System.Drawing.Size(117, 20);
            this.tbTempMax.TabIndex = 18;
            // 
            // tbTempMin
            // 
            this.tbTempMin.Location = new System.Drawing.Point(10, 59);
            this.tbTempMin.Name = "tbTempMin";
            this.tbTempMin.Size = new System.Drawing.Size(117, 20);
            this.tbTempMin.TabIndex = 19;
            // 
            // tbPreMax
            // 
            this.tbPreMax.Location = new System.Drawing.Point(10, 137);
            this.tbPreMax.Name = "tbPreMax";
            this.tbPreMax.Size = new System.Drawing.Size(117, 20);
            this.tbPreMax.TabIndex = 16;
            // 
            // tbPreMin
            // 
            this.tbPreMin.Location = new System.Drawing.Point(10, 163);
            this.tbPreMin.Name = "tbPreMin";
            this.tbPreMin.Size = new System.Drawing.Size(117, 20);
            this.tbPreMin.TabIndex = 17;
            // 
            // tbHumMax
            // 
            this.tbHumMax.Location = new System.Drawing.Point(10, 85);
            this.tbHumMax.Name = "tbHumMax";
            this.tbHumMax.Size = new System.Drawing.Size(117, 20);
            this.tbHumMax.TabIndex = 14;
            // 
            // tbHumMin
            // 
            this.tbHumMin.Location = new System.Drawing.Point(10, 111);
            this.tbHumMin.Name = "tbHumMin";
            this.tbHumMin.Size = new System.Drawing.Size(117, 20);
            this.tbHumMin.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Temperatura Minima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Humedad Maxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Humedad Minima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Presion Maxima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Presion Minima";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Temperatura Maxima";
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(10, 5);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(117, 21);
            this.cbMes.TabIndex = 42;
            // 
            // btn_Prediccion
            // 
            this.btn_Prediccion.Location = new System.Drawing.Point(10, 233);
            this.btn_Prediccion.Name = "btn_Prediccion";
            this.btn_Prediccion.Size = new System.Drawing.Size(277, 44);
            this.btn_Prediccion.TabIndex = 43;
            this.btn_Prediccion.Text = "Predecir el clima";
            this.btn_Prediccion.UseVisualStyleBackColor = true;
            this.btn_Prediccion.Click += new System.EventHandler(this.btn_Prediccion_Click);
            // 
            // Prediccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 289);
            this.Controls.Add(this.btn_Prediccion);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prediccion";
            this.Text = "Predecir Clima";
            this.Load += new System.EventHandler(this.Prediccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.TextBox tbTempMax;
        private System.Windows.Forms.TextBox tbTempMin;
        private System.Windows.Forms.TextBox tbPreMax;
        private System.Windows.Forms.TextBox tbPreMin;
        private System.Windows.Forms.TextBox tbHumMax;
        private System.Windows.Forms.TextBox tbHumMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Button btn_Prediccion;
    }
}