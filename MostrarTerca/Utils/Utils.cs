using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarTerca.Utils
{
    internal class Utils
    {
        public static void OpenForm(Form form, Panel panel)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
        }
    }
}
