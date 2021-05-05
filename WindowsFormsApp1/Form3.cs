using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeskBooruApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gal_Create_Click(object sender, EventArgs e)
        {
            string gal_name = Gal_Name_Input.Text;
            string gal_desc = " ";
            Database db = new Database();
            db.create_Gallery(gal_name, gal_desc);
            db.CloseConnection();
            db.dispose();
            this.Close();
        }
    }
}
