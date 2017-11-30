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
    public partial class formularioDespido : Form
    {
        public formularioDespido()
        {
            InitializeComponent();
         
        }

   
        List<int> listaIdContrato = new List<int>();
        List<int> listaHoras = new List<int>();
        List<float> listaSueldos = new List<float>();
        
        List<float> listaIndem = new List<float>();


      
        void limpiar_listas()
        {

            listaIdContrato.Clear();
            listaHoras.Clear();
            listaSueldos.Clear();
            listaIndem.Clear();
           
      
        }

    
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                conexion_baseDatos.conectar();
                string Query = "insert into despido (idDespido, causaDespido, fechaDespido, montoIndem, contrato_idContrato) values(null,'" + this.txt_motivo.Text + "','" + this.dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',@pago,@idcon)";
                MySqlCommand command = new MySqlCommand(Query, conexion_baseDatos.conexion);
                conexion_baseDatos.OpenConnection();


                for (int i = 0; i<1; i++)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@pago", listaIndem[i]);
                    command.Parameters.AddWithValue("@idcon", listaIdContrato[i]);
                   




                    command.ExecuteNonQuery();

                }
                MessageBox.Show("Indemnizacion Insertada");
           
                conexion_baseDatos.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

    

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                conexion_baseDatos.conectar();

                string Query = "select contrato.idContrato,contrato.sueldoBase,horaextra.cantidadHoras from contrato,horaextra where contrato.idContrato in(select contrato_idContrato from horaextra) and contrato.idContrato='"+txt_contrato.Text+"' " ;

                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();


                while (MyReader2.Read())
                {
                    listaIdContrato.Add(Convert.ToInt32(MyReader2["idContrato"]));
                    listaSueldos.Add((float)Convert.ToDouble(MyReader2["sueldoBase"]));
                    listaHoras.Add(Convert.ToInt32(MyReader2["cantidadHoras"]));

                }
                conexion_baseDatos.CloseConnection();

                double f = 1.5;
                float horas = (float)f;
                int i = 0;
                //  SD + (SD÷ 6) +H.E.X R.L ÷365 DÍAS

                foreach (var itemA in listaSueldos)
                {
                    float s = (itemA);
                    float monto = (float)Math.Round(s, 2);
                   txt_monto.Text = s.ToString();
                    listaIndem.Add(s);

                }


               

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

                string Query = "select  causaDespido, fechaDespido, montoIndem, contrato_idContrato from despido where contrato_idContrato ='" + this.txt_contrato.Text + "'";
                conexion_baseDatos.conectar();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
                conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();
                if (MyReader2.Read())

                {
                    txt_motivo.Text = Convert.ToString(MyReader2["causaDespido"]);
                    dateTimePicker1.Text = Convert.ToString(MyReader2["fechaDespido"]);
                    txt_monto.Text = Convert.ToString(MyReader2["montoIndem"]);
                    txt_contrato.Text = Convert.ToString(MyReader2["contrato_idContrato"]);
                }
                else { MessageBox.Show("contrato no existe"); }
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
                conexion_baseDatos.conectar();
                string Query = "delete from despido where contrato_idContrato='" + this.txt_contrato.Text + "';";

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

        private void formularioDespido_Load(object sender, EventArgs e)
        {

        }
    }
}
