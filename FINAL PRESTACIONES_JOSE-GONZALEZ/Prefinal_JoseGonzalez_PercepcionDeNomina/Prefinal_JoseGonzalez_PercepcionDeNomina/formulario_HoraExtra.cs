using MySql.Data.MySqlClient;
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
    public partial class formulario_HoraExtra : Form
    {
        public formulario_HoraExtra()
        {
            InitializeComponent();
        }

        //lista de carga contrato inicial
        List<int> listaIdContrato = new List<int>();
        List<int> lista= new List<int>();



        //listas de operaciones
        List<int> listaTotalHoras = new List<int>();
        List<float> listaMonetariaHoras = new List<float>();
        List<int> listaIdContratoComparacion = new List<int>();
        List<float> listaSueldos = new List<float>();

        List<float> listaS = new List<float>();
        List<float> listaS2 = new List<float>();



        void limpiar_listas()
        {

            listaIdContrato.Clear();
            lista.Clear();
            listaTotalHoras.Clear();
            listaMonetariaHoras.Clear();
            listaIdContratoComparacion.Clear();
            listaSueldos.Clear();
            listaS.Clear();
            listaS2.Clear();

        
        }

        /*                txt_autoriza.Text = "";
                txt_canthoras.Text = "";
                txt_idCon.Text = "";
                dateTimePicker1.Text = "";*/

        void insertarNuevasHoras()
        {
            DateTime fechaHoy = DateTime.Now;
            string date = fechaHoy.ToString("yyyy-MM-dd ");

            conexion_baseDatos.conectar();
          
            string Query = "UPDATE horaextra SET fechaHoras ='" + date + "', cantidadHoras = @horas, personaAutorizo = @monto  where contrato_idContrato=@idcontra";
            MySqlCommand command = new MySqlCommand(Query, conexion_baseDatos.conexion);
            conexion_baseDatos.OpenConnection();


            for (int i = 0; i <listaS2.Count ; i++)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@monto", listaS2[i]);
                command.Parameters.AddWithValue("@idcontra", listaIdContratoComparacion[i]);
                command.Parameters.AddWithValue("@horas", listaTotalHoras[i]);





                command.ExecuteNonQuery();

            }
            MessageBox.Show("horas actualizadas");

            conexion_baseDatos.CloseConnection();

        }
        void insertar()
        {
           
            DateTime fechaHoy = DateTime.Now;
            string date = fechaHoy.ToString("yyyy-MM-dd ");
            int numero = 0;
            conexion_baseDatos.conectar();
                string Query = "insert into horaextra(idHorasExtra,fechaHoras, cantidadHoras, personaAutorizo, contrato_idContrato) values (@idcon,'" + date + "','" +numero + "','" + numero+ "',@idcon)";
                MySqlCommand command = new MySqlCommand(Query, conexion_baseDatos.conexion);
                conexion_baseDatos.OpenConnection();


                for (int i = 0; i < listaIdContrato.Count; i++)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@idcon", listaIdContrato[i]);
                    //  command.Parameters.AddWithValue("@fechaAcumulatoria", listaFechasB[i]);




                    command.ExecuteNonQuery();

                }
                MessageBox.Show("empleado nuevos insertados");

                conexion_baseDatos.CloseConnection();

            }
            



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                conexion_baseDatos.conectar();

                string Query = "select idContrato,sueldoBase from contrato where  idContrato not IN(SELECT contrato_idContrato FROM horaextra)";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();


                while (MyReader2.Read())
                {
                    listaIdContrato.Add(Convert.ToInt32(MyReader2["idContrato"]));
                    listaSueldos.Add((float)Convert.ToDouble(MyReader2["sueldoBase"]));
                }
                conexion_baseDatos.CloseConnection();

                insertar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
             {

                 string Query = "select * from horaextra;";
                conexion_baseDatos.conectar();
                 MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                 MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                 MyAdapter.SelectCommand = MyCommand2;
                 DataTable dTable = new DataTable();
                 MyAdapter.Fill(dTable);
                 dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                    // MyConn2.Close();  
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
             }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "select idHorasExtra,fechaHoras,cantidadHoras,personaAutorizo,contrato_idContrato from horaextra where contrato_idContrato ='" + this.txt_idCon.Text + "'";
                conexion_baseDatos.conectar();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();
                if (MyReader2.Read())
              
                {
                  txt_idCon.Text = Convert.ToString(MyReader2["contrato_idContrato"]);
                 dateTimePicker1.Text = Convert.ToString(MyReader2["fechaHoras"]);
               txt_canthoras.Text = Convert.ToString(MyReader2["cantidadHoras"]);
                   txt_autoriza.Text = Convert.ToString(MyReader2["personaAutorizo"]);
                }
                else{ MessageBox.Show("contrato no existe"); }
               conexion_baseDatos.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void formulario_HoraExtra_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "update horaextra set fechaHoras='" + this.dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',cantidadHoras= cantidadHoras + '" + this.txt_canthoras.Text + "' where contrato_idContrato ='" + this.txt_idCon.Text + "'";
                conexion_baseDatos.conectar();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();
                txt_autoriza.Text = "";
                txt_canthoras.Text = "";
                txt_idCon.Text = "";
                dateTimePicker1.Text = "";
                MessageBox.Show("HORA AÑADIDA");
                while (MyReader2.Read())

                {
                 
                }
                conexion_baseDatos.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {


            try
            {
                conexion_baseDatos.conectar();
                string Query = "delete from horaextra where contrato_idContrato='" + this.txt_idCon.Text + "';";
              
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();
              
                while (MyReader2.Read())
                {
                   
                }
               
                MessageBox.Show("eliminado");
                
               conexion_baseDatos.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {


                conexion_baseDatos.conectar();
                string Query = "select contrato.sueldoBase,horaextra.cantidadHoras,horaextra.contrato_idContrato,horaextra.idHorasExtra from horaextra,contrato where contrato.idContrato=horaextra.contrato_idContrato";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();


                while (MyReader2.Read())
                {

                    listaIdContratoComparacion.Add(Convert.ToInt32(MyReader2["contrato_idContrato"]));
                    listaTotalHoras.Add(Convert.ToInt32(MyReader2["cantidadHoras"]));
                    listaS.Add((float)Convert.ToDouble(MyReader2["sueldoBase"]));
                }
                conexion_baseDatos.CloseConnection();



                double f = 1.5;
                float horas = (float)f;
                int i = 0;
              
                foreach (var itemA in listaS)
                {
                    float s = ((itemA/30/8)*horas);
                 
                    listaMonetariaHoras.Add(s);
                }
              
                foreach (int itemA in listaTotalHoras)
                {


                    int k=0;
                    float s = itemA * (listaS[k++]/30/8*horas);

                    listaS2.Add(s);
                }


                insertarNuevasHoras();
                limpiar_listas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }


    }

