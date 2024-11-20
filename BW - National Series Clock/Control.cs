using OfficeOpenXml;

namespace BW___National_Series_Clock
{
    public partial class Control : Form
    {
        public const int EQUIPO_A = 0;
        public const int EQUIPO_B = 1;

        public int INACTIVO = 3;
        public int PASIVE_TIME = 30;

        private int minutos = 3;
        private int segundos = 0;
        private int decimas = 0;

        public void SetMatchTime(int t)
        {
            minutos = t/60;
            segundos = t%60;
        }


        private int segundosI = 0;
        private int decimasI = 0;

        private int puntosA = 0;
        private int puntosB = 0;


        public Control()
        {
            InitializeComponent();
            CargarDatosDesdeArchivo("data/datos.xlsx");
        }

        private const int INICIADO = 1;
        private const int PAUSADO = 0;
        private int ESTADO = 0;
        private int indiceFilaActual = -1; // Inicializa el índice de fila actual

        private const int PUNTOS_A = 0;
        private const int PUNTOS_B = 0;

        private string numeroLucha, luchador1, equipo1, luchador2, equipo2, category, round;

        private Clock tablero;
        private TimeSettings timeSettings;

        private List<string[]> dataVector = new List<string[]>();

        private void CargarDatosDesdeArchivo(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("The file does not exist.");
                return;
            }

            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    // Clear existing data
                    dataVector.Clear();
                    dataGridView1.Rows.Clear();

                    // Iterate through rows and add data to vector and DataGridView
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        // Break if first cell is empty
                        if (string.IsNullOrWhiteSpace(worksheet.Cells[row, 1].Text))
                        {
                            break;
                        }

                        string[] rowData = new string[7];
                        for (int col = 0; col < 7; col++)
                        {
                            rowData[col] = worksheet.Cells[row, col + 1].Text;
                        }

                        // Add to vector
                        dataVector.Add(rowData);

                        // Add to DataGridView
                        dataGridView1.Rows.Add(rowData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }


            if (File.Exists(filePath))
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    // Limpiar el vector antes de cargar nuevos datos
                    dataVector.Clear();

                    // Iterar sobre las filas y columnas para leer y agregar los datos al vector
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        if (worksheet.Cells[row, 1].Text.ToString() == "")
                        {
                            break;
                        }

                        string[] rowData =
                        {
                            worksheet.Cells[row, 1].Text,
                            worksheet.Cells[row, 2].Text,
                            worksheet.Cells[row, 3].Text,
                            worksheet.Cells[row, 4].Text,
                            worksheet.Cells[row, 5].Text,
                            worksheet.Cells[row, 6].Text,
                            worksheet.Cells[row, 7].Text,
                        };

