using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace InventoryManage.Forms
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diang\OneDrive\Documents\invertoryMdb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataProductGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
            }
        }

            private void FormProduct_Load(object sender, EventArgs e)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productIdTb.Text != dataProductGV.SelectedRows[0].Cells[0].Value.ToString())
            {
                MessageBox.Show("Product ID allredy exist!");
               
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values(N'" + productIdTb.Text + "',N'" + productNameTb.Text + "',N'" + productColorTb.Text + "',N'" + productPriceTb.Text + "',N'"+productDescriptionTb.Text+"')", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void dataCustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTb.Text = dataProductGV.SelectedRows[0].Cells[0].Value.ToString();
            productNameTb.Text = dataProductGV.SelectedRows[0].Cells[1].Value.ToString();
            productColorTb.Text = dataProductGV.SelectedRows[0].Cells[2].Value.ToString();
            productPriceTb.Text = dataProductGV.SelectedRows[0].Cells[3].Value.ToString();
            productDescriptionTb.Text = dataProductGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("update ProductTbl set Name= N'" + productNameTb.Text + "' ,Color= N'" + productColorTb.Text + "' ,Price= N'" + productPriceTb.Text + "' ,Description= N'"+productDescriptionTb.Text+"' where ID= N'"+productIdTb.Text+"'", Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                populate();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {

            if (productIdTb.Text == "")
            {
                MessageBox.Show("Pleace enter priduct ID");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from ProductTbl where ProductID= '" + productIdTb.Text + "'; ";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfuly deleted");
                Con.Close();
                populate();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            productIdTb.Text= string.Empty;
            productNameTb.Text= string.Empty;
            productColorTb.Text= string.Empty;
            productPriceTb.Text= string.Empty;
            productDescriptionTb.Text= string.Empty;
        }
    }
}
