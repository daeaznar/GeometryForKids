using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class PerimsAndAreasAct : Form
    {
        private Form parent;
        public PerimsAndAreasAct(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void PerimsAndAreasAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnPrevious_Click(object sender, System.EventArgs e)
        {
            PerimetersAndAreas perimsAndAreas = new PerimetersAndAreas(parent);
            perimsAndAreas.Show();
            this.Close();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            Volumes volumes = new Volumes(parent);
            this.Close();
            volumes.Show();
        }
    }
}
