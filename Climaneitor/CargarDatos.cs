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
    public partial class CargarDatos : Form
    {
        const double TASA_APRENDE = 0.3f;

        public CargarDatos()
        {
            InitializeComponent();
        }


        private void btn_CargarDatos_Click(object sender, EventArgs e)
        {

            string mes = cbMes.Text;
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
            BaseDatos.addPronostico(mes, humMax, humMin, presMax, presMin, tempMax, tempMin, ckLlovio.Checked);
            limpiarTexto();
        }
        private void limpiarTexto()
        {
            tbHumMax.Clear();
            tbHumMin.Clear();
            tbPreMax.Clear();
            tbPreMin.Clear();
            tbTempMax.Clear();
            tbTempMin.Clear();
            ckLlovio.Checked = false;
        }

        private void btn_Entrenar_Click(object sender, EventArgs e)
        {

            btn_Entrenar.Text = "Entrenando...";
            btn_Entrenar.Enabled = false;



            List<double[]> datos;

            Random rnd = new Random();
            double[] pesos = new double[4];
            double salidaReal = 0;
            int salidaEntera;

            bool aprendiendo = true;
            /*Recorre todos los datos de la base de datos
            y compara que los pesos apliquen a todos los casos, pudiendo llegar asi al resultado esperado
             * en caso de que el resultado no sea el esperado, se vuelve a recorrer desde el primer dato
             */
            // El codigo entrena cada peso dependiendo del mes en el que esta, usando la variable messi(mes siguiente indice)
            for (int messi = 1; messi < 13; messi++)
            {
                datos = BaseDatos.getPronosticos(messi);
                pesos = BaseDatos.getPesos(messi);
                if (pesos[0] == 0) for (int i = 0; i < 4; i++) pesos[i] = rnd.NextDouble();
                aprendiendo = true;
                while (aprendiendo)
                {
                    aprendiendo = false;
                    foreach (double[] dato in datos)
                    {
                        salidaReal = (dato[1] - dato[2]) * pesos[0] + (dato[3] - dato[4]) * pesos[1] + (dato[5] - dato[6]) * pesos[2] + pesos[3];
                        if (salidaReal > 0) salidaEntera = 1;
                        else salidaEntera = 0;

                        int error = (int)Math.Floor(dato[0]) - salidaEntera;

                        if (salidaEntera != dato[0])
                        {
                            aprendiendo = true;
                            pesos[0] += TASA_APRENDE * error * (dato[1] - dato[2]);
                            pesos[1] += TASA_APRENDE * error * (dato[3] - dato[4]);
                            pesos[2] += TASA_APRENDE * error * (dato[5] - dato[6]);
                            pesos[3] += TASA_APRENDE * error;
                            Console.WriteLine("Estamos en el mes:" + messi);
                            Console.WriteLine("Peso 1:{0} Peso 2:{1} Peso 3:{2} Peso 4:{3} SalidaReal:{6}SalidaEntera:{4} Salida esperada: {5}", pesos[0], pesos[1], pesos[2], pesos[3], salidaEntera, dato[0], salidaReal);
                        }
                    }
                }
                BaseDatos.modPesos(messi, pesos[0], pesos[1], pesos[2], pesos[3]);
            }
            btn_Entrenar.Text = "Entrenar";
            btn_Entrenar.Enabled = true;
        }

        private void CargarDatos_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                cbMes.Items.Add(i);
            }
        }
    }
}


