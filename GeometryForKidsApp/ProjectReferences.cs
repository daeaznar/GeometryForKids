using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryForKidsApp
{
    public partial class ProjectReferences : Form
    {
        private Form parent;
        public ProjectReferences(Form caller)
        {
            parent = caller;
            InitializeComponent();
        }

        private void ProjectReferences_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
