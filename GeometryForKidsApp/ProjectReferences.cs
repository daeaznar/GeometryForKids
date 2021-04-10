using System;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class ProjectReferences : Form
    {
        private Form parent;
        public ProjectReferences(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void ProjectReferences_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PolygonsAct polygonsAct = new PolygonsAct(parent);
            this.Close();
            polygonsAct.Show();
        }
    }
}
