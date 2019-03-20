using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        //Variable para conectarse a Oracle.
        OleDbConnection cnOracle;

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
            //Lo mismo para el segundo combobox.
            comunes.cargaCombo(cboOrg2,dsOrg, "T4Organizacion", "Nombre");


        }

        private void button1_Click(object sender, EventArgs e) {
            OleDbCommand procOrg;
            OleDbParameter par;
            string nomOrg;
            int tot;

            // 1 - Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle.itam.mx;" +
            "User ID=bd01;Password=linesp");
            cnOracle.Open();
            procOrg = new OleDbCommand();
            procOrg.Connection = cnOracle;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            procOrg.CommandText = "T4E"; //nombre del procedimiento
            procOrg.CommandType = CommandType.StoredProcedure; //tipo del procedimiento. Store precedure puede ejecutar procedimientos y funciones

            //3- Especificar los parámetros:
            // a) Nota: primero hay que definir el tipo de valor que regresará la función.
            par = new OleDbParameter("RETURN_VALUE", OleDbType.Integer,
              4, ParameterDirection.ReturnValue, false, 4, 0, "total", DataRowVersion.Current, 0);
            procOrg.Parameters.Add(par);

            // b) luego hay que definir los parámetros de entrada (uno en este caso).
            nomOrg = Convert.ToString(cboOrg.SelectedItem);
            par = new OleDbParameter("nombreO", nomOrg);
            procOrg.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try
            {
                procOrg.ExecuteNonQuery();

                //5- Recuperar el valor regresado por la función.
                tot = Convert.ToInt16(procOrg.Parameters["RETURN_VALUE"].Value);
                MessageBox.Show("Ha participado en: " + tot);
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();

        }

        

        private void button2_Click(object sender, EventArgs e) {
            string nomOrg, nomOrg2, res;
            OleDbCommand procOrg;
            OleDbParameter par;

            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle.itam.mx;" +
           "User ID=bd01;Password=linesp");
            cnOracle.Open();
            procOrg = new OleDbCommand();
            procOrg.Connection = cnOracle;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            procOrg.CommandText = "T4F";
            procOrg.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            //a) primero todos los de entrada:
            nomOrg = Convert.ToString(cboOrg.SelectedItem);    
            par = new OleDbParameter("nombre1", nomOrg);
            procOrg.Parameters.Add(par);

            nomOrg2 = Convert.ToString(cboOrg2.SelectedItem);
            par = new OleDbParameter("nombre2", nomOrg2);
            procOrg.Parameters.Add(par);

            //b) luego todos los de salida (uno en este caso):
            par = new OleDbParameter("mayor", OleDbType.VarChar,
              20, ParameterDirection.Output, false, 4, 0, "res", DataRowVersion.Current, 0);
            procOrg.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try {
                procOrg.ExecuteNonQuery();

                //5- Recuperar el (los) valor(es) regresado(s) por medio del (de los)
                //   parámetro(s) de salida.
                res = Convert.ToString(procOrg.Parameters["mayor"].Value);
                MessageBox.Show("La organización que más ha participado es: " + res);
            }
            catch (OleDbException err) {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }



        private void addorgBtn_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            cboOrg2.Visible = true;
        }
    }
}
