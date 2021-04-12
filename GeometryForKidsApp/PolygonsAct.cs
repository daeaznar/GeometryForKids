using System;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class PolygonsAct : Form
    {
        private Form parent;
        int page = 0;
        int correctAnswers = 0;
        public PolygonsAct(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void PolygonsAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (page != 1)
                parent.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ++page;
            Polygons polygons = new Polygons(parent);
            this.Close();
            polygons.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        { 
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to skip to the next part?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ++page;
                ProjectReferences references = new ProjectReferences(parent);
                this.Close();
                references.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (cmb11.SelectedItem == null || cmb12.SelectedItem == null || cmb21.SelectedItem == null ||
                    cmb22.SelectedItem == null || cmb31.SelectedItem == null || cmb32.SelectedItem == null ||
                    cmb41.SelectedItem == null || cmb42.SelectedItem == null || cmb51.SelectedItem == null ||
                    cmb52.SelectedItem == null)
            {
                MessageBox.Show("One or more fields haven't been selected, please do", "Error");
                return;
            }

            else
            {
                if (cmb11.Text == "Regular" && cmb12.Text == "Triangle")
                {
                    ++correctAnswers;
                }
                if (cmb21.Text == "Irregular" && cmb22.Text == "Hexagon")
                {
                    ++correctAnswers;
                }
                if (cmb31.Text == "Regular" && cmb32.Text == "Hexagon")
                {
                    ++correctAnswers;
                }
                if (cmb41.Text == "Irregular" && cmb42.Text == "Triangle")
                {
                    ++correctAnswers;
                }
                if (cmb51.Text == "Irregular" && cmb52.Text == "Octagon")
                {
                    ++correctAnswers;
                }
                if (correctAnswers != 5)
                {
                    DialogResult dialogResult = MessageBox.Show($"You got {correctAnswers} correct answers out of 5. Want to try again?", "Test Completed", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ++page;
                        PolygonsAct activity = new PolygonsAct(parent);
                        this.Close();
                        activity.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        ++page;
                        ProjectReferences references = new ProjectReferences(parent);
                        this.Close();
                        references.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Congratulations! You've made it! Perfect score!", "Perfect Score");
                    ProjectReferences references = new ProjectReferences(parent);
                    this.Close();
                    references.Show();
                }
            }
        }
    }
}
