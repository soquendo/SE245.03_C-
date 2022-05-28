
namespace week5_class
{
    partial class Form1
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtAuthorFirst = new System.Windows.Forms.TextBox();
            this.txtAuthorLast = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.sample = new System.Windows.Forms.Button();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.lblDatePub = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dtpDateRentalExpires = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.txtBookmark = new System.Windows.Forms.TextBox();
            this.lblBookmark = new System.Windows.Forms.Label();
            this.lblEBook_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(561, 118);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(406, 35);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(446, 124);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Book Title:";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(408, 689);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(236, 29);
            this.lblFeedback.TabIndex = 12;
            this.lblFeedback.Text = "Feedback goes here";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(561, 579);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(108, 33);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(363, 236);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(189, 25);
            this.lblLname.TabIndex = 15;
            this.lblLname.Text = "Author\'s Last Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(489, 451);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 25);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(362, 184);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(189, 25);
            this.lblFname.TabIndex = 14;
            this.lblFname.Text = "Author\'s First Name:";
            // 
            // txtAuthorFirst
            // 
            this.txtAuthorFirst.Location = new System.Drawing.Point(561, 178);
            this.txtAuthorFirst.Name = "txtAuthorFirst";
            this.txtAuthorFirst.Size = new System.Drawing.Size(281, 35);
            this.txtAuthorFirst.TabIndex = 1;
            // 
            // txtAuthorLast
            // 
            this.txtAuthorLast.Location = new System.Drawing.Point(561, 230);
            this.txtAuthorLast.Name = "txtAuthorLast";
            this.txtAuthorLast.Size = new System.Drawing.Size(281, 35);
            this.txtAuthorLast.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(561, 445);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(115, 35);
            this.txtPrice.TabIndex = 4;
            // 
            // sample
            // 
            this.sample.Location = new System.Drawing.Point(961, 579);
            this.sample.Name = "sample";
            this.sample.Size = new System.Drawing.Size(121, 33);
            this.sample.TabIndex = 11;
            this.sample.Text = "sample data";
            this.sample.UseVisualStyleBackColor = true;
            this.sample.Click += new System.EventHandler(this.sample_Click);
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePublished.Location = new System.Drawing.Point(561, 391);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(151, 35);
            this.dtpDatePublished.TabIndex = 3;
            // 
            // lblDatePub
            // 
            this.lblDatePub.AutoSize = true;
            this.lblDatePub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePub.Location = new System.Drawing.Point(401, 399);
            this.lblDatePub.Name = "lblDatePub";
            this.lblDatePub.Size = new System.Drawing.Size(150, 25);
            this.lblDatePub.TabIndex = 16;
            this.lblDatePub.Text = "Date Published:";
            this.lblDatePub.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(409, 290);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(143, 25);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Author\'s Email:";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(428, 342);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(123, 25);
            this.lblPages.TabIndex = 19;
            this.lblPages.Text = "Total Pages:";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(820, 399);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(121, 25);
            this.lblReturn.TabIndex = 20;
            this.lblReturn.Text = "Return Date:";
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // dtpDateRentalExpires
            // 
            this.dtpDateRentalExpires.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateRentalExpires.Location = new System.Drawing.Point(947, 391);
            this.dtpDateRentalExpires.Name = "dtpDateRentalExpires";
            this.dtpDateRentalExpires.Size = new System.Drawing.Size(151, 35);
            this.dtpDateRentalExpires.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(561, 284);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 35);
            this.txtEmail.TabIndex = 21;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(561, 336);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(110, 35);
            this.txtPages.TabIndex = 22;
            // 
            // txtBookmark
            // 
            this.txtBookmark.Location = new System.Drawing.Point(561, 501);
            this.txtBookmark.Name = "txtBookmark";
            this.txtBookmark.Size = new System.Drawing.Size(115, 35);
            this.txtBookmark.TabIndex = 23;
            // 
            // lblBookmark
            // 
            this.lblBookmark.AutoSize = true;
            this.lblBookmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookmark.Location = new System.Drawing.Point(378, 507);
            this.lblBookmark.Name = "lblBookmark";
            this.lblBookmark.Size = new System.Drawing.Size(173, 25);
            this.lblBookmark.TabIndex = 24;
            this.lblBookmark.Text = "Bookmark Page #:";
            // 
            // lblEBook_ID
            // 
            this.lblEBook_ID.AutoSize = true;
            this.lblEBook_ID.Location = new System.Drawing.Point(32, 35);
            this.lblEBook_ID.Name = "lblEBook_ID";
            this.lblEBook_ID.Size = new System.Drawing.Size(120, 29);
            this.lblEBook_ID.TabIndex = 25;
            this.lblEBook_ID.Text = "EBook ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 898);
            this.Controls.Add(this.lblEBook_ID);
            this.Controls.Add(this.lblBookmark);
            this.Controls.Add(this.txtBookmark);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDatePub);
            this.Controls.Add(this.dtpDateRentalExpires);
            this.Controls.Add(this.dtpDatePublished);
            this.Controls.Add(this.sample);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthorLast);
            this.Controls.Add(this.txtAuthorFirst);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtAuthorFirst;
        private System.Windows.Forms.TextBox txtAuthorLast;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button sample;
        private System.Windows.Forms.DateTimePicker dtpDatePublished;
        private System.Windows.Forms.Label lblDatePub;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DateTimePicker dtpDateRentalExpires;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.TextBox txtBookmark;
        private System.Windows.Forms.Label lblBookmark;
        private System.Windows.Forms.Label lblEBook_ID;
    }
}

