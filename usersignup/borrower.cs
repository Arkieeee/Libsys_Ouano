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
    public partial class borrower : Form
    {
        Thread Home, Report;
        public borrower()
        {
            InitializeComponent();
        }
        public void backtoHome(object obj)
        {
            Application.Run(new homeuser());
        }
        public void GoToReport(object obj)
        {
            Application.Run(new Report());
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Report = new Thread(GoToReport);
            Report.SetApartmentState(ApartmentState.STA);
            Report.Start();
        }
        private void loadDatagrid()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
            {
                con.Open();
                SqlCommand com = new SqlCommand(" Select borrower_info.firstname, borrower_info.lastname, borrower_info.username, books_borrowed.Accession_number, books_borrowed.Title," +
                    "books_borrowed.Author, borrower_info.date from books_borrowed" +
                    " INNER JOIN borrower_info on books_borrowed.username = borrower_info.username", con);

                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                datagrid_borrower.DataSource = tab;

                con.Close();
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select borrower_info.firstname, borrower_info.lastname, borrower_info.username, books_borrowed.Accession_number, books_borrowed.Title," +
                    "books_borrowed.Author, borrower_info.date from books_borrowed INNER JOIN borrower_info on books_borrowed.username = borrower_info.username where Accession_number like'%" + txtSearch.Text + "%'", con);

                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                datagrid_borrower.DataSource = tab;

                con.Close();
            }
        }

        private void borrower_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Home = new Thread(backtoHome);
            Home.SetApartmentState(ApartmentState.STA);
            Home.Start();
        }
    }
}
