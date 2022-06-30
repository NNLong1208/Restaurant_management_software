namespace Restaurant_management_software
{
    partial class frmOrder
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabFoods = new System.Windows.Forms.TabControl();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button31 = new System.Windows.Forms.Button();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TextBox();
            this.ordertab = new System.Windows.Forms.TabControl();
            this.Orders = new System.Windows.Forms.TabPage();
            this.groupBox3.SuspendLayout();
            this.ordertab.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1069, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Xin chao Dat09";
            // 
            // tabFoods
            // 
            this.tabFoods.ItemSize = new System.Drawing.Size(100, 25);
            this.tabFoods.Location = new System.Drawing.Point(649, 97);
            this.tabFoods.Name = "tabFoods";
            this.tabFoods.SelectedIndex = 0;
            this.tabFoods.Size = new System.Drawing.Size(1189, 638);
            this.tabFoods.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.textBox3.Location = new System.Drawing.Point(487, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(352, 64);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Nhà Hàng .NET";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.button31);
            this.groupBox3.Controls.Add(this.tbtotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(9, 626);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 80);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Aqua;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Location = new System.Drawing.Point(28, 11);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(145, 32);
            this.button31.TabIndex = 10;
            this.button31.TabStop = false;
            this.button31.Text = "Thanh toán";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // tbtotal
            // 
            this.tbtotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtotal.Location = new System.Drawing.Point(435, 17);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(145, 19);
            this.tbtotal.TabIndex = 8;
            this.tbtotal.Text = "1000000";
            this.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền: ";
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.Location = new System.Drawing.Point(9, 85);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(177, 19);
            this.table.TabIndex = 11;
            this.table.Text = "Bàn số: ";
            // 
            // ordertab
            // 
            this.ordertab.Controls.Add(this.Orders);
            this.ordertab.Location = new System.Drawing.Point(9, 111);
            this.ordertab.Name = "ordertab";
            this.ordertab.SelectedIndex = 0;
            this.ordertab.Size = new System.Drawing.Size(634, 509);
            this.ordertab.TabIndex = 15;
            // 
            // Orders
            // 
            this.Orders.Location = new System.Drawing.Point(4, 29);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(626, 476);
            this.Orders.TabIndex = 0;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1757, 706);
            this.Controls.Add(this.ordertab);
            this.Controls.Add(this.table);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabFoods);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ordertab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabFoods;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox table;
        private System.Windows.Forms.TabControl ordertab;
        private System.Windows.Forms.TabPage Orders;
    }
}