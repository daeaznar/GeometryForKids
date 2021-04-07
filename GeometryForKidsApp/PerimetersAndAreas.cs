using System;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class PerimetersAndAreas : Form
    {

        private Form parent;
        public PerimetersAndAreas(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();  //Goes to Index
        }

        private void PerimetersAndAreas_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

    }
}
