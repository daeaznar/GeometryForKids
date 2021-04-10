using System.Collections.Generic;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class Volumes : Form
    {
        private Form parent;
        List<Panel> panels = new List<Panel>();
        int i;  //index
        public Volumes(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void Volumes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (i < 3)
                parent.Show();
        }

        private void btnPrevious_Click(object sender, System.EventArgs e)
        {
            --i;
            if (i < 0)
            {
                PerimsAndAreasAct perimsAndAreasAct = new PerimsAndAreasAct(parent);
                perimsAndAreasAct.Show();
                this.Close();
            }
            else
                panels[i].BringToFront();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            ++i;
            if (i == 2)
                btnNext.Text = "Continue";
            if (i == 3)
            {
                VolumesAct volumesAct = new VolumesAct(parent);    //passes Form1 to Form3
                this.Close();
                volumesAct.Show();
            }
            else
                panels[i].BringToFront();
        }

        private void Volumes_Load(object sender, System.EventArgs e)
        {
            panels.Add(pnl1);
            panels.Add(pnl2);
            panels.Add(pnl3);
            panels[i].BringToFront();
        }
    }
}
