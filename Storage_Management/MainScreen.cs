using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage_Management
{
    public partial class MainScreen : Form
    {
        public MainScreen(string first_name, string last_name)
        {
            InitializeComponent();
            nameLabel.Text = first_name+" "+last_name;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storage_managementDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.storage_managementDataSet.items);

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            this.itemsTableAdapter.Fill(this.storage_managementDataSet.items);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var newForm = new LoginScreen();
            this.Hide();
            newForm.Show();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            try
            {
                itemsBindingSource.EndEdit();
                itemsTableAdapter.Update(this.storage_managementDataSet.items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            itemsBindingSource.RemoveCurrent(); 
        }

        private void cancelChangesButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            this.itemsTableAdapter.Fill(this.storage_managementDataSet.items);
        }

        private void itemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemsGridView_KeyDown(object sender, KeyEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if (e.KeyCode == Keys.Delete)
                itemsBindingSource.RemoveCurrent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            itemsGridView.ClearSelection();//If you want

            int nRowIndex = itemsGridView.Rows.Count - 1;
            int nColumnIndex = 3;

            itemsGridView.Rows[nRowIndex].Selected = true;
            itemsGridView.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

            //In case if you want to scroll down as well.
            itemsGridView.FirstDisplayedScrollingRowIndex = nRowIndex;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
