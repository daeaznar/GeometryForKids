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
    public partial class AnglesAct : Form
    {
        private Form parent;
        public AnglesAct(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void AnglesAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Angles angles = new Angles(parent);
            this.Close();
            angles.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Protractors protractors = new Protractors(parent);
            this.Close();
            protractors.Show();
        }
    }
}
