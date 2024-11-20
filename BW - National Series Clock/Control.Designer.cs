namespace BW___National_Series_Clock
{
    partial class Control
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSuma1A = new System.Windows.Forms.Button();
            this.btnResta1A = new System.Windows.Forms.Button();
            this.btnSuma3A = new System.Windows.Forms.Button();
            this.btnSuma3B = new System.Windows.Forms.Button();
            this.btnResta1B = new System.Windows.Forms.Button();
            this.btnSuma1B = new System.Windows.Forms.Button();
            this.btnInactivoA = new System.Windows.Forms.Button();
            this.btnInactivoB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Round = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Match = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrestler1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrestler2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipe2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNextMatch = new System.Windows.Forms.Button();
            this.lblNumeroLucha = new System.Windows.Forms.Label();
            this.lblBeforeluta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.relojToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirRelojToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiemposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTimePasive = new System.Windows.Forms.Label();
            this.lblTextTimePasive = new System.Windows.Forms.Label();
            this.lblTextTimeMatch = new System.Windows.Forms.Label();
            this.lblTimeMatch = new System.Windows.Forms.Label();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.lblTextTeamB = new System.Windows.Forms.Label();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.lblTextTeamA = new System.Windows.Forms.Label();
            this.lblPuntosB = new System.Windows.Forms.Label();
            this.lblPuntosA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWrestlerB = new System.Windows.Forms.Label();
            this.lblWrestlerA = new System.Windows.Forms.Label();
            this.lblTextWB = new System.Windows.Forms.Label();
            this.lblTextWA = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.Location = new System.Drawing.Point(198, 22);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(99, 61);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReiniciar.Location = new System.Drawing.Point(382, 22);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(97, 61);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSuma1A
            // 
            this.btnSuma1A.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSuma1A.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma1A.ForeColor = System.Drawing.Color.Black;
            this.btnSuma1A.Location = new System.Drawing.Point(11, 18);
            this.btnSuma1A.Name = "btnSuma1A";
            this.btnSuma1A.Size = new System.Drawing.Size(75, 59);
            this.btnSuma1A.TabIndex = 4;
            this.btnSuma1A.Text = "+1";
            this.btnSuma1A.UseVisualStyleBackColor = false;
            this.btnSuma1A.Click += new System.EventHandler(this.btnSuma1A_Click);
            // 
            // btnResta1A
            // 
            this.btnResta1A.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnResta1A.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResta1A.ForeColor = System.Drawing.Color.Black;
            this.btnResta1A.Location = new System.Drawing.Point(404, 18);
            this.btnResta1A.Name = "btnResta1A";
            this.btnResta1A.Size = new System.Drawing.Size(75, 59);
            this.btnResta1A.TabIndex = 5;
            this.btnResta1A.Text = "-1";
            this.btnResta1A.UseVisualStyleBackColor = false;
            this.btnResta1A.Click += new System.EventHandler(this.btnResta1A_Click);
            // 
            // btnSuma3A
            // 
            this.btnSuma3A.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSuma3A.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma3A.ForeColor = System.Drawing.Color.Black;
            this.btnSuma3A.Location = new System.Drawing.Point(92, 18);
            this.btnSuma3A.Name = "btnSuma3A";
            this.btnSuma3A.Size = new System.Drawing.Size(75, 59);
            this.btnSuma3A.TabIndex = 6;
            this.btnSuma3A.Text = "+3";
            this.btnSuma3A.UseVisualStyleBackColor = false;
            this.btnSuma3A.Click += new System.EventHandler(this.btnSuma3A_Click);
            // 
            // btnSuma3B
            // 
            this.btnSuma3B.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSuma3B.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma3B.ForeColor = System.Drawing.Color.Black;
            this.btnSuma3B.Location = new System.Drawing.Point(92, 22);
            this.btnSuma3B.Name = "btnSuma3B";
            this.btnSuma3B.Size = new System.Drawing.Size(75, 59);
            this.btnSuma3B.TabIndex = 9;
            this.btnSuma3B.Text = "+3";
            this.btnSuma3B.UseVisualStyleBackColor = false;
            this.btnSuma3B.Click += new System.EventHandler(this.btnSuma3B_Click);
            // 
            // btnResta1B
            // 
            this.btnResta1B.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnResta1B.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResta1B.ForeColor = System.Drawing.Color.Black;
            this.btnResta1B.Location = new System.Drawing.Point(404, 22);
            this.btnResta1B.Name = "btnResta1B";
            this.btnResta1B.Size = new System.Drawing.Size(75, 59);
            this.btnResta1B.TabIndex = 8;
            this.btnResta1B.Text = "-1";
            this.btnResta1B.UseVisualStyleBackColor = false;
            this.btnResta1B.Click += new System.EventHandler(this.btnResta1B_Click);
            // 
            // btnSuma1B
            // 
            this.btnSuma1B.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSuma1B.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma1B.ForeColor = System.Drawing.Color.Black;
            this.btnSuma1B.Location = new System.Drawing.Point(11, 22);
            this.btnSuma1B.Name = "btnSuma1B";
            this.btnSuma1B.Size = new System.Drawing.Size(75, 59);
            this.btnSuma1B.TabIndex = 7;
            this.btnSuma1B.Text = "+1";
            this.btnSuma1B.UseVisualStyleBackColor = false;
            this.btnSuma1B.Click += new System.EventHandler(this.btnSuma1B_Click);
            // 
            // btnInactivoA
            // 
            this.btnInactivoA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInactivoA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInactivoA.ForeColor = System.Drawing.Color.Black;
            this.btnInactivoA.Location = new System.Drawing.Point(185, 19);
            this.btnInactivoA.Name = "btnInactivoA";
            this.btnInactivoA.Size = new System.Drawing.Size(131, 59);
            this.btnInactivoA.TabIndex = 10;
            this.btnInactivoA.Text = "INACTIVIDAD";
            this.btnInactivoA.UseVisualStyleBackColor = false;
            this.btnInactivoA.Click += new System.EventHandler(this.btnInactivoA_Click);
            // 
            // btnInactivoB
            // 
            this.btnInactivoB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInactivoB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInactivoB.ForeColor = System.Drawing.Color.Black;
            this.btnInactivoB.Location = new System.Drawing.Point(185, 22);
            this.btnInactivoB.Name = "btnInactivoB";
            this.btnInactivoB.Size = new System.Drawing.Size(131, 59);
            this.btnInactivoB.TabIndex = 11;
            this.btnInactivoB.Text = "INACTIVIDAD";
            this.btnInactivoB.UseVisualStyleBackColor = false;
            this.btnInactivoB.Click += new System.EventHandler(this.btnInactivoB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Round,
            this.Match,
            this.Wrestler1,
            this.Equipe1,
            this.Wrestler2,
            this.Equipe2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(885, 123);
            this.dataGridView1.TabIndex = 12;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Round
            // 
            this.Round.HeaderText = "Round";
            this.Round.Name = "Round";
            // 
            // Match
            // 
            this.Match.HeaderText = "Match";
            this.Match.Name = "Match";
            // 
            // Wrestler1
            // 
            this.Wrestler1.HeaderText = "Wrestler 1";
            this.Wrestler1.Name = "Wrestler1";
            // 
            // Equipe1
            // 
            this.Equipe1.HeaderText = "Equip 1";
            this.Equipe1.Name = "Equipe1";
            // 
            // Wrestler2
            // 
            this.Wrestler2.HeaderText = "Wrestler 2";
            this.Wrestler2.Name = "Wrestler2";
            // 
            // Equipe2
            // 
            this.Equipe2.HeaderText = "Equip 2";
            this.Equipe2.Name = "Equipe2";
            // 
            // btnNextMatch
            // 
            this.btnNextMatch.Location = new System.Drawing.Point(11, 22);
            this.btnNextMatch.Name = "btnNextMatch";
            this.btnNextMatch.Size = new System.Drawing.Size(80, 61);
            this.btnNextMatch.TabIndex = 14;
            this.btnNextMatch.Text = "SIGUIENTE LUCHA";
            this.btnNextMatch.UseVisualStyleBackColor = true;
            this.btnNextMatch.Click += new System.EventHandler(this.NextMatch_Click);
            // 
            // lblNumeroLucha
            // 
            this.lblNumeroLucha.AutoSize = true;
            this.lblNumeroLucha.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroLucha.Location = new System.Drawing.Point(130, 27);
            this.lblNumeroLucha.Name = "lblNumeroLucha";
            this.lblNumeroLucha.Size = new System.Drawing.Size(37, 47);
            this.lblNumeroLucha.TabIndex = 15;
            this.lblNumeroLucha.Text = "1";
            // 
            // lblBeforeluta
            // 
            this.lblBeforeluta.AutoSize = true;
            this.lblBeforeluta.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBeforeluta.Location = new System.Drawing.Point(92, 27);
            this.lblBeforeluta.Name = "lblBeforeluta";
            this.lblBeforeluta.Size = new System.Drawing.Size(41, 47);
            this.lblBeforeluta.TabIndex = 17;
            this.lblBeforeluta.Text = "#";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.btnNextMatch);
            this.groupBox1.Controls.Add(this.lblNumeroLucha);
            this.groupBox1.Controls.Add(this.lblBeforeluta);
            this.groupBox1.Location = new System.Drawing.Point(12, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnSuma1A);
            this.groupBox2.Controls.Add(this.btnSuma3A);
            this.groupBox2.Controls.Add(this.btnInactivoA);
            this.groupBox2.Controls.Add(this.btnResta1A);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 84);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wresler 1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Controls.Add(this.btnSuma1B);
            this.groupBox3.Controls.Add(this.btnInactivoB);
            this.groupBox3.Controls.Add(this.btnSuma3B);
            this.groupBox3.Controls.Add(this.btnResta1B);
            this.groupBox3.Location = new System.Drawing.Point(12, 592);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 100);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wrestler 2";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relojToolStripMenuItem,
            this.ajustesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(951, 24);
            this.menuStrip2.TabIndex = 23;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // relojToolStripMenuItem
            // 
            this.relojToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirRelojToolStripMenuItem,
            this.pantallaCompletaToolStripMenuItem});
            this.relojToolStripMenuItem.Name = "relojToolStripMenuItem";
            this.relojToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.relojToolStripMenuItem.Text = "Reloj";
            // 
            // abrirRelojToolStripMenuItem
            // 
            this.abrirRelojToolStripMenuItem.Name = "abrirRelojToolStripMenuItem";
            this.abrirRelojToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.abrirRelojToolStripMenuItem.Text = "Abrir reloj";
            this.abrirRelojToolStripMenuItem.Click += new System.EventHandler(this.abrirRelojToolStripMenuItem_Click);
            // 
            // pantallaCompletaToolStripMenuItem
            // 
            this.pantallaCompletaToolStripMenuItem.Name = "pantallaCompletaToolStripMenuItem";
            this.pantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pantallaCompletaToolStripMenuItem.Text = "Pantalla completa";
            this.pantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.pantallaCompletaToolStripMenuItem_Click);
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiemposToolStripMenuItem,
            this.idiomaToolStripMenuItem});
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // tiemposToolStripMenuItem
            // 
            this.tiemposToolStripMenuItem.Name = "tiemposToolStripMenuItem";
            this.tiemposToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.tiemposToolStripMenuItem.Text = "Tiempos";
            this.tiemposToolStripMenuItem.Click += new System.EventHandler(this.tiemposToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTimePasive);
            this.groupBox4.Controls.Add(this.lblTextTimePasive);
            this.groupBox4.Controls.Add(this.lblTextTimeMatch);
            this.groupBox4.Controls.Add(this.lblTimeMatch);
            this.groupBox4.Controls.Add(this.lblTeamB);
            this.groupBox4.Controls.Add(this.lblTextTeamB);
            this.groupBox4.Controls.Add(this.lblTeamA);
            this.groupBox4.Controls.Add(this.lblTextTeamA);
            this.groupBox4.Controls.Add(this.lblPuntosB);
            this.groupBox4.Controls.Add(this.lblPuntosA);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblWrestlerB);
            this.groupBox4.Controls.Add(this.lblWrestlerA);
            this.groupBox4.Controls.Add(this.lblTextWB);
            this.groupBox4.Controls.Add(this.lblTextWA);
            this.groupBox4.Location = new System.Drawing.Point(12, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(625, 137);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Match";
            // 
            // lblTimePasive
            // 
            this.lblTimePasive.AutoSize = true;
            this.lblTimePasive.Location = new System.Drawing.Point(510, 30);
            this.lblTimePasive.Name = "lblTimePasive";
            this.lblTimePasive.Size = new System.Drawing.Size(13, 15);
            this.lblTimePasive.TabIndex = 27;
            this.lblTimePasive.Text = "0";
            // 
            // lblTextTimePasive
            // 
            this.lblTextTimePasive.AutoSize = true;
            this.lblTextTimePasive.Location = new System.Drawing.Point(510, 16);
            this.lblTextTimePasive.Name = "lblTextTimePasive";
            this.lblTextTimePasive.Size = new System.Drawing.Size(57, 15);
            this.lblTextTimePasive.TabIndex = 26;
            this.lblTextTimePasive.Text = "Pasividad";
            // 
            // lblTextTimeMatch
            // 
            this.lblTextTimeMatch.AutoSize = true;
            this.lblTextTimeMatch.Location = new System.Drawing.Point(441, 14);
            this.lblTextTimeMatch.Name = "lblTextTimeMatch";
            this.lblTextTimeMatch.Size = new System.Drawing.Size(47, 15);
            this.lblTextTimeMatch.TabIndex = 12;
            this.lblTextTimeMatch.Text = "Tiempo";
            // 
            // lblTimeMatch
            // 
            this.lblTimeMatch.AutoSize = true;
            this.lblTimeMatch.Location = new System.Drawing.Point(441, 29);
            this.lblTimeMatch.Name = "lblTimeMatch";
            this.lblTimeMatch.Size = new System.Drawing.Size(13, 15);
            this.lblTimeMatch.TabIndex = 11;
            this.lblTimeMatch.Text = "0";
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.Location = new System.Drawing.Point(130, 110);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(14, 15);
            this.lblTeamB.TabIndex = 10;
            this.lblTeamB.Text = "B";
            // 
            // lblTextTeamB
            // 
            this.lblTextTeamB.AutoSize = true;
            this.lblTextTeamB.Location = new System.Drawing.Point(70, 110);
            this.lblTextTeamB.Name = "lblTextTeamB";
            this.lblTextTeamB.Size = new System.Drawing.Size(38, 15);
            this.lblTextTeamB.TabIndex = 9;
            this.lblTextTeamB.Text = "Team:";
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.Location = new System.Drawing.Point(130, 53);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(15, 15);
            this.lblTeamA.TabIndex = 8;
            this.lblTeamA.Text = "A";
            // 
            // lblTextTeamA
            // 
            this.lblTextTeamA.AutoSize = true;
            this.lblTextTeamA.Location = new System.Drawing.Point(70, 53);
            this.lblTextTeamA.Name = "lblTextTeamA";
            this.lblTextTeamA.Size = new System.Drawing.Size(38, 15);
            this.lblTextTeamA.TabIndex = 7;
            this.lblTextTeamA.Text = "Team:";
            // 
            // lblPuntosB
            // 
            this.lblPuntosB.AutoSize = true;
            this.lblPuntosB.Location = new System.Drawing.Point(343, 85);
            this.lblPuntosB.Name = "lblPuntosB";
            this.lblPuntosB.Size = new System.Drawing.Size(13, 15);
            this.lblPuntosB.TabIndex = 6;
            this.lblPuntosB.Text = "0";
            // 
            // lblPuntosA
            // 
            this.lblPuntosA.AutoSize = true;
            this.lblPuntosA.Location = new System.Drawing.Point(343, 29);
            this.lblPuntosA.Name = "lblPuntosA";
            this.lblPuntosA.Size = new System.Drawing.Size(13, 15);
            this.lblPuntosA.TabIndex = 5;
            this.lblPuntosA.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puntos";
            // 
            // lblWrestlerB
            // 
            this.lblWrestlerB.AutoSize = true;
            this.lblWrestlerB.Location = new System.Drawing.Point(130, 85);
            this.lblWrestlerB.Name = "lblWrestlerB";
            this.lblWrestlerB.Size = new System.Drawing.Size(14, 15);
            this.lblWrestlerB.TabIndex = 3;
            this.lblWrestlerB.Text = "B";
            // 
            // lblWrestlerA
            // 
            this.lblWrestlerA.AutoSize = true;
            this.lblWrestlerA.Location = new System.Drawing.Point(130, 29);
            this.lblWrestlerA.Name = "lblWrestlerA";
            this.lblWrestlerA.Size = new System.Drawing.Size(15, 15);
            this.lblWrestlerA.TabIndex = 2;
            this.lblWrestlerA.Text = "A";
            // 
            // lblTextWB
            // 
            this.lblTextWB.AutoSize = true;
            this.lblTextWB.Location = new System.Drawing.Point(11, 85);
            this.lblTextWB.Name = "lblTextWB";
            this.lblTextWB.Size = new System.Drawing.Size(97, 15);
            this.lblTextWB.TabIndex = 1;
            this.lblTextWB.Text = "Wrestler 2 Name:";
            // 
            // lblTextWA
            // 
            this.lblTextWA.AutoSize = true;
            this.lblTextWA.Location = new System.Drawing.Point(11, 29);
            this.lblTextWA.Name = "lblTextWA";
            this.lblTextWA.Size = new System.Drawing.Size(97, 15);
            this.lblTextWA.TabIndex = 0;
            this.lblTextWA.Text = "Wrestler 1 Name:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 698);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Control";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnIniciar;
        private Button btnReiniciar;
        private Button btnSuma1A;
        private Button btnResta1A;
        private Button btnSuma3A;
        private Button btnSuma3B;
        private Button btnResta1B;
        private Button btnSuma1B;
        private Button btnInactivoA;
        private Button btnInactivoB;
        private DataGridView dataGridView1;
        private Button btnNextMatch;
        private Label lblNumeroLucha;
        private Label lblBeforeluta;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Round;
        private DataGridViewTextBoxColumn Match;
        private DataGridViewTextBoxColumn Wrestler1;
        private DataGridViewTextBoxColumn Equipe1;
        private DataGridViewTextBoxColumn Wrestler2;
        private DataGridViewTextBoxColumn Equipe2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem relojToolStripMenuItem;
        private ToolStripMenuItem abrirRelojToolStripMenuItem;
        private ToolStripMenuItem pantallaCompletaToolStripMenuItem;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private ToolStripMenuItem tiemposToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox4;
        private Label label5;
        private Label lblWrestlerB;
        private Label lblWrestlerA;
        private Label lblTextWB;
        private Label lblTextWA;
        private Label lblPuntosB;
        private Label lblPuntosA;
        private Label lblTeamA;
        private Label lblTextTeamA;
        private Label lblTeamB;
        private Label lblTextTeamB;
        private ToolStripMenuItem idiomaToolStripMenuItem;
        private Label lblTextTimeMatch;
        private Label lblTimeMatch;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimePasive;
        private Label lblTextTimePasive;
        private System.Windows.Forms.Timer timer2;
    }
}