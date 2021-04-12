using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class PerimsAndAreasAct : Form
    {
        private Form parent;
        List<Panel> panels = new List<Panel>();
        int i = 0;  //index
        Random rnd = new Random();  //Generates random number instance
        int num;    //num for random number
        bool answer = false;
        PictureBox img;
        double shapePerimeter;
        double shapeArea;
        bool result_p, result_a;

        public PerimsAndAreasAct(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        #region part 1
        private int ResultsPart1()
        {
            int q1 = GetOption(grp1, rdb3);      //for grp 1 the correct answer is rdb3
            int q2 = GetOption(grp2, rdb7);
            int q3 = GetOption(grp3, rdb9);
            int q4 = GetOption(grp4, rdb16);
            int q5 = GetOption(grp5, rdb18);
            return q1 + q2 + q3 + q4 + q5;
        }

        private int GetOption(GroupBox grp, RadioButton rdb)
        {
            foreach (Control control in grp.Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                {
                    if (rdb.Checked)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        #endregion
        private void PerimsAndAreasAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (i != 2 && i >= 0)
                parent.Show();
        }

        private void btnPrevious_Click(object sender, System.EventArgs e)
        {
            --i;
            if (i < 0)
            {
                PerimetersAndAreas perimsAndAreas = new PerimetersAndAreas(parent);
                perimsAndAreas.Show();
                this.Close();
            }
            else
            {
                panels[i].BringToFront();
                pnl3.Refresh();
            }
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to continue to next part?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ++i;
                if (i == 1)
                {
                    MessageBox.Show($"You got {ResultsPart1()} correct answers", "Quiz Score");
                }

                if (i == 2)
                {
                    Volumes volumes = new Volumes(parent);
                    this.Close();
                    volumes.Show();
                }
                else
                    panels[i].BringToFront();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void PerimsAndAreasAct_Load(object sender, System.EventArgs e)
        {
            panels.Add(pnl1);
            panels.Add(pnl2);
            panels[i].BringToFront();
        }

        #region Part 2
        private int GetNumber()
        {
            num = rnd.Next(1, 100);
            return num;
        }

        private void pctSquare_Click(object sender, System.EventArgs e)
        {
            img = pctSquare;
            pnl3.BringToFront();
            pctShape.Image = Properties.Resources.square;

            int side = GetNumber();
            lblHeight.Text = $"Side: {side}";
            lblLenght.Text = "";

            shapePerimeter = side * 4;
            shapeArea = side * side;
        }

        private void pctCircle_Click(object sender, System.EventArgs e)
        {
            img = pctCircle;
            pnl3.BringToFront();
            pctShape.Image = Properties.Resources.circle;

            int radius = GetNumber();
            lblHeight.Text = $"Radius: {radius}";
            lblLenght.Text = "";

            shapePerimeter= 3.1416 * radius * 2;
            shapeArea = radius * radius * 3.1416;
        }

        private void pctRectangle_Click(object sender, System.EventArgs e)
        {
            img = pctSquare;
            pnl3.BringToFront();
            pctShape.Image = Properties.Resources.rectangle;

            int height = GetNumber();
            int lenght = GetNumber();
            lblHeight.Text = $"Height: {height}";
            lblLenght.Text = $"Length: {lenght}";

            shapePerimeter = height * 2 + lenght * 2;
            shapeArea = lenght * height;
        }

        private void pctTriangle_Click(object sender, System.EventArgs e)
        {
            img = pctTriangle;
            pnl3.BringToFront();
            pctShape.Image = Properties.Resources.triangle;

            int height = GetNumber();
            int triangBase = GetNumber();
            lblHeight.Text = $"Height: {height}";
            lblLenght.Text = $"Base: {triangBase}";

            shapePerimeter = triangBase * 3;
            shapeArea = triangBase * height / 2;
        }

        public void btnCheck_Click(object sender, EventArgs e)
        {
            double perim, area;

            if (img == pctSquare)
            {
                result_p = double.TryParse(txtPerimeter.Text, out perim);
                result_a = double.TryParse(txtArea.Text, out area);
                if (result_p == false || result_a == false)
                {
                    MessageBox.Show("Invalid Value");
                    txtPerimeter.Clear();
                    txtArea.Clear();
                    return;
                }
                if (perim == shapePerimeter && area == shapeArea)
                {
                    answer = true;
                }
            }
            if (img == pctCircle)
            {
                result_p = double.TryParse(txtPerimeter.Text, out perim);
                result_a = double.TryParse(txtArea.Text, out area);
                if (result_p == false || result_a == false)
                {
                    MessageBox.Show("Invalid Value");
                    txtPerimeter.Clear();
                    txtArea.Clear();
                    return;
                }
                if (perim == shapePerimeter && area == shapeArea)
                {
                    answer = true;
                }
            }
            if (img == pctRectangle)
            {
                result_p = double.TryParse(txtPerimeter.Text, out perim);
                result_a = double.TryParse(txtArea.Text, out area);
                if (result_p == false || result_a == false)
                {
                    MessageBox.Show("Invalid Value");
                    txtPerimeter.Clear();
                    txtArea.Clear();
                    return;
                }
                if (perim == shapePerimeter && area == shapeArea)
                {
                    answer = true;
                }
            }
            if (img == pctTriangle)
            {
                result_p = double.TryParse(txtPerimeter.Text, out perim);
                result_a = double.TryParse(txtArea.Text, out area);
                if (result_p == false || result_a == false)
                {
                    MessageBox.Show("Invalid Value");
                    txtPerimeter.Clear();
                    txtArea.Clear();
                    return;
                }
                if (perim == shapePerimeter && area == shapeArea)
                {
                    answer = true;
                }

            }

            if (answer == true)
            {
                DialogResult dialogResult = MessageBox.Show("Correct! You rock! Want to try again?", "Success", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    pnl2.BringToFront();
                    txtArea.Clear();
                    txtPerimeter.Clear();
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
        #endregion
    }
}
