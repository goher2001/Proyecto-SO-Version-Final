using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MaterialSkin.Controls;

namespace Cliente_Proyecto
{
   
    public partial class Form1 : MaterialForm
    {
        
        List<string> jugadorA = new List<string>();
        List<string> jugadorAz = new List<string>();
        List<string> jugadorR = new List<string>();
        List<string> jugadorV = new List<string>();
        List<Point> posicionesA = new List<Point>();
        List<Point> posicionesV = new List<Point>();
        List<Point> posicionesAz = new List<Point>();
        List<Point> posicionesR = new List<Point>();
        int jugadores = 0;
        int ama = 2;
        int az = 2;    
        int color = 1;
        int pos = 0;
        Socket server;
        Thread atender;
        public Form1()
        {
            InitializeComponent();
            TablaConectados.ColumnCount = 1;
            TablaConectados.Columns[0].Name = "Jugadores conectados";
            TablaConectados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

      
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.BackColor = Color.CadetBlue;
            jugadorA.Add("Tu");
            jugadorA.Add("Azul");
            jugadorA.Add("Rojo");
            jugadorA.Add("Verde");

            jugadorAz.Add("Tu");
            jugadorAz.Add("Amarillo");
            jugadorAz.Add("Rojo");
            jugadorAz.Add("Verde");

            jugadorR.Add("Tu");
            jugadorR.Add("Amarillo");
            jugadorR.Add("Azul");
            jugadorR.Add("Verde");
           
            jugadorV.Add("Tu");
            jugadorV.Add("Amarillo");
            jugadorV.Add("Azul");
            jugadorV.Add("Rojo");


            posicionesA.Add(new Point(417, 474));
            posicionesA.Add(new Point(414, 441));
            posicionesA.Add(new Point(415, 413));
            posicionesA.Add(new Point(406, 385));
            posicionesA.Add(new Point(423, 368));
            posicionesA.Add(new Point(455, 382));
            posicionesA.Add(new Point(485, 382));
            posicionesA.Add(new Point(525, 382));
            posicionesA.Add(new Point(555, 382));
            posicionesA.Add(new Point(590, 382));
            posicionesA.Add(new Point(625, 382));
            posicionesA.Add(new Point(657, 382));
            posicionesA.Add(new Point(658, 316));
            posicionesA.Add(new Point(658, 220));
            posicionesA.Add(new Point(625, 220));
            posicionesA.Add(new Point(589, 220));
            posicionesA.Add(new Point(555, 220));
            posicionesA.Add(new Point(519, 220));
            posicionesA.Add(new Point(485, 220));
            posicionesA.Add(new Point(450, 220));
            posicionesA.Add(new Point(423, 231));
            posicionesA.Add(new Point(378, 218));
            posicionesA.Add(new Point(381, 191));
            posicionesA.Add(new Point(381, 161));
            posicionesA.Add(new Point(381, 129));
            posicionesA.Add(new Point(381, 99));
            posicionesA.Add(new Point(381, 67));
            posicionesA.Add(new Point(381, 36));
            posicionesA.Add(new Point(381, 5));
            posicionesA.Add(new Point(344, 5));
            posicionesA.Add(new Point(276, 5));
            posicionesA.Add(new Point(276, 35));
            posicionesA.Add(new Point(276, 66));
            posicionesA.Add(new Point(276, 96));
            posicionesA.Add(new Point(276, 126));
            posicionesA.Add(new Point(276, 159));
            posicionesA.Add(new Point(276, 189));
            posicionesA.Add(new Point(276, 224));
            posicionesA.Add(new Point(252, 255));
            posicionesA.Add(new Point(209, 248));
            posicionesA.Add(new Point(174, 248));
            posicionesA.Add(new Point(140, 248));
            posicionesA.Add(new Point(107, 248));
            posicionesA.Add(new Point(73, 248));
            posicionesA.Add(new Point(37, 248));
            posicionesA.Add(new Point(3, 248));
            posicionesA.Add(new Point(5, 284));
            posicionesA.Add(new Point(5, 346));
            posicionesA.Add(new Point(38, 347));
            posicionesA.Add(new Point(71, 347));
            posicionesA.Add(new Point(106, 347));
            posicionesA.Add(new Point(141, 347));
            posicionesA.Add(new Point(173, 347));
            posicionesA.Add(new Point(208, 347));
            posicionesA.Add(new Point(243, 347));
            posicionesA.Add(new Point(280, 372));
            posicionesA.Add(new Point(275, 410));
            posicionesA.Add(new Point(275, 442));
            posicionesA.Add(new Point(275, 473));
            posicionesA.Add(new Point(275, 503));
            posicionesA.Add(new Point(275, 533));
            posicionesA.Add(new Point(275, 563));
            posicionesA.Add(new Point(275, 593));
            posicionesA.Add(new Point(311, 594));
            posicionesA.Add(new Point(344, 563));
            posicionesA.Add(new Point(344, 533));
            posicionesA.Add(new Point(344, 503));
            posicionesA.Add(new Point(344, 473));
            posicionesA.Add(new Point(344, 443));
            posicionesA.Add(new Point(344, 403));
            posicionesA.Add(new Point(344, 372));
            posicionesA.Add(new Point(344, 339));


            posicionesAz.Add(new Point(144, 383));
            posicionesAz.Add(new Point(174, 383));
            posicionesAz.Add(new Point(209, 383));
            posicionesAz.Add(new Point(244, 370));
            posicionesAz.Add(new Point(260, 388));
            posicionesAz.Add(new Point(245, 413));
            posicionesAz.Add(new Point(245, 444));
            posicionesAz.Add(new Point(245, 475));
            posicionesAz.Add(new Point(245, 506));
            posicionesAz.Add(new Point(245, 539));
            posicionesAz.Add(new Point(245, 566));
            posicionesAz.Add(new Point(245, 598));
            posicionesAz.Add(new Point(313, 598));
            posicionesAz.Add(new Point(421, 598));
            posicionesAz.Add(new Point(421, 568));
            posicionesAz.Add(new Point(421, 536));
            posicionesAz.Add(new Point(421, 505));
            posicionesAz.Add(new Point(421, 475));
            posicionesAz.Add(new Point(421, 442));
            posicionesAz.Add(new Point(421, 414));
            posicionesAz.Add(new Point(411, 386));
            posicionesAz.Add(new Point(424, 372));
            posicionesAz.Add(new Point(454, 380));
            posicionesAz.Add(new Point(487, 380));
            posicionesAz.Add(new Point(521, 380));
            posicionesAz.Add(new Point(556, 380));
            posicionesAz.Add(new Point(591, 380));
            posicionesAz.Add(new Point(623, 380));
            posicionesAz.Add(new Point(658, 380));
            posicionesAz.Add(new Point(658, 287));
            posicionesAz.Add(new Point(658, 225));
            posicionesAz.Add(new Point(624, 225));
            posicionesAz.Add(new Point(590, 225));
            posicionesAz.Add(new Point(558, 225));
            posicionesAz.Add(new Point(523, 225));
            posicionesAz.Add(new Point(486, 225));
            posicionesAz.Add(new Point(454, 225));
            posicionesAz.Add(new Point(428, 237));
            posicionesAz.Add(new Point(413, 221));
            posicionesAz.Add(new Point(421, 190));
            posicionesAz.Add(new Point(421, 166));
            posicionesAz.Add(new Point(421, 131));
            posicionesAz.Add(new Point(421, 100));
            posicionesAz.Add(new Point(421, 67));
            posicionesAz.Add(new Point(421, 38));
            posicionesAz.Add(new Point(421, 6));
            posicionesAz.Add(new Point(314, 6));
            posicionesAz.Add(new Point(246, 6));
            posicionesAz.Add(new Point(246, 37));
            posicionesAz.Add(new Point(246, 68));
            posicionesAz.Add(new Point(246, 98));
            posicionesAz.Add(new Point(246, 129));
            posicionesAz.Add(new Point(246, 161));
            posicionesAz.Add(new Point(246, 191));
            posicionesAz.Add(new Point(255, 219));
            posicionesAz.Add(new Point(241, 230));
            posicionesAz.Add(new Point(208, 224));
            posicionesAz.Add(new Point(177, 224));
            posicionesAz.Add(new Point(144, 224));
            posicionesAz.Add(new Point(110, 224));
            posicionesAz.Add(new Point(76, 224));
            posicionesAz.Add(new Point(41, 224));
            posicionesAz.Add(new Point(4, 224));
            posicionesAz.Add(new Point(6, 318));
            posicionesAz.Add(new Point(40, 318));
            posicionesAz.Add(new Point(74, 318));
            posicionesAz.Add(new Point(111, 318));
            posicionesAz.Add(new Point(144, 318));
            posicionesAz.Add(new Point(176, 318));
            posicionesAz.Add(new Point(213, 318));
            posicionesAz.Add(new Point(250, 318));
            posicionesAz.Add(new Point(228, 318));


            posicionesR.Add(new Point(242, 127));
            posicionesR.Add(new Point(242, 160));
            posicionesR.Add(new Point(242, 189));
            posicionesR.Add(new Point(275, 225));
            posicionesR.Add(new Point(241, 250));
            posicionesR.Add(new Point(206, 219));
            posicionesR.Add(new Point(175, 222));
            posicionesR.Add(new Point(142, 220));
            posicionesR.Add(new Point(106, 220));
            posicionesR.Add(new Point(74, 220));
            posicionesR.Add(new Point(38, 220));
            posicionesR.Add(new Point(3, 220));
            posicionesR.Add(new Point(3, 285));
            posicionesR.Add(new Point(3, 377));
            posicionesR.Add(new Point(38, 377));
            posicionesR.Add(new Point(71, 377));
            posicionesR.Add(new Point(106, 377));
            posicionesR.Add(new Point(138, 377));
            posicionesR.Add(new Point(173, 377));
            posicionesR.Add(new Point(209, 377));
            posicionesR.Add(new Point(239, 349));
            posicionesR.Add(new Point(279, 376));
            posicionesR.Add(new Point(242, 411));
            posicionesR.Add(new Point(242, 443));
            posicionesR.Add(new Point(242, 471));
            posicionesR.Add(new Point(242, 502));
            posicionesR.Add(new Point(242, 531));
            posicionesR.Add(new Point(242, 563));
            posicionesR.Add(new Point(242, 594));
            posicionesR.Add(new Point(313, 594));
            posicionesR.Add(new Point(421, 594));
            posicionesR.Add(new Point(421, 565));
            posicionesR.Add(new Point(421, 536));
            posicionesR.Add(new Point(421, 505));
            posicionesR.Add(new Point(421, 469));
            posicionesR.Add(new Point(421, 440));
            posicionesR.Add(new Point(421, 410));
            posicionesR.Add(new Point(382, 377));
            posicionesR.Add(new Point(410, 348));
            posicionesR.Add(new Point(449, 382));
            posicionesR.Add(new Point(485, 382));
            posicionesR.Add(new Point(516, 382));
            posicionesR.Add(new Point(551, 382));
            posicionesR.Add(new Point(586, 382));
            posicionesR.Add(new Point(620, 382));
            posicionesR.Add(new Point(653, 382));
            posicionesR.Add(new Point(651, 296));
            posicionesR.Add(new Point(654, 220));
            posicionesR.Add(new Point(619, 220));
            posicionesR.Add(new Point(584, 220));
            posicionesR.Add(new Point(518, 220));
            posicionesR.Add(new Point(485, 220));
            posicionesR.Add(new Point(450, 220));
            posicionesR.Add(new Point(411, 253));
            posicionesR.Add(new Point(381, 223));
            posicionesR.Add(new Point(416, 188));
            posicionesR.Add(new Point(416, 160));
            posicionesR.Add(new Point(416, 127));
            posicionesR.Add(new Point(416, 95));
            posicionesR.Add(new Point(416, 66));
            posicionesR.Add(new Point(416, 35));
            posicionesR.Add(new Point(416, 4));
            posicionesR.Add(new Point(341, 5));
            posicionesR.Add(new Point(241, 5));
            posicionesR.Add(new Point(241, 38));
            posicionesR.Add(new Point(241, 63));
            posicionesR.Add(new Point(241, 98));


            posicionesV.Add(new Point(521, 223));
            posicionesV.Add(new Point(487, 223));
            posicionesV.Add(new Point(454, 223));
            posicionesV.Add(new Point(429, 240));
            posicionesV.Add(new Point(412, 222));
            posicionesV.Add(new Point(421, 190));
            posicionesV.Add(new Point(418, 160));
            posicionesV.Add(new Point(418, 130));
            posicionesV.Add(new Point(418, 100));
            posicionesV.Add(new Point(418, 69));
            posicionesV.Add(new Point(418, 39));
            posicionesV.Add(new Point(418, 9));
            posicionesV.Add(new Point(317, 9));
            posicionesV.Add(new Point(244, 9));
            posicionesV.Add(new Point(244, 38));
            posicionesV.Add(new Point(244, 70));
            posicionesV.Add(new Point(244, 98));
            posicionesV.Add(new Point(244, 129));
            posicionesV.Add(new Point(244, 163));
            posicionesV.Add(new Point(244, 190));
            posicionesV.Add(new Point(256, 220));
            posicionesV.Add(new Point(242, 231));
            posicionesV.Add(new Point(210, 222));
            posicionesV.Add(new Point(176, 224));
            posicionesV.Add(new Point(142, 224));
            posicionesV.Add(new Point(108, 224));
            posicionesV.Add(new Point(73, 224));
            posicionesV.Add(new Point(41, 224));
            posicionesV.Add(new Point(7, 318));
            posicionesV.Add(new Point(7, 380));
            posicionesV.Add(new Point(42, 380));
            posicionesV.Add(new Point(73, 380));
            posicionesV.Add(new Point(109, 380));
            posicionesV.Add(new Point(142, 380));
            posicionesV.Add(new Point(175, 380));
            posicionesV.Add(new Point(213, 380));
            posicionesV.Add(new Point(243, 374));
            posicionesV.Add(new Point(264, 387));
            posicionesV.Add(new Point(245, 410));
            posicionesV.Add(new Point(245, 442));
            posicionesV.Add(new Point(245, 472));
            posicionesV.Add(new Point(245, 503));
            posicionesV.Add(new Point(245, 535));
            posicionesV.Add(new Point(245, 556));
            posicionesV.Add(new Point(245, 598));
            posicionesV.Add(new Point(414, 598));
            posicionesV.Add(new Point(414, 569));
            posicionesV.Add(new Point(414, 538));
            posicionesV.Add(new Point(414, 505));
            posicionesV.Add(new Point(414, 474));
            posicionesV.Add(new Point(414, 444));
            posicionesV.Add(new Point(414, 412));
            posicionesV.Add(new Point(412, 387));
            posicionesV.Add(new Point(427, 372));
            posicionesV.Add(new Point(453, 377));
            posicionesV.Add(new Point(487, 380));
            posicionesV.Add(new Point(523, 380));
            posicionesV.Add(new Point(554, 380));
            posicionesV.Add(new Point(590, 380));
            posicionesV.Add(new Point(623, 380));
            posicionesV.Add(new Point(656, 380));
            posicionesV.Add(new Point(660, 286));
            posicionesV.Add(new Point(623, 285));
            posicionesV.Add(new Point(590, 285));
            posicionesV.Add(new Point(555, 285));
            posicionesV.Add(new Point(521, 285));
            posicionesV.Add(new Point(485, 285));
            posicionesV.Add(new Point(454, 285));
            posicionesV.Add(new Point(414, 285));
            posicionesV.Add(new Point(376, 285));


            bool mostrar = true;
            DelegadoShow delegadoShow = new DelegadoShow(ShowTablero);
            pictureBox4.Invoke(delegadoShow, new object[] { mostrar });
            tablero.Invoke(delegadoShow, new object[] { mostrar });
            button2.Invoke(delegadoShow, new object[] { mostrar });
           
            

        }
        private void AtenderServidor()
        {
            while (true) //recibir respuesta
            {
                byte[] msg2 = new byte[700];
                server.Receive(msg2);
                string mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                string[] trozos = mensaje.Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                
                
                switch (codigo)
                {

                    case 1: //consulta mostrar jugadores
                        mensaje = trozos[1];
                        MessageBox.Show(mensaje);
                        break;

                    case 2: //consulta partidas ganadas
                        mensaje = trozos[1];
                        MessageBox.Show(mensaje);
                        break;

                    case 3: //Consulta resultado partidas
                        mensaje = trozos[1];
                        MessageBox.Show(mensaje);
                        break;

                    case 4: //logging
                        mensaje = trozos[1];
                        MessageBox.Show(mensaje);
                        break;

                    case 5: //registro
                        mensaje = trozos[1];
                        MessageBox.Show(mensaje);
                        break;

                    case 7:
                        //rellena la tabla de conectados
                        DelegadoTabla delegadoTabla = new DelegadoTabla(FillData);
                        TablaConectados.Invoke(delegadoTabla, new object[] { trozos });
                           
                        break;

                    case 8: 
                        //recibe la invitacion y muestra al cliente 
                        //un form donde acepta o rechaza
                        color = Convert.ToInt32(trozos[1]);
                        Invitacion f = new Invitacion();
                        f.ShowDialog();
                        string result = f.Mensaje();
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(result);
                        server.Send(msg);
                        break;

                    case 9:  //jugar la partida
                        mensaje = trozos[1];
                        bool mostrar = true;
                        MessageBox.Show(mensaje);
                        DelegadoShow delegadoShow = new DelegadoShow(ShowTablero);
                        pictureBox4.Invoke(delegadoShow, new object[] { mostrar });
                        button2.Invoke(delegadoShow, new object[] { mostrar });
                        tablero.Invoke(delegadoShow, new object[] { mostrar });
                        label2.Invoke(delegadoShow, new object[] { mostrar });
                        Turno();
                        break;

                    case 10: //darse de baja
                        mensaje = trozos[1];
                        MessageBox.Show(mensaje);
                        break;

                    case 12:
                        break;

                    case 13: //no se juega la partida
                        mensaje = trozos[1];
                        MessageBox.Show(mensaje);
                        break;

                    case 14:
                        //muestro la tirada que se acaba de realizar
                        mensaje = trozos[1];
                        MessageBox.Show("Tirada:  " +  mensaje);
                        break;

                    case 15:
                        //recibo datos de la localizacion de la ficha que se ha movido
                        //y actualizo su posicion
                        int ficha = Convert.ToInt32(trozos[1]); 
                        int X = Convert.ToInt32(trozos[2]);
                        int Y = Convert.ToInt32(trozos[3]);
                        Point P = new Point(X, Y);
                        DelegadoMover moverAM = new DelegadoMover(MoverAmarillo);
                        DelegadoMover moverAZ = new DelegadoMover(MoverAzul);
                        DelegadoMover moverR = new DelegadoMover(MoverRojo);
                        DelegadoMover moverV = new DelegadoMover(MoverVerde);

                        if (ficha == 111)
                            amarillolbl.Invoke(moverAM, new object[] { P });
                        if (ficha == 222)
                            azullbl.Invoke(moverAZ, new object[] { P });
                        if (ficha == 333)
                            rojolbl.Invoke(moverR, new object[] { P });
                        if (ficha == 444)
                            verdelbl.Invoke(moverV, new object[] { P });

                        break;



                }
            }

        }
        

