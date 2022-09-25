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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void stuListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stuListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDS);

        }

        private void stuListBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.stuListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDS);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDS.stuList' table. You can move, or remove it, as needed.
            this.stuListTableAdapter.Fill(this.mainDS.stuList);
            stuListBindingSource.Filter = "sid =" + Program.id;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                stuListTableAdapter.UpdateItem(snameTextBox.Text, sfamilyTextBox.Text, scmeliTextBox.Text, smobileTextBox.Text,int.Parse(sidTextBox.Text));
                Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
    }
}
