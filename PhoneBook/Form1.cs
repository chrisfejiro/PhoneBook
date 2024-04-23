using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class ContactDetails : Form
    {
        public ContactDetails()
        {
            InitializeComponent();
        }

        private void tsbRegisterData_Click(object sender, EventArgs e)
        {
            var regData = new Registration();
            regData.MdiParent = this;
            regData.Show();
            
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm();
            search.MdiParent = this;
            search.Show();

        }
        private void tbsAboutUs_Click(object sender, EventArgs e)
        {
            var aboutUs = new AboutUs();
            aboutUs.MdiParent = this;
            aboutUs.Show();

        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbCalculator_Click(object sender, EventArgs e)
        {
            this.calcProcess.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.calcProcess.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                tsbRegisterData_Click(sender, e);
            };
            //
            if (e.KeyCode == Keys.F3)
            {
                tsbSearch_Click(sender, e);
            };
            //
            if (e.KeyCode == Keys.F4)
            {
                tsbCalculator_Click(sender, e);
            };
            //
            if (e.KeyCode == Keys.F5)
            {
                tbsAboutUs_Click(sender, e);
             };
            //
            if (e.KeyCode == Keys.Escape)
            {           
                tsbExit_Click(sender, e);
            };
           
           
        }

       
    }
}
