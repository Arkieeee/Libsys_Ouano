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
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using NPOI.HSSF.Util;


namespace usersignup
{
    public partial class books : Form
    {

        Thread thhome;
        public books()
        {

            InitializeComponent();

        }
        public void backtohome(object obj)
        {
            Application.Run(new home());
        }


        private void books_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select * from books order by Title asc", con);

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
                SqlCommand com = new SqlCommand("Select * from books where Title like'%" + txtSearch.Text + "%'", con);

                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);
                grid1.DataSource = tab;

                con.Close();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            int acs_num = Convert.ToInt32(txtno.Text);
            string title = txttitle.Text;
            string author = txtauthor.Text;
            int quantity = Convert.ToInt32(txtquantity.Text);
            string year_published = txtyrpublished.Text;

            //connect to the database and insert a new book record
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True"))
            {
                con.Open();
                string query = "INSERT INTO books (Accession_number, Title, Author, quantity, Year_Published) VALUES (@Accession_number, @Title, @Author, @quantity, @Year_Published)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Accession_number", acs_num);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@Year_Published", year_published);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Added!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadDatagrid();
            }
        }
   

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtno.Text = grid1.Rows[e.RowIndex].Cells["Accession_number"].Value.ToString();
            txttitle.Text = grid1.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            txtauthor.Text = grid1.Rows[e.RowIndex].Cells["Author"].Value.ToString();
            txtquantity.Text = grid1.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            txtyrpublished.Text = grid1.Rows[e.RowIndex].Cells["Year_Published"].Value.ToString();


        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True");
            con.Open();
            int no;
            no = int.Parse(txtno.Text);

            SqlCommand com = new SqlCommand("Update books SET Title= '" + txttitle.Text + "', Author='" + txtauthor.Text + "', quantity= '"+txtquantity.Text+"', Year_Published='" + txtyrpublished.Text + "'  where accession_number= '" + no + "'", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully UPDATED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            loadDatagrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True");
            con.Open();
            string num = txtno.Text;

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("Delete from books where accession_number= '" + num + "'", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfully DELETED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CANCELLED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            loadDatagrid();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thhome = new Thread(backtohome);
            thhome.SetApartmentState(ApartmentState.STA);
            thhome.Start();
        }
    }
    }

