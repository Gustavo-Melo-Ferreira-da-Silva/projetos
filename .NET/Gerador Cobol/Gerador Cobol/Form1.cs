using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_Cobol
{
    public partial class Form1 : Form
    {
        String programa;
        String desenv;
        String analista;
        Boolean arquivoIO;
        String arquivoNome;
        String arquivoBook;
        String arquivoTamanho;
        Boolean rdbFixo;
        String subNome;
        String subBook;
        String tabelaNome;
        String dclgen;
        Boolean chkBalanceline;
        String comboArquivo1;
        String comboArquivo2;
        String indArquivo1;
        String indArquivo2;
        Boolean radio1_1;
        Boolean radio1_N;
        Boolean radioN_1;
        Boolean radioN_N;
        Boolean chk_Select;
        Boolean chk_Insert;
        Boolean chk_Update;
        Boolean chk_Delete;
        Boolean chk_Cursor;
        List<ListaArquivos> arquivos = new List<ListaArquivos>();
        List<ListaSub> subprogramas = new List<ListaSub>();
        List<ListaTabela> tabelas = new List<ListaTabela>();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            programa = this.txtPrograma.Text.Trim().ToUpper();
            desenv = this.txtDesenvolvedor.Text.Trim();
            analista = this.TxtAnalista.Text.Trim();
            chkBalanceline = this.chkBalanceLine.Checked;
            if (chkBalanceline)
            {
                if (String.IsNullOrEmpty(this.cmbArquivo1.Text))
                {
                    comboArquivo1 = String.Empty;
                }

                if (String.IsNullOrEmpty(this.cmbArquivo2.Text))
                {
                    comboArquivo2 = String.Empty;
                }
                if (String.IsNullOrEmpty(this.txtIndArquivo1.Text))
                {
                    indArquivo1 = String.Empty;
                }
                if (String.IsNullOrEmpty(this.txtIndArquivo2.Text))
                {
                    indArquivo2 = String.Empty;
                }
                radio1_1 = this.rdb1_1.Checked;
                radio1_N = this.rdb1_N.Checked;
                radioN_1 = this.rdbN_1.Checked;
                radioN_N = this.rdbN_N.Checked;
            }

            ClnValidar validar = new ClnValidar();

            validar.Programa = programa;
            validar.Desenv = desenv;
            validar.Analista = analista;
            validar.ChkBalanceline = chkBalanceline;
            validar.ComboArquivo1 = comboArquivo1;
            validar.ComboArquivo2 = comboArquivo2;
            validar.IndArquivo1 = indArquivo1;
            validar.IndArquivo2 = indArquivo2;
            validar.Rdb1_1 = radio1_1;
            validar.Rdb1_N = radio1_N;
            validar.RdbN_1 = radioN_1;
            validar.RdbN_N = radioN_N;

            String msg = validar.Validar();

            if (!String.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                return;
            }

            try {

                ClnGerarArquivo gerarArquivo = new ClnGerarArquivo();
                gerarArquivo.Analista = analista.ToUpper();
                gerarArquivo.Desenv = desenv.ToUpper();
                gerarArquivo.Programa = programa.ToUpper();
                if (chkBalanceline)
                {
                    gerarArquivo.Bl_arquivo1 = comboArquivo1.ToUpper();
                    gerarArquivo.Bl_arquivo2 = comboArquivo2.ToUpper();
                    gerarArquivo.Bl_indice1 = indArquivo1.ToUpper();
                    gerarArquivo.Bl_indice2 = indArquivo2.ToUpper();
                }
                else
                {
                    gerarArquivo.Bl_arquivo1 = String.Empty;
                    gerarArquivo.Bl_arquivo2 = String.Empty;
                    gerarArquivo.Bl_indice1 = String.Empty;
                    gerarArquivo.Bl_indice2 = String.Empty;
                }
                gerarArquivo.Chk_bl = chkBalanceline;
                gerarArquivo.Rdb_1_1 = radio1_1;
                gerarArquivo.Rdb_1_N = radio1_N;
                gerarArquivo.Rdb_N_1 = radioN_1;
                gerarArquivo.Rdb_N_N = radioN_N;

                gerarArquivo.ListaArq = arquivos;
                gerarArquivo.ListaSub = subprogramas;
                gerarArquivo.ListaTabela = tabelas;
                gerarArquivo.GerarFonte();

                MessageBox.Show("Fonte gerado com sucesso!");

            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnAddArquivo_Click(object sender, EventArgs e)
        {
            arquivoNome = this.txtNomeArquivo.Text.Trim().ToUpper();
            arquivoBook = this.txtBookArquivo.Text.Trim().ToUpper();
            arquivoTamanho = this.txtTamanhoArquivo.Text.Trim().ToUpper();
            arquivoIO = this.rdbEntrada.Checked;
            rdbFixo = this.rdbFB.Checked;

            ClnValidar validarArquivo = new ClnValidar();

            validarArquivo.ArquivoNome = arquivoNome;
            validarArquivo.ArquivoBook = arquivoBook;
            validarArquivo.ArquivoTamanho = arquivoTamanho;

            String msg = validarArquivo.ValidarArquivo();

            if (!String.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                this.groupArquivo.Focus();
                return;
            }

            arquivos.Add(new ListaArquivos() { Io = arquivoIO, ArquivoNome = arquivoNome, ArquivoBook = arquivoBook, ArquivoTamanho = int.Parse(arquivoTamanho), Fixo = rdbFixo });

            AtualizaListaArquivos();
            this.txtNomeArquivo.Text = String.Empty;
            this.txtBookArquivo.Text = String.Empty;
            this.txtTamanhoArquivo.Text = String.Empty;
            this.txtNomeArquivo.Focus();
        }

        private void AtualizaListaArquivos()
        {
            this.lstArquivo.Clear();
            this.cmbArquivo1.Items.Clear();
            this.cmbArquivo2.Items.Clear();

            foreach (var item in arquivos)
            {
                this.lstArquivo.Items.Add(item.ToString());
                if (item.Io)
                {
                    this.cmbArquivo1.Items.Add(item.ArquivoNome.ToString());
                    this.cmbArquivo2.Items.Add(item.ArquivoNome.ToString());
                }
            }
        }

        private void btnLimparArquivos_Click(object sender, EventArgs e)
        {
            arquivos.Clear();
            AtualizaListaArquivos();
            this.txtNomeArquivo.Text = String.Empty;
            this.txtBookArquivo.Text = String.Empty;
            this.txtTamanhoArquivo.Text = String.Empty;
            this.txtNomeArquivo.Focus();
        }

        private void chkBalanceLine_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.chkBalanceLine.Checked)
            {
                this.cmbArquivo1.Enabled = false;
                this.cmbArquivo2.Enabled = false;
                this.groupBox5.Enabled = false;
                this.txtIndArquivo2.Enabled = false;
                this.txtIndArquivo1.Enabled = false;
                this.label9.Enabled = false;
                this.label10.Enabled = false;
                this.label11.Enabled = false;
                this.label12.Enabled = false;
            }
            else
            {
                this.cmbArquivo1.Enabled = true;
                this.cmbArquivo2.Enabled = true;
                this.groupBox5.Enabled = true;
                this.txtIndArquivo2.Enabled = true;
                this.txtIndArquivo1.Enabled = true;
                this.label9.Enabled = true;
                this.label10.Enabled = true;
                this.label11.Enabled = true;
                this.label12.Enabled = true;
            }
        }

        private void btnAddSubPrograma_Click(object sender, EventArgs e)
        {
            subNome = this.txtSubPrograma.Text.Trim().ToUpper();
            subBook = this.txtBookSubPrograma.Text.Trim().ToUpper();

            ClnValidar validarArquivo = new ClnValidar();

            validarArquivo.SubNome = subNome;
            validarArquivo.SubBook = subBook;

            String msg = validarArquivo.ValidarSub();

            if (!String.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                this.groupBox3.Focus();
                return;
            }

            subprogramas.Add(new ListaSub() { SubBook = subBook, SubNome = subNome});

            AtualizaListaSub();
        }

        private void AtualizaListaSub()
        {
            this.lstSubPrograma.Clear();

            foreach (var item in subprogramas)
            {
                this.lstSubPrograma.Items.Add(item.ToString());
            }
        }

        private void btnLimparSub_Click(object sender, EventArgs e)
        {
            subprogramas.Clear();
            AtualizaListaSub();
        }

        private void btnAddTabela_Click(object sender, EventArgs e)
        {
            tabelaNome = this.txtTabela.Text.Trim().ToUpper();
            dclgen = this.txtDclgen.Text.Trim().ToUpper();
            chk_Select = this.chkSelect.Checked;
            chk_Insert = this.chkInsert.Checked;
            chk_Update = this.chkUpdate.Checked;
            chk_Delete = this.chkDelete.Checked;
            chk_Cursor = this.chkCursor.Checked;

            ClnValidar validarArquivo = new ClnValidar();

            validarArquivo.TabelaNome = tabelaNome;
            validarArquivo.Dclgen = dclgen;

            String msg = validarArquivo.ValidarTabela();

            if (!String.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                this.groupBox1.Focus();
                return;
            }

            tabelas.Add(new ListaTabela() { TabelNome = tabelaNome, Dclgen = dclgen, ChkSelect = chk_Select, ChkInsert = chk_Insert, ChkUpdate = chk_Update, ChkDelete = chk_Delete, ChkCursor = chk_Cursor });

            AtualizaListaTabela();
        }

        private void AtualizaListaTabela()
        {
            this.lstTabela.Clear();

            foreach (var item in tabelas)
            {
                this.lstTabela.Items.Add(item.ToString());
            }
        }

        private void btnLimparTabela_Click(object sender, EventArgs e)
        {
            tabelas.Clear();
            AtualizaListaTabela();
        }


    }
}
