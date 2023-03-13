using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usersignup
{
    public partial class homeuser : Form
    {
        Thread exthome_user;
        Thread logout;
        Thread Return;
        public homeuser()
        {
            InitializeComponent();
        }


        public void ext_home_user(object obj)
        {
            Application.Run(new borrow());
        }


        public void ext_logout(object obj)
        {
            Application.Run(new Login());
        }

        public void GoToReturn(object obj)
        {
            Application.Run(new Return());
        }
        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            exthome_user = new Thread(ext_home_user);
            exthome_user.SetApartmentState(ApartmentState.STA);
            exthome_user.Start();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            logout = new Thread(ext_logout);
            logout.SetApartmentState(ApartmentState.STA);
            logout.Start();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Return = new Thread(GoToReturn);
            Return.SetApartmentState(ApartmentState.STA);
            Return.Start();

        }
    }
}
