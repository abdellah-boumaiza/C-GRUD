namespace books
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
            this.books = new System.Windows.Forms.ComboBox();
            this.bookName = new System.Windows.Forms.TextBox();
            this.bookEdition = new System.Windows.Forms.TextBox();
            this.AuthorFirstName = new System.Windows.Forms.TextBox();
            this.AuthorLastName = new System.Windows.Forms.TextBox();
            this.bookNameTitle = new System.Windows.Forms.Label();
            this.bookEditionTitle = new System.Windows.Forms.Label();
            this.authorFNameTitle = new System.Windows.Forms.Label();
            this.authorLNameTitle = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.abortBtn = new System.Windows.Forms.Button();
            this.bookNameError = new System.Windows.Forms.Label();
            this.bookEditionError = new System.Windows.Forms.Label();
            this.authorFNameError = new System.Windows.Forms.Label();
            this.authorLNameError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // books
            // 
            this.books.DropDownHeight = 206;
            this.books.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.books.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books.FormattingEnabled = true;
            this.books.IntegralHeight = false;
            this.books.Location = new System.Drawing.Point(181, 31);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(389, 22);
            this.books.TabIndex = 0;
            this.books.SelectionChangeCommitted += new System.EventHandler(this.books_SelectionChangeCommitted);
            // 
            // bookName
            // 
            this.bookName.Enabled = false;
            this.bookName.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(209, 146);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(188, 22);
            this.bookName.TabIndex = 1;
            // 
            // bookEdition
            // 
            this.bookEdition.Enabled = false;
            this.bookEdition.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookEdition.Location = new System.Drawing.Point(209, 196);
            this.bookEdition.MaxLength = 4;
            this.bookEdition.Name = "bookEdition";
            this.bookEdition.Size = new System.Drawing.Size(188, 22);
            this.bookEdition.TabIndex = 2;
            this.bookEdition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bookEdition_KeyPress);
            // 
            // AuthorFirstName
            // 
            this.AuthorFirstName.Enabled = false;
            this.AuthorFirstName.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorFirstName.Location = new System.Drawing.Point(209, 238);
            this.AuthorFirstName.Name = "AuthorFirstName";
            this.AuthorFirstName.Size = new System.Drawing.Size(188, 22);
            this.AuthorFirstName.TabIndex = 3;
            // 
            // AuthorLastName
            // 
            this.AuthorLastName.Enabled = false;
            this.AuthorLastName.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLastName.Location = new System.Drawing.Point(209, 282);
            this.AuthorLastName.Name = "AuthorLastName";
            this.AuthorLastName.Size = new System.Drawing.Size(188, 22);
            this.AuthorLastName.TabIndex = 4;
            // 
            // bookNameTitle
            // 
            this.bookNameTitle.AutoSize = true;
            this.bookNameTitle.Enabled = false;
            this.bookNameTitle.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameTitle.Location = new System.Drawing.Point(44, 149);
            this.bookNameTitle.Name = "bookNameTitle";
            this.bookNameTitle.Size = new System.Drawing.Size(127, 14);
            this.bookNameTitle.TabIndex = 5;
            this.bookNameTitle.Text = "The Name Of The Book";
            // 
            // bookEditionTitle
            // 
            this.bookEditionTitle.AutoSize = true;
            this.bookEditionTitle.Enabled = false;
            this.bookEditionTitle.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookEditionTitle.Location = new System.Drawing.Point(44, 199);
            this.bookEditionTitle.Name = "bookEditionTitle";
            this.bookEditionTitle.Size = new System.Drawing.Size(105, 14);
            this.bookEditionTitle.TabIndex = 6;
            this.bookEditionTitle.Text = "The Book\'s Edition";
            // 
            // authorFNameTitle
            // 
            this.authorFNameTitle.AutoSize = true;
            this.authorFNameTitle.Enabled = false;
            this.authorFNameTitle.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorFNameTitle.Location = new System.Drawing.Point(44, 241);
            this.authorFNameTitle.Name = "authorFNameTitle";
            this.authorFNameTitle.Size = new System.Drawing.Size(114, 14);
            this.authorFNameTitle.TabIndex = 7;
            this.authorFNameTitle.Text = "Author\'s First Name";
            // 
            // authorLNameTitle
            // 
            this.authorLNameTitle.AutoSize = true;
            this.authorLNameTitle.Enabled = false;
            this.authorLNameTitle.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLNameTitle.Location = new System.Drawing.Point(44, 285);
            this.authorLNameTitle.Name = "authorLNameTitle";
            this.authorLNameTitle.Size = new System.Drawing.Size(112, 14);
            this.authorLNameTitle.TabIndex = 8;
            this.authorLNameTitle.Text = "Author\'s Last Name";
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(65, 370);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(80, 29);
            this.newBtn.TabIndex = 9;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(165, 370);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 29);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(265, 370);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(80, 29);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(365, 370);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(80, 29);
            this.editBtn.TabIndex = 12;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // abortBtn
            // 
            this.abortBtn.Enabled = false;
            this.abortBtn.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortBtn.Location = new System.Drawing.Point(465, 370);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(80, 29);
            this.abortBtn.TabIndex = 13;
            this.abortBtn.Text = "Abort";
            this.abortBtn.UseVisualStyleBackColor = true;
            this.abortBtn.Click += new System.EventHandler(this.abortBtn_Click);
            // 
            // bookNameError
            // 
            this.bookNameError.AutoSize = true;
            this.bookNameError.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameError.ForeColor = System.Drawing.Color.Red;
            this.bookNameError.Location = new System.Drawing.Point(462, 149);
            this.bookNameError.Name = "bookNameError";
            this.bookNameError.Size = new System.Drawing.Size(152, 14);
            this.bookNameError.TabIndex = 14;
            this.bookNameError.Text = "Enter the name of the book";
            this.bookNameError.Visible = false;
            // 
            // bookEditionError
            // 
            this.bookEditionError.AutoSize = true;
            this.bookEditionError.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookEditionError.ForeColor = System.Drawing.Color.Red;
            this.bookEditionError.Location = new System.Drawing.Point(462, 199);
            this.bookEditionError.Name = "bookEditionError";
            this.bookEditionError.Size = new System.Drawing.Size(133, 14);
            this.bookEditionError.TabIndex = 15;
            this.bookEditionError.Text = "Enter the book\'s edition";
            this.bookEditionError.Visible = false;
            // 
            // authorFNameError
            // 
            this.authorFNameError.AutoSize = true;
            this.authorFNameError.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorFNameError.ForeColor = System.Drawing.Color.Red;
            this.authorFNameError.Location = new System.Drawing.Point(462, 241);
            this.authorFNameError.Name = "authorFNameError";
            this.authorFNameError.Size = new System.Drawing.Size(137, 14);
            this.authorFNameError.TabIndex = 16;
            this.authorFNameError.Text = "Enter the Author\'s name";
            this.authorFNameError.Visible = false;
            // 
            // authorLNameError
            // 
            this.authorLNameError.AutoSize = true;
            this.authorLNameError.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLNameError.ForeColor = System.Drawing.Color.Red;
            this.authorLNameError.Location = new System.Drawing.Point(462, 285);
            this.authorLNameError.Name = "authorLNameError";
            this.authorLNameError.Size = new System.Drawing.Size(159, 14);
            this.authorLNameError.TabIndex = 17;
            this.authorLNameError.Text = "Enter the Author\'s last name";
            this.authorLNameError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "available books";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorLNameError);
            this.Controls.Add(this.authorFNameError);
            this.Controls.Add(this.bookEditionError);
            this.Controls.Add(this.bookNameError);
            this.Controls.Add(this.abortBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.authorLNameTitle);
            this.Controls.Add(this.authorFNameTitle);
            this.Controls.Add(this.bookEditionTitle);
            this.Controls.Add(this.bookNameTitle);
            this.Controls.Add(this.AuthorLastName);
            this.Controls.Add(this.AuthorFirstName);
            this.Controls.Add(this.bookEdition);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.books);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox books;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox bookEdition;
        private System.Windows.Forms.TextBox AuthorFirstName;
        private System.Windows.Forms.TextBox AuthorLastName;
        private System.Windows.Forms.Label bookNameTitle;
        private System.Windows.Forms.Label bookEditionTitle;
        private System.Windows.Forms.Label authorFNameTitle;
        private System.Windows.Forms.Label authorLNameTitle;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button abortBtn;
        private System.Windows.Forms.Label bookNameError;
        private System.Windows.Forms.Label bookEditionError;
        private System.Windows.Forms.Label authorFNameError;
        private System.Windows.Forms.Label authorLNameError;
        private System.Windows.Forms.Label label1;
    }
}

