using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarTerca
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            OpenForm(new FormHome());
        }

        private void OpenForm(Form form)
        {
            if (panelContent.Controls.Count > 0)
            {
                panelContent.Controls.Clear();
            }

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            panelContent.Tag = form;
            form.Show();
        }

        private void timerHourLabel_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.ToString("HH:mm");
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonOpenAddScreen_Click(object sender, EventArgs e)
        {
            OpenForm(new FormInclude());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenForm(new FormHome());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BarTitle_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BarTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        // mover app com o cursor
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Iparam);


    }
}
