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
    public partial class Angles : Form
    {
        private Form parent;
        public Angles(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void Angles_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
