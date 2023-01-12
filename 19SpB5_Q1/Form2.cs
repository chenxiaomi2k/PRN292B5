using _19SpB5_Q1.DAL;
using _19SpB5_Q1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _19SpB5_Q1
{
    public partial class Form2 : Form
    {
        CorpDAO dao = new CorpDAO();       
        public int CorpNo { get; set; }
        public string CorpName { get; set; }
        public string Street { get; set; }
        public DateTime ExpDate { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int corpNo, string corpName, string street, DateTime expDate)
        {
            CorpNo = corpNo;
            CorpName = corpName;
            Street = street;
            ExpDate = expDate;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = CorpName;
            textBox2.Text = Street;
            dateTimePicker1.Value = ExpDate;            
        }

        private void editCorp_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals(""))
            {
                string name = textBox1.Text;
                string street = textBox2.Text;
                DateTime date = dateTimePicker1.Value;
                Corporation c = new Corporation(name, street, date);
                dao.UpdateCorp(c, CorpNo);
                MessageBox.Show("Update sucessful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Corporation name is not valid");
            }            
        }
    }
}
