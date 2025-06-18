using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DOAN
{
    public partial class fLogin : Form
    {
        public static string username;
        public fLogin()
        {
            InitializeComponent();
        }
        bool Check_Textbox(string host, string port, string sid, string username, string password)
        {
            if (host == "" || port == "" || sid == "" || username == "" || password == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }
            else return true;
        }
        bool Login(string host, string port, string sid, string username, string password)
        {
            Database.Set_Database(host, port, sid, username, password);
            if (Database.Connect())
            {
                OracleConnection c = Database.Get_connect();
                MessageBox.Show("Đăng nhập thành công!\n\nServer version: " + c.ServerVersion, "Thông báo");
                return true;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string host = txbHost.Text;
            string port = txbPort.Text;
            string sid = txbSid.Text;
            username = txbUsername.Text;
            string password = txbPassword.Text;

            if (Check_Textbox(host, port, sid, username, password))
            {
                Login(host, port, sid, username, password);
                fProductManager f = new fProductManager(username);
                this.Hide();
                f.ShowDialog();
                txbUsername.Clear();
                txbPassword.Clear();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            fRegister f = new fRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
