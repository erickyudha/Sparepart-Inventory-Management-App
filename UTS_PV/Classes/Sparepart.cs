using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data.MySqlClient;
using MySql.Data;

namespace UTS_PV.Classes
{
    class Sparepart
    {
        public static Dictionary<string, string[]> getSparepartList()
        {
            // Struktur data Dictionary = Kode: NamaBarang, Stok, Harga
            Database db = new Database();

            string sql = "SELECT kode, nama_barang, stok, harga FROM inventori_sparepart ORDER BY kode";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, db.connection);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "inventori_sparepart");

            Dictionary<string, string[]> sparepartList = new Dictionary<string, string[]>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string kode = ds.Tables[0].Rows[i][0].ToString();
                string nama_barang = ds.Tables[0].Rows[i][1].ToString();
                string stok = ds.Tables[0].Rows[i][2].ToString();
                string harga = ds.Tables[0].Rows[i][3].ToString();

                string[] tmp = { nama_barang, stok, harga };
                sparepartList.Add(kode, tmp);
            }

            return sparepartList;
        }

        public static void addSparepart(string kode, string nama, int stok, int harga)
        {
            Database db = new Database();
            db.connection.Open();

            string sql = "INSERT INTO `inventori_sparepart`" +
                "(`id`, `kode`, `nama_barang`, `stok`, `harga`) VALUES " +
                "(NULL, ?kode, ?nama_barang, ?stok, ?harga);";
            MySqlCommand command = db.connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add("?kode", MySqlDbType.VarChar).Value = kode;
            command.Parameters.Add("?nama_barang", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("?stok", MySqlDbType.Int32).Value = stok;
            command.Parameters.Add("?harga", MySqlDbType.Int32).Value = harga;

            command.ExecuteNonQuery();
            db.connection.Close();
        }

        public static void deleteSparepart(string kode)
        {
            Database db = new Database();
            db.connection.Open();

            string sql = "DELETE FROM `inventori_sparepart` " +
                "WHERE kode=?kode;";
            MySqlCommand command = db.connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add("?kode", MySqlDbType.VarChar).Value = kode;

            command.ExecuteNonQuery();
            db.connection.Close();
        }
    }
}
