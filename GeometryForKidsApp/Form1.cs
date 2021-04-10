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
            //Validates if the txtBox is empty or not
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                // Error MessageBox with message and caption
                MessageBox.Show("The Name CAN'T be empty", "Error");
                this.ActiveControl = txtName; //Autofocus on txtName
                return;
            }
            
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
