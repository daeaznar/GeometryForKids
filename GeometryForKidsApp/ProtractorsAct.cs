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
    public partial class ProtractorsAct : Form
    {
        private Form parent;
        public ProtractorsAct(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void ProtractorsAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Protractors protractors = new Protractors(parent);
            this.Close();
            protractors.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Polygons polygons = new Polygons(parent);
            this.Close();
            polygons.Show();
        }
    }
}
