using ProyectoFinal.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RUsuarios rg = new RUsuarios();
            rg.Show();
        }

    }
}
