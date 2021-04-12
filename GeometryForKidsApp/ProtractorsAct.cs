using System;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class ProtractorsAct : Form
    {
        private Form parent;
        int page = 0;
        int correctAnswers;
        public ProtractorsAct(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void ProtractorsAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(page != 1)
                parent.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ++page;
            Protractors protractors = new Protractors(parent);
            this.Close();
            protractors.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to skip to the next part?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ++page;
                Polygons polygons = new Polygons(parent);
                this.Close();
                polygons.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Get numbers from txtbox
            int ex1, ex2, ex3, ex4, ex5;

            bool result1 = int.TryParse(txt1.Text, out ex1);
            bool result2 = int.TryParse(txt2.Text, out ex2);
            bool result3 = int.TryParse(txt3.Text, out ex3);
            bool result4 = int.TryParse(txt4.Text, out ex4);
            bool result5 = int.TryParse(txt5.Text, out ex5);

            if (result1 == false || result2 == false || result4 == false || result4 == false || result5 == false)
            {
                MessageBox.Show("One or more fields are blank or have invalid values", "Error");
                if (result1 == false) txt1.Clear();
                if (result2 == false) txt2.Clear();
                if (result3 == false) txt3.Clear();
                if (result4 == false) txt4.Clear();
                if (result5 == false) txt5.Clear();
                return;
            }
            else
            {
                if (cmb1.SelectedItem == null || cmb2.SelectedItem == null || cmb3.SelectedItem == null || 
                    cmb4.SelectedItem == null || cmb5.SelectedItem == null)
                {
                    MessageBox.Show("One or more fields haven't been selected, please do", "Error");
                    return;
                }
                    
                else
                {
                    if (cmb1.Text == "Obtuse" && ex1 == 105)
                    {
                        ++correctAnswers;
                    }
                    if (cmb2.Text == "Acute" && ex2 == 20)
                    {
                        ++correctAnswers;
                    }
                    if (cmb3.Text == "Right" && ex3 == 90)
                    {
                        ++correctAnswers;
                    }
                    if (cmb4.Text == "Obtuse" && ex4 == 150)
                    {
                        ++correctAnswers;
                    }
                    if (cmb5.Text == "Reflex" && ex5 == 290)
                    {
                        ++correctAnswers;
                    }
                    if (correctAnswers != 5)
                    {
                        DialogResult dialogResult = MessageBox.Show($"You got {correctAnswers} correct answers out of 5. Want to try again?", "Test Completed", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ProtractorsAct activity = new ProtractorsAct(parent);
                            this.Close();
                            activity.Show();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            Polygons polygons = new Polygons(parent);
                            this.Close();
                            polygons.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Congratulations! You've made it! Perfect score!", "Perfect Score");
                        Polygons polygons = new Polygons(parent);
                        this.Close();
                        polygons.Show();
                    }
                }

            }

        }
    }
}
