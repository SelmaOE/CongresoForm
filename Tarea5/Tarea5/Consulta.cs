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
        DataSet dsAutor = new DataSet(), dsArticulo = new DataSet(), dsCoaut = new DataSet(), dsNoCong = new DataSet();
        string cadSql, cadSql2;
        Varios.Comunes comunes = new Varios.Comunes();
        public Consulta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            cadSql = "select a.nombre, o.nombre as Trabaja, art.nomArt as Articulo, c.nombre as Congreso, e.IdBeca, p.fecha " +
               "from T4Autor a, T4Escribio e, T4Articulo art, T4Presentado p, T4Congreso c, T4ORganizacion o " +
               "where  c.idCong = p.idCong and p.idArt = e.idArt and e.idAut = a.idAut " +
               "and e.idArt = art.idArt and a.idOrg = o.idOrg " +
               "and a.idaut in (select a.idAut " +
               "from T4Escribio e, T4Autor a, T4Presentado p " +
               "where p.idArt = e.idArt and e.idAut = a.idAut and p.fecha>='" + dtpFecha.Value.Day + "-" + dtpFecha.Value.Month +
               "-" + dtpFecha.Value.Year + "' and p.idAut = (select p.idAut " +
               "from T4Presentado p, T4Autor a " +
               "where p.idAut = a.idAut and a.nombre='" + cboAutor.Text + "'))";


            GestorBD.consBD(cadSql, dsCoaut, "Coaut");
            dtgGeneral.DataSource = dsCoaut.Tables["Coaut"];


            cadSql2 = "select count(unique idpresent) " +
                "from T4Congreso c, T4Presentado p, T4Autor a " +
                "where c.idCong = p.idCong " +
                "and p.idaut in (select a.idAut " +
                "from T4Escribio e, T4Autor a, T4Presentado p " +
                "where p.idArt = e.idArt and e.idAut = a.idAut " +
                "and p.idAut = (select p.idAut " +
                "from T4Presentado p, T4Autor a " +
                "where p.idAut = a.idAut and a.nombre ='" + cboAutor.Text + "'))";

            GestorBD.consBD(cadSql2, dsNoCong, "NoCon");
            dtgCong.DataSource = dsNoCong.Tables["NoCon"];

            //GestorBD.consBD(cadSql2, dsCoaut, "Coaut");
            //dtgGeneral.DataSource = dsCoaut.Tables["Coaut"];



        }


    }
}
