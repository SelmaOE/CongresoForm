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
        GestorBD.GestorBD GestorBD;
        DataSet dsAutor = new DataSet(), dsArticulo = new DataSet();
        string cadSql;
        Varios.Comunes comunes = new Varios.Comunes();
        public Consulta()
        {
            InitializeComponent();
        }



        private void Consulta_Load(object sender, EventArgs e)
        {
            //1- Hace la conexìón a la BD de Oracle.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd01", "linesp", "oracle");

            //2- Obtiene y muestra los datos de los autores.
            cadSql = "select * from T4Autor";
            GestorBD.consBD(cadSql, dsAutor, "T4Autor");
            comunes.cargaCombo(cboAutor, dsAutor, "T4Autor", "Nombre");
        }

        // Una forma para que dado el nombre de un autor 
        //(a través de un combo box) y una fecha (por medio de un DateTimePicker), 
        //se muestren todos los artículos que ha presentado (o presentará) a partir de esa fecha, 
        //detallando por cada artículo: co-autores, nombre de la institución en que trabaja el autor, 
        //si el artículo fue financiado o no, nombre del congreso y fecha de presentación, 
        //y total de congresos en que se ha presentado (incluidos en los que se presentará). 

        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cadSql = "";
            GestorBD.consBD(cadSql, dsArticulo, "Articulo");
            dtgGeneral.DataSource = dsArticulo.Tables["Articulo"];
            */

        }
    }
}
