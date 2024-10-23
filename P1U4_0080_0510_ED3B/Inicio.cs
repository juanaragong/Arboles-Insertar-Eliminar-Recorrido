using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1U4_0080_0510_ED3B
{
    public partial class Inicio : Form
    {
        string transicion;
        int puntosMensaje;
        int contadorTicks;
        SoundPlayer reproducir;
        public Inicio()
        {
            InitializeComponent();
            reproducir = new SoundPlayer(Properties.Resources.Wii_News_Channel____tip_cat__music);
            reproducir.PlayLooping();
        }

        private void Btn_iniciar_Click(object sender, EventArgs e)
        {
            pnl_barra.Visible = true;
            pnl_barra.BringToFront();
            TmCarga.Start();
        }

        #region Transicion
        private void TmTransicion_Tick(object sender, EventArgs e)
        {
            if (transicion == "Entrada")
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                    this.Top -= 2;
                }
                else
                {
                    TmTransicion.Stop();
                }
            }

            else if (transicion == "Cerrar")
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.05;
                    this.Left += 2;
                }
                else
                {
                    TmTransicion.Stop();
                    Application.Exit();
                }
            }

            else if (transicion == "Minimizar")
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.05;
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Opacity = 1;
                    TmTransicion.Stop();
                }
            }
            else if (transicion == "Salida")
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.05;
                    this.Top += 2;
                }
                else
                {
                    Form inicio = new Form1();
                    inicio.Show();
                    TmTransicion.Stop();
                    this.Hide();
                }
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            transicion = "Entrada";
            this.Top += 15;
            TmTransicion.Start();
        }

        private void Btn_minimizr_Click(object sender, EventArgs e)
        {
            transicion = "Minimizar";
            TmTransicion.Start();
            SystemSounds.Beep.Play();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar la aplicación?", "ARBOL BINARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                transicion = "Cerrar";
                TmTransicion.Start();
            }
        }
        #endregion

        private void TmCarga_Tick(object sender, EventArgs e)
        {
            pgbar_carga.Increment(5);
            Opacity -= 0.020;
            contadorTicks++;

            if (contadorTicks >= 4) 
            {
                puntosMensaje = (puntosMensaje + 1) % 4; //actualizar el mensaje con puntos del 0 a 3.
                lb_mensaje.Text = "Iniciando" + new string('.', puntosMensaje);
                contadorTicks = 0;
            }

            if (pgbar_carga.Value >= pgbar_carga.Maximum)
            {
                TmCarga.Stop();
                transicion = "Salida";
                TmTransicion.Start();
            }
        }
    }
}
