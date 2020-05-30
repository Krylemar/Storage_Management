using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladov_Softuer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storage_managementDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.storage_managementDataSet.items);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
