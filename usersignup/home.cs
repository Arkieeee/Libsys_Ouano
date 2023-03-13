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

namespace usersignup
{

    public partial class home : Form
    {
        Thread Closehome, borrower, logout, Report;
        public home()
        {
            InitializeComponent();
        }
        public void CloseHome(object obj)
        {
            Application.Run(new books());
        }

        public void GoToBorrower(object obj)
        {
            Application.Run(new borrower());
        }

        public void LogoutAdmin(object obj)
        {
            Application.Run(new Login());
        }

        public void GoToReport(object obj)
        {
            Application.Run(new Report());
        }
        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Closehome = new Thread(CloseHome);
            Closehome.SetApartmentState(ApartmentState.STA);
            Closehome.Start();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Report = new Thread(GoToReport);
            Report.SetApartmentState(ApartmentState.STA);
            Report.Start();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            logout = new Thread(LogoutAdmin);
            logout.SetApartmentState(ApartmentState.STA);
            logout.Start();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            borrower = new Thread(GoToBorrower);
            borrower.SetApartmentState(ApartmentState.STA);
            borrower.Start();

        }
    }
}
