using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_oquendo
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }

        private void btnSearchPeople_Click(object sender, EventArgs e)
        {
            PeopleSearch temp = new PeopleSearch();
            temp.Show();
        }
    }
}
