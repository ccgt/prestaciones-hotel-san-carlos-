using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prefinal_JoseGonzalez_PercepcionDeNomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bono14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioBono14 f14 = new formularioBono14();
            f14.Show();
        }

        private void aguinaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioAguinaldo fA = new formularioAguinaldo();
            fA.Show();
        }

        private void renunciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horasExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario_HoraExtra fh = new formulario_HoraExtra();
                fh.Show();
        }

        private void horaExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioVacaciones fv = new formularioVacaciones();
            fv.Show();
        }

        private void despidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioDespido fd = new formularioDespido();
            fd.Show();
        }
    }
}
