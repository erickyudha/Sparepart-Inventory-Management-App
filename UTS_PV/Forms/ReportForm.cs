using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_PV.Classes;

using MySql.Data.MySqlClient;
using UTS_PV.bin.Debug;

namespace UTS_PV.Forms
{
    public partial class ReportForm : Form
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter adp;
        private DataTable dtb = new DataTable();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void showReport()
        {
            Database db = new Database();
            cmd = new MySqlCommand("SELECT kode, nama_barang, stok, harga FROM `inventori_sparepart`", db.connection);
            adp = new MySqlDataAdapter(cmd);
            adp.Fill(dtb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtb.Clear();
            Database db = new Database();
            CrystalReport1 myrpt = new CrystalReport1();
            showReport();
            myrpt.Database.Tables["inventori_sparepart"].SetDataSource(dtb);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = myrpt;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
