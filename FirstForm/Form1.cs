using FirstForm.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1 : Form
    {
        Department d = new Department();
        AccountDAO dao = new AccountDAO();
        private List<Account> list = new List<Account>();
        public Form1()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            d.accounts = dao.GetAllAccount();
            list.AddRange(d.accounts);
            listBox1.DataSource = d.accounts;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void account_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void employee_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void customer_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private bool button1Clicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (account.Checked)
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                Account a = new Account(username, password);
                d.AddAccount(a);
                listBox1.DataSource = null;
                listBox1.DataSource = d.accounts;
            }
            if (employee.Checked)
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                string role = comboBox1.Text;
                decimal salary = numericUpDown1.Value;
                Employee em = new Employee(username, password, role, salary);
                d.AddAccount(em);
                listBox1.DataSource = null;
                listBox1.DataSource = d.accounts;
            }
            if (customer.Checked)
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                string name = textBox3.Text;
                DateTime dob = dateTimePicker1.Value;
                Customer c = new Customer(username, password, name, dob);
                d.AddAccount(c);
                listBox1.DataSource = null;
                listBox1.DataSource = d.accounts;
            }
            button1Clicked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File|*.txt";
            save.InitialDirectory = @"D:\";
            if (save.ShowDialog() == DialogResult.OK)
            {
                d.WriteFromFile(save.FileName);
                MessageBox.Show("Save data successful");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1Clicked)
            {
                if (d.accounts.Count == 0)
                {
                    MessageBox.Show("Nothing to insert");
                }
                else
                {
                    foreach (Account a in d.accounts)
                    {
                        if (!list.Contains(a))
                        {
                            if (a.GetType() == typeof(Account))
                            {
                                string[] arr = a.ToString().Split('|');
                                Account acc = new Account(arr[1], arr[2]);
                                dao.AddAccToDatabase(acc);
                            }
                            if (a.GetType() == typeof(Employee))
                            {
                                string[] arr = a.ToString().Split('|');
                                Employee em = new Employee(arr[1], arr[2], arr[3], Convert.ToDecimal(arr[4]));
                                dao.AddEmplToDatabase(em);
                            }
                            if (a.GetType() == typeof(Customer))
                            {
                                string[] arr = a.ToString().Split('|');
                                Customer c = new Customer(arr[1], arr[2], arr[3], Convert.ToDateTime(arr[4]));
                                dao.AddCusToDatabase(c);
                            }
                            list.Add(a);
                        }                        
                    }
                    MessageBox.Show("Insert successful");
                }
            }
            else
            {
                MessageBox.Show("Add something to insert first");
            }            
        }
    }
}
