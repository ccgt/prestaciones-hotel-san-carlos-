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
    public partial class formularioVacaciones : Form
    {
        public formularioVacaciones()
        {
            InitializeComponent();
        }
        List<int> listaIdContratoF = new List<int>();
        List<float> listaTotalBonoF = new List<float>();
        List<float> listaSueldosF = new List<float>();
        List<string> listaFechasF = new List<string>();
        List<float> listaDiasF = new List<float>();

        void limpiar_listas()
        {

          

            listaIdContratoF.Clear();
            listaTotalBonoF.Clear();
            listaSueldosF.Clear();
            listaFechasF.Clear();
            listaDiasF.Clear();
        }
        void calculoMenor()
        {
            DateTime actual = DateTime.Now;
            string date = actual.ToString("yyyy-MM-dd");
            conexion_baseDatos.conectar();
            string Query = "update vacaciones set encargadoAutorizacion =@pago where contrato_idContrato=@idcon"; 
                MySqlCommand command = new MySqlCommand(Query, conexion_baseDatos.conexion);
            conexion_baseDatos.OpenConnection();


            for (int i = 0; i < listaIdContratoF.Count; i++)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pago", listaTotalBonoF[i]);
                command.Parameters.AddWithValue("@idcon", listaIdContratoF[i]);
                //  command.Parameters.AddWithValue("@fechaAcumulatoria", listaFechasB[i]);




                command.ExecuteNonQuery();

            }
            MessageBox.Show("Monto calculado");

            conexion_baseDatos.CloseConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "insert into vacaciones(idVacaciones,fechaInicioVacaciones,fechaCulminacionVacaciones,mesSolicitado,cantidadDiasHabiles,estadoVacaciones,encargadoAutorizacion,contrato_idContrato) values(null,'" + this.dateTimePicker1_inicio.Value.ToString("yyyy-MM-dd") + "','" + this.dateTimePicker2_fin.Value.ToString("yyyy-MM-dd") + "','" + this.txt_mes.Text + "','" + this.txt_habiles.Text + "','" + this.txt_estado.Text + "','" + this.txt_autoriza.Text + "','" + this.txt_idcon.Text + "');";

                conexion_baseDatos.conectar();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Datos Insertados");
                txt_autoriza.Text = "";
                txt_estado.Text = "";
                txt_habiles.Text = "";
                dateTimePicker1_inicio.Text = "";
                dateTimePicker2_fin.Text = "";
                txt_idcon.Text = "";
                txt_mes.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "SELECT fechaInicioVacaciones,fechaCulminacionVacaciones,mesSolicitado,cantidadDiasHabiles,estadoVacaciones,encargadoAutorizacion,contrato_idContrato   from vacaciones where contrato_idContrato = '" + this.txt_idcon.Text + "';";
                conexion_baseDatos.conectar();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())

                {
                    dateTimePicker1_inicio.Text = Convert.ToString(MyReader2["fechaInicioVacaciones"]);
                    dateTimePicker2_fin.Text = Convert.ToString(MyReader2["fechaCulminacionVacaciones"]);
                   txt_mes.Text = Convert.ToString(MyReader2["mesSolicitado"]);
                    txt_habiles.Text = Convert.ToString(MyReader2["cantidadDiasHabiles"]);
                    txt_estado.Text = Convert.ToString(MyReader2["estadoVacaciones"]);
                    txt_autoriza.Text = Convert.ToString(MyReader2["encargadoAutorizacion"]);
                    txt_idcon.Text = Convert.ToString(MyReader2["contrato_idContrato"]);
                }
                conexion_baseDatos.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "select *from vacaciones;";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "update vacaciones set fechaInicioVacaciones='" + this.dateTimePicker1_inicio.Value.ToString("yyyy-MM-dd") + "',fechaCulminacionVacaciones='" + this.dateTimePicker2_fin.Value.ToString("yyyy-MM-dd") + "',mesSolicitado= '" + this.txt_mes.Text + "' , cantidadDiasHabiles='" + this.txt_habiles.Text + "',estadoVacaciones='" + this.txt_estado .Text + "',encargadoAutorizacion='" + this.txt_autoriza.Text + "' where contrato_idContrato ='" + this.txt_idcon.Text + "'";
                conexion_baseDatos.conectar();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();
                txt_autoriza.Text = "";
              txt_estado.Text = "";
             txt_habiles.Text = "";
                dateTimePicker1_inicio.Text = "";
                dateTimePicker2_fin.Text = "";
                txt_mes.Text = "";
                
                MessageBox.Show("DATO ACTUALIZADO");
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

        private void formularioVacaciones_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                conexion_baseDatos.conectar();

                string Query = "select idContrato,inicioRelacionTrabajo,sueldoBase from contrato where  idContrato IN(SELECT contrato_idContrato FROM vacaciones)";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();


                while (MyReader2.Read())
                {

                    listaFechasF.Add((MyReader2["inicioRelacionTrabajo"].ToString()));
                    listaSueldosF.Add((float)Convert.ToDouble(MyReader2["sueldoBase"]));
                    listaIdContratoF.Add(Convert.ToInt32(MyReader2["idContrato"]));
                }
                conexion_baseDatos.CloseConnection();

                //aqui convertirmos las fechas en dias  desde el 30 de junio del año presente hasta el 1 enero del presente
                foreach (string fecha in listaFechasF)
                {

                    DateTime datos = DateTime.Parse(fecha);
                    DateTime fechaCorte = DateTime.Now;
                    TimeSpan vac = fechaCorte - datos;
                    int vaca = vac.Days;
                    int anio = 365;
                  /*  DateTime fechaCorte1 = new DateTime(int.Parse(anioActual), 01, 01);
                    DateTime fechaCorte2 = new DateTime(int.Parse(anioActual), 06, 30);
                    DateTime fechaCorte3 = new DateTime(int.Parse(anioActual), 12, 31);*/

                   /* TimeSpan ttotal = fechaCorte - fechaCorte1;
                    int dias = ttotal.Days;
                    TimeSpan total2 = fechaCorte - fechaCorte2;
                    int dias2 = total2.Days;*/

                    /*if ((fechaCorte >= fechaCorte1) && (fechaCorte <= fechaCorte2))
                    {
                        listaDiasF.Add(dias);
                    }
                    if ((fechaCorte >= fechaCorte2) && (fechaCorte <= fechaCorte3))
                    {
                        listaDiasF.Add(dias2);
                    }
                    //  textBox11.Text = dias.ToString();*/
                    if(vaca >=365)
                    {
                        listaDiasF.Add(anio);
                    }
                    if(vaca <365)
                    {
                        listaDiasF.Add(vaca);
                    }
                  //  textBox1.Text += vaca.ToString();








                }
                //aqui multiplicamos los dias laborados y con el salarioBase y / 365
                int i = 0;

                foreach (var itemA in listaSueldosF)
                {

                    float re= ((itemA / 30) *( 20 * listaDiasF[i++])) /365;
                   
                    float rsBono14EmpleadoNuevo = (float)Math.Round(re, 2); //se pasa a float ya que el valor por defecto es decimal

                    listaTotalBonoF.Add(rsBono14EmpleadoNuevo);
                }
                foreach (var itemA in listaTotalBonoF)
                {
                   //  textBox2.Text += itemA.ToString();

                }

                calculoMenor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            limpiar_listas();
        }
    }
}
