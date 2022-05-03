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
    public partial class Main : Form
    {
        public static bool pre = false;
        public static bool cd = false;
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Predecir_Click(object sender, EventArgs e)
        {
            if (!Main.pre)
            {
                Prediccion pre_form = new Prediccion();
                Main.pre = true;
                pre_form.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_CargaDatos_Click(object sender, EventArgs e)
        {
            if (!Main.cd)
            {
                CargarDatos cd_form = new CargarDatos();
                Main.cd = true;
                cd_form.Show();
            }
        }
    }
}
