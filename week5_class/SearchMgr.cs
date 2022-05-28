using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5_class
{
    public partial class SearchMgr : Form
    {
        public SearchMgr()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //get data
            Ebook temp = new Ebook();
            //perform search we created in EBook class, store the returned dataset
            DataSet ds = temp.SearchEBooks(txtTitle.Text, txtAuthorLast.Text);

            dgvResults.DataSource = ds;    //point datagrid to dataset
            dgvResults.DataMember = ds.Tables["Ebooks_Temp"].ToString(); //which table in dataset

        }

        /// <summary>
        /// Event-Handler Method - When we double-click a data cell, get the ID and use it to search for the
        ///   whole record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //gather info - gathers from the row clicked, chooses the first cell data
            string strEBook_ID = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            //display data in popup
            MessageBox.Show(strEBook_ID);

            //Convert the string over to an integer
            int intEBook_ID = Convert.ToInt32(strEBook_ID);

            //creates editor and passes it one ebook's ID
            // NOTE THAT THE ID BEING PASSED WILL CALL THE OVERLOADED VERSION
            // OF THE CONSTRUCTOR...TELL IT, IN ESSENCE THAT WE ARE PULLING UP
            // RATHER THAN ADDING DATA 
            Form1 Editor = new Form1(intEBook_ID);
            Editor.ShowDialog();
        }

    }
}
