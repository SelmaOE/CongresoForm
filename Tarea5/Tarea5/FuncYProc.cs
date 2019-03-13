using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5 {
    public partial class FuncYProc : Form {
        //Atributos de la clase.
        GestorBD.GestorBD GestorBD;
        DataSet dsOrg = new DataSet();
        string cadSql;
        Varios.Comunes comunes = new Varios.Comunes();

        public FuncYProc() {
            InitializeComponent();
        }
        private void FuncYProc_Load(object sender, EventArgs e) {
            //1- Hace la conexìón a la BD de Oracle.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd01", "linesp", "oracle");

            //2- Obtiene y muestra los datos de las organizaciones.
            cadSql = "select * from T4Organizacion";
            GestorBD.consBD(cadSql, dsOrg, "T4Organizacion");
            comunes.cargaCombo(cboOrg, dsOrg, "T4Organizacion", "Nombre");
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        

        private void button2_Click(object sender, EventArgs e) {

        }
    }
}
