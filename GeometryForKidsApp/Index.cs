using System;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            lblWelcome.Text += $" {Form1.student}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();   //Closes this window
            Application.Exit(); //Terminates program
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PerimetersAndAreas perimsAndAreas = new PerimetersAndAreas(this);
            perimsAndAreas.Show();
            this.Hide();
        }

        private void llbPerimsAndAreas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PerimetersAndAreas perimsAndAreas = new PerimetersAndAreas(this);
            perimsAndAreas.Show();
            this.Hide();
        }

        private void llbVolumes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Volumes volumes = new Volumes(this);
            volumes.Show();
            this.Hide();
        }

        private void llbAngles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Angles angles = new Angles(this);
            angles.Show();
            this.Hide();
        }

        private void llbProtractors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Protractors protractos = new Protractors(this);
            protractos.Show();
            this.Hide();
        }

        private void llbPolygons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Polygons polygons = new Polygons(this);
            polygons.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //llbReferences
        {
            ProjectReferences references = new ProjectReferences(this);
            references.Show();
            this.Hide();
        }

        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
