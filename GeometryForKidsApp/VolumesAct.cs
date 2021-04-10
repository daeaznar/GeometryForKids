using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class VolumesAct : Form
    {
        private Form parent;
        public VolumesAct(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void VolumesAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnPrevious_Click(object sender, System.EventArgs e)
        {
            Volumes volumes = new Volumes(parent);
            this.Close();
            volumes.Show();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            Angles angles = new Angles(parent);
            this.Close();
            angles.Show();
        }
    }
}
