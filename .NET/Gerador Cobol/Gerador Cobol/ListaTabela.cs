using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_Cobol
{
    class ListaTabela
    {
        private String _tabelaNome;
        private String _dclgen;
        private Boolean _chkSelect;
        private Boolean _chkInsert;
        private Boolean _chkUpdate;
        private Boolean _chkDelete;
        private Boolean _chkCursor;

        public string TabelNome { get => _tabelaNome; set => _tabelaNome = value; }
        public string Dclgen { get => _dclgen; set => _dclgen = value; }
        public bool ChkSelect { get => _chkSelect; set => _chkSelect = value; }
        public bool ChkInsert { get => _chkInsert; set => _chkInsert = value; }
        public bool ChkUpdate { get => _chkUpdate; set => _chkUpdate = value; }
        public bool ChkDelete { get => _chkDelete; set => _chkDelete = value; }
        public bool ChkCursor { get => _chkCursor; set => _chkCursor = value; }

        public override string ToString()
        {
            String tbl = String.Empty;

            if (_chkSelect)
            {
                tbl += "|S|";
            }
            if (_chkInsert)
            {
                tbl += "|I|";
            }
            if (_chkUpdate)
            {
                tbl += "|U|";
            }
            if (_chkDelete)
            {
                tbl += "|D|";
            }
            if (_chkCursor)
            {
                tbl += "|C|";
            }
            return $"{_tabelaNome} | {_dclgen} | {tbl}";
        }
    }
}
