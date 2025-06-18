using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DOAN
{
    public partial class fProductManager : Form
    {
        public fProductManager(string username)
        {
            InitializeComponent();
            LoadList(username);
        }
        void LoadList(string username)
        {
            LoadProduct(username);
            LoadBill(username);
            LoadAccount(username);
        }
        void LoadProduct(string username)
        {
            try
            {
                string Procedure = "PCD_LOADPRODUCTLIST";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Database.conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("username", username));

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    dtgvProduct.DataSource = reader;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể truy cập dữ liệu sản phẩm", "Thông báo");
            }
        }
        void LoadBill(string username)
        {
            try
            {
                string Procedure = "PCD_LOADBILLLIST";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Database.conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("username", username));

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    dtgvBill.DataSource = reader;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể truy cập dữ liệu hóa đơn", "Thông báo");
            }
        }
        void LoadAccount(string username)
        {
            try
            {
                string Procedure = "PCD_LOADACCOUNTLIST";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Database.conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("username", username));

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    dtgvAccount.DataSource = reader;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể truy cập dữ liệu tài khoản", "Thông báo");
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Database.conn.Close();
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {

        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {

        }

        private void fProductManager_Load(object sender, EventArgs e)
        {

        }
    }
}
