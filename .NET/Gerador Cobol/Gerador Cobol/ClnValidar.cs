using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_Cobol
{
    class ClnValidar
    {
        private String _programa;
        private String _desenv;
        private String _analista;
        private String _arquivoNome;
        private String _arquivoBook;
        private String _arquivoTamanho;
        private String _subNome;
        private String _subBook;
        private String _comboArquivo1;
        private String _comboArquivo2;
        private String _indArquivo1;
        private String _indArquivo2;
        private Boolean _chkBalanceline;
        private Boolean _rdb1_1;
        private Boolean _rdb1_N;
        private Boolean _rdbN_1;
        private Boolean _rdbN_N;
        private String _tabelaNome;
        private String _dclgen;

        public string Programa {set => _programa = value; }
        public string Desenv {set => _desenv = value; }
        public string Analista {set => _analista = value; }
        public string ArquivoNome {set => _arquivoNome = value; }
        public string ArquivoBook {set => _arquivoBook = value; }
        public string ArquivoTamanho {set => _arquivoTamanho = value; }
        public string SubNome {set => _subNome = value; }
        public string SubBook {set => _subBook = value; }
        public bool ChkBalanceline {set => _chkBalanceline = value; }
        public string ComboArquivo1 {set => _comboArquivo1 = value; }
        public string ComboArquivo2 {set => _comboArquivo2 = value; }
        public string IndArquivo1 {set => _indArquivo1 = value; }
        public string IndArquivo2 {set => _indArquivo2 = value; }
        public bool Rdb1_1 {set => _rdb1_1 = value; }
        public bool Rdb1_N {set => _rdb1_N = value; }
        public bool RdbN_1 {set => _rdbN_1 = value; }
        public bool RdbN_N {set => _rdbN_N = value; }
        public string TabelaNome { get => _tabelaNome; set => _tabelaNome = value; }
        public string Dclgen { get => _dclgen; set => _dclgen = value; }

        public String Validar()
        {
            if (String.IsNullOrEmpty(_programa))
            {
                return ("Preencha o nome do programa");
            }

            if (String.IsNullOrEmpty(_desenv))
            {
                return ("Preencha o nome do(a) desenvolvedor(a)");
            }

            if (String.IsNullOrEmpty(_analista))
            {
                return ("Preencha o nome do(a) analista");
            }

            if (_chkBalanceline)
            {
                if (String.IsNullOrEmpty(_comboArquivo1))
                {
                    return ("Selecione o arquivo 1 do Balance Line");
                }

                if (String.IsNullOrEmpty(_comboArquivo2))
                {
                    return ("Selecione o arquivo 2 do Balance Line");
                }

                if (String.IsNullOrEmpty(_indArquivo1))
                {
                    return ("Preencha o índice do arquivo 1 do Balance Line");
                }

                if (_comboArquivo1 == _comboArquivo2)
                {
                    return ("Os arquivos do Balance Line devem ser diferentes");
                }

                if (String.IsNullOrEmpty(_indArquivo2))
                {
                    return ("Preencha o índice do arquivo 2 do Balance Line");
                }

                if (!_rdb1_1 && !_rdb1_N && !_rdbN_1 && !_rdbN_N)
                {
                    return ("Escolha o tipo de Balance Line");
                }
            }

            return String.Empty;
        }

        public String ValidarArquivo()
        {
            if (String.IsNullOrEmpty(_arquivoNome))
            {
                return ("Preencha o nome do arquivo");
            }

            if (String.IsNullOrEmpty(_arquivoBook))
            {
                return ("Preencha o book do arquivo");
            }

            if (String.IsNullOrEmpty(_arquivoTamanho))
            {
                return ("Preencha o tamanho do arquivo");
            }

            if (!int.TryParse(_arquivoTamanho, out int n))
            {
                return ("O Tamanho deve ser numérico");
            }

            return String.Empty;
        }

        public String ValidarSub()
        {
            if (String.IsNullOrEmpty(_subNome))
            {
                return ("Preencha o nome do sub programa");
            }

            if (String.IsNullOrEmpty(_subBook))
            {
                return ("Preencha o book do sub programa");
            }

            return String.Empty;
        }

        public String ValidarTabela()
        {
            if (String.IsNullOrEmpty(_tabelaNome))
            {
                return ("Preencha o nome da tabela");
            }

            if (String.IsNullOrEmpty(_dclgen))
            {
                return ("Preencha o DCLGEN da tabela");
            }

            return String.Empty;
        }
    }

}
