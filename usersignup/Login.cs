using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NPOI.HPSF;

namespace usersignup
{
    public partial class Login : Form
    {
        Thread th;
        Thread th2;
        Thread th3;
        public Login()
        {
            InitializeComponent();
        }
        
        public void openmdi(object obj)
        {
            Application.Run(new Form1());
        }
        public void openmdi2(object obj)
        {
            Application.Run(new home());
        }

        public void openmdi3(object obj)
        {
            Application.Run(new homeuser());
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
    
        private void BtnLogin_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True");
            SqlCommand CheckifExist = new SqlCommand();
            CheckifExist.CommandText = "Select * from [dbo].[register] where username = '" + txtusername.Text + "' and password='" + Encrypt(textpassword.Text) + "'";
            CheckifExist.Parameters.AddWithValue("@username", txtusername.Text);
            CheckifExist.Parameters.AddWithValue("@password", Encrypt(textpassword.Text));

            CheckifExist.Connection = con;
            con.Open();
            SqlDataReader dt = CheckifExist.ExecuteReader();
            if (txtusername.Text == "" && textpassword.Text == "")
            {
                MessageBox.Show("Please provide username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!dt.HasRows)
            {
                MessageBox.Show("Username or Password incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            else if (dt.HasRows)
            {
                if (txtusername.Text == "Admin")
                {
                    MessageBox.Show("Success! Welcome: " + txtusername.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    th2 = new Thread(openmdi2);
                    th2.SetApartmentState(ApartmentState.STA);
                    th2.Start();

                }

                else
                {
                    MessageBox.Show("Success! Welcome user: " + txtusername.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    th3 = new Thread(openmdi3);
                    th3.SetApartmentState(ApartmentState.STA);
                    th3.Start();
                }

            }
        }

        private void btnsignup_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openmdi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement, but the decryption key should be same as encryption key    
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        private void btnfpass_Click(object sender, EventArgs e)
        {
            if (textpassword.Text == "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS01;Initial Catalog=userregcs;Integrated Security=True");
                SqlCommand CheckifExist = new SqlCommand("select password from register where username = '" + txtusername.Text + "'");
                CheckifExist.Connection = con;
                CheckifExist.Parameters.AddWithValue("@username", txtusername.Text);
            
                con.Open();
                SqlDataReader dt = CheckifExist.ExecuteReader();

                if (dt.Read())
                {
                    txtreveal.Text = Decrypt(dt.GetValue(0).ToString());
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please provide a username", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshow.Checked == true)
            {
                textpassword.UseSystemPasswordChar = false;
            }
            else
                textpassword.UseSystemPasswordChar = true;
        }
    }
}