using System;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class VolumesAct : Form
    {
        private Form parent;
        int page = 0;
        Random rnd = new Random();  //Generates random number instance
        int num;    //num for random number
        bool answer = false;
        PictureBox img;
        double shapeVolume;
        bool result;
        public VolumesAct(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void VolumesAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (page != 1)
                parent.Show();
        }

        private void btnPrevious_Click(object sender, System.EventArgs e)
        {
            ++page;
            Volumes volumes = new Volumes(parent);
            this.Close();
            volumes.Show();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            if (img == null || string.IsNullOrEmpty(txtVolume.Text) || answer == false)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to skip to the next part?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ++page;
                    Angles angles = new Angles(parent);
                    this.Close();
                    angles.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
            else
            {
                Angles angles = new Angles(parent);
                this.Close();
                angles.Show();
            }
        }

        private void VolumesAct_Load(object sender, EventArgs e)
        {
            pnl1.BringToFront();
        }

        #region Solve Volume
        private int GetNumber()
        {
            num = rnd.Next(1, 100);
            return num;
        }

        private void pctCube_Click(object sender, EventArgs e)
        {
            img = pctCube;
            pnl2.BringToFront();
            pctShape.Image = Properties.Resources.cube;

            int h = GetNumber();
            int l = GetNumber();
            int w = GetNumber();

            lblHeight.Text = $"Height: {h}";
            lblLength.Text = $"Lenght: {l}";
            lblWidth.Text = $"Width: {w}";

            shapeVolume = h * l * w;
        }

        private void pctSphere_Click(object sender, EventArgs e)
        {
            img = pctSphere;
            pnl2.BringToFront();
            pctShape.Image = Properties.Resources.sphere;

            int r = GetNumber();

            lblHeight.Text = $"Radius: {r}";
            lblLength.Text = $"";
            lblWidth.Text = $"";

            shapeVolume = 4 / 3 * 3.1416 * (r * r * r); // 4/3rds of pi multiplied by radius cube

        }

        private void pctCylinder_Click(object sender, EventArgs e)
        {
            img = pctCylinder;
            pnl2.BringToFront();
            pctShape.Image = Properties.Resources.cylinder;

            int h = GetNumber();
            int r = GetNumber();

            lblHeight.Text = $"Height: {h}";
            lblLength.Text = $"Radius: {r}";
            lblWidth.Text = $"";

            shapeVolume = 3.1416 * (r * r) * h; // pi multiplied by radius square multiplied by height
        }

        private void pctCone_Click(object sender, EventArgs e)
        {
            img = pctCone;
            pnl2.BringToFront();
            pctShape.Image = Properties.Resources.cone;

            int h = GetNumber();
            int r = GetNumber();

            lblHeight.Text = $"Height: {h}";
            lblLength.Text = $"Radius: {r}";
            lblWidth.Text = $"";

            shapeVolume = 1/3 * 3.1416 * (r * r) * h; // 1/3rd pi multiplied by radius square multiplied by height
        }
        #endregion

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double volume;

            if (img == pctCube)
            {
                result = double.TryParse(txtVolume.Text, out volume);
                if (result == false)
                {
                    MessageBox.Show("Invalid Value");
                    txtVolume.Clear();
                    return;
                }
                if (volume == shapeVolume)
                {
                    answer = true;
                }
            }
            if (img == pctSphere)
            {
                result = double.TryParse(txtVolume.Text, out volume);
                if (result == false)
                {
                    MessageBox.Show("Invalid Value");
                    txtVolume.Clear();
                    return;
                }
                if (volume == shapeVolume)
                {
                    answer = true;
                }
            }
            if (img == pctCylinder)
            {
                result = double.TryParse(txtVolume.Text, out volume);
                if (result == false)
                {
                    MessageBox.Show("Invalid Value");
                    txtVolume.Clear();
                    return;
                }
                if (volume == shapeVolume)
                {
                    answer = true;
                }
            }
            if (img == pctCone)
            {
                result = double.TryParse(txtVolume.Text, out volume);
                if (result == false)
                {
                    MessageBox.Show("Invalid Value");
                    txtVolume.Clear();
                    return;
                }
                if (volume == shapeVolume)
                {
                    answer = true;
                }
            }

            if (answer == true)
            {
                DialogResult dialogResult = MessageBox.Show("Correct! You rock! Want to try again?", "Success", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    pnl1.BringToFront();
                    txtVolume.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do nothing
                }

            }
            else
            {
                MessageBox.Show("That's not the correct answer, check again", "Wrong");
            }
        }
    }
}
