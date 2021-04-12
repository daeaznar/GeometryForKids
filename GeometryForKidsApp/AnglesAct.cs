using System;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class AnglesAct : Form
    {
        private Form parent;
        int page = 0;

        // quiz variables
        int correctAnswer;
        int questionNumber = 1;
        int score = 0;
        int totalQuestions;

        public AnglesAct(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void AnglesAct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (page != 1)
                parent.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ++page;
            Angles angles = new Angles(parent);
            this.Close();
            angles.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to skip to the next part?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ++page;
                Protractors protractors = new Protractors(parent);
                this.Close();
                protractors.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                ++score;
            }

            if (questionNumber == totalQuestions)
            {
                DialogResult dialogResult = MessageBox.Show($"You've finished the quiz. You got right {score} " +
                    $"questions out of {totalQuestions}. Do you want to play again?", "Quiz Completed", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ++page;
                    AnglesAct activity = new AnglesAct(parent);
                    this.Close();
                    activity.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    ++page;
                    Protractors protractors = new Protractors(parent);
                    this.Close();
                    protractors.Show();
                }
            }
            ++questionNumber;
            AskQuestion(questionNumber);
        }

        private void AskQuestion(int qNum)   //question number
        {
            switch (qNum)
            {
                case 1:     // Acute angle
                    pctAngle.Image = Properties.Resources.Acute_Angle;

                    btn1.Text = "Obtuse";
                    btn2.Text = "Acute";
                    btn3.Text = "Reflex";
                    btn4.Text = "Right";

                    correctAnswer = 2;

                    break;

                case 2:     // Right Angle
                    pctAngle.Image = Properties.Resources.Right_Angle;

                    btn1.Text = "Acute";
                    btn2.Text = "Reflex";
                    btn3.Text = "Obtuse";
                    btn4.Text = "Right";

                    correctAnswer = 4;

                    break;

                case 3:     // Obtuse Angle
                    pctAngle.Image = Properties.Resources.Obtuse_Angle;

                    btn1.Text = "Obtuse";
                    btn2.Text = "Right";
                    btn3.Text = "Straight";
                    btn4.Text = "Acute";

                    correctAnswer = 1;
                    break;

                case 4:     // Reflex Angle
                    pctAngle.Image = Properties.Resources.Reflex_Angle;

                    btn1.Text = "Right";
                    btn2.Text = "Acute";
                    btn3.Text = "Reflex";
                    btn4.Text = "Obtuse";

                    correctAnswer = 3;
                    break;

                case 5:     // Straight Angle
                    pctAngle.Image = Properties.Resources.Straight_Angle;

                    btn1.Text = "Obtuse";
                    btn2.Text = "Acute";
                    btn3.Text = "Straight";
                    btn4.Text = "Right";

                    correctAnswer = 3;
                    break;

                case 6:     // Obtuse Angle upside down
                    pctAngle.Image = Properties.Resources.Obtuse_Angle_upside_down;

                    btn1.Text = "Stright";
                    btn2.Text = "Acute";
                    btn3.Text = "Reflex";
                    btn4.Text = "Obtuse";

                    correctAnswer = 4;
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            btn1.Show();
            btn2.Show();
            btn3.Show();
            btn4.Show();
            lblQuestion.Text = "What type of Angle is the one above?";
            AskQuestion(questionNumber);
            totalQuestions = 6;

        }

        private void AnglesAct_Load(object sender, EventArgs e)
        {
            btn1.Hide();
            btn2.Hide();
            btn3.Hide();
            btn4.Hide();
        }
    }
}
