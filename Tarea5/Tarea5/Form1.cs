using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void procesosToolStripMenuItem_Click_1(object sender, EventArgs e) {
            FuncYProc fp = new FuncYProc();
            fp.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta fc = new Consulta();
            fc.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar fa = new Agregar();
            fa.ShowDialog();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaccion t = new Transaccion();
            t.ShowDialog();
        }
    }
}
