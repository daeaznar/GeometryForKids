using System;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class Form1 : Form
    {
        public static string student;
        public Form1()
        {
            InitializeComponent();
        }

        public void btnGo_Click(object sender, EventArgs e)
        {
            student = txtName.Text;   
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e) //BtnGo_click when pressing enter ir txtName field
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnGo_Click(this, new EventArgs());
            }
        }
    }
}
