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

namespace usersignup
{
    public partial class Return : Form
    {
        Thread backhome;
        public Return()
        {
            InitializeComponent();
        }
        public void backtoHome(object obj)
        {
            Application.Run(new homeuser());
        }
        private void loadDatagrid()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT borrower_info.firstname, borrower_info.lastname, borrower_info.username, books_borrowed.Accession_number, books_borrowed.Title, books_borrowed.Author, books_borrowed.Year_Published, borrower_info.date as 'Date Borrowed' FROM books_borrowed INNER JOIN borrower_info ON books_borrowed.username = borrower_info.username;", con);

                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                dataGridView1.DataSource = tab;

                con.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtusername.Text = row.Cells["username"].Value.ToString();
                txtfirstname.Text = row.Cells["firstname"].Value.ToString();
                txtlastname.Text = row.Cells["lastname"].Value.ToString();
                txtdate.Text = row.Cells["Date Borrowed"].Value.ToString();
                txtaccessionnumber.Text = row.Cells["Accession_number"].Value.ToString();
                txttitle.Text = row.Cells["Title"].Value.ToString();
                txtauthor.Text = row.Cells["Author"].Value.ToString();
                txtyrpublished.Text = row.Cells["Year_Published"].Value.ToString();

            }
        }

        private void borrowed_books_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            
                if (txtusername.Text != "" && txtfirstname.Text != "" && txtlastname.Text != "" && txtaccessionnumber.Text != ""
                && txttitle.Text != "" && txtauthor.Text != "" && txtyrpublished.Text != "" && txtdate.Text != "")
                {
                    // Check if book is available
                    int quantity = 0;
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
                    {
                        con.Open();
                        SqlCommand com = new SqlCommand("SELECT quantity FROM books WHERE Accession_number = '" + txtaccessionnumber.Text + "'", con);
                        SqlDataReader reader = com.ExecuteReader();
                        if (reader.Read())
                        {
                            quantity = int.Parse(reader["quantity"].ToString());
                        }
                        reader.Close();
                    }

                    // Retrun the book
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
                    {
                        con.Open();
                    SqlCommand deleteBorrowedBook = new SqlCommand("DELETE FROM books_borrowed WHERE Accession_number = @accessionNumber AND username = @username", con);
                    deleteBorrowedBook.Parameters.AddWithValue("@accessionNumber", txtaccessionnumber.Text);
                    deleteBorrowedBook.Parameters.AddWithValue("@username", txtusername.Text);
                    deleteBorrowedBook.ExecuteNonQuery();

                    SqlCommand deleteBorrower = new SqlCommand("DELETE FROM borrower_info WHERE username = @username", con);
                    deleteBorrower.Parameters.AddWithValue("@username", txtusername.Text);
                    deleteBorrower.ExecuteNonQuery();

                    SqlCommand updateQuantity = new SqlCommand("UPDATE books SET quantity = quantity + 1 WHERE Accession_number = @accessionNumber", con);
                    updateQuantity.Parameters.AddWithValue("@accessionNumber", txtaccessionnumber.Text);
                    updateQuantity.ExecuteNonQuery();
                    updateQuantity.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Book has been returned successfully.");
                    loadDatagrid();
                }
                else
                {
                    MessageBox.Show("Please fill up all the required information.");
                }
            }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            backhome = new Thread(backtoHome);
            backhome.SetApartmentState(ApartmentState.STA);
            backhome.Start();
        }

    }
    }

