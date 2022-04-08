using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UTS_PV.Forms;
using UTS_PV.Classes;

namespace UTS_PV
{
    
    public partial class MainForm : Form
    {
        private bool isDbActive;
        int autoId = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkState();   

            if (isDbActive)
            {
                updateListView();
            }
        }

        private void dbSettings_Click(object sender, EventArgs e)
        {
            DbSettingsForm dbSettingsForm = new DbSettingsForm(this);
            dbSettingsForm.ShowDialog();
        }

        public void checkState()
        {
            Database db = new Database();
            if (db.isCurrentDbValid())
            {
                mainListView.Enabled = true;
                kodeAddBox.Enabled = true;
                namaAddBox.Enabled = true;
                stokAddBox.Enabled = true;
                hargaAddBox.Enabled = true;
                namaEditBox.Enabled = true;
                stokEditBox.Enabled = true;
                hargaEditBox.Enabled = true;
                addBtn.Enabled = true;
                editBtn.Enabled = true;
                deleteBtn.Enabled = true;

                isDbActive = true;

                updateListView();
            } else
            {
                clearListViewItem();
                mainListView.Enabled = false;
                kodeAddBox.Enabled = false;
                namaAddBox.Enabled = false;
                stokAddBox.Enabled = false;
                hargaAddBox.Enabled = false;
                namaEditBox.Enabled = false;
                stokEditBox.Enabled = false;
                hargaEditBox.Enabled = false;
                addBtn.Enabled = false;
                editBtn.Enabled = false;
                deleteBtn.Enabled = false;

                isDbActive = false;
            }
        }

        public void clearListViewItem()
        {
            for (int i = mainListView.Items.Count - 1; i >= 0; i--)
            {
                mainListView.Items[i].Remove();
            }
        }

        public void updateListView()
        {
            clearListViewItem();

            Dictionary<string, string[]> dict = Sparepart.getSparepartList();

            autoId = 1;
            foreach (KeyValuePair<string, string[]> data in dict)
            {
                ListViewItem newItem = new ListViewItem("" + autoId);

                newItem.SubItems.Add(data.Key);
                newItem.SubItems.Add(data.Value[0]);
                newItem.SubItems.Add(data.Value[1]);
                newItem.SubItems.Add(data.Value[2]);

                mainListView.Items.Add(newItem);

                autoId++;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (kodeAddBox.Text.Length != 4) throw new Exception();
                if (kodeAddBox.Text.Length == 0) throw new Exception();
                int stok = Int32.Parse(stokAddBox.Text);
                int harga = Int32.Parse(hargaAddBox.Text);

                Sparepart.addSparepart(kodeAddBox.Text, namaAddBox.Text, stok, harga);
                updateListView();
            } catch (Exception ex)
            {
                MessageBox.Show("Please check input! Kode harus 4 digit");
            }
        }

        private void mainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            kodeEditBox.Text = mainListView.FocusedItem.SubItems[1].Text;
            namaEditBox.Text = mainListView.FocusedItem.SubItems[2].Text;
            stokEditBox.Text = mainListView.FocusedItem.SubItems[3].Text;
            hargaEditBox.Text = mainListView.FocusedItem.SubItems[4].Text;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (kodeEditBox.Text.Length != 4) throw new Exception();
                if (namaEditBox.Text.Length == 0) throw new Exception();
                int stok = Int32.Parse(stokEditBox.Text);
                int harga = Int32.Parse(hargaEditBox.Text);

                Sparepart.deleteSparepart(kodeEditBox.Text);
                Sparepart.addSparepart(kodeEditBox.Text, namaEditBox.Text, stok, harga);

                updateListView();
            } catch (Exception ex)
            {
                MessageBox.Show("Please check input again!");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (kodeEditBox.Text.Length != 4) throw new Exception();

                DialogResult confirmResult = MessageBox.Show("Do you sure you want to delete this item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Sparepart.deleteSparepart(kodeEditBox.Text);
                    updateListView();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Select an item first!");
            }
            
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int stok = Int32.Parse(stokEditBox.Text);
                stokEditBox.Text = (stok -= 1).ToString();
            } catch
            {
                stokEditBox.Text = "" + 1;
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int stok = Int32.Parse(stokEditBox.Text);

                stokEditBox.Text = (stok += 1).ToString();
            }
            catch
            {
                stokEditBox.Text = "" + 1;
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }
    }
}
