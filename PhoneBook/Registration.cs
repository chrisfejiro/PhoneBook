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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void tsbNewData_Click(object sender, EventArgs e)
        {
            this.tsbNewData.Enabled = false;
            this.tsbSave.Enabled = true;
            this.gbInfoBox.Enabled = true;
            //Clearing Text Box
            this.tbId.ResetText();
            this.tbFirstName.ResetText();
            this.tbLastName.ResetText();
            this.tbTelephone.ResetText();
            this.tbCellNumber.ResetText();
            this.tbEmail.ResetText();
            this.tbAddress.ResetText();
            this.tbComment.ResetText();

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (this.tbId.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            //
            this.tsbSave.Enabled = false;
            this.tsbNewData.Enabled = true;
            this.gbInfoBox.Enabled = false;
            //Storing the details in a text file
            string fileName,p;
            //firstName
            fileName= "C:\\Users\\HP\\Downloads\\phone\\";
            p = fileName + this.tbId.Text + "_firstName.txt";
            System.IO.File.WriteAllText(p,this.tbFirstName.Text,Encoding.UTF8);
            //LastName
            p = fileName + this.tbId.Text + "_lastName.txt";
            System.IO.File.WriteAllText(p, this.tbLastName.Text, Encoding.UTF8);
            //Telephone
            p = fileName + this.tbId.Text + "_telephone.txt";
            System.IO.File.WriteAllText(p, this.tbTelephone.Text, Encoding.UTF8);
            //Cell Number
            p = fileName + this.tbId.Text + "_cellNumber.txt";
            System.IO.File.WriteAllText(p, this.tbCellNumber.Text, Encoding.UTF8);
            //Email
            p = fileName + this.tbId.Text + "_Email.txt";
            System.IO.File.WriteAllText(p, this.tbEmail.Text, Encoding.UTF8);
            //Address
            p = fileName + this.tbId.Text + "_Address.txt";
            System.IO.File.WriteAllText(p, this.tbAddress.Text, Encoding.UTF8);
            //Comment
            p = fileName + this.tbId.Text + "_Comment.txt";
            System.IO.File.WriteAllText(p, this.tbComment.Text, Encoding.UTF8);
            //
            MessageBox.Show("Saved Successfully");
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.gbInfoBox.Enabled = false;

        }
    }
}
