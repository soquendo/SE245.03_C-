
namespace lab6_oquendo
{
    partial class ControlPanel
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
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearchPeople = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.Location = new System.Drawing.Point(209, 165);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(160, 67);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchPeople
            // 
            this.btnSearchPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPeople.Location = new System.Drawing.Point(489, 165);
            this.btnSearchPeople.Name = "btnSearchPeople";
            this.btnSearchPeople.Size = new System.Drawing.Size(160, 67);
            this.btnSearchPeople.TabIndex = 0;
            this.btnSearchPeople.Text = "Search People";
            this.btnSearchPeople.UseVisualStyleBackColor = true;
            this.btnSearchPeople.Click += new System.EventHandler(this.btnSearchPeople_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 455);
            this.Controls.Add(this.btnSearchPeople);
            this.Controls.Add(this.btnAddPerson);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearchPeople;
    }
}