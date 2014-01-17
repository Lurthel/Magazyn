using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace UsuwanieTowaru
{
    class Program
    {
        static void Main(string[] args)
        {

            if (!(e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1)))
                if (TowaryTabela.Columns[e.ColumnIndex].Name == "Usun")
                {
                    DialogResult flag = MessageBox.Show("Czy na pewno chcesz usunąć ten towar ?", "Usuwanie towaru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (flag == DialogResult.Yes)
                    {
                        ListaTowarow list = ListaTowarow.Instance;
                        int i = Convert.ToInt32(TowaryTabela.Rows[e.RowIndex].Cells["Id"].Value);
                        list.usun(i);
                        list.Rebind();
                        TowaryTabela.Refresh();
                    }
                }
        }
    }

}

