using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Climaneitor
{
    public partial class Prediccion : Form
    {
        public Prediccion()
        {
            InitializeComponent();
        }

        
        private void Prediccion_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
            Application.Exit();
        }

        private void btn_Prediccion_Click(object sender, EventArgs e)
        {
            try
            {
                double[] pesos = new double[4];
                int mes = int.Parse(cbMes.SelectedItem.ToString());

                pesos = BaseDatos.getPesos(mes);
                double
                    humMax,
                    humMin,
                    presMax,
                    presMin,
                    tempMax,
                    tempMin;
                if (
                    !double.TryParse(tbHumMax.Text, out humMax) ||
                    !double.TryParse(tbHumMin.Text, out humMin) ||
                    !double.TryParse(tbPreMax.Text, out presMax) ||
                    !double.TryParse(tbPreMin.Text, out presMin) ||
                    !double.TryParse(tbTempMax.Text, out tempMax) ||
                    !double.TryParse(tbTempMin.Text, out tempMin)
                )
                {
                    MessageBox.Show("Revise que haya escrito bien los datos", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if ((tempMax - tempMin) * pesos[0] + (humMax - humMin) * pesos[1] +(presMax - presMin) * pesos[2] + pesos[3] > 0)
                    {
                        MessageBox.Show("Es probable que llueva", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Es probable que no llueva", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception exx) {
                 MessageBox.Show("Error insesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }

        private void Prediccion_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                cbMes.Items.Add(i);
            }
        }

     

        
   }       
}

