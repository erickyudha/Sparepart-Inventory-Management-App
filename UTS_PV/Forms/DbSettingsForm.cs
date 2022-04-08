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

namespace UTS_PV.Forms
{
    public partial class DbSettingsForm : Form
    {
        MainForm mainForm;

        public DbSettingsForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void DbSettingsForm_Load(object sender, EventArgs e)
        {
            string host_name = Properties.Settings.Default.HostName;
            string username = Properties.Settings.Default.Username;
            string password = Properties.Settings.Default.Password;
            string port = Properties.Settings.Default.Port;
            string db_name = Properties.Settings.Default.DbName;

            testConnectionSettings(host_name, username, password, port, db_name);

            hostNameBox.Text = host_name;
            usernameBox.Text = username;
            passwordBox.Text = password;
            portBox.Text = port;
            dbNameBox.Text = db_name;
        }

        private void testConnectionSettings(string host_name, string username, string password, string port, string db_name)
        {
            if (Database.isValidSettings(host_name, username, password, port, db_name))
            {
                ConnectionLabel.Text = "Connection active";
                ConnectionLabel.ForeColor = Color.LimeGreen;
            }
            else
            {
                ConnectionLabel.Text = "Connection inactive";
                ConnectionLabel.ForeColor = Color.Red;
            }

            mainForm.checkState();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HostName = hostNameBox.Text;
            Properties.Settings.Default.Username = usernameBox.Text;
            Properties.Settings.Default.Password = passwordBox.Text;
            Properties.Settings.Default.Port = portBox.Text;
            Properties.Settings.Default.DbName = dbNameBox.Text;

            testConnectionSettings(
                Properties.Settings.Default.HostName,
                Properties.Settings.Default.Username,
                Properties.Settings.Default.Password,
                Properties.Settings.Default.Port,
                Properties.Settings.Default.DbName
                );
        }
    }
}
