
namespace week5_class
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
            this.btnAddABook = new System.Windows.Forms.Button();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddABook
            // 
            this.btnAddABook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddABook.Location = new System.Drawing.Point(140, 184);
            this.btnAddABook.Name = "btnAddABook";
            this.btnAddABook.Size = new System.Drawing.Size(179, 55);
            this.btnAddABook.TabIndex = 0;
            this.btnAddABook.Text = "Add a Book";
            this.btnAddABook.UseVisualStyleBackColor = true;
            this.btnAddABook.Click += new System.EventHandler(this.btnAddABook_Click);
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBooks.Location = new System.Drawing.Point(447, 184);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(179, 55);
            this.btnSearchBooks.TabIndex = 1;
            this.btnSearchBooks.Text = "Search Books";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchBooks);
            this.Controls.Add(this.btnAddABook);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddABook;
        private System.Windows.Forms.Button btnSearchBooks;
    }
}