        private void ConectarB_Click(object sender, EventArgs e)
        {
            //conectarse a la base de datos
            IPAddress direc = IPAddress.Parse("147.83.117.22");
            IPEndPoint ipep = new IPEndPoint(direc,50051);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);

                MessageBox.Show("Conectado");
                Conectar V = new Conectar();
                V.ShowDialog();
                string mensaje = V.Mensaje();
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);


            }
            catch (SocketException ex)
            {

                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();

        }

        private void EnviarB_Click(object sender, EventArgs e) //enviar consultas al servidor
        {
            if (MostrarJR.Checked)
            {
                string mensaje = "1/";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);


            }

            else if (PganadasR.Checked)
            {
                string mensaje = ("2/" + nombreG.Text + "/");
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);


            }

            else if (ResultadosR.Checked)
            {
                string mensaje = "3/";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);


            }
        }
        private void Turno ()
        {
            if (color == 1)
            {
                label5.Text = "Tu";
            }
            if (color == 2)
            {
                label5.Text = "Tu";
            }
            if (color == 3)
            {
                label5.Text = "Tu";
            }
            if (color == 4)
            {
                label5.Text = "Tu";
            }



        }
        private void IniciarSB_Click(object sender, EventArgs e)
        {
            //iniciar sesion 
            Logging formv = new Logging();
            formv.ShowDialog();
            string mensaje = formv.Mensaje();

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);



        }

        private void DesconectarB_Click(object sender, EventArgs e)
        {
            //desconectarse
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            atender.Abort();
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            MessageBox.Show("Desconectado");

        }

        private void RegistrarB_Click(object sender, EventArgs e)
        {
            //registrarse en la base de datos
            Registro form = new Registro();
            form.ShowDialog();
            string mensaje = form.mensaje();
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //lanzar dado
            int num1;
            Random r = new Random();
            int iRnd = new int();
            iRnd = r.Next(0, 6);

            if (iRnd == 0)
            {
                num1 = 1;
                pictureBox4.Image = pictureBox10.Image;
            }
            else if (iRnd == 1)
            {
                num1 = 2;
                pictureBox4.Image = pictureBox9.Image;
            }
            else if (iRnd == 2)
            {
                num1 = 3;
                pictureBox4.Image = pictureBox8.Image;
            }
            else if (iRnd == 3)
            {
                num1 = 4;
                pictureBox4.Image = pictureBox7.Image;
            }
            else if (iRnd == 4)
            {
                num1 = 5;
                pictureBox4.Image = pictureBox6.Image;
            }
            else
            {
                num1 = 6;
                pictureBox4.Image = pictureBox5.Image;
            }

            //mover ficha y enviar datos a servidor
            int result = num1;
            Mover_ficha1(result);
            string mensaje = "12/" + result + "/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            Turno2();

        }

      
        private void FillData(string [] trozos)
        {
            //rellenar tabla de conectados
            TablaConectados.Rows.Clear();
            int i = 2;
           
            while (i<trozos.Length)
            {

                TablaConectados.Rows.Add(trozos[i]) ;
                i=i+2;
            }
        }
        delegate void DelegadoTabla(string[] trozos);

        private void ShowTablero(bool mostrar)
        { //hacer visibles distintos objetos
            pictureBox4.Visible = mostrar;
            tablero.Visible = mostrar;
            button2.Visible = mostrar;
            label2.Visible = mostrar;

            

        }
        delegate void DelegadoShow(bool mostrar);
        private void TablaConectados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seleccionar a quien queremos invitar
            int index = e.RowIndex;
            
            DataGridViewRow selectedRow = TablaConectados.Rows[index];
            string mensaje = "9/" + selectedRow.Cells[0].Value.ToString()+"/";
            jugadores++;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            //darse de baja de la base de datos
            Eliminar V = new Eliminar();
            V.ShowDialog();
            string mensaje = V.Mensaje();
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Turno2()
        {
           
            if ( color == 1)
            {
                int cont = (ama + 1) % 2;
                label5.Text = jugadorA[cont];
                ama = ama + 1;
            }
            if (color == 2)
            {
                int cont = (az + 1) % 2;
                label5.Text = jugadorAz[cont];
                az = az + 1;
            }
        }

        public void Mover_ficha1(int dado)
        {
            if(color==1) // mover ficha amarillo
            {
                pos = pos + dado;
                amarillolbl.Location = posicionesA[pos - 1];
                string X;
                X =Convert.ToString(amarillolbl.Location.X);
                string Y;
                Y = Convert.ToString(amarillolbl.Location.Y);
                string mensaje = "13/" + X + "/" + Y + "/111/";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

            }
            if(color==2) // mover ficha azul
            {
                pos = pos + dado;
                azullbl.Location = posicionesAz[pos - 1];
                string X;
                X = Convert.ToString(azullbl.Location.X);
                string Y;
                Y = Convert.ToString(azullbl.Location.Y);
                string mensaje = "13/" + X + "/" + Y + "/222/";
               
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            if (color == 3) // mover ficha rojo
            {
                pos = pos + dado;
                rojolbl.Location = posicionesAz[pos - 1];
                string X;
                X = Convert.ToString(rojolbl.Location.X);
                string Y;
                Y = Convert.ToString(rojolbl.Location.Y);
                string mensaje = "13/" + X + "/" + Y + "/333/";
               
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            if (color == 4) // mover ficha verde
            {
                pos = pos + dado;
                verdelbl.Location = posicionesAz[pos - 1];
                string X;
                X = Convert.ToString(verdelbl.Location.X);
                string Y;
                Y = Convert.ToString(verdelbl.Location.Y);
                string mensaje = "13/" + X + "/" + Y + "/444/";
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        private void tablero_MouseMove(object sender, MouseEventArgs e)
        {
            //salen las coordenadas del tablero referidas a la posicion del mouse
            label4.Text = e.X.ToString() + "," + e.Y.ToString();
            
        }

        private void MoverAmarillo(Point p)
        { //mover ficha amarilla
            amarillolbl.Location = p;
        }
        delegate void DelegadoMover(Point p);

        private void MoverAzul(Point p)
        { //mover ficha azul
            azullbl.Location = p;
        }
        private void MoverRojo(Point p)
        { //mover ficha rojo
            rojolbl.Location = p;
        }
        private void MoverVerde(Point p)
        { //mover ficha verde
            verdelbl.Location = p;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

