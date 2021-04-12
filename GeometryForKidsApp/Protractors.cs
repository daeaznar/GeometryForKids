using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class Protractors : Form
    {
        private Form parent;
        List<Panel> panels = new List<Panel>();
        int i = 0;  //index
        public Protractors(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void Protractors_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (i != 2 && i >= 0)
                parent.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++i;
            if (i == 2)
            {
                ProtractorsAct protractorAct = new ProtractorsAct(parent);
                this.Close();
                protractorAct.Show();
            }
            else
                panels[i].BringToFront();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            --i;
            if (i < 0)
            {
                AnglesAct anglesAct = new AnglesAct(parent);
                this.Close();
                anglesAct.Show();
            }
            else
                panels[i].BringToFront();
        }

        private void Protractors_Load(object sender, EventArgs e)
        {
            panels.Add(pnl1);
            panels.Add(pnl2);
            panels[i].BringToFront();
        }
    }
}
