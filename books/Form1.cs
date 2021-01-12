using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace books
{
    public partial class Form1 : Form
    {
        
        static string chaine = @"Data Source = localhost; Initial Catalog = Csharp; Integrated Security = True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        bool save = false;
        // enabling btns
        void enableNewBtn()
        {
            newBtn.Enabled = true;
        }
        void enableSaveBtn()
        {
            saveBtn.Enabled = true;
        }
        void enableDeleteBtn()
        {
            deleteBtn.Enabled = true;
        }
        void enableEditBtn()
        {
            editBtn.Enabled = true;
        }
        void enableAbortBtn()
        {
            abortBtn.Enabled = true;
        }

        // disabling btns
        void disableNewBtn()
        {
            newBtn.Enabled = false;
        }
        void disableSaveBtn()
        {
            saveBtn.Enabled = false;
        }
        void disableDeleteBtn()
        {
            deleteBtn.Enabled = false;
        }
        void disableEditBtn()
        {
            editBtn.Enabled = false;
        }
        void disableAbortBtn()
        {
            abortBtn.Enabled = false;
        }

        // enabling fields

        void enableFields()
        {
            bookName.Enabled = true;
            bookEdition.Enabled = true;
            AuthorFirstName.Enabled = true;
            AuthorLastName.Enabled = true;

            bookNameTitle.Enabled = true;
            bookEditionTitle.Enabled = true;
            authorFNameTitle.Enabled = true;
            authorLNameTitle.Enabled = true;


        }
        // disabling fields

        void disableFields()
        {
            bookName.Enabled = false;
            bookEdition.Enabled = false;
            AuthorFirstName.Enabled = false;
            AuthorLastName.Enabled = false;

            bookNameTitle.Enabled = false;
            bookEditionTitle.Enabled = false;
            authorFNameTitle.Enabled = false;
            authorLNameTitle.Enabled = false;


        }
        // emotying fields
        void emptyingFields()
        {
            bookName.Text = "";
            bookEdition.Text = "";
            AuthorFirstName.Text = "";
            AuthorLastName.Text = "";

        }


        public Form1()
        {
            InitializeComponent();
        }

        public bool checkErrors()
        {
            if (bookName.Text == "")
                bookNameError.Visible = true;
            else
                bookNameError.Visible = false;

            if (bookEdition.Text == "")
                bookEditionError.Visible = true;
            else
                bookNameError.Visible = false;

            if (AuthorFirstName.Text == "")
                authorFNameError.Visible = true;
            else
                bookNameError.Visible = false;

            if (AuthorLastName.Text == "")
                authorLNameError.Visible = true;
            else
                bookNameError.Visible = false;

            if (bookName.Text != "" && bookEdition.Text != "" && AuthorFirstName.Text != "" && AuthorLastName.Text != "")
                return true;
            return false;
        }

        public bool checkFieldsIfEmpty()
        {
            return (bookName.Text == "" && bookEdition.Text == "" && AuthorFirstName.Text == "" && AuthorLastName.Text == "");
        }

        void disableErrorMsgs()
        {
                bookNameError.Visible = false;

                bookEditionError.Visible = false;

                authorFNameError.Visible = false;

                authorLNameError.Visible = false;
        }

        // load the data from the sql server database
        void getdata()
        {
            cnx.Open();
            cmd.CommandText = "SELECT * FROM bookDataBase";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            books.DataSource = dt;
            books.DisplayMember = "bookName";
            cnx.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (checkErrors())
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "INSERT INTO bookDataBase VALUES('" + bookName.Text + "','" + bookEdition.Text + "','" + AuthorFirstName.Text + "','" + AuthorLastName.Text + "')";
                int n=cmd.ExecuteNonQuery();
                cnx.Close();
                getdata();
                emptyingFields();
                disableFields();
                disableSaveBtn();
                MessageBox.Show("new book added");
                save = true;
            }
            else
                save = false;

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            disableNewBtn();
            disableDeleteBtn();
            disableEditBtn();
            enableSaveBtn();
            enableAbortBtn();
            enableFields();

            emptyingFields();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure you want to delete this book ?", "Abdellah Boumaia's books", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from bookDataBase where bookName='" + books.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                enableAbortBtn();
                enableSaveBtn();
                disableSaveBtn();
                getdata();
                MessageBox.Show("book deleted");
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (checkErrors())
            {
                disableErrorMsgs();
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "update bookDataBase set bookName='" + bookName.Text + "',bookEdition='" + bookEdition.Text + "', authorFirstName='" + AuthorFirstName + "',authorLastName='" + AuthorLastName + "'" +
                    "where bookName='" + books.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                getdata();
            }

        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            emptyingFields();
            disableFields();
            enableNewBtn();
            disableSaveBtn();
            disableErrorMsgs();
            disableAbortBtn();
        }

        private void books_SelectionChangeCommitted(object sender, EventArgs e)
        {
            enableDeleteBtn();
            enableEditBtn();
            disableAbortBtn();
            disableSaveBtn();
            enableNewBtn();
            enableFields();
        }

        // making book edition textbox allows only numbers
        private void bookEdition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        // add two verification dialog , the first one for check if the fields is not empty and we didn't save the book's info yet,
        // the second verification is for closing the form 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (save == false && !checkFieldsIfEmpty())
            {
                DialogResult dialogResult = MessageBox.Show("would you like to save the book information", "Abdellah Boumaia's books", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cnx.Open();
                    cmd.Connection = cnx;
                    cmd.CommandText = "INSERT INTO bookDataBase VALUES('" + bookName.Text + "','" + bookEdition.Text + "','" + AuthorFirstName.Text + "','" + AuthorLastName.Text + "')";
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    getdata();
                    emptyingFields();
                    disableFields();
                    disableSaveBtn();
                    save = true;
                }
            }
            DialogResult dialogResult2 = MessageBox.Show("Are you sure you want to quit ?", "Abdellah Boumaia's books", MessageBoxButtons.YesNo);
            if (dialogResult2 == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
