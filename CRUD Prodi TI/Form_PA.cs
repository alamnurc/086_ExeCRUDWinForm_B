using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Prodi_TI
{
    public partial class Form_PA : Form
    {
        public Form_PA()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = MACBOOKPRO114; Initial Catalog = SMA; Persist Security Info=True;User ID = sa; Password=04204332300");

        private void button_Back_Click(object sender, EventArgs e)
        {
            new Form_Menu().Show();
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.INSERT_PA'" + txtNIP.Text + "','" + txtNP.Text + "','" + txtMP.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved");
                LoadAllRecords();
            }

            void LoadAllRecords()
            {
                SqlCommand com = new SqlCommand("exec dbo.READ_PA", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.UPDATE_PA'" + txtNIP.Text + "','" + txtNP.Text + "','" + txtMP.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated");
                LoadAllRecords();
            }

            void LoadAllRecords()
            {
                SqlCommand com = new SqlCommand("exec dbo.READ_PA", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.DELETE_PA'" + txtNIP.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted");
                LoadAllRecords();
            }

            void LoadAllRecords()
            {
                SqlCommand com = new SqlCommand("exec dbo.READ_PA", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Form_PA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMADataSet.READ_PA' table. You can move, or remove it, as needed.
            this.rEAD_PATableAdapter.Fill(this.sMADataSet.READ_PA);

        }
    }
}
