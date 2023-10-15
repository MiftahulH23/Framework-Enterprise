using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }
        bool isEditing = false;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MK_Click(object sender, EventArgs e)
        {

        }
        public void clearForm()
        {
            txtMK.Text = "";
            txtDetail.Text = "";
            dateTimeDeadline.Text = "";
        }
        private void tambah_Click(object sender, EventArgs e)
        {
            string[] baris = new string[3];
            ListViewItem item;
            if (isEditing)
            {
                SimpanEdit();
            } else
            {
                
                baris[0] = txtMK.Text;
                baris[1] = txtDetail.Text;
                baris[2] = dateTimeDeadline.Text;
                item = new ListViewItem(baris);
                listView1.Items.Add(item);
            }
            clearForm();
            isEditing = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditing = true;
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtMK.Text = selectedItem.SubItems[0].Text;
                txtDetail.Text = selectedItem.SubItems[1].Text;
                dateTimeDeadline.Text = selectedItem.SubItems[2].Text;
            }
        }

        private void SimpanEdit()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[0].Text = txtMK.Text;
                selectedItem.SubItems[1].Text = txtDetail.Text;
                selectedItem.SubItems[2].Text = dateTimeDeadline.Text;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                listView1.Items.Remove(selectedItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
