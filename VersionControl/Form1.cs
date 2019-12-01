using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersionControl.Entities;

namespace VersionControl
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource1.FullName; // label2
            btnAdd.Text = Resource1.Add; // button1

            // listbox1
            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnIntoFile_Click(object sender, EventArgs e)
        {
            // kellene a SaveFileDialog, de arra sajnos nem emlékszem :(
        }
    }
}
