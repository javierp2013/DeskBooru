using DeskBooruApp;
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

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void InfoSaveButton_Click(object sender, EventArgs e)
        {

        }

        public void UpdatePictureBox(System.Drawing.Image picture)
        {
            if (this.InfoPictureBox.Image != null)
            {
                this.InfoPictureBox.Image.Dispose();
            }
            this.InfoPictureBox.Image = picture;
        }

        private void InfoTagTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // //Attempting to print tags into textbox
           // string tagList = "";
           // Database db = new Database();
           // string query = "SELECT * FROM tags";
           // SQLiteCommand myCommand = new SQLiteCommand(query, db.myConnection);
           // db.OpenConnection();
           // SQLiteDataReader DR1 = myCommand.ExecuteReader();
           // while (DR1.Read())
           // {
           //     tagList += DR1.GetString(1);
           //     tagList += "\n";
           // }
           // InfoTagTextBox.Text = tagList;
           // db.CloseConnection();
           // db.dispose();
        }
    }
}
