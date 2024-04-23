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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.tbSearchId.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            //
            string fileName, p, read;
            fileName = "C:\\Users\\HP\\Downloads\\phone\\";

            //first name
            p = fileName + this.tbSearchId.Text + "_firstName.txt";
            if (System.IO.File.Exists(p))
            {
                read = System.IO.File.ReadAllText(p, Encoding.UTF8);
                tbFirstName.Text = read;
            }
            //last name
            p = fileName + this.tbSearchId.Text + "_lastName.txt";
            if (System.IO.File.Exists(p))
            {
                read = System.IO.File.ReadAllText(p, Encoding.UTF8);
                tbLastName.Text = read;
            }
            //telephone
            p = fileName + this.tbSearchId.Text + "_telephone.txt";
            if (System.IO.File.Exists(p))
            {
                read = System.IO.File.ReadAllText(p, Encoding.UTF8);
                tbTelephone.Text = read;
            }
            //cell number
            p = fileName + this.tbSearchId.Text + "_cellNumber.txt";
            if (System.IO.File.Exists(p))
            {
                read = System.IO.File.ReadAllText(p, Encoding.UTF8);
                tbCellNumber.Text = read;
            }
            //email
            p = fileName + this.tbSearchId.Text + "_Email.txt";
            if (System.IO.File.Exists(p))
            {
                read = System.IO.File.ReadAllText(p, Encoding.UTF8);
                tbEmail.Text = read;
            }
            //address
            p = fileName + this.tbSearchId.Text + "_Address.txt";
            if (System.IO.File.Exists(p))
            {
                read = System.IO.File.ReadAllText(p, Encoding.UTF8);
                tbAddress.Text = read;
            }
            //comment
            p = fileName + this.tbSearchId.Text + "_Comment.txt";
            if (System.IO.File.Exists(p))
            {
                read = System.IO.File.ReadAllText(p, Encoding.UTF8);
                tbComment.Text = read;
            }
            //
            this.tbSearchId.Text =this.tbId.Text;   




        }
    }
}
