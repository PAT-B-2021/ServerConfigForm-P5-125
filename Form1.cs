using ServiceMtk_P1_125;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_125
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));
            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk mematikan Server";
            Host.Open();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik ON untuk menjalankan Server";
            labelOnOrOff.Text = "Server OFF";

        }
    }
}
