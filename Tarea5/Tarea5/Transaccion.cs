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
    public partial class Transaccion : Form
    {
        //Atributos de la clase.
        GestorBD.GestorBD GestorBD;
        DataSet dsGeneral = new DataSet();
        DataSet dsAut = new DataSet(), dsCong = new DataSet(), dsArt = new DataSet();
        string cadSql, cons;
        Varios.Comunes comunes = new Varios.Comunes();

        public Transaccion()
        {
            InitializeComponent();
        }

        

        private void Transaccion_Load(object sender, EventArgs e)
        {
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

            //Obtiene datos de las conferencias.
            cons = "select * from T4Presentado";                       //Consulta.
            GestorBD.consBD(cons, dsGeneral, "T4Presentado");          //Se ejecuta.
            DtgGeneral.DataSource = dsGeneral.Tables["T4Presentado"];     //Muestra resultados.
        }

        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboArticulo.Visible = true;
            //Obtiene y muestra los datos de los Articulos.
            cadSql = "select * from T4Articulo art, T4Autor a, T4Escribio e where art.idart=e.idart and e.idaut=a.idaut and a.nombre='" + cboAutor.SelectedItem + "'";
            GestorBD.consBD(cadSql, dsArt, "T4Articulo");
            comunes.cargaCombo(cboArticulo, dsArt, "T4Articulo", "Nomart");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {

        }
    }
}
