namespace Gerador_Cobol
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDesenvolvedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnalista = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.chkBalanceLine = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.rdbSaida = new System.Windows.Forms.RadioButton();
            this.groupArquivo = new System.Windows.Forms.GroupBox();
            this.lstArquivo = new System.Windows.Forms.ListView();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddArquivo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookArquivo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstSubPrograma = new System.Windows.Forms.ListView();
            this.txtSubPrograma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddSubPrograma = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookSubPrograma = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbFB = new System.Windows.Forms.RadioButton();
            this.rdbVB = new System.Windows.Forms.RadioButton();
            this.txtTamanhoArquivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbArquivo1 = new System.Windows.Forms.ComboBox();
            this.cmbArquivo2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdb1_1 = new System.Windows.Forms.RadioButton();
            this.rdbN_1 = new System.Windows.Forms.RadioButton();
            this.rdbN_N = new System.Windows.Forms.RadioButton();
            this.rdb1_N = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIndArquivo1 = new System.Windows.Forms.TextBox();
            this.txtIndArquivo2 = new System.Windows.Forms.TextBox();
            this.Tamanho = new System.Windows.Forms.GroupBox();
            this.btnLimparArquivos = new System.Windows.Forms.Button();
            this.btnLimparSub = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparTabela = new System.Windows.Forms.Button();
            this.lstTabela = new System.Windows.Forms.ListView();
            this.txtTabela = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddTabela = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDclgen = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.chkInsert = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkCursor = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.groupArquivo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Tamanho.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesenvolvedor
            // 
            this.txtDesenvolvedor.Location = new System.Drawing.Point(25, 94);
            this.txtDesenvolvedor.MaxLength = 50;
            this.txtDesenvolvedor.Name = "txtDesenvolvedor";
            this.txtDesenvolvedor.Size = new System.Drawing.Size(260, 20);
            this.txtDesenvolvedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desenvolvedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Analista";
            // 
            // TxtAnalista
            // 
            this.TxtAnalista.Location = new System.Drawing.Point(25, 142);
            this.TxtAnalista.MaxLength = 50;
            this.TxtAnalista.Name = "TxtAnalista";
            this.TxtAnalista.Size = new System.Drawing.Size(260, 20);
            this.TxtAnalista.TabIndex = 2;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 445);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(1239, 33);
            this.btnGerar.TabIndex = 23;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // chkBalanceLine
            // 
            this.chkBalanceLine.AutoSize = true;
            this.chkBalanceLine.Checked = true;
            this.chkBalanceLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBalanceLine.Location = new System.Drawing.Point(6, 19);
            this.chkBalanceLine.Name = "chkBalanceLine";
            this.chkBalanceLine.Size = new System.Drawing.Size(88, 17);
            this.chkBalanceLine.TabIndex = 14;
            this.chkBalanceLine.Text = "Balance Line";
            this.chkBalanceLine.UseVisualStyleBackColor = true;
            this.chkBalanceLine.CheckedChanged += new System.EventHandler(this.chkBalanceLine_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome do programa";
            // 
            // txtPrograma
            // 
            this.txtPrograma.Location = new System.Drawing.Point(25, 46);
            this.txtPrograma.MaxLength = 8;
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(260, 20);
            this.txtPrograma.TabIndex = 0;
            // 
            // rdbEntrada
            // 
            this.rdbEntrada.AutoSize = true;
            this.rdbEntrada.Checked = true;
            this.rdbEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEntrada.Location = new System.Drawing.Point(6, 19);
            this.rdbEntrada.Name = "rdbEntrada";
            this.rdbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rdbEntrada.TabIndex = 3;
            this.rdbEntrada.TabStop = true;
            this.rdbEntrada.Text = "Entrada";
            this.rdbEntrada.UseVisualStyleBackColor = true;
            // 
            // rdbSaida
            // 
            this.rdbSaida.AutoSize = true;
            this.rdbSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbSaida.Location = new System.Drawing.Point(90, 19);
            this.rdbSaida.Name = "rdbSaida";
            this.rdbSaida.Size = new System.Drawing.Size(54, 17);
            this.rdbSaida.TabIndex = 4;
            this.rdbSaida.Text = "Saída";
            this.rdbSaida.UseVisualStyleBackColor = true;
            // 
            // groupArquivo
            // 
            this.groupArquivo.Controls.Add(this.btnLimparArquivos);
            this.groupArquivo.Controls.Add(this.Tamanho);
            this.groupArquivo.Controls.Add(this.txtTamanhoArquivo);
            this.groupArquivo.Controls.Add(this.label8);
            this.groupArquivo.Controls.Add(this.lstArquivo);
            this.groupArquivo.Controls.Add(this.txtNomeArquivo);
            this.groupArquivo.Controls.Add(this.label3);
            this.groupArquivo.Controls.Add(this.btnAddArquivo);
            this.groupArquivo.Controls.Add(this.label5);
            this.groupArquivo.Controls.Add(this.rdbEntrada);
            this.groupArquivo.Controls.Add(this.txtBookArquivo);
            this.groupArquivo.Controls.Add(this.rdbSaida);
            this.groupArquivo.Location = new System.Drawing.Point(350, 12);
            this.groupArquivo.Name = "groupArquivo";
            this.groupArquivo.Size = new System.Drawing.Size(337, 418);
            this.groupArquivo.TabIndex = 10;
            this.groupArquivo.TabStop = false;
            this.groupArquivo.Text = "Arquivos";
            // 
            // lstArquivo
            // 
            this.lstArquivo.HideSelection = false;
            this.lstArquivo.Location = new System.Drawing.Point(9, 216);
            this.lstArquivo.Name = "lstArquivo";
            this.lstArquivo.Size = new System.Drawing.Size(322, 196);
            this.lstArquivo.TabIndex = 11;
            this.lstArquivo.TileSize = new System.Drawing.Size(322, 30);
            this.lstArquivo.UseCompatibleStateImageBehavior = false;
            this.lstArquivo.View = System.Windows.Forms.View.Tile;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(9, 67);
            this.txtNomeArquivo.MaxLength = 8;
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(147, 20);
            this.txtNomeArquivo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome do arquivo";
            // 
            // btnAddArquivo
            // 
            this.btnAddArquivo.Location = new System.Drawing.Point(9, 155);
            this.btnAddArquivo.Name = "btnAddArquivo";
            this.btnAddArquivo.Size = new System.Drawing.Size(322, 23);
            this.btnAddArquivo.TabIndex = 10;
            this.btnAddArquivo.Text = "Adicionar";
            this.btnAddArquivo.UseVisualStyleBackColor = true;
            this.btnAddArquivo.Click += new System.EventHandler(this.btnAddArquivo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Book";
            // 
            // txtBookArquivo
            // 
            this.txtBookArquivo.Location = new System.Drawing.Point(183, 66);
            this.txtBookArquivo.MaxLength = 8;
            this.txtBookArquivo.Name = "txtBookArquivo";
            this.txtBookArquivo.Size = new System.Drawing.Size(148, 20);
            this.txtBookArquivo.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtAnalista);
            this.groupBox2.Controls.Add(this.txtDesenvolvedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPrograma);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 191);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identificação";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimparSub);
            this.groupBox3.Controls.Add(this.lstSubPrograma);
            this.groupBox3.Controls.Add(this.txtSubPrograma);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnAddSubPrograma);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBookSubPrograma);
            this.groupBox3.Location = new System.Drawing.Point(714, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 418);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sub programas";
            // 
            // lstSubPrograma
            // 
            this.lstSubPrograma.HideSelection = false;
            this.lstSubPrograma.Location = new System.Drawing.Point(9, 216);
            this.lstSubPrograma.Name = "lstSubPrograma";
            this.lstSubPrograma.Size = new System.Drawing.Size(245, 196);
            this.lstSubPrograma.TabIndex = 11;
            this.lstSubPrograma.TileSize = new System.Drawing.Size(245, 30);
            this.lstSubPrograma.UseCompatibleStateImageBehavior = false;
            this.lstSubPrograma.View = System.Windows.Forms.View.Tile;
            // 
            // txtSubPrograma
            // 
            this.txtSubPrograma.Location = new System.Drawing.Point(9, 44);
            this.txtSubPrograma.MaxLength = 8;
            this.txtSubPrograma.Name = "txtSubPrograma";
            this.txtSubPrograma.Size = new System.Drawing.Size(115, 20);
            this.txtSubPrograma.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome Subprograma";
            // 
            // btnAddSubPrograma
            // 
            this.btnAddSubPrograma.Location = new System.Drawing.Point(9, 155);
            this.btnAddSubPrograma.Name = "btnAddSubPrograma";
            this.btnAddSubPrograma.Size = new System.Drawing.Size(245, 23);
            this.btnAddSubPrograma.TabIndex = 13;
            this.btnAddSubPrograma.Text = "Adicionar";
            this.btnAddSubPrograma.UseVisualStyleBackColor = true;
            this.btnAddSubPrograma.Click += new System.EventHandler(this.btnAddSubPrograma_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Book";
            // 
            // txtBookSubPrograma
            // 
            this.txtBookSubPrograma.Location = new System.Drawing.Point(144, 44);
            this.txtBookSubPrograma.MaxLength = 8;
            this.txtBookSubPrograma.Name = "txtBookSubPrograma";
            this.txtBookSubPrograma.Size = new System.Drawing.Size(110, 20);
            this.txtBookSubPrograma.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtIndArquivo2);
            this.groupBox4.Controls.Add(this.txtIndArquivo1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cmbArquivo2);
            this.groupBox4.Controls.Add(this.cmbArquivo1);
            this.groupBox4.Controls.Add(this.chkBalanceLine);
            this.groupBox4.Location = new System.Drawing.Point(12, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 221);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Balance Line";
            // 
            // rdbFB
            // 
            this.rdbFB.AutoSize = true;
            this.rdbFB.Checked = true;
            this.rdbFB.Location = new System.Drawing.Point(6, 19);
            this.rdbFB.Name = "rdbFB";
            this.rdbFB.Size = new System.Drawing.Size(44, 17);
            this.rdbFB.TabIndex = 8;
            this.rdbFB.TabStop = true;
            this.rdbFB.Text = "Fixo";
            this.rdbFB.UseVisualStyleBackColor = true;
            // 
            // rdbVB
            // 
            this.rdbVB.AutoSize = true;
            this.rdbVB.Location = new System.Drawing.Point(79, 19);
            this.rdbVB.Name = "rdbVB";
            this.rdbVB.Size = new System.Drawing.Size(63, 17);
            this.rdbVB.TabIndex = 9;
            this.rdbVB.Text = "Variável";
            this.rdbVB.UseVisualStyleBackColor = true;
            // 
            // txtTamanhoArquivo
            // 
            this.txtTamanhoArquivo.Location = new System.Drawing.Point(9, 105);
            this.txtTamanhoArquivo.MaxLength = 7;
            this.txtTamanhoArquivo.Name = "txtTamanhoArquivo";
            this.txtTamanhoArquivo.Size = new System.Drawing.Size(115, 20);
            this.txtTamanhoArquivo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tamanho";
            // 
            // cmbArquivo1
            // 
            this.cmbArquivo1.FormattingEnabled = true;
            this.cmbArquivo1.Location = new System.Drawing.Point(6, 66);
            this.cmbArquivo1.Name = "cmbArquivo1";
            this.cmbArquivo1.Size = new System.Drawing.Size(135, 21);
            this.cmbArquivo1.TabIndex = 15;
            // 
            // cmbArquivo2
            // 
            this.cmbArquivo2.FormattingEnabled = true;
            this.cmbArquivo2.Location = new System.Drawing.Point(168, 67);
            this.cmbArquivo2.Name = "cmbArquivo2";
            this.cmbArquivo2.Size = new System.Drawing.Size(129, 21);
            this.cmbArquivo2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Arquivo 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Arquivo 2";
            // 
            // rdb1_1
            // 
            this.rdb1_1.AutoSize = true;
            this.rdb1_1.Checked = true;
            this.rdb1_1.Location = new System.Drawing.Point(6, 23);
            this.rdb1_1.Name = "rdb1_1";
            this.rdb1_1.Size = new System.Drawing.Size(64, 17);
            this.rdb1_1.TabIndex = 19;
            this.rdb1_1.TabStop = true;
            this.rdb1_1.Text = "1 para 1";
            this.rdb1_1.UseVisualStyleBackColor = true;
            // 
            // rdbN_1
            // 
            this.rdbN_1.AutoSize = true;
            this.rdbN_1.Location = new System.Drawing.Point(148, 23);
            this.rdbN_1.Name = "rdbN_1";
            this.rdbN_1.Size = new System.Drawing.Size(66, 17);
            this.rdbN_1.TabIndex = 21;
            this.rdbN_1.Text = "N para 1";
            this.rdbN_1.UseVisualStyleBackColor = true;
            // 
            // rdbN_N
            // 
            this.rdbN_N.AutoSize = true;
            this.rdbN_N.Location = new System.Drawing.Point(217, 23);
            this.rdbN_N.Name = "rdbN_N";
            this.rdbN_N.Size = new System.Drawing.Size(68, 17);
            this.rdbN_N.TabIndex = 22;
            this.rdbN_N.Text = "N para N";
            this.rdbN_N.UseVisualStyleBackColor = true;
            // 
            // rdb1_N
            // 
            this.rdb1_N.AutoSize = true;
            this.rdb1_N.Location = new System.Drawing.Point(76, 23);
            this.rdb1_N.Name = "rdb1_N";
            this.rdb1_N.Size = new System.Drawing.Size(66, 17);
            this.rdb1_N.TabIndex = 20;
            this.rdb1_N.Text = "1 para N";
            this.rdb1_N.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdbN_1);
            this.groupBox5.Controls.Add(this.rdb1_N);
            this.groupBox5.Controls.Add(this.rdb1_1);
            this.groupBox5.Controls.Add(this.rdbN_N);
            this.groupBox5.Location = new System.Drawing.Point(6, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 60);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo de Balance Line";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Índice arquivo 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Índice arquivo 1";
            // 
            // txtIndArquivo1
            // 
            this.txtIndArquivo1.Location = new System.Drawing.Point(6, 106);
            this.txtIndArquivo1.MaxLength = 30;
            this.txtIndArquivo1.Name = "txtIndArquivo1";
            this.txtIndArquivo1.Size = new System.Drawing.Size(135, 20);
            this.txtIndArquivo1.TabIndex = 17;
            // 
            // txtIndArquivo2
            // 
            this.txtIndArquivo2.Location = new System.Drawing.Point(168, 106);
            this.txtIndArquivo2.MaxLength = 30;
            this.txtIndArquivo2.Name = "txtIndArquivo2";
            this.txtIndArquivo2.Size = new System.Drawing.Size(129, 20);
            this.txtIndArquivo2.TabIndex = 18;
            // 
            // Tamanho
            // 
            this.Tamanho.Controls.Add(this.rdbFB);
            this.Tamanho.Controls.Add(this.rdbVB);
            this.Tamanho.Location = new System.Drawing.Point(183, 93);
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.Size = new System.Drawing.Size(148, 43);
            this.Tamanho.TabIndex = 19;
            this.Tamanho.TabStop = false;
            this.Tamanho.Text = "FB / VB";
            // 
            // btnLimparArquivos
            // 
            this.btnLimparArquivos.Location = new System.Drawing.Point(9, 184);
            this.btnLimparArquivos.Name = "btnLimparArquivos";
            this.btnLimparArquivos.Size = new System.Drawing.Size(322, 23);
            this.btnLimparArquivos.TabIndex = 20;
            this.btnLimparArquivos.Text = "Limpar";
            this.btnLimparArquivos.UseVisualStyleBackColor = true;
            this.btnLimparArquivos.Click += new System.EventHandler(this.btnLimparArquivos_Click);
            // 
            // btnLimparSub
            // 
            this.btnLimparSub.Location = new System.Drawing.Point(9, 184);
            this.btnLimparSub.Name = "btnLimparSub";
            this.btnLimparSub.Size = new System.Drawing.Size(245, 23);
            this.btnLimparSub.TabIndex = 21;
            this.btnLimparSub.Text = "Limpar";
            this.btnLimparSub.UseVisualStyleBackColor = true;
            this.btnLimparSub.Click += new System.EventHandler(this.btnLimparSub_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.btnLimparTabela);
            this.groupBox1.Controls.Add(this.lstTabela);
            this.groupBox1.Controls.Add(this.txtTabela);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnAddTabela);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtDclgen);
            this.groupBox1.Location = new System.Drawing.Point(991, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 418);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB2";
            // 
            // btnLimparTabela
            // 
            this.btnLimparTabela.Location = new System.Drawing.Point(9, 184);
            this.btnLimparTabela.Name = "btnLimparTabela";
            this.btnLimparTabela.Size = new System.Drawing.Size(245, 23);
            this.btnLimparTabela.TabIndex = 21;
            this.btnLimparTabela.Text = "Limpar";
            this.btnLimparTabela.UseVisualStyleBackColor = true;
            this.btnLimparTabela.Click += new System.EventHandler(this.btnLimparTabela_Click);
            // 
            // lstTabela
            // 
            this.lstTabela.HideSelection = false;
            this.lstTabela.Location = new System.Drawing.Point(9, 216);
            this.lstTabela.Name = "lstTabela";
            this.lstTabela.Size = new System.Drawing.Size(245, 196);
            this.lstTabela.TabIndex = 11;
            this.lstTabela.TileSize = new System.Drawing.Size(245, 30);
            this.lstTabela.UseCompatibleStateImageBehavior = false;
            this.lstTabela.View = System.Windows.Forms.View.Tile;
            // 
            // txtTabela
            // 
            this.txtTabela.Location = new System.Drawing.Point(6, 44);
            this.txtTabela.MaxLength = 8;
            this.txtTabela.Name = "txtTabela";
            this.txtTabela.Size = new System.Drawing.Size(115, 20);
            this.txtTabela.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tabela";
            // 
            // btnAddTabela
            // 
            this.btnAddTabela.Location = new System.Drawing.Point(9, 155);
            this.btnAddTabela.Name = "btnAddTabela";
            this.btnAddTabela.Size = new System.Drawing.Size(245, 23);
            this.btnAddTabela.TabIndex = 13;
            this.btnAddTabela.Text = "Adicionar";
            this.btnAddTabela.UseVisualStyleBackColor = true;
            this.btnAddTabela.Click += new System.EventHandler(this.btnAddTabela_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(138, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "DCLGEN";
            // 
            // txtDclgen
            // 
            this.txtDclgen.Location = new System.Drawing.Point(141, 44);
            this.txtDclgen.MaxLength = 8;
            this.txtDclgen.Name = "txtDclgen";
            this.txtDclgen.Size = new System.Drawing.Size(110, 20);
            this.txtDclgen.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkDelete);
            this.groupBox6.Controls.Add(this.chkCursor);
            this.groupBox6.Controls.Add(this.chkUpdate);
            this.groupBox6.Controls.Add(this.chkInsert);
            this.groupBox6.Controls.Add(this.chkSelect);
            this.groupBox6.Location = new System.Drawing.Point(9, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(242, 79);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ações";
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Location = new System.Drawing.Point(6, 19);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(99, 17);
            this.chkSelect.TabIndex = 0;
            this.chkSelect.Text = "Select (simples)";
            this.chkSelect.UseVisualStyleBackColor = true;
            // 
            // chkInsert
            // 
            this.chkInsert.AutoSize = true;
            this.chkInsert.Location = new System.Drawing.Point(6, 37);
            this.chkInsert.Name = "chkInsert";
            this.chkInsert.Size = new System.Drawing.Size(52, 17);
            this.chkInsert.TabIndex = 1;
            this.chkInsert.Text = "Insert";
            this.chkInsert.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Location = new System.Drawing.Point(6, 55);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(61, 17);
            this.chkUpdate.TabIndex = 2;
            this.chkUpdate.Text = "Update";
            this.chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkCursor
            // 
            this.chkCursor.AutoSize = true;
            this.chkCursor.Location = new System.Drawing.Point(132, 18);
            this.chkCursor.Name = "chkCursor";
            this.chkCursor.Size = new System.Drawing.Size(94, 17);
            this.chkCursor.TabIndex = 3;
            this.chkCursor.Text = "Select (cursor)";
            this.chkCursor.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(132, 37);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(57, 17);
            this.chkDelete.TabIndex = 4;
            this.chkDelete.Text = "Delete";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupArquivo);
            this.Controls.Add(this.btnGerar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gerador de código fonte";
            this.groupArquivo.ResumeLayout(false);
            this.groupArquivo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Tamanho.ResumeLayout(false);
            this.Tamanho.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesenvolvedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAnalista;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.CheckBox chkBalanceLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.RadioButton rdbSaida;
        private System.Windows.Forms.GroupBox groupArquivo;
        private System.Windows.Forms.ListView lstArquivo;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddArquivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookArquivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstSubPrograma;
        private System.Windows.Forms.TextBox txtSubPrograma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddSubPrograma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBookSubPrograma;
        private System.Windows.Forms.TextBox txtTamanhoArquivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbVB;
        private System.Windows.Forms.RadioButton rdbFB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdbN_1;
        private System.Windows.Forms.RadioButton rdb1_N;
        private System.Windows.Forms.RadioButton rdb1_1;
        private System.Windows.Forms.RadioButton rdbN_N;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbArquivo2;
        private System.Windows.Forms.ComboBox cmbArquivo1;
        private System.Windows.Forms.TextBox txtIndArquivo2;
        private System.Windows.Forms.TextBox txtIndArquivo1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Tamanho;
        private System.Windows.Forms.Button btnLimparArquivos;
        private System.Windows.Forms.Button btnLimparSub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimparTabela;
        private System.Windows.Forms.ListView lstTabela;
        private System.Windows.Forms.TextBox txtTabela;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddTabela;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDclgen;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkCursor;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.CheckBox chkInsert;
        private System.Windows.Forms.CheckBox chkSelect;
    }
}

