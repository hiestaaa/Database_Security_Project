namespace DOAN
{
    partial class fProductManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabProduct = new TabPage();
            nmrQuantity = new NumericUpDown();
            nmrPrice = new NumericUpDown();
            txbProductCategory = new TextBox();
            txbProductName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            btnAddProduct = new Button();
            dtgvProduct = new DataGridView();
            tabBill = new TabPage();
            txbAccountID = new TextBox();
            label7 = new Label();
            nmrProductBillQuantity = new NumericUpDown();
            txbProductID = new TextBox();
            txbBillID = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnEditBill = new Button();
            btnDeleteBill = new Button();
            btnAddBill = new Button();
            dtgvBill = new DataGridView();
            tabAccount = new TabPage();
            textBox4 = new TextBox();
            label12 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnLogout = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            dtgvAccount = new DataGridView();
            tabControl1.SuspendLayout();
            tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProduct).BeginInit();
            tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrProductBillQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProduct);
            tabControl1.Controls.Add(tabBill);
            tabControl1.Controls.Add(tabAccount);
            tabControl1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(16, 18);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1515, 854);
            tabControl1.TabIndex = 0;
            // 
            // tabProduct
            // 
            tabProduct.Controls.Add(nmrQuantity);
            tabProduct.Controls.Add(nmrPrice);
            tabProduct.Controls.Add(txbProductCategory);
            tabProduct.Controls.Add(txbProductName);
            tabProduct.Controls.Add(label4);
            tabProduct.Controls.Add(label3);
            tabProduct.Controls.Add(label2);
            tabProduct.Controls.Add(label1);
            tabProduct.Controls.Add(btnEditProduct);
            tabProduct.Controls.Add(btnDeleteProduct);
            tabProduct.Controls.Add(btnAddProduct);
            tabProduct.Controls.Add(dtgvProduct);
            tabProduct.Location = new Point(4, 31);
            tabProduct.Margin = new Padding(4, 5, 4, 5);
            tabProduct.Name = "tabProduct";
            tabProduct.Padding = new Padding(4, 5, 4, 5);
            tabProduct.Size = new Size(1507, 819);
            tabProduct.TabIndex = 0;
            tabProduct.Text = "Sản phẩm";
            tabProduct.UseVisualStyleBackColor = true;
            // 
            // nmrQuantity
            // 
            nmrQuantity.Location = new Point(1344, 671);
            nmrQuantity.Margin = new Padding(4, 5, 4, 5);
            nmrQuantity.Name = "nmrQuantity";
            nmrQuantity.Size = new Size(152, 30);
            nmrQuantity.TabIndex = 11;
            // 
            // nmrPrice
            // 
            nmrPrice.Location = new Point(1044, 672);
            nmrPrice.Margin = new Padding(4, 5, 4, 5);
            nmrPrice.Name = "nmrPrice";
            nmrPrice.Size = new Size(160, 30);
            nmrPrice.TabIndex = 10;
            // 
            // txbProductCategory
            // 
            txbProductCategory.Location = new Point(219, 746);
            txbProductCategory.Margin = new Padding(4, 5, 4, 5);
            txbProductCategory.Name = "txbProductCategory";
            txbProductCategory.Size = new Size(676, 30);
            txbProductCategory.TabIndex = 9;
            // 
            // txbProductName
            // 
            txbProductName.Location = new Point(219, 671);
            txbProductName.Margin = new Padding(4, 5, 4, 5);
            txbProductName.Name = "txbProductName";
            txbProductName.Size = new Size(676, 30);
            txbProductName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 751);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 22);
            label4.TabIndex = 7;
            label4.Text = "Loại sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1212, 675);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 6;
            label3.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(919, 675);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 5;
            label2.Text = "Đơn giá:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 675);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 22);
            label1.TabIndex = 4;
            label1.Text = "Tên sản phẩm:";
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(1305, 734);
            btnEditProduct.Margin = new Padding(4, 5, 4, 5);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(191, 63);
            btnEditProduct.TabIndex = 3;
            btnEditProduct.Text = "Sửa";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(1107, 734);
            btnDeleteProduct.Margin = new Padding(4, 5, 4, 5);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(191, 63);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Xóa";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(908, 734);
            btnAddProduct.Margin = new Padding(4, 5, 4, 5);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(191, 63);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dtgvProduct
            // 
            dtgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProduct.Location = new Point(9, 11);
            dtgvProduct.Margin = new Padding(4, 5, 4, 5);
            dtgvProduct.Name = "dtgvProduct";
            dtgvProduct.RowHeadersWidth = 51;
            dtgvProduct.Size = new Size(1487, 632);
            dtgvProduct.TabIndex = 0;
            // 
            // tabBill
            // 
            tabBill.Controls.Add(txbAccountID);
            tabBill.Controls.Add(label7);
            tabBill.Controls.Add(nmrProductBillQuantity);
            tabBill.Controls.Add(txbProductID);
            tabBill.Controls.Add(txbBillID);
            tabBill.Controls.Add(label5);
            tabBill.Controls.Add(label6);
            tabBill.Controls.Add(label8);
            tabBill.Controls.Add(btnEditBill);
            tabBill.Controls.Add(btnDeleteBill);
            tabBill.Controls.Add(btnAddBill);
            tabBill.Controls.Add(dtgvBill);
            tabBill.Location = new Point(4, 31);
            tabBill.Margin = new Padding(4, 5, 4, 5);
            tabBill.Name = "tabBill";
            tabBill.Padding = new Padding(4, 5, 4, 5);
            tabBill.Size = new Size(1507, 819);
            tabBill.TabIndex = 1;
            tabBill.Text = "Hóa đơn";
            tabBill.UseVisualStyleBackColor = true;
            // 
            // txbAccountID
            // 
            txbAccountID.Location = new Point(1003, 668);
            txbAccountID.Margin = new Padding(4, 5, 4, 5);
            txbAccountID.Name = "txbAccountID";
            txbAccountID.Size = new Size(492, 30);
            txbAccountID.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(904, 672);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 22);
            label7.TabIndex = 20;
            label7.Text = "Mã TK:";
            // 
            // nmrProductBillQuantity
            // 
            nmrProductBillQuantity.Location = new Point(740, 745);
            nmrProductBillQuantity.Margin = new Padding(4, 5, 4, 5);
            nmrProductBillQuantity.Name = "nmrProductBillQuantity";
            nmrProductBillQuantity.Size = new Size(152, 30);
            nmrProductBillQuantity.TabIndex = 19;
            // 
            // txbProductID
            // 
            txbProductID.Location = new Point(107, 745);
            txbProductID.Margin = new Padding(4, 5, 4, 5);
            txbProductID.Name = "txbProductID";
            txbProductID.Size = new Size(405, 30);
            txbProductID.TabIndex = 17;
            // 
            // txbBillID
            // 
            txbBillID.Location = new Point(107, 668);
            txbBillID.Margin = new Padding(4, 5, 4, 5);
            txbBillID.Name = "txbBillID";
            txbBillID.Size = new Size(784, 30);
            txbBillID.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 749);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 22);
            label5.TabIndex = 15;
            label5.Text = "Mã SP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 749);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 22);
            label6.TabIndex = 14;
            label6.Text = "Số lượng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 674);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(82, 22);
            label8.TabIndex = 12;
            label8.Text = "Mã HD:";
            // 
            // btnEditBill
            // 
            btnEditBill.Location = new Point(1305, 734);
            btnEditBill.Margin = new Padding(4, 5, 4, 5);
            btnEditBill.Name = "btnEditBill";
            btnEditBill.Size = new Size(191, 63);
            btnEditBill.TabIndex = 7;
            btnEditBill.Text = "Sửa";
            btnEditBill.UseVisualStyleBackColor = true;
            btnEditBill.Click += btnEditBill_Click;
            // 
            // btnDeleteBill
            // 
            btnDeleteBill.Location = new Point(1107, 734);
            btnDeleteBill.Margin = new Padding(4, 5, 4, 5);
            btnDeleteBill.Name = "btnDeleteBill";
            btnDeleteBill.Size = new Size(191, 63);
            btnDeleteBill.TabIndex = 6;
            btnDeleteBill.Text = "Xóa";
            btnDeleteBill.UseVisualStyleBackColor = true;
            btnDeleteBill.Click += btnDeleteBill_Click;
            // 
            // btnAddBill
            // 
            btnAddBill.Location = new Point(908, 734);
            btnAddBill.Margin = new Padding(4, 5, 4, 5);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(191, 63);
            btnAddBill.TabIndex = 5;
            btnAddBill.Text = "Thêm";
            btnAddBill.UseVisualStyleBackColor = true;
            btnAddBill.Click += btnAddBill_Click;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(9, 11);
            dtgvBill.Margin = new Padding(4, 5, 4, 5);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.Size = new Size(1487, 634);
            dtgvBill.TabIndex = 4;
            // 
            // tabAccount
            // 
            tabAccount.Controls.Add(textBox4);
            tabAccount.Controls.Add(label12);
            tabAccount.Controls.Add(textBox3);
            tabAccount.Controls.Add(label11);
            tabAccount.Controls.Add(textBox1);
            tabAccount.Controls.Add(textBox2);
            tabAccount.Controls.Add(label9);
            tabAccount.Controls.Add(label10);
            tabAccount.Controls.Add(btnLogout);
            tabAccount.Controls.Add(btnEditAccount);
            tabAccount.Controls.Add(btnDeleteAccount);
            tabAccount.Controls.Add(dtgvAccount);
            tabAccount.Location = new Point(4, 31);
            tabAccount.Margin = new Padding(4, 5, 4, 5);
            tabAccount.Name = "tabAccount";
            tabAccount.Padding = new Padding(4, 5, 4, 5);
            tabAccount.Size = new Size(1507, 819);
            tabAccount.TabIndex = 2;
            tabAccount.Text = "Tài khoản";
            tabAccount.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(615, 665);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(464, 30);
            textBox4.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(503, 669);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(94, 22);
            label12.TabIndex = 24;
            label12.Text = "Tên TK:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 665);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(364, 30);
            textBox3.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 669);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 22;
            label11.Text = "Mã TK:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 748);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(733, 30);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1175, 665);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 30);
            textBox2.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(220, 752);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 22);
            label9.TabIndex = 19;
            label9.Text = "Địa chỉ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1103, 669);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 22);
            label10.TabIndex = 18;
            label10.Text = "SĐT:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(9, 734);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(191, 63);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(1305, 734);
            btnEditAccount.Margin = new Padding(4, 5, 4, 5);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(191, 63);
            btnEditAccount.TabIndex = 7;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(1107, 734);
            btnDeleteAccount.Margin = new Padding(4, 5, 4, 5);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(191, 63);
            btnDeleteAccount.TabIndex = 6;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(9, 11);
            dtgvAccount.Margin = new Padding(4, 5, 4, 5);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(1487, 635);
            dtgvAccount.TabIndex = 4;
            // 
            // fProductManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 891);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "fProductManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng tiện lợi";
            Load += fProductManager_Load;
            tabControl1.ResumeLayout(false);
            tabProduct.ResumeLayout(false);
            tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProduct).EndInit();
            tabBill.ResumeLayout(false);
            tabBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrProductBillQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tabAccount.ResumeLayout(false);
            tabAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.Button btnEditBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.TextBox txbProductCategory;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrQuantity;
        private System.Windows.Forms.NumericUpDown nmrProductBillQuantity;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.TextBox txbBillID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbAccountID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
    }
}