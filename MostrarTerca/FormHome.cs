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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridHome.Rows[dataGridHome.CurrentCell.RowIndex].Cells[0].Value);
            OpenForm(new FormInclude(id));
        }

        private void OpenForm(Form form)
        {
            if (this.Controls.Count > 0)
            {
                this.Controls.Clear();
            }

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            this.Tag = form;
            form.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want remove this row", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dataGridHome.Rows[dataGridHome.CurrentCell.RowIndex].Cells[0].Value);
                DataBaseConnection.DeleteVehicle(id);
                MessageBox.Show("Deleted");
                DataBaseConnection.ReloadDataTable(ref dataGridHome);
            }
        }
    }
}
