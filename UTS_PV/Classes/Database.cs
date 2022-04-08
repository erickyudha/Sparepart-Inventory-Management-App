using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace UTS_PV.Classes
{
    class Database
    {
        private string host_name = Properties.Settings.Default.HostName;
        private string username = Properties.Settings.Default.Username;
        private string password = Properties.Settings.Default.Password;
        private string port = Properties.Settings.Default.Port;
        private string db_name = Properties.Settings.Default.DbName;
        public MySqlConnection connection;

        public Database()
        {
            /*
            this.host_name = Properties.Settings.Default.HostName;
            this.username = Properties.Settings.Default.Username;
            this.password = Properties.Settings.Default.Password;
            this.port = Properties.Settings.Default.Port;
            this.db_name = Properties.Settings.Default.DbName;
            */

            if (password.Length == 0)
            {
                this.connection = new MySqlConnection(
                String.Format("server={0};user={1};port={2};database={3};",
                host_name, username, port, db_name
                ));
            }
            else {
                this.connection = new MySqlConnection(
                String.Format("server={0};user={1};password={2};port={3};database={4};",
                host_name, username, password, port, db_name
                ));
            }
        }

        public bool isCurrentDbValid()
        {
            return isValidSettings(host_name, username, password, port, db_name);
        }

        public static bool isValidSettings(string host_name_str, string username_str, string password_str, string port_str, string db_name_str)
        {
            try
            {
                MySqlConnection testConnection;
                if (password_str.Length == 0)
                {
                    testConnection = new MySqlConnection(
                    String.Format("server={0};user={1};port={2};database={3};",
                    host_name_str, username_str, port_str, db_name_str
                    ));
                }
                else
                {
                    testConnection = new MySqlConnection(
                    String.Format("server={0};user={1};password={2};port={3};database={4};",
                    host_name_str, username_str, password_str, port_str, db_name_str
                    ));
                }
                testConnection.Open();
                testConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
