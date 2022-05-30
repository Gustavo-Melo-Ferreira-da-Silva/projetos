using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gerador_Cobol
{
    class ClnGerarArquivo
    {
        private String _desenv;
        private String _analista;
        private String _programa;
        private String _bl_arquivo1;
        private String _bl_arquivo2;
        private String _bl_indice1;
        private String _bl_indice2;
        private List<ListaArquivos> _listaArq;
        private List<ListaSub> _listaSub;
        private List<ListaTabela> _listaTabela;
        private int _cont_entrada;
        private int _cont_saida;
        private Boolean _chk_bl;
        private Boolean _rdb_1_1;
        private Boolean _rdb_1_N;
        private Boolean _rdb_N_1;
        private Boolean _rdb_N_N;

        public string Desenv { get => _desenv; set => _desenv = value; }
        public string Analista { get => _analista; set => _analista = value; }
        public string Programa { get => _programa; set => _programa = value; }
        public string Bl_arquivo1 { get => _bl_arquivo1; set => _bl_arquivo1 = value; }
        public string Bl_arquivo2 { get => _bl_arquivo2; set => _bl_arquivo2 = value; }
        public string Bl_indice1 { get => _bl_indice1; set => _bl_indice1 = value; }
        public string Bl_indice2 { get => _bl_indice2; set => _bl_indice2 = value; }
        public bool Chk_bl { get => _chk_bl; set => _chk_bl = value; }
        public bool Rdb_1_1 { get => _rdb_1_1; set => _rdb_1_1 = value; }
        public bool Rdb_1_N { get => _rdb_1_N; set => _rdb_1_N = value; }
        public bool Rdb_N_1 { get => _rdb_N_1; set => _rdb_N_1 = value; }
        public bool Rdb_N_N { get => _rdb_N_N; set => _rdb_N_N = value; }
        internal List<ListaArquivos> ListaArq { get => _listaArq; set => _listaArq = value; }
        internal List<ListaSub> ListaSub { get => _listaSub; set => _listaSub = value; }
        internal List<ListaTabela> ListaTabela { get => _listaTabela; set => _listaTabela = value; }

        public void GerarFonte()
        {
            String data = DateTime.Now.Date.ToString("dd/MM/yyyy");
            String diretorio = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Fontes Cobol";

            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            // Abrir arquivo
            StreamWriter coboltxt = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Fontes Cobol\\{_programa}.txt");

            // Gravar linhas
            coboltxt.WriteLine($"      *================================================================*        ");
            coboltxt.WriteLine($"       IDENTIFICATION                  DIVISION.                                ");
            coboltxt.WriteLine($"      *================================================================*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"       PROGRAM-ID.     {_programa}                                              ");
            coboltxt.WriteLine($"       AUTHOR.         {_desenv}                                                ");
            coboltxt.WriteLine($"       DATE-WRITTEN.   {data}                                                   ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      ******************************************************************        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *                    COMENTARIOS DO PROGRAMA                     *        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      ******************************************************************        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *================================================================*        ");
            coboltxt.WriteLine($"       ENVIRONMENT                     DIVISION.                                ");
            coboltxt.WriteLine($"      *================================================================*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       CONFIGURATION                   SECTION.                                 ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"       SPECIAL-NAMES.                                                           ");
            coboltxt.WriteLine($"           DECIMAL-POINT IS COMMA.                                              ");
            coboltxt.WriteLine($"      *                                                                *        ");

            if (_listaArq.Count() > 0)
            {

                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"       INPUT-OUTPUT                    SECTION.                                 ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"       FILE-CONTROL.                                                            ");


                foreach (var item in _listaArq)
                {
                    String spaces = new string(' ', 9 - item.ArquivoNome.Length);
                    coboltxt.WriteLine($"           SELECT {item.ArquivoNome} ASSIGN {spaces}    TO {item.ArquivoNome}                      ");
                    coboltxt.WriteLine($"           FILE STATUS IS              FS-{item.ArquivoNome}.                            ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                }

            }
            coboltxt.WriteLine($"      *================================================================*        ");
            coboltxt.WriteLine($"       DATA                            DIVISION.                                ");
            coboltxt.WriteLine($"      *================================================================*        ");
            coboltxt.WriteLine($"      *                                                                *        ");


            if (_listaArq.Count() > 0)
            {
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"       FILE                            SECTION.                                 ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");

                foreach (var item in _listaArq)
                {
                    String rec;
                    if (item.Fixo)
                    {
                        rec = "F";
                    }
                    else
                    {
                        rec = "V";
                    }
                    coboltxt.WriteLine($"       FD {item.ArquivoNome}                                                             ");
                    coboltxt.WriteLine($"           RECORDIND MODE IS {rec}                                                  ");
                    coboltxt.WriteLine($"           BLOCK CONTAINS 0 RECORDS.                                            ");
                    coboltxt.WriteLine($"       $COPY {item.ArquivoBook}                                                ");
                    coboltxt.WriteLine($"       $SUFFIX {item.ArquivoNome}                                                         ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                }
            }
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       WORKING-STORAGE                 SECTION.                                 ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");

            if (_listaArq.Count() > 0)
            {
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *             AREA PARA A DECLARACAO DE FILE STATUS              *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");

                foreach (var item in _listaArq)
                {
                    String spaces = new String(' ', 8 - item.ArquivoNome.Length);
                    coboltxt.WriteLine($"       01 FS-{item.ArquivoNome + spaces}                  PIC XX              VALUE ZEROS.         ");
                }

                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *         AREA PARA VARIAVEIS DE ESTATISTICAS DO PROGRAMA        *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");

                foreach (var item in _listaArq)
                {
                    String spaces = new String(' ', 8 - item.ArquivoNome.Length);
                    if (item.Io)
                    {
                        coboltxt.WriteLine($"       01 WS-LIDOS-{item.ArquivoNome + spaces}                PIC 9(8)       VALUE ZEROS. *        ");
                    }
                }
                
                foreach (var item in _listaArq)
                {
                    String spaces = new String(' ', 8 - item.ArquivoNome.Length);
                    if (!item.Io)
                    {
                        coboltxt.WriteLine($"       01 WS-GRAVADOS-{item.ArquivoNome + spaces}             PIC 9(8)       VALUE ZEROS. *        ");
                    }
                }

                coboltxt.WriteLine($"       01 WS-MASCARA                       PIC --.---.--9 VALUE ZEROS. *        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *          AREA DE VARIAVEIS DE TRATAMENTO DE ARQUIVO            *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"       01 WS-ABERTURA                  PIC X(13)     VALUE                      ");
                coboltxt.WriteLine($"                                                     \"NA ABERTURA  \".           ");
                coboltxt.WriteLine($"       01 WS-FECHAMENTO                PIC X(13)     VALUE                      ");
                coboltxt.WriteLine($"                                                     \"NO FECHAMENTO\".           ");
                coboltxt.WriteLine($"       01 WS-LEITURA                   PIC X(13)     VALUE                      ");
                coboltxt.WriteLine($"                                                     \"NA LEITURA   \".           ");
                coboltxt.WriteLine($"       01 WS-GRAVACAO                  PIC X(13)     VALUE                      ");
                coboltxt.WriteLine($"                                                     \"NA GRAVACAO  \".           ");
                coboltxt.WriteLine($"      *                                                                *        ");
            }

            if (_chk_bl && _rdb_N_N )
            {
                String spaces = new String(' ', 8 - _bl_arquivo2.Length);
                int tamanho = 0;
                foreach (var item in _listaArq)
                {
                    if (item.ArquivoNome == _bl_arquivo2)
                    {
                        tamanho = item.ArquivoTamanho;
                    }
                }
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                  AREA DE VARIAVEIS AUXILIARES                  *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"       01 WS-{_bl_arquivo2}-AUX{spaces}              PIC X({tamanho})                           ");
                coboltxt.WriteLine($"                                       OCCURS 100 TIMES INDEXED BY I.           ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"       01 WS-J                         PIC 99         VALUE ZEROS.     *        ");
                coboltxt.WriteLine($"      *                                                                *        ");
            }

            if (_listaSub.Count > 0)
            {
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                      AREA DE SUBPROGRAMAS                      *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"       01 WS-RETURN-CODE               PIC X(02)      VALUE ZEROS.              ");
                coboltxt.WriteLine($"       01 WS-MSG-ERRO                  PIC X(20)      VALUE SPACES.             ");
                coboltxt.WriteLine($"       01 WS-SUBPROGRAMA               PIC X(08)      VALUE SPACES.             ");
                coboltxt.WriteLine($"      *                                                                *        ");

                foreach (var item in _listaSub)
                {
                    String spaces = new String(' ', 8 - item.SubNome.Length);
                    coboltxt.WriteLine($"       01 WS-{item.SubNome + spaces}                  PIC X(08)      VALUE \"{item.SubNome}\".         ");
                    coboltxt.WriteLine($"       $COPY '{item.SubBook}'.                                                        ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                }


                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
            }


            if (_listaTabela.Count > 0)
            {
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                          AREA DE DB2                           *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                int nselect = 0;
                foreach (var item in _listaTabela)
                {
                    String spaces = new String(' ', 8 - item.TabelNome.Length);
                    if (item.ChkSelect)
                    {
                        coboltxt.WriteLine($"       01 WS-TOTAL-SELECT-{item.TabelNome + spaces} PIC 9(8)               VALUE ZEROS.          ");
                        nselect += 1;
                    }
                    if (item.ChkInsert)
                    {
                        coboltxt.WriteLine($"       01 WS-TOTAL-INSERT-{item.TabelNome + spaces} PIC 9(8)               VALUE ZEROS.          ");
                    }
                    if (item.ChkUpdate)
                    {
                        coboltxt.WriteLine($"       01 WS-TOTAL-UPDATE-{item.TabelNome + spaces} PIC 9(8)               VALUE ZEROS.          ");
                    }
                    if (item.ChkDelete)
                    {
                        coboltxt.WriteLine($"       01 WS-TOTAL-DELETE-{item.TabelNome + spaces} PIC 9(8)               VALUE ZEROS.          ");
                    }

                    if (item.ChkCursor)
                    {
                        coboltxt.WriteLine($"       01 WS-TOTAL-FETCH-{item.TabelNome + spaces}  PIC 9(8)               VALUE ZEROS.          ");
                        nselect += 1;
                    }
                }

                if (nselect > 0)
                {
                    coboltxt.WriteLine($"       01 WS-SELECT-ENCONTROU      PIC X(1)               VALUE SPACES.         ");
                }
                coboltxt.WriteLine($"       01 WS-SQLCODE               PIC +999               VALUE ZEROS.          ");
                coboltxt.WriteLine($"       01 WS-TABELA                PIC X(08)              VALUE SPACES.         ");
                coboltxt.WriteLine($"       01 WS-ACAO-TABELA           PIC X(06)              VALUE SPACES.         ");
                coboltxt.WriteLine($"       01 WS-MASCARA-DB2           PIC --.---.---         VALUE ZEROS.          ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                coboltxt.WriteLine($"              INCLUDE SQLCA                                                     ");
                coboltxt.WriteLine($"           END-EXEC.                                                            ");
                coboltxt.WriteLine($"      *                                                                *        ");

                foreach (var item in _listaTabela)
                {
                    coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                    coboltxt.WriteLine($"              INCLUDE {item.Dclgen}                                                  ");
                    coboltxt.WriteLine($"           END-EXEC.                                                            ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                }

                foreach (var item in _listaTabela)
                {
                    int ncsr = 0;
                    if (item.ChkCursor)
                    {
                        ncsr += 1;
                        if (ncsr == 1)
                        {
                            coboltxt.WriteLine($"      *-------------------- DECLARACAO DE CURSORES --------------------*        ");
                            coboltxt.WriteLine($"      *                                                                *        ");
                        }
                        coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                        coboltxt.WriteLine($"              DECLARE CSR-{item.TabelNome} FOR                                          ");
                        coboltxt.WriteLine($"              SELECT [CAMPO AQUI],                                              ");
                        coboltxt.WriteLine($"                     [CAMPO AQUI],                                              ");
                        coboltxt.WriteLine($"                     [CAMPO AQUI],                                              ");
                        coboltxt.WriteLine($"              FROM {item.TabelNome}                                                     ");
                        coboltxt.WriteLine($"              WHERE  [CONDICOES]                                                ");
                        coboltxt.WriteLine($"              FOR    FETCH ONLY                                                 ");
                        coboltxt.WriteLine($"           END-EXEC.                                                            ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                    }
                }
            }



            coboltxt.WriteLine($"      *================================================================*        ");
            coboltxt.WriteLine($"       PROCEDURE                       DIVISION.                                ");
            coboltxt.WriteLine($"      *================================================================*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       0000-INICIO                     SECTION.                                 ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"           PERFORM 1000-INICIAR.                                                ");

            
            _cont_entrada = 0;
            if (_listaArq.Count() > 0)
            {
                foreach (var item in _listaArq)
                {
                    if (item.Io)
                    {
                         _cont_entrada += 1;

                        if (_cont_entrada == 1) { 
                            coboltxt.WriteLine($"           PERFORM 2000-PROCESSAR      UNTIL FS-{item.ArquivoNome} EQUAL \"10\"          ");
                        }
                        else
                        {
                            coboltxt.WriteLine($"                                         AND FS-{item.ArquivoNome} EQUAL \"10\"          ");
                        }
                    }
                }

                if (_cont_entrada == 0)
                {
                    coboltxt.WriteLine($"           PERFORM 2000-PROCESSAR.                                              ");
                }
                else
                {
                    coboltxt.WriteLine($"                                                                    .           ");
                }

            }
            else
            {
                coboltxt.WriteLine($"           PERFORM 2000-PROCESSAR.                                              ");
            }

            coboltxt.WriteLine($"           PERFORM 3000-FINALIZAR.                                              ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       0000-INICIO-FIM.                EXIT.                                    ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       1000-INICIAR                    SECTION.                                 ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");

            _cont_entrada = 0;
            if (_listaArq.Count > 0)
            {
                foreach (var item in _listaArq)
                {
                    if (item.Io)
                    {
                        _cont_entrada += 1;

                        if (_cont_entrada == 1)
                        {
                            coboltxt.WriteLine($"           OPEN INPUT  {item.ArquivoNome}                                                ");
                        }
                        else
                        {
                            coboltxt.WriteLine($"                       {item.ArquivoNome}                                                ");
                        }
                    }
                }

                _cont_saida = 0;
                foreach (var item in _listaArq)
                {
                    if (!item.Io)
                    {
                        _cont_saida += 1;

                        if (_cont_saida == 1)
                        {
                            if (_cont_entrada == 0)
                            {
                                coboltxt.WriteLine($"           OPEN OUTPUT {item.ArquivoNome}                                                ");
                            }
                            else
                            {
                                coboltxt.WriteLine($"                OUTPUT {item.ArquivoNome}                                                ");
                            }
                        }
                        else
                        {
                            coboltxt.WriteLine($"                       {item.ArquivoNome}                                                 ");
                        }
                    }
                }

                if (_cont_entrada > 0 || _cont_saida > 0)
                {
                    coboltxt.WriteLine($"                                                                   .            ");

                }
            }
            coboltxt.WriteLine($"                                                                                ");

            if (_listaArq.Count > 0)
            {
                coboltxt.WriteLine($"           MOVE WS-ABERTURA            TO WS-ACAO-ARQUIVO                       ");
                coboltxt.WriteLine($"      *                                                                *        ");

                _cont_entrada = 6090;
                foreach (var item in _listaArq)
                {
                    _cont_entrada += 20;
                    coboltxt.WriteLine($"           PERFORM {_cont_entrada}-VALIDAR-{item.ArquivoNome}.                                      ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                }


            }

            if (_listaTabela.Count > 0)
            {
                int nsection = 7100;
                foreach (var item in _listaTabela)
                {
                    if (item.ChkSelect)
                    {
                        nsection += 10;
                    }
                    if (item.ChkInsert)
                    {
                        nsection += 10;
                    }
                    if (item.ChkUpdate)
                    {
                        nsection += 10;
                    }
                    if (item.ChkDelete)
                    {
                        nsection += 10;
                    }

                    if (item.ChkCursor)
                    {
                        nsection += 20;
                        coboltxt.WriteLine($"           {nsection}-OPEN-CSR-{item.TabelNome}.                                             ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        nsection += 10;
                    }
                }
            }

            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       1000-INICIAR-FIM.               EXIT.                                    ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       2000-PROCESSAR                  SECTION.                                 ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");


            if (Chk_bl && _rdb_1_1)
            {
                int section1 = 0;
                int section2 = 0;
                int ns = 6100;

                foreach (var item in _listaArq)
                {
                    ns += 20;
                    if (item.ArquivoNome == _bl_arquivo1)
                    {
                        section1 = ns;
                    }
                    if (item.ArquivoNome == _bl_arquivo2)
                    {
                        section2 = ns;

                    }
                }

                coboltxt.WriteLine($"      *----------------------BALANCE LINE 1 PARA 1---------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"           IF  {Bl_indice1}-{_bl_arquivo1}                                                ");
                coboltxt.WriteLine($"                                   EQUAL {_bl_indice2}-{_bl_arquivo2}                   ");
                coboltxt.WriteLine($"      *        [LOGICA]                                                         ");
                coboltxt.WriteLine($"               PERFORM {section1}-LER-{_bl_arquivo1}                                         ");
                coboltxt.WriteLine($"               PERFORM {section2}-LER-{_bl_arquivo2}                                         ");
                coboltxt.WriteLine($"           ELSE                                                                 ");
                coboltxt.WriteLine($"               IF {_bl_indice1}-{_bl_arquivo1}                                             ");
                coboltxt.WriteLine($"                                    GREATER {_bl_indice2}-{_bl_arquivo2}                 ");
                coboltxt.WriteLine($"      *           [LOGICA]                                                      ");
                coboltxt.WriteLine($"                  PERFORM {section2}-LER-{_bl_arquivo2}                                     ");
                coboltxt.WriteLine($"               ELSE                                                             ");
                coboltxt.WriteLine($"      *           [LOGICA]                                                      ");
                coboltxt.WriteLine($"                  PERFORM {section1}-LER-{_bl_arquivo1}                                      ");
                coboltxt.WriteLine($"               END-IF                                                           ");
                coboltxt.WriteLine($"           END-IF.                                                              ");
                coboltxt.WriteLine($"      *                                                                *        ");
            }


            if (Chk_bl && (_rdb_1_N || _rdb_N_1))
            {
                int ns = 6100;
                String arq1 = String.Empty;
                String arq2 = String.Empty;
                String ind1 = String.Empty;
                String ind2 = String.Empty;
                int section1 = 0;
                int section2 = 0;

                if (_rdb_1_N)
                {
                    arq1 = Bl_arquivo1;
                    ind1 = Bl_indice1;
                    arq2 = Bl_arquivo2;
                    ind2 = Bl_indice2;
                }
                else
                {
                    arq1 = Bl_arquivo2;
                    ind1 = Bl_indice2;
                    arq2 = Bl_arquivo1;
                    ind2 = Bl_indice1;
                }

                foreach (var item in _listaArq)
                {
                    ns += 20;
                    if (item.ArquivoNome == arq1)
                    {
                        section1 = ns;
                    }
                    if (item.ArquivoNome == arq2)
                    {
                        section2 = ns;

                    }
                }

                coboltxt.WriteLine($"      *----------------------BALANCE LINE 1 PARA N---------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"           IF  {ind1}-{arq1}                                                ");
                coboltxt.WriteLine($"                                       EQUAL     {ind2}-{arq2}               ");
                coboltxt.WriteLine($"      *                                                                         ");
                coboltxt.WriteLine($"               PERFORM                 UNTIL     {ind1}-{arq2}               ");
                coboltxt.WriteLine($"                                       NOT EQUAL {ind1}-{arq1}               ");
                coboltxt.WriteLine($"      *           [LOGICA]                                                      ");
                coboltxt.WriteLine($"                  PERFORM {section2}-LER-{arq2}                                     ");
                coboltxt.WriteLine($"               END-PERFORM                                                      ");
                coboltxt.WriteLine($"               PERFORM {section1}-LER-{arq1}                                        ");
                coboltxt.WriteLine($"           ELSE                                                                 ");
                coboltxt.WriteLine($"               IF {ind1}-{arq1}                                             ");
                coboltxt.WriteLine($"                                       GREATER {ind2}-{arq2}                 ");
                coboltxt.WriteLine($"      *           [LOGICA]                                                      ");
                coboltxt.WriteLine($"                  PERFORM {section2}-LER-{arq2}                                     ");
                coboltxt.WriteLine($"               ELSE                                                             ");
                coboltxt.WriteLine($"      *           [LOGICA]                                                      ");
                coboltxt.WriteLine($"                  PERFORM {section1}-LER-{arq1}                                     ");
                coboltxt.WriteLine($"               END-IF                                                           ");
                coboltxt.WriteLine($"           END-IF.                                                              ");
                coboltxt.WriteLine($"      *                                                                *        ");
            }

            if (Chk_bl && _rdb_N_N)
            {
                int ns = 6100;
                int section1 = 0;
                int section2 = 0;

                foreach (var item in _listaArq)
                {
                    ns += 20;
                    if (item.ArquivoNome == _bl_arquivo1)
                    {
                        section1 = ns;
                    }
                    if (item.ArquivoNome == _bl_arquivo2)
                    {
                        section2 = ns;

                    }
                }

                coboltxt.WriteLine($"      *----------------------BALANCE LINE N PARA N---------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"           IF  {_bl_indice1}-{_bl_arquivo1}                                                ");
                coboltxt.WriteLine($"                                       EQUAL     {_bl_indice2}-{_bl_arquivo2}               ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"               MOVE ZEROS              TO I                                     ");
                coboltxt.WriteLine($"               PERFORM                 UNTIL     {_bl_indice2}-{_bl_arquivo2}               ");
                coboltxt.WriteLine($"                                       NOT EQUAL {_bl_indice1}-{_bl_arquivo1}               ");
                coboltxt.WriteLine($"                  ADD 1                TO I                                     ");
                coboltxt.WriteLine($"                  MOVE [{_bl_arquivo2}]      TO WS-{_bl_arquivo2}-AUX(I)                    ");
                coboltxt.WriteLine($"                  PERFORM {section2}-LER-{_bl_arquivo2}                                     ");
                coboltxt.WriteLine($"               END-PERFORM                                                      ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"               PERFORM                 UNTIL     {_bl_indice1}-{_bl_arquivo1}               ");
                coboltxt.WriteLine($"                                       NOT EQUAL {_bl_indice2}-AUX(1)                ");
                coboltxt.WriteLine($"                  PERFORM VARYING WS-J FROM 1 BY 1                              ");
                coboltxt.WriteLine($"                                       UNTIL WS-J GREATER I                     ");
                coboltxt.WriteLine($"      *              [LOGICA]                                                   ");
                coboltxt.WriteLine($"                  END-PERFORM                                                   ");
                coboltxt.WriteLine($"                                                                                ");
                coboltxt.WriteLine($"                  PERFORM {section1}-LER-{_bl_arquivo1}                                     ");
                coboltxt.WriteLine($"               END-PERFORM                                                      ");
                coboltxt.WriteLine($"           ELSE                                                                 ");
                coboltxt.WriteLine($"               IF {_bl_indice1}-{_bl_arquivo1}    GREATER {_bl_indice2}-{_bl_arquivo2}                 ");
                coboltxt.WriteLine($"      *           [LOGICA]                                                      ");
                coboltxt.WriteLine($"                  PERFORM {section2}-LER-{_bl_arquivo1}                                     ");
                coboltxt.WriteLine($"               ELSE                                                             ");
                coboltxt.WriteLine($"      *           [LOGICA]                                                      ");
                coboltxt.WriteLine($"                  PERFORM {section1}-LER-{_bl_arquivo1}                                     ");
                coboltxt.WriteLine($"               END-IF                                                           ");
                coboltxt.WriteLine($"           END-IF.                                                              ");
                coboltxt.WriteLine($"      *                                                                *        ");
            }
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       2000-PROCESSAR-FIM.             EXIT.                                    ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       3000-FINALIZAR                  SECTION.                                 ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");


            _cont_entrada = 0;
            if (_listaArq.Count > 0)
            {
                foreach (var item in _listaArq)
                {
                    _cont_entrada += 1;
                    if (_cont_entrada == 1)
                    {
                        coboltxt.WriteLine($"           CLOSE {item.ArquivoNome}                                                      ");
                    }
                    else
                    {
                        coboltxt.WriteLine($"                 {item.ArquivoNome}                                                      ");
                    }

                }
                coboltxt.WriteLine($"                                                                      .         ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"           MOVE WS-FECHAMENTO          TO WS-ACAO-ARQUIVO.                      ");

                _cont_entrada = 6090;
            foreach (var item in _listaArq)
                {
                    _cont_entrada += 20;
                    coboltxt.WriteLine($"           PERFORM {_cont_entrada}-VALIDAR-{item.ArquivoNome}.                                      ");
                }
            }

            if (_listaTabela.Count > 0)
            {
                int nsection = 7100;
                foreach (var item in _listaTabela)
                {
                    if (item.ChkSelect)
                    {
                        nsection += 10;
                    }
                    if (item.ChkInsert)
                    {
                        nsection += 10;
                    }
                    if (item.ChkUpdate)
                    {
                        nsection += 10;
                    }
                    if (item.ChkDelete)
                    {
                        nsection += 10;
                    }

                    if (item.ChkCursor)
                    {
                        nsection += 30;
                        coboltxt.WriteLine($"           {nsection}-CLOSE-CSR-{item.TabelNome}.                                             ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                    }
                }
            }


            coboltxt.WriteLine($"                                                                                ");
            coboltxt.WriteLine($"           PERFORM 9000-ESTATISTICAS.                                           ");
            coboltxt.WriteLine($"                                                                                ");
            coboltxt.WriteLine($"           STOP RUN.                                                            ");
            coboltxt.WriteLine($"                                                                                ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       3000-FINALIZAR-FIM.             EXIT.                                    ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");

            _cont_entrada = 6100;
            foreach (var item in _listaArq)
            {
                _cont_entrada += 10;
                String spaces = new string(' ', 8 - item.ArquivoNome.Length);
                String spaces2 = new string(' ', 8 - _programa.Length);
                String spaces3;
                String espaco = " ";
                String acao;
                String estati;
                String le_grava, read_write;
                if (item.Io)
                {
                    le_grava = "LER";
                    read_write = "READ";
                    spaces3 = new string(' ', 3);
                    acao = "LEITURA";
                    estati = "LIDOS";
                    espaco = " ";
                }
                else
                {
                    le_grava = "GRAVAR";
                    read_write = "WRITE";
                    spaces3 = String.Empty;
                    acao = "GRAVACAO";
                    estati = "GRAVADOS";
                    espaco = String.Empty;
                }

                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"       {_cont_entrada}-VALIDAR-{item.ArquivoNome + spaces}           SECTION.                                 ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"           IF FS-{item.ArquivoNome + spaces}          NOT EQUAL \"00\" AND \"10\"                          ");

                String sp = new String(' ', 8 - _programa.Length);
                int m = sp.Length;
                int n = m / 2;
                sp = new String(' ', n);
                String sp1 = new String(' ', m - n);

                coboltxt.WriteLine($"              DISPLAY \"**********************************\"            ");
                coboltxt.WriteLine($"              DISPLAY \"*            {sp + _programa + sp1}            *\"            ");
                coboltxt.WriteLine($"              DISPLAY \"*--------------------------------*\"            ");
                coboltxt.WriteLine($"              DISPLAY \"*                                *\"            ");
                coboltxt.WriteLine($"              DISPLAY \"* ARQUIVO {item.ArquivoNome + spaces}               *\"            ");
                coboltxt.WriteLine($"              DISPLAY \"* CANCELADO \" WS-ACAO-ARQUIVO \"        *\"            ");
                coboltxt.WriteLine($"              DISPLAY \"* COM FILE STATUS \" FS-{item.ArquivoNome} \"             *\"            ");
                coboltxt.WriteLine($"              DISPLAY \"*                                *\"            ");
                coboltxt.WriteLine($"              DISPLAY \"**********************************\"            ");
                coboltxt.WriteLine($"              CANCEL                                                            ");
                coboltxt.WriteLine($"           END.                                                                 ");
                coboltxt.WriteLine($"      *                                                                *        ");

                if (item.ArquivoNome == _bl_arquivo1)
                {
                    coboltxt.WriteLine($"           IF FS-{_bl_arquivo1}                   EQUAL \"10\"                              ");
                    coboltxt.WriteLine($"              MOVE HIGH-VALUES              TO {_bl_indice1}-{_bl_arquivo1}                     ");
                    coboltxt.WriteLine($"           END-IF.                                                                  ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                }
                else if (item.ArquivoNome == _bl_arquivo2) 
                {
                    coboltxt.WriteLine($"           IF FS-{_bl_arquivo2}                   EQUAL \"10\"                              ");
                    coboltxt.WriteLine($"              MOVE HIGH-VALUES              TO {_bl_indice2}-{_bl_arquivo2}                     ");
                    coboltxt.WriteLine($"           END-IF.                                                                  ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                }

                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"       {_cont_entrada}-VALIDAR-{item.ArquivoNome}-FIM.{spaces}      EXIT.                                    ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");

                _cont_entrada += 10;

                coboltxt.WriteLine($"       {_cont_entrada}-{le_grava}-{item.ArquivoNome + spaces + spaces3}            SECTION.                                 ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"           {read_write} {item.ArquivoNome}.                                                        ");
                coboltxt.WriteLine($"           MOVE WS-{acao + espaco}            TO WS-ACAO-ARQUIVO.                      ");
                coboltxt.WriteLine($"           ADD 1                       TO WS-{estati}-{item.ArquivoNome}.             ");
                coboltxt.WriteLine($"           PERFORM {_cont_entrada}-VALIDAR-{item.ArquivoNome}.                                        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"       {_cont_entrada}-{le_grava}-{item.ArquivoNome}-FIM.{spaces + spaces3}       EXIT.                                    ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
            }

            if (_listaTabela.Count > 0)
            {
                int nsection = 7100;

                foreach (var item in _listaTabela)
                {
                    String spaces = new String(' ', 8 - item.TabelNome.Length);

                    if (item.ChkSelect)
                    {
                        nsection += 10; 
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-SELECT-{item.TabelNome + spaces}            SECTION.                                 ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           MOVE 'S'                    TO WS-SELECT-ENCONTROU.                  ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                        coboltxt.WriteLine($"              SELECT [CAMPO],                                                   ");
                        coboltxt.WriteLine($"                     [CAMPO],                                                   ");
                        coboltxt.WriteLine($"                     [CAMPO]                                                    ");
                        coboltxt.WriteLine($"              INTO  :[CAMPO-DCLGEN],                                            ");
                        coboltxt.WriteLine($"                    :[CAMPO-DCLGEN],                                            ");
                        coboltxt.WriteLine($"                    :[CAMPO-DCLGEN]                                             ");
                        coboltxt.WriteLine($"              FROM {item.TabelNome + spaces}                                                     ");
                        coboltxt.WriteLine($"              WHERE [CONDICAO]                                                  ");
                        coboltxt.WriteLine($"           END-EXEC.                                                            ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           IF SQLCODE                  NOT EQUAL ZEROS AND +100                 ");
                        coboltxt.WriteLine($"              MOVE SQLCODE             TO WS-SQLCODE                            ");
                        coboltxt.WriteLine($"              MOVE 'SELECT'            TO WS-ACAO-TABELA                        ");
                        coboltxt.WriteLine($"              MOVE '{item.TabelNome}'{spaces}          TO WS-TABELA                             ");
                        coboltxt.WriteLine($"              PERFORM 7999-ERRO-TABELA                                          ");
                        coboltxt.WriteLine($"           END-IF.                                                              ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           IF SQLCODE                  EQUAL +100                               ");
                        coboltxt.WriteLine($"              MOVE 'N'                 TO WS-SELECT-ENCONTROU                   ");
                        coboltxt.WriteLine($"           ELSE                                                                 ");
                        coboltxt.WriteLine($"              ADD 1                    TO WS-TOTAL-SELECT-{item.TabelNome + spaces}              ");
                        coboltxt.WriteLine($"           END-IF.                                                              ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-{item.TabelNome}-FIM.{spaces}       EXIT.                                    ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                    }

                    if (item.ChkInsert)
                    {


                        nsection += 10; 
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-INSERT-{item.TabelNome + spaces}            SECTION.                                 ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                        coboltxt.WriteLine($"              INSERT INTO {item.TabelNome + spaces}                                              ");
                        coboltxt.WriteLine($"                    (                                                           ");
                        coboltxt.WriteLine($"                     [CAMPO],                                                   ");
                        coboltxt.WriteLine($"                     [CAMPO],                                                   ");
                        coboltxt.WriteLine($"                     [CAMPO]                                                    ");
                        coboltxt.WriteLine($"                    )                                                           ");
                        coboltxt.WriteLine($"              VALUES                                                            ");
                        coboltxt.WriteLine($"                    (                                                           ");
                        coboltxt.WriteLine($"                    :[CAMPO-DCLGEN],                                            ");
                        coboltxt.WriteLine($"                    :[CAMPO-DCLGEN],                                            ");
                        coboltxt.WriteLine($"                    :[CAMPO-DCLGEN]                                             ");
                        coboltxt.WriteLine($"                    )                                                           ");
                        coboltxt.WriteLine($"           END-EXEC.                                                            ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           IF SQLCODE                  NOT EQUAL ZEROS                          ");
                        coboltxt.WriteLine($"              MOVE SQLCODE             TO WS-SQLCODE                            ");
                        coboltxt.WriteLine($"              MOVE 'INSERT'            TO WS-ACAO-TABELA                        ");
                        coboltxt.WriteLine($"              MOVE '{item.TabelNome}'{spaces}          TO WS-TABELA                             ");
                        coboltxt.WriteLine($"              PERFORM 7999-ERRO-TABELA                                          ");
                        coboltxt.WriteLine($"           END-IF.                                                              ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           ADD 1                       TO WS-TOTAL-INSERT-{item.TabelNome}.{spaces}             ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-INSERT-{item.TabelNome}-FIM.{spaces}       EXIT                                     ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                    }

                    if (item.ChkUpdate)
                    {


                        nsection += 10; 
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-UPDATE-{item.TabelNome + spaces}            SECTION.                                 ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                        coboltxt.WriteLine($"              UPDATE {item.TabelNome + spaces}                                                   ");
                        coboltxt.WriteLine($"              SET                                                               ");
                        coboltxt.WriteLine($"                     [CAMPO] = :[CAMPO-DCLGEN],                                 ");
                        coboltxt.WriteLine($"                     [CAMPO] = :[CAMPO-DCLGEN],                                 ");
                        coboltxt.WriteLine($"                     [CAMPO] = :[CAMPO-DCLGEN]                                  ");
                        coboltxt.WriteLine($"              WHERE  [CONDICAO]                                                 ");
                        coboltxt.WriteLine($"           END-EXEC.                                                            ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           IF SQLCODE                  NOT EQUAL ZEROS                          ");
                        coboltxt.WriteLine($"              MOVE SQLCODE             TO WS-SQLCODE                            ");
                        coboltxt.WriteLine($"              MOVE 'UPDATE'            TO WS-ACAO-TABELA                        ");
                        coboltxt.WriteLine($"              MOVE '{item.TabelNome}'{spaces}          TO WS-TABELA                             ");
                        coboltxt.WriteLine($"              PERFORM 7999-ERRO-TABELA                                          ");
                        coboltxt.WriteLine($"           END-IF.                                                              ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           ADD 1                       TO WS-TOTAL-UPDATE-{item.TabelNome}.{spaces}             ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-UPDATE-{item.TabelNome}-FIM.{spaces}       EXIT.                                    ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                    }

                    if (item.ChkDelete)
                    {


                        nsection += 10; 
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-DELETE-{item.TabelNome + spaces}            SECTION.                                 ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                        coboltxt.WriteLine($"              DELETE FROM {item.TabelNome + spaces}                                              ");
                        coboltxt.WriteLine($"              WHERE  [CONDICAO]                                                 ");
                        coboltxt.WriteLine($"           END-EXEC.                                                            ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           IF SQLCODE                  NOT EQUAL ZEROS                          ");
                        coboltxt.WriteLine($"              MOVE SQLCODE             TO WS-SQLCODE                            ");
                        coboltxt.WriteLine($"              MOVE 'DELETE'            TO WS-ACAO-TABELA                        ");
                        coboltxt.WriteLine($"              MOVE '{item.TabelNome}'{spaces}          TO WS-TABELA                             ");
                        coboltxt.WriteLine($"              PERFORM 7999-ERRO-TABELA                                          ");
                        coboltxt.WriteLine($"           END-IF.                                                              ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           ADD 1                       TO WS-TOTAL-DELETE-{item.TabelNome}.{spaces}             ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-DELETE-{item.TabelNome}-FIM.{spaces}       EXIT.                                    ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                    }

                    if (item.ChkCursor)
                    {


                        nsection += 10; 
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-FETCH-{item.TabelNome + spaces}             SECTION.                                 ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           MOVE 'S'                    TO WS-SELECT-ENCONTROU                   ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                        coboltxt.WriteLine($"              FETCH CSR-{item.TabelNome + spaces}                                                ");
                        coboltxt.WriteLine($"              INTO :[CAMPOR-DCLGEN],                                            ");
                        coboltxt.WriteLine($"                   :[CAMPOR-DCLGEN],                                            ");
                        coboltxt.WriteLine($"                   :[CAMPOR-DCLGEN]                                             ");
                        coboltxt.WriteLine($"           END-EXEC.                                                            ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           IF SQLCODE                  NOT EQUAL ZEROS AND +100                 ");
                        coboltxt.WriteLine($"              MOVE SQLCODE             TO WS-SQLCODE                            ");
                        coboltxt.WriteLine($"              MOVE 'FETCH'             TO WS-ACAO-TABELA                        ");
                        coboltxt.WriteLine($"              MOVE '{item.TabelNome}'{spaces}          TO WS-TABELA                             ");
                        coboltxt.WriteLine($"              PERFORM 7999-ERRO-TABELA                                          ");
                        coboltxt.WriteLine($"           END-IF.                                                              ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           IF SQLCODE                  EQUAL +100                               ");
                        coboltxt.WriteLine($"              MOVE 'N'                 TO WS-SELECT-ENCONTROU                   ");
                        coboltxt.WriteLine($"           ELSE                                                                 ");
                        coboltxt.WriteLine($"              ADD 1                    TO WS-TOTAL-FETCH-{item.TabelNome + spaces}               ");
                        coboltxt.WriteLine($"           END-IF.                                                              ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-FETCH-{item.TabelNome}-FIM.{spaces}        EXIT.                                    ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        nsection += 10; 
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-OPEN-CSR-{item.TabelNome + spaces}          SECTION.                                 ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                        coboltxt.WriteLine($"              OPEN CSR-{item.TabelNome + spaces}                                                 ");
                        coboltxt.WriteLine($"           END-EXEC.                                                            ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           IF SQLCODE                  NOT EQUAL ZEROS                          ");
                        coboltxt.WriteLine($"              MOVE SQLCODE             TO WS-SQLCODE                            ");
                        coboltxt.WriteLine($"              MOVE 'OPEN'              TO WS-ACAO-TABELA                        ");
                        coboltxt.WriteLine($"              MOVE '{item.TabelNome}'{spaces}          TO WS-TABELA                             ");
                        coboltxt.WriteLine($"              PERFORM 7999-ERRO-TABELA                                          ");
                        coboltxt.WriteLine($"           END-IF.                                                              ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-OPEN-CSR-{item.TabelNome}-FIM.{spaces}     EXIT.                                    ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        nsection += 10; 
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-CLOSE-CSR-{item.TabelNome + spaces}         SECTION.                                 ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           EXEC-SQL                                                             ");
                        coboltxt.WriteLine($"              CLOSE CSR-{item.TabelNome + spaces}                                                 ");
                        coboltxt.WriteLine($"           END-EXEC.                                                            ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"           IF SQLCODE                  NOT EQUAL ZEROS                          ");
                        coboltxt.WriteLine($"              MOVE SQLCODE             TO WS-SQLCODE                            ");
                        coboltxt.WriteLine($"              MOVE 'CLOSE'             TO WS-ACAO-TABELA                        ");
                        coboltxt.WriteLine($"              MOVE '{item.TabelNome}'{spaces}          TO WS-TABELA                             ");
                        coboltxt.WriteLine($"              PERFORM 7999-ERRO-TABELA                                          ");
                        coboltxt.WriteLine($"           END-IF.                                                              ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"       {nsection}-CLOSE-CSR-{item.TabelNome}-FIM.{spaces}    EXIT.                                    ");
                        coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                        coboltxt.WriteLine($"      *                                                                *        ");
                    }
                }

                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"       7999-ERRO-TABELA                SECTION.                                 ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"           DISPLAY ****************************************.                    ");
                coboltxt.WriteLine($"           DISPLAY *               \" WS-TABELA \"               *.                    ");
                coboltxt.WriteLine($"           DISPLAY *--------------------------------------*.                    ");
                coboltxt.WriteLine($"           DISPLAY *  CANCELADO COM SQLCODE: \" WS-SQLCODE \"         *.                    ");
                coboltxt.WriteLine($"           DISPLAY *  NO \" WS-ACAO-TABELA \"                           *.                    ");
                coboltxt.WriteLine($"           DISPLAY ****************************************.                    ");
                coboltxt.WriteLine($"           CANCEL.                                                              ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"       7999-ERRO-TABELA-FIM.           EXIT.                                    ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
            }

            if (_listaSub.Count > 0)
            {
                int numsection = 8100;
                foreach (var item in _listaSub)
                {
                    numsection += 10;
                    String spaces = new String(' ', 8 - item.SubNome.Length);
                    coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                    coboltxt.WriteLine($"       {numsection}-CHAMAR-{item.SubNome + spaces}            SECTION.                                 ");
                    coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                    coboltxt.WriteLine($"           CALL WS-{item.SubNome + spaces}            USING WS-RETURN-CODE                     ");
                    coboltxt.WriteLine($"                                             WS-MSG-ERRO                        ");
                    coboltxt.WriteLine($"                                             BOOKSUBP.                          ");
                    coboltxt.WriteLine($"           MOVE \"{item.SubNome}\"{spaces}             TO WS-SUBPROGRAMA.                       ");
                    coboltxt.WriteLine($"           PERFORM 8110-TRATAR-SUBPROGRAMA.                                     ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                    coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                    coboltxt.WriteLine($"       8100-CHAMAR-{item.SubNome}-FIM.{spaces}       EXIT.                                    ");
                    coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                    coboltxt.WriteLine($"      *                                                                *        ");
                }


                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"       8999-TRATAR-SUBPROGRAMA         SECTION.                                 ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"           IF WS-RETURN-CODE           NOT EQUAL ZEROS                          ");
                coboltxt.WriteLine($"              DISPLAY \"***************************************\"                   ");
                coboltxt.WriteLine($"              DISPLAY \"*              \" WS-SUBPROGRAMA \"               *\"                   ");
                coboltxt.WriteLine($"              DISPLAY \"*-------------------------------------*\"                   ");
                coboltxt.WriteLine($"              DISPLAY \"* CANCELADO NA CHAMADA DO SUBPROGRAMA *\"                   ");
                coboltxt.WriteLine($"              DISPLAY \"*-------------------------------------*\"                   ");
                coboltxt.WriteLine($"              DISPLAY \"*                                     *\"                   ");
                coboltxt.WriteLine($"              DISPLAY \"*  RETURN-CODE: \" WS-RETURN-CODE \"                    *\"                   ");
                coboltxt.WriteLine($"              DISPLAY \"*  MENSAGEM...: \" WS-MSG-ERRO                             ");
                coboltxt.WriteLine($"              DISPLAY \"*                                     *\"                   ");
                coboltxt.WriteLine($"              DISPLAY \"*                                     *\"                   ");
                coboltxt.WriteLine($"              DISPLAY \"***************************************\"                   ");
                coboltxt.WriteLine($"              CANCEL                                                            ");
                coboltxt.WriteLine($"           END.                                                                 ");
                coboltxt.WriteLine($"      *                                                                *        ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"       8999-TRATAR-SUBPROGRAMA-FIM.    EXIT.                                    ");
                coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
                coboltxt.WriteLine($"      *                                                                *        ");

            }





            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       9000-ESTATISTICAS               SECTION.                                 ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");
            coboltxt.WriteLine($"           DISPLAY \"********************************************\".              ");

            String space = new String(' ', 8 - _programa.Length);
            int t = space.Length;
            int j = t / 2;
            space = new String(' ', j);
            String space1 = new String(' ', t - j);

            coboltxt.WriteLine($"           DISPLAY \"*                {space + _programa + space1}                  *\".              ");
            coboltxt.WriteLine($"           DISPLAY \"********************************************\".              ");
            coboltxt.WriteLine($"           DISPLAY \"*                                          *\".              ");

            foreach (var item in _listaArq)
            {
                String spaces = new String(' ', 8 - item.ArquivoNome.Length);
                String pontos = new String('.', 8 - item.ArquivoNome.Length);
                if (item.Io)
                {
                    coboltxt.WriteLine($"           MOVE WS-LIDOS-{item.ArquivoNome + spaces}      TO WS-MASCARA.                           ");
                    coboltxt.WriteLine($"           DISPLAY \"* LIDOS DO ARQUIVO {item.ArquivoNome + pontos}...: WS-MASCARA *\".              ");
                    coboltxt.WriteLine($"           DISPLAY \"*                                          *\".              ");

                }
            }

            foreach (var item in _listaArq)
            {
                String spaces = new String(' ', 8 - item.ArquivoNome.Length);
                String pontos = new String('.', 8 - item.ArquivoNome.Length);
                if (!item.Io)
                {
            coboltxt.WriteLine($"           MOVE WS-GRAVADOS-{item.ArquivoNome + spaces}   TO WS-MASCARA.                           ");
            coboltxt.WriteLine($"           DISPLAY \"* GRAVADOS NO ARQUIVO {item.ArquivoNome + pontos}: WS-MASCARA *\"               ");
            coboltxt.WriteLine($"           DISPLAY \"*                                          *\"               ");

                }
            }

            if (_listaTabela.Count > 0)
            {
                foreach (var item in _listaTabela)
                {
                    String pontos = new String('.', 8 - item.TabelNome.Length);
                    if (item.ChkSelect)
                    {
                        coboltxt.WriteLine($"           MOVE WS-TOTAL-SELECT-{item.TabelNome}                                          ");
                        coboltxt.WriteLine($"                                       TO WS-MASCARA-DB2.                         ");
                        coboltxt.WriteLine($"           DISPLAY \"* SELECTS {item.TabelNome + pontos}............: \" WS-MASCARA-DB2 \" *\".              ");
                        coboltxt.WriteLine($"           DISPLAY \"*                                          *\".              ");

                    }

                    if (item.ChkInsert)
                    { 
                        coboltxt.WriteLine($"           MOVE WS-TOTAL-INSERT-{item.TabelNome}                                          ");
                        coboltxt.WriteLine($"                                       TO WS-MASCARA-DB2.                         ");
                        coboltxt.WriteLine($"           DISPLAY \"* INSERTS {item.TabelNome + pontos}............: \" WS-MASCARA-DB2 \" *\".              ");
                        coboltxt.WriteLine($"           DISPLAY \"*                                          *\".              ");
                    }

                    if (item.ChkUpdate)
                    {
                        coboltxt.WriteLine($"           MOVE WS-TOTAL-UPDATE-{item.TabelNome}                                          ");
                        coboltxt.WriteLine($"                                       TO WS-MASCARA-DB2.                         ");
                        coboltxt.WriteLine($"           DISPLAY \"* UPDATES {item.TabelNome + pontos}............: \" WS-MASCARA-DB2 \" *\".              ");
                        coboltxt.WriteLine($"           DISPLAY \"*                                          *\".              ");
                    }

                    if (item.ChkDelete)
                    { 
                        coboltxt.WriteLine($"           MOVE WS-TOTAL-DELETE-{item.TabelNome}                                          ");
                        coboltxt.WriteLine($"                                       TO WS-MASCARA-DB2.                         ");
                        coboltxt.WriteLine($"           DISPLAY \"* DELETES {item.TabelNome + pontos}............: \" WS-MASCARA-DB2 \" *\".              ");
                        coboltxt.WriteLine($"           DISPLAY \"*                                          *\".              ");
                    }

                    if (item.ChkCursor)
                    { 
                        coboltxt.WriteLine($"           MOVE WS-TOTAL-FETCH-{item.TabelNome}                                           ");
                        coboltxt.WriteLine($"                                       TO WS-MASCARA-DB2.                         ");
                        coboltxt.WriteLine($"           DISPLAY \"* FETCHS  {item.TabelNome + pontos}............: \" WS-MASCARA-DB2 \" *\".              ");
                        coboltxt.WriteLine($"           DISPLAY \"*                                          *\".              ");
                    }

                }
            }
            coboltxt.WriteLine($"           DISPLAY \"********************************************\".              ");
            coboltxt.WriteLine($"      *                                                                *        ");

            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"       9000-ESTATISTICAS-FIM.          EXIT.                                    ");
            coboltxt.WriteLine($"      *----------------------------------------------------------------*        ");
            coboltxt.WriteLine($"      *                                                                *        ");

            //Fechar arquivo
            coboltxt.Close();

           

        }
    }
}
