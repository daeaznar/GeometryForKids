using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class Angles : Form
    {
        private Form parent;
        List<Panel> panels = new List<Panel>();
        int i = 0;  //index
        public Angles(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void Angles_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (i != 3 && i >= 0)
                parent.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            --i;
            if (i < 0)
            {
                VolumesAct volumeAct = new VolumesAct(parent);
                this.Close();
                volumeAct.Show();
            }
            else
                panels[i].BringToFront();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++i;
            if (i == 3)
            {
                AnglesAct anglesAct = new AnglesAct(parent);    //passes Index to AnglesAct
                this.Close();
                anglesAct.Show();
            }
            else
                panels[i].BringToFront();
        }

        private void Angles_Load(object sender, EventArgs e)
        {
            panels.Add(pnl1);
            panels.Add(pnl2);
            panels.Add(pnl3);
            panels[i].BringToFront();
        }
    }
}
