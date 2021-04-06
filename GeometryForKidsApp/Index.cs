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
            //PerimetersAndAreas perimsAndAreas = new PerimetersAndAreas();
            //perimsAndAreas.Show();
            Form1.perimsAndAreas.Show();
            this.Close();
        }

        private void llbPerimsAndAreas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PerimetersAndAreas perimsAndAreas = new PerimetersAndAreas();
            perimsAndAreas.Show();
            this.Close();
        }

        private void llbVolumes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Volumes volumes = new Volumes();
            volumes.Show();
            this.Close();
        }

        private void llbAngles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Angles angles = new Angles();
            angles.Show();
            this.Close();
        }

        private void llbProtractors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Protractors protractos = new Protractors();
            protractos.Show();
            this.Close();
        }

        private void llbPolygons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Polygons polygons = new Polygons();
            polygons.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //llbReferences
        {
            ProjectReferences references = new ProjectReferences();
            references.Show();
            this.Close();
        }
    }
}
