using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Reflection.Metadata.Ecma335;
using NPOI.SS.Formula.Functions;
using NPOI.SS.Formula.Eval;
using MathNet.Numerics;
using NPOI.POIFS.Crypt.Dsig;
using System.Security.Cryptography;
using System.Threading;
using NPOI.HPSF;

namespace usersignup
{
    
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();

        }

        public void openmdi(object obj)
        {
            Application.Run(new Login());
        }
        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement    
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {

            var input = txtpass.Text;

            if (input == "")
            {
                MessageBox.Show("Password required!");
                return;
            }

            var hasnumber = new Regex(@"[0-9]+");
            var hasUpper = new Regex(@"[A-Z]+");
            var hasLower = new Regex(@"[a-z]+");
            var hasChar = new Regex(@"[!@#$%^&*()_,?/|+=]+");


            if (!hasnumber.IsMatch(input))
            {
                MessageBox.Show("Password must contain numeric!");
            }
            else if (!hasUpper.IsMatch(input))
            {
                MessageBox.Show("Password must contain one upper case");
            }
            else if (!hasLower.IsMatch(input))
            {
                MessageBox.Show("Password must contain one lower case");
            }
            else if (!hasChar.IsMatch(input))
            {
                MessageBox.Show("Password must contain one special character");
            }
            else if (txtpass.Text.Length <= 7)
            {
                MessageBox.Show("Password must be 8 character or more long!");
            }
            else if (txtconfirmpass.Text != txtpass.Text)
            {
                MessageBox.Show("Password unmatched!");

            }
            else if (txtconfirmpass.Text == txtpass.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True");
                SqlCommand CheckifExist = new SqlCommand();
                CheckifExist.CommandText = "Select * from [dbo].[register] where username = '" + txtuser.Text + "'";
                CheckifExist.Parameters.AddWithValue("@username", txtuser.Text);
                CheckifExist.Connection = con;
                con.Open();
                SqlDataReader dt = CheckifExist.ExecuteReader();
                if (dt.HasRows)
                {
                    MessageBox.Show("Userame already existed!");

                }
                else if (txtuser.Text != "" && txtpass.Text != "" && txtconfirmpass.Text != "")  //validating the fields whether the fields or empty or not  
                {
                    if (txtpass.Text.ToString().Trim().ToLower() == txtconfirmpass.Text.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                    {

                        string Password = Encrypt(txtpass.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                        con.Close();
                        con.Open();

                        SqlCommand insert = new SqlCommand("insert into register(firstname,lastname,username,password)values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtuser.Text + "','" + Password + "')", con);
                        insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if any fields is empty  
                }

            }
        }


        private void btncancel_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(openmdi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            
        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshow.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
                txtpass.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
