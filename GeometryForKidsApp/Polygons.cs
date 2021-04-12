using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class Polygons : Form
    {
        private Form parent;
        List<Panel> panels = new List<Panel>();
        int i = 0;  //index
        public Polygons(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void Polygons_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (i != 2 && i >= 0)
                parent.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            --i;
            if (i < 0)
            {
                ProtractorsAct protractorAct = new ProtractorsAct(parent);
                this.Close();
                protractorAct.Show();
            }
            else
                panels[i].BringToFront();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++i;
            if (i == 2)
            {
                PolygonsAct polygonsAct = new PolygonsAct(parent);
                this.Close();
                polygonsAct.Show();
            }
            else
                panels[i].BringToFront();
        }

        private void Polygons_Load(object sender, EventArgs e)
        {
            panels.Add(pnl1);
            panels.Add(pnl2);
            panels[i].BringToFront();
        }
    }
}
