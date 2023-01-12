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
    public partial class Form1 : Form
    {
        CorpDAO dao = new CorpDAO();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewCheckBoxColumn boxColumn = new DataGridViewCheckBoxColumn();
            boxColumn.ValueType = typeof(bool);
            boxColumn.Name = "select";
            boxColumn.HeaderText = "Select";
            dataGridView1.Columns.Add(boxColumn);
            dataGridView1.Columns.Add("corpno", "Corporation No");
            dataGridView1.Columns["corpno"].DataPropertyName = "corp_no";
            dataGridView1.Columns.Add("corpname", "Corporation Name");
            dataGridView1.Columns["corpname"].DataPropertyName = "corp_name";
            dataGridView1.Columns.Add("street", "Street");
            dataGridView1.Columns["street"].DataPropertyName = "street";
            dataGridView1.Columns.Add("region", "Region Name");
            dataGridView1.Columns["region"].DataPropertyName = "Region";
            dataGridView1.Columns.Add("date", "Expire");
            dataGridView1.Columns["date"].DataPropertyName = "expr_dt";
            dataGridView1.Columns["date"].Visible = false;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "edit";
            buttonColumn.HeaderText = "Edit";
            buttonColumn.Text = "Edit";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.DataSource = dao.GetAllCorp();
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void LoadForm()
        {
            dataGridView1.DataSource = dao.GetAllCorp();
        }

        private void Reload(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (e.RowIndex < 0)
            {
                return;
            }
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                int CorpNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                string CorpName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string street = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                DateTime expr = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                Form2 form2 = new Form2(CorpNo, CorpName, street, expr);
                form2.FormClosed += Reload;
                form2.ShowDialog();               
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    check++;
                }
            }
            if (check == 0)
            {
                MessageBox.Show("You must select one corporation at least");
            }
            else
            {
                int n = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        dao.DeleteCorp((int)row.Cells[1].Value);
                        n++;
                    }
                }
                MessageBox.Show($"Deleted {n} corporation(s)");
                LoadForm();
            }
        }
    }
}
