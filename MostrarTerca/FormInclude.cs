using MostrarTerca.Model;
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
    public partial class FormInclude : Form
    {
        private static string[] optionsGas = new string[]
{
            "1 - Gasoline",
            "2 - Alcohol",
            "3 - Flex",
            "4 - Diesel",
            "5 - Natural Gas"
};
        private int id;
        private Vehicle vehicle;

        public FormInclude()
        {
            InitializeComponent();
        }

        private void FormInclude_Load(object sender, EventArgs e)
        {
            comboBoxFuel.Items.Clear();
            comboBoxFuel.Items.AddRange(optionsGas);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!SomeEmptyField())
            {
                SaveVehicle();
            }
        }

        private void SaveVehicle()
        {
            if (DataBaseConnection.SaveVehicle(textBoxBrand.Text, textBoxModel.Text, textBoxYear.Text, textBoxYearManufacture.Text,
                    textBoxColor.Text, comboBoxFuel.Text, comboBoxAutomatic.Text, textBoxPrice.Text))
            {
                MessageBox.Show("Vehicle Added");
            }
        }

        private bool SomeEmptyField()
        {
            TextBox[] texts = new TextBox[]
            {
                textBoxBrand, textBoxModel, textBoxYear, textBoxYearManufacture, textBoxColor, textBoxPrice,
            };
            ComboBox[] combos = new ComboBox[]
            {
                comboBoxAutomatic, comboBoxFuel,
            };

            foreach (var text in texts)
            {
                if (text == null || text.Text == "")
                    return true;
            }

            foreach (var comboBox in combos)
            {
                if (comboBox == null || comboBox.Text == "")
                    return true;
            }

            return false;
        }
    }
}
