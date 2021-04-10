using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class PerimetersAndAreas : Form
    {
        private Form parent;
        List<Panel> panels = new List<Panel>();
        int i;  //index
        public PerimetersAndAreas(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            --i;
            if (i < 0)
            {
                this.Close();
                parent.Show();  //Goes to Index
            }
            else
                panels[i].BringToFront();
        }

        private void PerimetersAndAreas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (i < 7)
                parent.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++i;
            if (i == 6)
                btnNext.Text = "Continue";
            if (i == 7)
            {
                PerimsAndAreasAct perimsAndAreasAct = new PerimsAndAreasAct(parent);    //passes Form1 to Form3
                this.Close();
                perimsAndAreasAct.Show();
            }
            else
                panels[i].BringToFront();
        }

        private void PerimetersAndAreas_Load(object sender, EventArgs e)
        {
            panels.Add(pnl1);
            panels.Add(pnl2);
            panels.Add(pnl3);
            panels.Add(pnl4);
            panels.Add(pnl5);
            panels.Add(pnl6);
            panels.Add(pnl7);
            panels[i].BringToFront();
        }
    }
}
