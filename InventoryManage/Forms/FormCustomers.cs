using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManage.Forms
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diang\OneDrive\Documents\invertoryMdb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomersTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataCustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
            }
        }
        private void FormCustomers_Load(object sender, EventArgs e)
        {
            LoadTheme();
            populate();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            label1.ForeColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.PrimaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("update CustomersTbl set Profile= '" + FbProfileTb.Text + "',FullName= '"+CustomersNameTb+"',PhoneNumber='"+CustomersPhoneTb+"' where Address='" + CustomersAddressTb.Text + "'", Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close() ;
                populate();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomersTbl values('" + FbProfileTb.Text + "','" + CustomersNameTb.Text + "','" + CustomersPhoneTb.Text + "','" + CustomersAddressTb.Text + "')", Con);
           
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataCustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FbProfileTb.Text = dataCustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomersNameTb.Text = dataCustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomersPhoneTb.Text = dataCustomersGV.SelectedRows[0].Cells[2].Value.ToString();
            CustomersAddressTb.Text = dataCustomersGV.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
