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
    public partial class Consulta : Form
    {
        private GestorBD.GestorBD GestorBD;
        private DataSet dsAutor = new DataSet();
        private string cadSql;
        public Consulta()
        {
            InitializeComponent();
        }


        private void FrmGestorBD_Load(object sender, EventArgs e)
        {

            //1- Hace la conexìón a la BD de Oracle.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd01", "linesp", "oracle");

            //2- Obtiene y muestra los datos de los autores.
            cadSql = "select * from T4Autor";
            GestorBD.consBD(cadSql, dsAutor, "Autor");
            dtgGeneral.DataSource = dsAutor.Tables["Autor"];
            Comunes.cargaCombo(cboAutor, dsAutor, "Autor", "Nombre");

           
        }


        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadSql = "";
        }
    }
}
