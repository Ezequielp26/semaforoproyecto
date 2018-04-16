using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace semaforoproyecto
{
    public partial class Form1 : Form
    {
        int caso = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = semaforoproyecto.Properties.Resources.SEMAFORO_APAGO;
            btnApagar.Enabled = false;
            btnDetener.Enabled = false;



        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnEncender.Enabled = false;
            btnDetener.Enabled = true;
            btnApagar.Enabled = true;
            label1.Text = "Semaforo Encendido";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (caso)



                case 0:
                pictureBox1.Image = semaforoproyecto.Properties.Resources.SEMAFORO_VERDE;
                timer1.Interval = 5000;
                caso = 1;
                break;
            case 1:

                pictureBox1.Image = semaforoproyecto.Properties.Resources.SEMAFORO_AMARILLO;
                timer1.Interval = 2000;
                caso = 2;
                break;

            case 2:
                pictureBox1.Image = semaforoproyecto.Properties.Resources.SEMAFORO_ROJO;
                timer1.Interval = 5000;
                caso = 0;
                break;














            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (btnDetener.Text == "Detener")
            {
                timer1.Enabled = false;
                btnDetener.Text = "Reanudar";
                label1.Text = "Semaforo detenido";
            }
            else
             if (btnDetener.Text == "Reanudar")
            {
                timer1.Enabled = true;
                btnDetener.Text = "Detener";
                label1.Text = "Semaforo Encendido";            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnDetener.Enabled = false;
            btnApagar.Enabled = false;
            btnEncender.Enabled = true;
            pictureBox1.Image = semaforoproyecto.Properties.Resources.SEMAFORO_APAGO;
            label1.Text = "Semaforo Apagado";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } }



