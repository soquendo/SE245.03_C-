
namespace lab6_oquendo
{
    partial class PeopleSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txt_fnamesearch = new System.Windows.Forms.TextBox();
            this.txt_lnamesearch = new System.Windows.Forms.TextBox();
            this.txt_statesearch = new System.Windows.Forms.TextBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(406, 52);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(125, 26);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(406, 114);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(124, 26);
            this.lblLname.TabIndex = 0;
            this.lblLname.Text = "Last Name:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(461, 174);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(69, 26);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "State:";
            // 
            // txt_fnamesearch
            // 
            this.txt_fnamesearch.Location = new System.Drawing.Point(537, 42);
            this.txt_fnamesearch.Multiline = true;
            this.txt_fnamesearch.Name = "txt_fnamesearch";
            this.txt_fnamesearch.Size = new System.Drawing.Size(288, 36);
            this.txt_fnamesearch.TabIndex = 1;
            // 
            // txt_lnamesearch
            // 
            this.txt_lnamesearch.Location = new System.Drawing.Point(537, 104);
            this.txt_lnamesearch.Multiline = true;
            this.txt_lnamesearch.Name = "txt_lnamesearch";
            this.txt_lnamesearch.Size = new System.Drawing.Size(288, 36);
            this.txt_lnamesearch.TabIndex = 1;
            // 
            // txt_statesearch
            // 
            this.txt_statesearch.Location = new System.Drawing.Point(537, 164);
            this.txt_statesearch.Multiline = true;
            this.txt_statesearch.Name = "txt_statesearch";
            this.txt_statesearch.Size = new System.Drawing.Size(288, 36);
            this.txt_statesearch.TabIndex = 1;
            // 
            // dgvResults
            // 
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 347);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 62;
            this.dgvResults.RowTemplate.Height = 28;
            this.dgvResults.Size = new System.Drawing.Size(1332, 575);
            this.dgvResults.TabIndex = 2;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(611, 243);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 53);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PeopleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 934);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.txt_statesearch);
            this.Controls.Add(this.txt_lnamesearch);
            this.Controls.Add(this.txt_fnamesearch);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Name = "PeopleSearch";
            this.Text = "PeopleSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txt_fnamesearch;
        private System.Windows.Forms.TextBox txt_lnamesearch;
        private System.Windows.Forms.TextBox txt_statesearch;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnSearch;
    }
}