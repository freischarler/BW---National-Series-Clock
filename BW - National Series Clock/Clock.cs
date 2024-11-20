using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BW___National_Series_Clock
{
    public partial class Clock : Form
    {
        public const int EQUIPO_A = 0;
        public const int EQUIPO_B = 1;

        public int INACTIVO = 3;
        public int PASIVE_TIME = 30;

        public int minutos = 3;
        public int segundos = 0;
        public int decimas = 0;

        private int numeroLucha = 0;

        private string equipoA = "";
        private string equipoB = "";

        private string nombreA = "";
        private string nombreB = "";

        private string categoria = "";
        private string fase = "";

        private float windowSize = 0;

        public Clock()
        {
            InitializeComponent();
            lblClockInactivo.Text = "";

            lblPuntosA.Font = new Font(lblPuntosA.Font, FontStyle.Regular);
            lblPuntosB.Font = new Font(lblPuntosB.Font, FontStyle.Regular);

            lblPuntosA.Text = "0";
            lblPuntosB.Text = "0";

        }


        private bool isFullscreen = false;
        public void SetFullScreen()
        {
            ToggleFullscreen();
        }

        private void ToggleFullscreen()
        {
            if (isFullscreen)
            {
                // Exit fullscreen mode
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Enter fullscreen mode
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }

            isFullscreen = !isFullscreen;
        }


        private void Clock_SizeChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            // Ajusta dinámicamente el tamaño de la fuente en función del nuevo tamaño del formulario
            float newWindowsSize = (float)(this.Width / this.Height);

            windowSize = newWindowsSize;


            lblCategoria.Font = new Font("Futura Now Text", (lblCategoria.Font.Size * newWindowsSize / windowSize));

            /*// Actualiza el texto del label
            labelTiempo.Text = $"{minutos:D}:{segundos:D2}";*/
        }

        public void setMetadata(int minutos, int segundos, int decimas, int segundosI, int decimasI, int puntoA, int puntoB, int inactivo)
        {

            labelTiempo.Text = minutos.ToString() + ":" + $"{segundos:D2}";
            if (inactivo != 3)
            {
                lblClockInactivo.Text = $"{segundosI:D2}";
            }
            
            lblPuntosA.Text = puntoA.ToString();
            lblPuntosB.Text = puntoB.ToString();
        }

        public void resetInactivo()
        {
            lblClockInactivo.Text = "";
        }

        public void setAthleteUnderline(int athlete)
        {
            if (athlete == 0)
            {
                lblPuntosA.Font = new Font(lblPuntosA.Font, FontStyle.Underline);
                lblPuntosB.Font = new Font(lblPuntosB.Font, FontStyle.Regular);
            }
            else
            {
                lblPuntosA.Font = new Font(lblPuntosA.Font, FontStyle.Regular);
                lblPuntosB.Font = new Font(lblPuntosB.Font, FontStyle.Underline);
            }
               
        }

        public void SetearJugadores(int NL, string JA, string EA, string JB, string EB, string CAT, string ST)
        {
            nombreA = JA; lblNombreA.Text = nombreA;
            nombreB = JB; lblNombreB.Text = nombreB;
            equipoA = EA; lblEquipoA.Text = equipoA;
            equipoB = EB; lblEquipoB.Text = equipoB;

            pictureBox1.ImageLocation = "data/" + equipoA + ".jpg";
            pictureBox2.ImageLocation = "data/" + equipoB + ".jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            categoria = CAT; lblCategoria.Text = categoria;
            fase = ST; lblEtapa.Text = fase;
            numeroLucha = NL; lblNroLucha.Text = numeroLucha.ToString();
        }
    }

}
