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
    public partial class PeopleSearch : Form
    {
        public PeopleSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();

            DataSet ds = temp.PeopleSearch(txt_fnamesearch.Text, txt_lnamesearch.Text, txt_statesearch.Text);

            dgvResults.DataSource = ds;
            dgvResults.DataMember = ds.Tables["PersonV2_Temp"].ToString();
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strSearchResult = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            int intPersonID = Convert.ToInt32(strSearchResult);

            Form1 Editor = new Form1(intPersonID);
            Editor.ShowDialog();

        }
    }
}
