using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DOAN
{
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }
        bool Check_Textbox(string host, string port, string sid, string username, string password, string repassword)
        {
            if (host == "" || port == "" || sid == "" || username == "" || password == "" || repassword == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }
            else return true;
        }

        public bool Register(string host, string port, string sid, string username, string password)
        {
            Database.Set_Database(host, port, sid, "sys", "sys");
            if (Database.Connect())
            {
                OracleConnection c = Database.Get_connect();
                OracleCommand cmd = new OracleCommand("PCD_CREATEUSER", Database.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", OracleDbType.NVarchar2).Value = username;
                cmd.Parameters.Add("password", OracleDbType.NVarchar2).Value = password;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Đăng kí thất bại", "Thông báo");
                return false;
            }
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string host = txbHost.Text;
            string port = txbPort.Text;
            string sid = txbSid.Text;
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            string repassword = txbRePassword.Text;

            if (Check_Textbox(host, port, sid, username, password, repassword) && password == repassword)
            {
                try
                {
                    Register(host, port, sid, username, password);
                }
                catch (Exception)
                {
                    MessageBox.Show("Đăng kí thất bại", "Thông báo");
                }
                txbUsername.Clear();
                txbPassword.Clear();
                txbRePassword.Clear();
            }
            else
            {
                MessageBox.Show("Đăng kí thất bại", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
