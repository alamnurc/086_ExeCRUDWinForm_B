using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Prodi_TI
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Form_PA().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form_MP().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form_P().Show();
            this.Hide();
        }
    }
}
