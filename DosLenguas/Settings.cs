using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosLenguas
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBoxdir.Text = propiedades.Default.dirsound;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            propiedades.Default.dirsound = textBoxdir.Text;
            propiedades.Default.Save();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
