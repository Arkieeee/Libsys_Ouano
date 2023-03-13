using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NPOI.HPSF;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace usersignup
{
    public partial class borrow : Form
    {
        Thread exthome;
        public borrow()
        {
            InitializeComponent();
        }

        public void ext_home(object obj)
        {
            Application.Run(new homeuser());
        }
        private void borrow_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select book_id, Accession_number, Title, Author, quantity, Year_Published from books where quantity >= 1", con);

                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                grid1.DataSource = tab;

                con.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select * from books where Title like'%" + txtSearch.Text + "%' and quantity >= 1", con);

                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                grid1.DataSource = tab;

                con.Close();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            exthome = new Thread(ext_home);
            exthome.SetApartmentState(ApartmentState.STA);
            exthome.Start();

        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtfirstname.Text != "" && txtlastname.Text != "" && txtdate.Text != "" && txtaccessionnumber.Text != "")
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

                if (quantity <= 0)
                {
                    MessageBox.Show("Book is not available for borrowing.");
                    return;
                }

                // Borrow the book
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand insertBorrower = new SqlCommand("INSERT INTO borrower_info(username,firstname,lastname,date) VALUES('" + txtusername.Text + "','" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtdate.Text + "')", con);
                    insertBorrower.ExecuteNonQuery();
                    String username = txtusername.Text;
                    SqlCommand insertBorrowedBook = new SqlCommand("INSERT INTO books_borrowed(username, Accession_number,Title,Author,Year_Published) VALUES('"+username+"','" + txtaccessionnumber.Text + "','" + txttitle.Text + "','" + txtauthor.Text + "','" + txtyrpublished.Text + "')", con);
                    insertBorrowedBook.ExecuteNonQuery();
                    SqlCommand updateQuantity = new SqlCommand("UPDATE books SET quantity = quantity - 1 WHERE Accession_number = '" + txtaccessionnumber.Text + "'", con);
                    updateQuantity.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Book has been borrowed successfully.");
                loadDatagrid();
            }
            else
            {
                MessageBox.Show("Please fill up all the required information.");
            }
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grid1.Rows[e.RowIndex];

                txtaccessionnumber.Text = row.Cells["Accession_number"].Value.ToString();
                txttitle.Text = row.Cells["Title"].Value.ToString();
                txtauthor.Text = row.Cells["Author"].Value.ToString();
                txtyrpublished.Text = row.Cells["Year_Published"].Value.ToString();
            }
        }
    }
}