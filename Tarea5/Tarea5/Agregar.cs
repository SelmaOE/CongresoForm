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
    public partial class Agregar : Form {
        //Atributos de la clase.
        GestorBD.GestorBD GestorBD;
        DataSet dsAut = new DataSet(), dsCong= new DataSet();
        string cadSql;
        Varios.Comunes comunes = new Varios.Comunes();

        public Agregar() {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e) {
            //1- Hace la conexìón a la BD de Oracle.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd01", "linesp", "oracle");

            //2- Obtiene y muestra los datos de los autores.
            cadSql = "select * from T4Autor";
            GestorBD.consBD(cadSql, dsAut, "T4Autor");
            comunes.cargaCombo(cboAutor, dsAut, "T4Autor", "Nombre");

            //3- Obtiene y muestra los datos de los Congresos.
            cadSql = "select * from T4Congreso";
            GestorBD.consBD(cadSql, dsCong, "T4Congreso");
            comunes.cargaCombo(cboCongreso, dsCong, "T4Congreso", "Nombre");

            //4- Obtiene y muestra los datos de los Articulos.
            //incompleto
            cadSql = "select * from T4Articulo art, T4Autor a, T4Escribio where art.idart= and a.nombre='"+cboAutor.SelectedItem+"'";
            GestorBD.consBD(cadSql, dsAut, "T4Autor");
            comunes.cargaCombo(cboAutor, dsAut, "T4Autor", "Nombre");



        }
    }
}
