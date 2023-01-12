using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fall20B5_Q2
{
    public partial class Form1 : Form
    {
        ProductDAO dao = new ProductDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.GetAllProduct();
            dataGridView1.Columns["Discontinued"].Visible = false;
            DataGridViewTextBoxColumn boxColumn = new DataGridViewTextBoxColumn();
            boxColumn.HeaderText = "Discontinued";
            boxColumn.DataPropertyName = "Discontinued";
            boxColumn.ValueType = typeof(bool);
            dataGridView1.Columns.Add(boxColumn);            
            string[] items = new string[] { "ProductID", "ProductName", "CompanyName", "CategoryName", "QuantityPerUnit", "UnitPrice", "UnitInStock", "UnitOnOrder", "ReOrderLevel", "Discontinued" };
            checkedListBox1.Items.AddRange(items);
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach(DataGridViewColumn c in dataGridView1.Columns)
            {
                c.Visible = false;
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    dataGridView1.Columns[i].Visible = true;
                }
            }
        }
    }
}
