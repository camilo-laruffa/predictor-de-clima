namespace Climaneitor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Predecir = new System.Windows.Forms.Button();
            this.btn_CargaDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Climaneitor!\r\nSeleccione alguna de las\r\nopciones para continuar";
            // 
            // btn_Predecir
            // 
            this.btn_Predecir.Location = new System.Drawing.Point(11, 107);
            this.btn_Predecir.Name = "btn_Predecir";
            this.btn_Predecir.Size = new System.Drawing.Size(261, 59);
            this.btn_Predecir.TabIndex = 1;
            this.btn_Predecir.Text = "Predecir Clima";
            this.btn_Predecir.UseVisualStyleBackColor = true;
            this.btn_Predecir.Click += new System.EventHandler(this.btn_Predecir_Click);
            // 
            // btn_CargaDatos
            // 
            this.btn_CargaDatos.Location = new System.Drawing.Point(12, 183);
            this.btn_CargaDatos.Name = "btn_CargaDatos";
            this.btn_CargaDatos.Size = new System.Drawing.Size(260, 59);
            this.btn_CargaDatos.TabIndex = 2;
            this.btn_CargaDatos.Text = "Cargar Datos";
            this.btn_CargaDatos.UseVisualStyleBackColor = true;
            this.btn_CargaDatos.Click += new System.EventHandler(this.btn_CargaDatos_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 257);
            this.Controls.Add(this.btn_CargaDatos);
            this.Controls.Add(this.btn_Predecir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Predecir;
        private System.Windows.Forms.Button btn_CargaDatos;
    }
}

