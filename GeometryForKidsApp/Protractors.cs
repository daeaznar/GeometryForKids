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
    public partial class Protractors : Form
    {
        private Form parent;
        public Protractors(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void Protractors_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ProtractorsAct protractorAct = new ProtractorsAct(parent);
            this.Close();
            protractorAct.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            AnglesAct anglesAct = new AnglesAct(parent);
            this.Close();
            anglesAct.Show();
        }
    }
}