                        // Agregar la fila al vector
                        dataVector.Add(rowData);
                    }
                }
            }
        }

        public void IniciarTemporizador()
        {
            timer1.Start();
            timer2.Start();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ESTADO == PAUSADO)
                {
                    IniciarTemporizador();
                    btnIniciar.Text = "PAUSAR";
                    ESTADO = INICIADO;

                    btnReiniciar.Enabled = false;
                    btnInactivoA.Enabled = false;
                    btnInactivoB.Enabled = false;

                    btnResta1A.Enabled = false;
                    btnSuma1A.Enabled = false;
                    btnSuma1A.Enabled = false;
                    btnSuma3A.Enabled = false;

                    btnResta1B.Enabled = false;
                    btnSuma1B.Enabled = false;
                    btnSuma1B.Enabled = false;
                    btnSuma3B.Enabled = false;

                    btnNextMatch.Enabled = false;
                }
                else
                {
                    DetenerTemporizador();
                    btnIniciar.Text = "INICIAR";
                    ESTADO = PAUSADO;

                    btnReiniciar.Enabled = true;

                    btnInactivoA.Enabled = true;
                    btnInactivoB.Enabled = true;

                    btnResta1A.Enabled = true;
                    btnSuma1A.Enabled = true;
                    btnSuma1A.Enabled = true;
                    btnSuma3A.Enabled = true;

                    btnResta1B.Enabled = true;
                    btnSuma1B.Enabled = true;
                    btnSuma1B.Enabled = true;
                    btnSuma3B.Enabled = true;

                    btnNextMatch.Enabled = true;
                }
            } 
            catch (Exception ex){     
                Console.WriteLine(ex.Message); 
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarTemporizador();


            lblPuntosA.Text = "0";
            lblPuntosA.Font = new Font(lblPuntosA.Font, FontStyle.Regular);
            lblPuntosB.Text = "0";
            lblPuntosA.Font = new Font(lblPuntosA.Font, FontStyle.Regular);

            lblTimePasive.Text = "0";
            lblTimeMatch.Text = "3:00";

            btnIniciar.Text = "INICIAR";
            ESTADO = PAUSADO;
        }

        public void ReiniciarTemporizador()
        {
            minutos = 3;
            segundos = decimas = 0;
            lblPuntosA.Text = "0";
            lblPuntosB.Text = "0";
            lblTimePasive.Text = "";
            puntosA = 0;
            puntosB = 0;
            //lblTimeMatch.ForeColor = Color.White;
            INACTIVO = 3;
            timer2.Stop();

            lblPuntosA.Font = new Font(lblPuntosA.Font, FontStyle.Regular);
            lblPuntosB.Font = new Font(lblPuntosB.Font, FontStyle.Regular);

            ActualizarEtiquetaTiempo();
            tablero.setMetadata(minutos, segundos, decimas, segundosI, decimasI, puntosA, puntosB, INACTIVO);
        }

        private void btnResta1A_Click(object sender, EventArgs e)
        {
            AsignarPuntos(-1, EQUIPO_A);
        }

        private void btnSuma1A_Click(object sender, EventArgs e)
        {
            AsignarPuntos(1, EQUIPO_A);
        }

        private void btnSuma3A_Click(object sender, EventArgs e)
        {
            AsignarPuntos(3, EQUIPO_A);
        }

        private void btnResta1B_Click(object sender, EventArgs e)
        {
            AsignarPuntos(-1, EQUIPO_B);
        }

        private void btnSuma1B_Click(object sender, EventArgs e)
        {
            AsignarPuntos(1, EQUIPO_B);
        }

        private void btnSuma3B_Click(object sender, EventArgs e)
        {
            AsignarPuntos(3, EQUIPO_B);
        }

        private void btnInactivoA_Click(object sender, EventArgs e)
        {
            Inactivo(Clock.EQUIPO_A);
        }


        private void Inactivo(int equipo)
        {
            INACTIVO = equipo;
            lblTimePasive.Text = "0";
            segundosI = decimasI = 0;
        }

        private void tiemposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timeSettings == null || timeSettings.IsDisposed)
            {
                timeSettings = new TimeSettings();
                timeSettings.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                decimas--;
                if (decimas < 0)
                {
                    decimas = 9;
                    segundos--;
                    if (segundos < 0)
                    {
                        segundos = 59;
                        minutos--;
                        if (minutos < 0)
                        {
                            // Si minutos llega a -1, detén el temporizador y realiza las acciones necesarias.
                            DetenerTemporizador();
                            //labelTiempo.ForeColor = Color.DarkGoldenrod;
                            minutos = 0;
                            segundos = 0;
                            decimas = 0;
                        }
                    }
                }

                ActualizarEtiquetaTiempo();
                tablero.setMetadata(minutos, segundos, decimas, segundosI, decimasI, puntosA, puntosB, INACTIVO);

        }

        private void DetenerTemporizador()
        {
            timer1.Stop();
            timer2.Stop();
        }



        private void ActualizarEtiquetaTiempo()
        {
            // Actualiza la etiqueta con el tiempo formateado (minutos):(segundos):(décimas)
            lblTimeMatch.Text = $"{minutos:D}:{segundos:D2}";
        }

        private void AsignarPuntos(int value_point, int value_equipo)
        {
            if (value_equipo == EQUIPO_A) {
                puntosA = puntosA + value_point;
                lblPuntosA.Text = puntosA.ToString();
                lblPuntosA.Font = new Font(lblPuntosB.Font, FontStyle.Underline);
                lblPuntosB.Font = new Font(lblPuntosB.Font, FontStyle.Regular);
                tablero.setAthleteUnderline(EQUIPO_A);

            }
            else {
                puntosB = puntosB + value_point;
                lblPuntosB.Text = puntosB.ToString();
                lblPuntosB.Font = new Font(lblPuntosB.Font, FontStyle.Underline);
                lblPuntosA.Font = new Font(lblPuntosA.Font, FontStyle.Regular);
                tablero.setAthleteUnderline(EQUIPO_B);
            }
            tablero.setMetadata(minutos, segundos, decimas, segundosI, decimasI, puntosA, puntosB, INACTIVO);

            INACTIVO = 3;
            lblTimePasive.Text = "";
            segundosI = decimasI = 0;
            tablero.resetInactivo();



            DetenerTemporizador();
            btnIniciar.Text = "INICIAR";
            ESTADO = PAUSADO;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            {
                if (INACTIVO != 3)
                {
                    decimasI++;
                    if (decimasI == 10)
                    {
                        decimasI = 0;
                        segundosI++;
                    }

                    if (segundosI == PASIVE_TIME)
                    {
                        DetenerTemporizadorInactividad();
                        if (INACTIVO == EQUIPO_A)
                            AsignarPuntos(1, EQUIPO_B);
                        else
                            AsignarPuntos(1, EQUIPO_A);
                        INACTIVO = 3;
                        lblTimePasive.Text = "";
                        segundosI = decimasI = 0;
                        tablero.resetInactivo();
                    }
                    else
                    {
                        ActualizarEtiquetaTiempoInactivo();
                        tablero.setMetadata(minutos, segundos, decimas, segundosI, decimasI, puntosA, puntosB, INACTIVO);
                    }
                }
            }
        }

        private void ActualizarEtiquetaTiempoInactivo()
        {
            lblTimePasive.Text = $"{segundosI:D2}";
        }

        private void DetenerTemporizadorInactividad()
        {
            timer2.Stop();
        }

        private void btnInactivoB_Click(object sender, EventArgs e)
        {
            Inactivo(Clock.EQUIPO_B);
        }


        private void NextMatch_Click(object sender, EventArgs e)
        {
            // Increment index and loop back to the start if necessary
            indiceFilaActual++;
            if (indiceFilaActual >= dataVector.Count)
            {
                indiceFilaActual = 0;
            }

            // Get the selected row data
            string[] rowData = dataVector[indiceFilaActual];

            // Assign data to variables
            category = rowData[0];
            round = rowData[1];
            numeroLucha = rowData[2];
            luchador1 = rowData[3];
            equipo1 = rowData[4];
            luchador2 = rowData[5];
            equipo2 = rowData[6];



            // Puedes realizar las operaciones necesarias con los datos obtenidos
            SetMatch();

            // Highlight the current row in the DataGridView
            dataGridView1.ClearSelection();
            if (indiceFilaActual < dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[indiceFilaActual].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = indiceFilaActual;
            }
        }

        

        private void SetMatch()
        {
            try
            {
                lblNumeroLucha.Text = numeroLucha.ToString();
                lblWrestlerA.Text = luchador1;
                lblWrestlerB.Text = luchador2;
                lblTeamA.Text = equipo1;
                lblTeamB.Text = equipo2;
                tablero.SetearJugadores(Int32.Parse(numeroLucha), luchador1, equipo1, luchador2, equipo2, category, round);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
            
        }


        private void abrirRelojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablero == null || tablero.IsDisposed)
            {
                tablero = new Clock();
                tablero.Show();
            }
        }

        private void pantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablero.SetFullScreen();
        }
    }
}