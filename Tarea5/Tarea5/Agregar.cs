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
        DataSet dsAut = new DataSet(), dsCong= new DataSet(), dsArt= new DataSet();
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


        }

        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboArticulo.Visible = true;
            //Obtiene y muestra los datos de los Articulos.
            cadSql = "select * from T4Articulo art, T4Autor a, T4Escribio e where art.idart=e.idart and e.idaut=a.idaut and a.nombre='" + cboAutor.SelectedItem + "'";
            GestorBD.consBD(cadSql, dsArt, "T4Articulo");
            comunes.cargaCombo(cboArticulo, dsArt, "T4Articulo", "Nomart");
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string aut, cong,art, fecha, hor;
            aut = Convert.ToString(cboAutor.SelectedItem);
            cong = Convert.ToString(cboCongreso.SelectedItem);
            art = Convert.ToString(cboArticulo.SelectedItem);
            fecha = Convert.ToString(dateCong.Value.Year+"-"+dateCong.Value.Month + "-" +dateCong.Value.Day).Trim();
            hor = txtHor.Text;
            //MessageBox.Show(hor);
            if (checar(aut, cong, art, fecha, hor))
            {
                DataSet dsTemp = new DataSet();
                //ID'S NECESARIOS
                cadSql= "select count(idpresent) from t4presentado";
                GestorBD.consBD(cadSql, dsTemp, "T4presentado");
                int idpresent = Convert.ToInt16(dsTemp.Tables["T4presentado"].Rows[0]["count(idpresent)"].ToString())+900;

                cadSql = "select * from t4congreso c where c.nombre='" + cong + "'";
                GestorBD.consBD(cadSql, dsTemp, "T4congreso");
                int idcong = Convert.ToInt16(dsTemp.Tables["T4congreso"].Rows[0]["idcong"].ToString());

                cadSql = "select * from t4autor a where a.nombre='" + aut + "'";
                GestorBD.consBD(cadSql, dsTemp, "T4autor");
                int idaut =Convert.ToInt16(dsTemp.Tables["T4autor"].Rows[0]["idaut"].ToString());
                //MessageBox.Show(idaut);

                cadSql = "select * from t4articulo a where a.nomart='" + art + "'";
                GestorBD.consBD(cadSql, dsTemp, "T4articulo");
                int idart =Convert.ToInt16( dsTemp.Tables["T4articulo"].Rows[0]["idart"].ToString());

                //Agrega a la tabla t4presentado
                cadSql = "insert into t4presentado values ("+idpresent+","+idcong+",'"+hor+"', date'"+fecha+"',"+idaut+","+idart+")";
                GestorBD.altaBD(cadSql);
                MessageBox.Show("Alta exitosa!");
               
            }
        }

        private bool checar(string autor, string congr,string art,string fecha,string horario)
        {
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd01", "linesp", "oracle");
            bool res=true;
            if(autor.Equals("") || congr.Equals("") || art.Equals("") || horario.Equals(""))
            {
                label1.Visible = true;
                label1.Text = "Checa que los datos sean correctos";
                res = false;
            }
            else
            {
                //Obtiene la fecha del congreso
                cadSql = "select * from t4congreso where nombre='"+congr+"' and date'"+fecha+"' between fechaini and fechafin ";
                GestorBD.consBD(cadSql, dsCong, "T4Congreso");
                
                if (dsCong.Tables["T4Congreso"] ==null || dsCong.Tables["T4Congreso"].Rows.Count<=0)
                {
                    label1.Visible = true;
                    label1.Text = "La fecha es incorrecta";
                    res = false;
                }
            }
                
            return res;
        }
    }
}
