using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDS.stuList' table. You can move, or remove it, as needed.
            this.stuListTableAdapter.Fill(this.mainDS.stuList);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = (int)dataGridView1.CurrentRow.Index;
            DialogResult dig = MessageBox.Show("Delete this one?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dig == System.Windows.Forms.DialogResult.Yes)
            {
                stuListTableAdapter.DeleteItem((int)dataGridView1.Rows[ind].Cells[0].Value);
                Form1_Load(sender, e);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                stuListBindingSource.Filter = "sname like '" + textBox1.Text + "%' or sfamily like '" + textBox1.Text + "%' or scmeli like '" + textBox1.Text + "%'";
            }
            catch
            {

            }
        }
    }
}
