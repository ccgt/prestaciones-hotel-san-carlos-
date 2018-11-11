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
    public partial class formularioBono14 : Form
    {
        public formularioBono14()
        {
            InitializeComponent();
           
        }
        string anioMenos_;
        DateTime actual = DateTime.Now;
       




        //listas de calculo empleado ingresa a empresa antes del 1 de julio
        List<int> listaIdContrato = new List<int>();
        List<float> listaTotalBono = new List<float>();
        List<float> listaSueldos = new List<float>();
        List<string> listaFechas = new List<string>();
        List<float> listaDias = new List<float>();

        //listas de calculo empleado ingresa a empresa despues del 1 de julio
        List<int> listaIdContratoB = new List<int>();
        List<float> listaTotalBonoB = new List<float>();
        List<float> listaSueldosB = new List<float>();
        List<string> listaFechasB = new List<string>();
        List<float> listaDiasB = new List<float>();


        //listas de calculo empleado lleva 1 año desde 1 julio año anterior a 30 junio año actual
        List<int> listaIdContratoC = new List<int>();
        List<float> listaTotalBonoC = new List<float>();
        List<float> listaSueldosC = new List<float>();
        List<string> listaFechasC = new List<string>();
        List<int> listaDiasC = new List<int>();



        //listas de modificacion
        List<int> listaIdContratoD = new List<int>();
        List<float> listaTotalBonoD = new List<float>();
        List<float> listaSueldosD = new List<float>();
        List<string> listaFechasD = new List<string>();
        List<float> listaDiasD = new List<float>();

        //----------------
        List<int> listaIdContratoE = new List<int>();
        List<float> listaTotalBonoE = new List<float>();
        List<float> listaSueldosE = new List<float>();
        List<string> listaFechasE = new List<string>();
        List<float> listaDiasE = new List<float>();

        List<int> listaIdContratoF = new List<int>();
        List<float> listaTotalBonoF = new List<float>();
        List<float> listaSueldosF = new List<float>();
        List<string> listaFechasF = new List<string>();
        List<float> listaDiasF = new List<float>();
        void limpiar_listas()
        {
            
            listaIdContrato.Clear();
            listaTotalBono.Clear();
            listaSueldos.Clear();
            listaFechas.Clear();
            listaDias.Clear();

            //listas de calculo empleado ingresa a empresa despues del 1 de julio
            listaIdContratoB.Clear();
            listaTotalBonoB.Clear();
            listaSueldosB.Clear();
            listaFechasB.Clear();
            listaDiasB.Clear();


            //listas de calculo empleado lleva 1 año desde 1 julio año anterior a 30 junio año actual
            listaIdContratoC.Clear();
            listaTotalBonoC.Clear();
            listaSueldosC.Clear();
            listaFechasC.Clear();
            listaDiasC.Clear();

            listaIdContratoD.Clear();
            listaTotalBonoD.Clear();
            listaSueldosD.Clear();
            listaFechasD.Clear();
            listaDiasD.Clear();

            listaIdContratoE.Clear();
            listaTotalBonoE.Clear();
            listaSueldosE.Clear();
            listaFechasE.Clear();
            listaDiasE.Clear();

            listaIdContratoF.Clear();
            listaTotalBonoF.Clear();
            listaSueldosF.Clear();
            listaFechasF.Clear();
            listaDiasF.Clear();
        }

        // aqui obtenemos la fecha actual
        string diaActual;
        string mesActual;
        string anioActual;
        string anioComparacion;

        void calculoMenor()
        {
            string date = actual.ToString("yyyy-MM-dd");
            conexion_baseDatos.conectar();
            string Query = "insert into bono14(idBono,fechaBono14,valorPercepcion,estadoBono,contrato_idContrato) values(null,'" + date + "',@pago,0,@idcon);";
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
            MessageBox.Show("Bono 14 ha sido calculado");

            conexion_baseDatos.CloseConnection();

        }

        void calculoMenor1julioPresente()
        {
            string date = actual.ToString("yyyy-MM-dd");
            conexion_baseDatos.conectar();
            string Query = "insert into bono14(idBono,fechaBono14,valorPercepcion,estadoBono,contrato_idContrato) values(null,'" + date + "',@percepcion,1,@idcon);";
            MySqlCommand command = new MySqlCommand(Query, conexion_baseDatos.conexion);
           conexion_baseDatos.OpenConnection();


            for (int i = 0; i < listaIdContrato.Count; i++)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@idcon", listaIdContrato[i]);
                command.Parameters.AddWithValue("@percepcion", listaTotalBono[i]);


                command.ExecuteNonQuery();

            }
           // MessageBox.Show("bono 14 nuevos creado");

            conexion_baseDatos.CloseConnection();

        }

        void calculoMayor1julioPresente()
        {
            string date = actual.ToString("yyyy-MM-dd");
            conexion_baseDatos.conectar();
            string Query = "insert into bono14(idBono,fechaBono14,valorPercepcion,estadoBono,contrato_idContrato) values(null,'" + date + "',@pago,0,@idcon);";
            MySqlCommand command = new MySqlCommand(Query, conexion_baseDatos.conexion);
            conexion_baseDatos.OpenConnection();


            for (int i = 0; i < listaIdContratoB.Count; i++)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pago", listaTotalBonoB[i]);
                command.Parameters.AddWithValue("@idcon", listaIdContratoB[i]);
              //  command.Parameters.AddWithValue("@fechaAcumulatoria", listaFechasB[i]);
             



                command.ExecuteNonQuery();

            }
         //   MessageBox.Show("bono 14 nuevos creado");

            conexion_baseDatos.CloseConnection();

        }

        void calculoAcumulativo()
        {
            string date = actual.ToString("yyyy-MM-dd ");

            conexion_baseDatos.conectar();
            string Query = "UPDATE bono14 SET fechaBono14 ='"+ date + "', valorPercepcion = @monto where contrato_idContrato=@idcontratoBono";
            MySqlCommand command = new MySqlCommand(Query, conexion_baseDatos.conexion);
            conexion_baseDatos.OpenConnection();


            for (int i = 0; i < listaTotalBonoE.Count; i++)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@monto",listaTotalBonoE[i]);
                command.Parameters.AddWithValue("@idcontratoBono", listaIdContratoE[i]);
              
              


                command.ExecuteNonQuery();

            }
          //  MessageBox.Show("bono 14 actualizado");

            conexion_baseDatos.CloseConnection();
         
        }
        

        void modificarAntes1julio()
        {
            string date = actual.ToString("yyyy-MM-dd H:mm:ss");
            conexion_baseDatos.conectar();
           string Query = "UPDATE bono14  SET fechaBono14 = '" + date +"', valorPercepcion = @monto WHERE contrato_idContrato = @idcontratoBono";
                MySqlCommand command = new MySqlCommand(Query, conexion_baseDatos.conexion);
            conexion_baseDatos.OpenConnection();


            for (int i = 0; i < listaTotalBonoC.Count; i++)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@monto", listaTotalBonoC[i]);
                command.Parameters.AddWithValue("@idcontratoBono", listaIdContratoC[i]);




                command.ExecuteNonQuery();

            }
         //   MessageBox.Show("bono 14 actualizado");

            conexion_baseDatos.CloseConnection();

        }

        void modificarDespues1julio()
        {
            string date = actual.ToString("yyyy-MM-dd H:mm:ss");
            conexion_baseDatos.conectar();
            string Query = "UPDATE bono14 SET fechaBono14 ='" + date + "', valorPercepcion = @monto where contrato_idContrato=@idcontratoBono";
            MySqlCommand command = new MySqlCommand(Query, conexion_baseDatos.conexion);
            conexion_baseDatos.OpenConnection();


            for (int i = 0; i < listaTotalBonoD.Count; i++)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@monto", listaTotalBonoD[i]);
                command.Parameters.AddWithValue("@idcontratoBono", listaIdContratoD[i]);




                command.ExecuteNonQuery();

            }
         //   MessageBox.Show("bono 14 actualizado");

            conexion_baseDatos.CloseConnection();

        }


        /****************************BOTON para buscar en datagrid a un empleado especifico ***************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
         
            string parametro;
            parametro =buscador.Text;
            conexion_baseDatos.conectar();
            dataGridView1.DataSource = conexion_baseDatos.llenarDataGridView("select empleado.primerNombre, empleado.segundoNombre, empleado.apellidoPaterno, empleado.apellidoMaterno, contrato.inicioRelacionTrabajo, contrato.sueldoBase, bono14.fechaBono14, bono14.valorPercepcion, bono14.estadoBono from empleado, contrato, bono14 where contrato.empleado_idEmpleado = '" + parametro + "' and empleado.idEmpleado = '" + parametro + "' and bono14.contrato_idContrato = contrato.idContrato");




        }

        /************************** BOTON para calcular bono14 de los empleados de primer ingreso al sistema ***********************************/

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            diaActual = fechaHoy.Day.ToString();
            mesActual = fechaHoy.Month.ToString();
            anioActual = fechaHoy.Year.ToString();
            anioComparacion = anioActual;



            //verificamos si hoy es 1 de julio para realizar el calculo del bono14

            //   if ((diaActual == "6") && (mesActual == "11") && (anioActual == anioComparacion))
            // {
           
                try
                {

                conexion_baseDatos.conectar();

                    string Query = "select idContrato,inicioRelacionTrabajo,sueldoBase from contrato where inicioRelacionTrabajo >= '" + anioActual + "-01-01' and inicioRelacionTrabajo <= '" + anioActual + "-06-30' and idContrato NOT IN(SELECT contrato_idContrato FROM bono14)";

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                    MySqlDataReader MyReader2;
                    conexion_baseDatos.OpenConnection();
                    MyReader2 = MyCommand2.ExecuteReader();


                    while (MyReader2.Read())
                    {

                        listaFechas.Add((MyReader2["inicioRelacionTrabajo"].ToString()));
                        listaSueldos.Add((float)Convert.ToDouble(MyReader2["sueldoBase"]));
                        listaIdContrato.Add(Convert.ToInt32(MyReader2["idContrato"]));
                    }
                    conexion_baseDatos.CloseConnection();

                    //aqui convertirmos las fechas en dias  desde el 30 de junio del año presente hasta el 1 enero del presente
                    foreach (string fecha in listaFechas)
                    {

                        DateTime datos = DateTime.Parse(fecha);
                          DateTime fechaCorte = DateTime.Now;
                    // restamos dias fecha de corte 30 junio 
                    TimeSpan td = fechaCorte - datos;

                    
                        // diferencia en dias.
                        int diasDiferencia = td.Days;
                   // textBox1.Text += diasDiferencia.ToString();
                    listaDias.Add(diasDiferencia);
                 



              
                    


                  


                    }
                    //aqui multiplicamos los dias laborados y con el salarioBase y / 365
                    int i = 0;

                    foreach (var itemA in listaSueldos)
                    {
                        float re = (itemA * listaDias[i++]) / 365;

                        float rsBono14EmpleadoNuevo = (float)Math.Round(re, 2); //se pasa a float ya que el valor por defecto es decimal

                        listaTotalBono.Add(rsBono14EmpleadoNuevo);
                    }
                    foreach (var itemA in listaTotalBono)
                    {
                      //  textBox2.Text += itemA.ToString();

                    }

                    calculoMenor1julioPresente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //            }
                /*********************** si el trabajador ingreso despues del 30 de junio a trabajar ***********************************/

                try
                {

                conexion_baseDatos.conectar();
                    string Query = "select idContrato, inicioRelacionTrabajo, sueldoBase from contrato where inicioRelacionTrabajo >= '" + anioActual + "-07-01' and inicioRelacionTrabajo <= '" + anioActual + "-12-31' and idContrato NOT IN(SELECT contrato_idContrato FROM bono14)";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                    MySqlDataReader MyReader2;
                    conexion_baseDatos.OpenConnection();
                    MyReader2 = MyCommand2.ExecuteReader();


                    while (MyReader2.Read())
                    {

                        listaFechasB.Add((MyReader2["inicioRelacionTrabajo"].ToString()));
                        listaSueldosB.Add((float)Convert.ToDouble(MyReader2["sueldoBase"]));
                        listaIdContratoB.Add(Convert.ToInt32(MyReader2["idContrato"]));





                    }
                    conexion_baseDatos.CloseConnection();

                    //aqui convertirmos las fechas en dias  desde el 30 de junio del año presente hasta el 1 enero del presente
                    foreach (string fecha in listaFechasB)
                    {

                        DateTime datos = DateTime.Parse(fecha);
                    //DateTime fechaCorte = new DateTime(int.Parse(anioActual), 06, 30);
                    DateTime fechaCorte = DateTime.Now;

                    // restamos dias fecha de corte 30 junio 
                    TimeSpan td =fechaCorte-datos;

                        // diferencia en dias.
                        int diasDiferencia = td.Days;
//textBox3.Text += diasDiferencia.ToString();

                        listaDiasB.Add(diasDiferencia);


                    }
                    //aqui multiplicamos los dias laborados y con el salarioBase y / 365
                    int i = 0;

                    foreach (var itemA in listaSueldosB)
                    {
                        float re = (itemA * listaDiasB[i++]) / 365;

                        float rsBono14EmpleadoNuevo = (float)Math.Round(re, 2); //se pasa a float ya que el valor por defecto es decimal

                        listaTotalBonoB.Add(rsBono14EmpleadoNuevo);
                    }
                    foreach (var itemA in listaTotalBonoB)
                    {
                      //  textBox4.Text += itemA.ToString();

                    }


                    calculoMayor1julioPresente();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            //MODIFICAR SI EMPLEADO EXISTE YA EN BONO 14" ****************************************************
                       //si es antes del 1 julio 
              try
                {

                conexion_baseDatos.conectar();
                    // "select bono14.fechaBono14,contrato.sueldoBase,bono14.contrato_idContrato from contrato,bono14 where  contrato.idContrato = bono14.contrato_idContrato and bono14.fechaBono14 >= '" + anioActual + "-01-01' and bono14.fechaBono14 <= '" + anioActual + "-12-31'";
                    string Query = "select contrato.inicioRelacionTrabajo,bono14.fechaBono14,contrato.sueldoBase,bono14.contrato_idContrato from contrato,bono14 where  contrato.idContrato = bono14.contrato_idContrato and bono14.fechaBono14 >= '" + anioActual + "-01-01' and bono14.fechaBono14 <= '" + anioActual + "-06-30'";




                    MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                    MySqlDataReader MyReader2;
                    conexion_baseDatos.OpenConnection();
                    MyReader2 = MyCommand2.ExecuteReader();


                    while (MyReader2.Read())
                    {

                        //listaFechasC.Add((MyReader2["fechaBono14"].ToString()));
                        listaFechasC.Add((MyReader2["inicioRelacionTrabajo"].ToString()));
                        listaSueldosC.Add((float)Convert.ToDouble(MyReader2["sueldoBase"]));
                        listaIdContratoC.Add(Convert.ToInt32(MyReader2["contrato_idContrato"]));
                    }
                   conexion_baseDatos.CloseConnection();

                    //aqui convertirmos las fechas en dias  desde el 30 de junio del año presente hasta el 1 enero del presente
                    foreach (string fecha in listaFechasC)
                    {

                        DateTime datos = DateTime.Parse(fecha);
                        // DateTime fechaCorte = new DateTime(int.Parse(anioActual), 06, 30);
                        DateTime fechaCorte = DateTime.Now;

                        // restamos dias fecha de corte 30 junio 
                        TimeSpan td = fechaCorte - datos;

                        // diferencia en dias.
                        int diasDiferencia = td.Days;
                    //   textBox1.Text += diasDiferencia.ToString();
                 
                        listaDiasC.Add(diasDiferencia);

                  


                }
                    //aqui multiplicamos los dias laborados y con el salarioBase y / 365
                    int i = 0;

                    foreach (var itemA in listaSueldosC)
                    {
                        float re = (itemA * listaDiasC[i++]) / 365;

                        float rsBono14EmpleadoNuevo = (float)Math.Round(re, 2); //se pasa a float ya que el valor por defecto es decimal

                        listaTotalBonoC.Add(rsBono14EmpleadoNuevo);
                    }
                    foreach (var itemA in listaTotalBonoC)
                    {
                      //  textBox6.Text += itemA.ToString();

                    }

                    modificarAntes1julio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

// si empleado modificamos despues de 1 julio 

            try
            {

                conexion_baseDatos.conectar();
                // "select bono14.fechaBono14,contrato.sueldoBase,bono14.contrato_idContrato from contrato,bono14 where  contrato.idContrato = bono14.contrato_idContrato and bono14.fechaBono14 >= '" + anioActual + "-01-01' and bono14.fechaBono14 <= '" + anioActual + "-12-31'";
                string Query = "select contrato.inicioRelacionTrabajo,bono14.fechaBono14,contrato.sueldoBase,bono14.contrato_idContrato from contrato,bono14 where  contrato.idContrato = bono14.contrato_idContrato and bono14.fechaBono14 >= '" + anioActual + "-07-01' and bono14.fechaBono14 <= '" + anioActual + "-12-31'";




                MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                MySqlDataReader MyReader2;
               conexion_baseDatos.OpenConnection();
                MyReader2 = MyCommand2.ExecuteReader();


                while (MyReader2.Read())
                {

                  //  listaFechasD.Add((MyReader2["fechaBono14"].ToString()));
                    listaFechasD.Add((MyReader2["inicioRelacionTrabajo"].ToString()));
                    listaSueldosD.Add((float)Convert.ToDouble(MyReader2["sueldoBase"]));
                    listaIdContratoD.Add(Convert.ToInt32(MyReader2["contrato_idContrato"]));
                }
               conexion_baseDatos.CloseConnection();

                //aqui convertirmos las fechas en dias  desde el 30 de junio del año presente hasta el 1 enero del presente
                foreach (string fecha in listaFechasD)
                {
                  
                    DateTime fechaMedia = new DateTime(int.Parse(anioActual), 07, 01);
                    DateTime hoy = DateTime.Now;

                    // Difference in days, hours, and minutes.
                    TimeSpan ts = hoy - fechaMedia;

                    // Difference in days.
                    int diasDespues1julio = ts.Days;

                    DateTime datos = DateTime.Parse(fecha);
                    DateTime fechaCorte = DateTime.Now;

                    // restamos dias fecha de corte 30 junio 
                    TimeSpan td = fechaCorte - datos;


                    int numero = 183;

                    // diferencia en dias.
                    int diasDiferencia = td.Days;
                    int dias;
                    if (diasDiferencia > numero )
                    {
                        dias = diasDespues1julio;

                        listaDiasD.Add(dias);
                      //  textBox7.Text += dias.ToString();
                    }
                    else
                    {
                      //  textBox7.Text += diasDiferencia.ToString();

                        listaDiasD.Add(diasDiferencia);

                    }

                  

                    }




                //aqui multiplicamos los dias laborados y con el salarioBase y / 365
                int i = 0;

                foreach (var itemA in listaSueldosD)
                {
                    float re = (itemA * listaDiasD[i++]) / 365;

                    float rsBono14EmpleadoNuevo = (float)Math.Round(re, 2); //se pasa a float ya que el valor por defecto es decimal

                    listaTotalBonoD.Add(rsBono14EmpleadoNuevo);
                }
                foreach (var itemA in listaTotalBonoD)
                {
                   // textBox8.Text += itemA.ToString();

                }


                modificarDespues1julio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //si el trabajador lleva mas de medio  año completo laborando 
            limpiar_listas();

            DateTime anioMenos = DateTime.Now.AddYears(-1);
                anioMenos_ = anioMenos.ToString("yyyy");

                try
                {

                //select bono14.fechaBono14,contrato.sueldoBase,bono14.contrato_idContrato from contrato,bono14 where bono14.fechaBono14 = '" + anioMenos_ + "' and contrato.idContrato = bono14.contrato_idContrato;
                conexion_baseDatos.conectar();
                    string Query = "select contrato.inicioRelacionTrabajo,bono14.fechaBono14,contrato.sueldoBase,bono14.contrato_idContrato from contrato,bono14 where bono14.fechaBono14 >= '" + anioMenos_ + "-06-30' and bono14.fechaBono14 <= '" + anioActual + "-06-30' and contrato.idContrato = bono14.contrato_idContrato";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, conexion_baseDatos.conexion);
                    MySqlDataReader MyReader2;
                    conexion_baseDatos.OpenConnection();
                    MyReader2 = MyCommand2.ExecuteReader();


                    while (MyReader2.Read())
                    {

                       // listaFechasC.Add((MyReader2["fechaBono14"].ToString()));
                       listaFechasE.Add((MyReader2["inicioRelacionTrabajo"].ToString()));
                        listaSueldosE.Add((float)Convert.ToDouble(MyReader2["sueldoBase"]));
                        listaIdContratoE.Add(Convert.ToInt32(MyReader2["contrato_idContrato"]));





                    }
                    conexion_baseDatos.CloseConnection();
                //aqui convertirmos las fechas en dias  desde el 30 de junio del año presente hasta el 1 enero del presente
                foreach (string fecha in listaFechasE)
                {
                   

                   

                    DateTime datos = DateTime.Parse(fecha);
                    DateTime fechaCorte = DateTime.Now;

                    // restamos dias fecha de corte 30 junio 
                    TimeSpan td = fechaCorte-datos;
                    int diasDiferencia = td.Days;

               //     textBox9.Text = diasDiferencia.ToString();
                    listaDiasE.Add(diasDiferencia);

                  




                }





                //aqui multiplicamos los dias laborados y con el salarioBase y / 365
                int i = 0;

                    foreach (var itemA in listaSueldosE)
                    {

                        float re = (itemA * listaDiasE[i++]) / 365;

                        float rsBono14EmpleadoNuevo = (float)Math.Round(re, 2); //se pasa a float ya que el valor por defecto es decimal

                        listaTotalBonoE.Add(rsBono14EmpleadoNuevo);
                    }
                foreach (var itemA in listaTotalBonoE)
                {
                  //  textBox10.Text += itemA.ToString();

                }
                calculoAcumulativo();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            try
            {

                conexion_baseDatos.conectar();

                string Query = "select idContrato,inicioRelacionTrabajo,sueldoBase from contrato where inicioRelacionTrabajo  <= '" + anioMenos_ + "-06-30' and idContrato NOT IN(SELECT contrato_idContrato FROM bono14)";

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

                    DateTime fechaCorte1 = new DateTime(int.Parse(anioActual), 01, 01);
                    DateTime fechaCorte2 = new DateTime(int.Parse(anioActual), 06, 30);
                    DateTime fechaCorte3 = new DateTime(int.Parse(anioActual), 12, 31);

                    TimeSpan ttotal = fechaCorte - fechaCorte1;
                    int dias = ttotal.Days;
                    TimeSpan total2 = fechaCorte - fechaCorte2;
                    int dias2 = total2.Days;

                    if ((fechaCorte >= fechaCorte1) && (fechaCorte <= fechaCorte2))
                    {
                        listaDiasF.Add(dias);
                    }
                    if ((fechaCorte >= fechaCorte2) && (fechaCorte <= fechaCorte3))
                    {
                        listaDiasF.Add(dias2);
                    }
                  //  textBox11.Text = dias.ToString();









                }
                //aqui multiplicamos los dias laborados y con el salarioBase y / 365
                int i = 0;

                foreach (var itemA in listaSueldosF)
                {
                    float re = (itemA * listaDiasF[i++]) / 365;

                    float rsBono14EmpleadoNuevo = (float)Math.Round(re, 2); //se pasa a float ya que el valor por defecto es decimal

                    listaTotalBonoF.Add(rsBono14EmpleadoNuevo);
                }
                foreach (var itemA in listaTotalBonoF)
                {
                   // textBox12.Text += itemA.ToString();
                   
                }

                calculoMenor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            limpiar_listas();

        }

        private void formularioBono14_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
            

            
        }
    }

        }
  