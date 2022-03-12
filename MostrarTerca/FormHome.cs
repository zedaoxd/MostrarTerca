using MostrarTerca.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarTerca
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            DataBaseConnection.ReloadDataTable(ref dataGridHome);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (textBoxSearch == null || buttonFilter.Text == "")
                return;

            DataBaseConnection.SearchByBrand(textBoxSearch.Text, ref dataGridHome);
        }
    }
}
