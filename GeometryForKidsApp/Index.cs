using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            lblWelcome.Text += $" {Form1.student}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes this window
            Application.Exit(); //Terminates program
        }
    }
}
