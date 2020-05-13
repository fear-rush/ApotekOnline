using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekOnline
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // fungsi untuk mengecek apakah database ApotekOnline ada atau tidak, jika tidak ada maka akan membuat database baru dengan memanggil
            // fungsi GenerateDatabase()
            if (!CheckDatabaseExist())
            {
                GenerateDatabase();
            }
        }
        private bool CheckDatabaseExist()
        {
            // Mencoba connect ke SQLServer dengan connection string conn, jika gagal maka akan return false dan memanggil fungsi GenerateDatabase()

            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ApotekOnline;Integrated Security=True");
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void GenerateDatabase()
        {

            // Generate database dengan cara membaca file ApotekOnlineSQL.sql pada folder installer dan akan mengenerate database dan table sesuai dengan file ApotekOnlineSQL.sql

            List<string> cmds = new List<string>();
            if(File.Exists(Application.StartupPath + "\\ApotekOnlineSQL.sql"))
            {
                TextReader tr = new StreamReader(Application.StartupPath + "\\ApotekOnlineSQL.sql");
                string line = "";
                string cmd = "";
                while ((line = tr.ReadLine()) != null)
                {
                    if (line.Trim().ToUpper() == "GO")
                    {
                        cmds.Add(cmd);
                        cmd = "";
                    }
                    else
                    {
                        cmd += line + "\r\n";
                    }
                }
                if(cmd.Length > 0)
                {
                    cmds.Add(cmd);
                    cmd = "";
                }
                tr.Close();
            }
            if (cmds.Count > 0)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MASTER;Integrated Security=True");
                command.CommandType = System.Data.CommandType.Text;
                command.Connection.Open();
                for(int i = 0; i<cmds.Count; i++)
                {
                    command.CommandText = cmds[i];
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btDokter_Click(object sender, EventArgs e)
        {
            DokterLogin dokterlogin = new DokterLogin();
            dokterlogin.Show();
        }

        private void btApoteker_Click(object sender, EventArgs e)
        {
            ApotekerLogin apotekerlogin = new ApotekerLogin();
            apotekerlogin.Show();
        }

        private void btPasien_Click(object sender, EventArgs e)
        {
            Fitur fitur = new Fitur();
            fitur.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
