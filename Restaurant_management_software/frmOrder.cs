using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_management_software
{
    public partial class frmOrder : Form
    {
        private string tableNo;
        public frmOrder()
        {
            InitializeComponent();
        }
        public frmOrder(string tableNo)
        {
            InitializeComponent();
            this.tableNo = tableNo;
        }

        SQL_Connection connect = new SQL_Connection();

        private void showFoodTabs()
        {
            DataTable datas = new DataTable();
            datas = connect.getData("select distinct Nhom from LoaiThucDon");
           
            foreach (DataRow row in datas.Rows)
            {
                int i = 0;
                int baselineX = -100;
                int baselineY = -50;
                TabPage pagefood = new TabPage();
                pagefood.Text = row[0].ToString();
                pagefood.Name = "tab_" + row[0].ToString();
                pagefood.AutoScroll = true;
                string tabname = pagefood.Name;
                this.tabFoods.Controls.Add(pagefood);
                DataTable listfoods = new DataTable();
                listfoods = connect.getData("select * from view_food where Nhom = N'" + row[0] + "'");
                foreach (DataRow food in listfoods.Rows)
                {
                    i++;
                    if (i % 8 == 0 || i == 1 )
                    {
                        baselineX += 150;
                        baselineY = 50;
                    }
                    else
                    {
                        baselineY = baselineY + 200;
                    }
                    GroupBox group = new GroupBox();
                    group.BackColor = System.Drawing.Color.LightBlue;
                    group.Name = "groupbox_" + i.ToString();
                    group.Width = 150;
                    group.Height = 100;
                    group.Location = new Point(baselineY, baselineX);
                    group.Enter += groupBox4_Enter;

                    TextBox foodname = new TextBox();
                    foodname.Text = food[1].ToString();
                    foodname.BackColor = System.Drawing.Color.LightBlue;
                    foodname.TextAlign = HorizontalAlignment.Left;
                    foodname.Name = "foodname_" + i.ToString();
                    foodname.Location = new Point(6, 25);
                    foodname.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    foodname.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);

                    TextBox foodPrice = new TextBox();
                    foodPrice.Text = food[0].ToString();
                    foodPrice.BackColor = System.Drawing.Color.LightBlue;
                    foodPrice.TextAlign = HorizontalAlignment.Right;
                    foodPrice.Name = "foodprice_" + i.ToString();
                    foodPrice.Location = new Point(30, 70);
                    foodPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    foodPrice.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                    pagefood.Controls.Add(group);
                    group.Controls.Add(foodname);
                    group.Controls.Add(foodPrice);
                    
                }
            }
        }

      

        private void frmOrder_Load(object sender, EventArgs e)
        {
            showFoodTabs();
            table.Text = "Bàn số: " + tableNo;
            showOrder();
        }

        private void tabTrangmieng_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            string foodname = (sender as GroupBox).GetChildAtPoint(new Point(6,25)).Text;
            
            string foodprice = (sender as GroupBox).GetChildAtPoint(new Point(30, 70)).Text;
            string sql_save = "insert into temp_Hoadon values(N'"+foodname +"', "+tableNo+","+1+","+foodprice+" );";
            connect.excute(sql_save);
            showOrder();
        }

        private void showOrder()
        {
           
            int i = 0;
            int baselineX = 50;
            int baselineY = 10;
            int total = 0;
            DataTable datas = new DataTable();
            datas = connect.getData("select * from temp_Hoadon where SoBan =" + tableNo.ToString());
            foreach (DataRow row in datas.Rows)
            {
                i++;
                GroupBox group = new GroupBox();
                group.BackColor = System.Drawing.Color.FromArgb(194, 217, 247);
                group.Name = "order_" + i.ToString();
                group.Width = 400;
                group.Height = 100;
                group.Location = new Point(baselineY, baselineX);
                
                baselineX += 110;

                TextBox foodname = new TextBox();
                foodname.Text = row[1].ToString();
                foodname.BackColor = System.Drawing.Color.WhiteSmoke;
                foodname.BorderStyle = System.Windows.Forms.BorderStyle.None;
                foodname.TextAlign = HorizontalAlignment.Left;
                foodname.Name = "foodname_" + i.ToString();
                foodname.Location = new Point(5, 14);
                foodname.Multiline = true;
                foodname.Width = 165;
                foodname.Height = 75;

                NumericUpDown quantity = new NumericUpDown();
                quantity.Width = 30;
                quantity.Height = 15;
                quantity.Value = (int) row[3];
                quantity.Name = "quantity_" + i.ToString();
                quantity.Location = new Point(180, 14);
                quantity.BackColor = System.Drawing.Color.WhiteSmoke;

                Label lbPrice = new Label();
                lbPrice.Text = "Giá";
                lbPrice.Location = new Point(230, 14);
                lbPrice.Width = 40;
                lbPrice.Height = 20;

                TextBox price = new TextBox();
                price.BackColor = System.Drawing.Color.WhiteSmoke;
                price.Text = row[4].ToString();
                price.BorderStyle = System.Windows.Forms.BorderStyle.None;
                price.TextAlign = HorizontalAlignment.Right;
                price.Width = 70;
                price.Height = 20;
                price.Location = new Point(280, 14);
                price.Name = "price_" + i.ToString();

                Button del = new Button();
                del.Location = new Point(360, 14);
                del.Width = 20;
                del.Height = 20;
                del.Text = "X";
                del.Click += button1_Click;
                del.BackColor = System.Drawing.Color.Red;
                del.ForeColor = System.Drawing.Color.White;

                Label lbsub = new Label();
                lbsub.Text = "Tạm tính";
                lbsub.Location = new Point(170, 70);
                lbsub.Width = 80;
                lbsub.Height = 20;

                TextBox subtotal = new TextBox();
                int sub = 0;
                sub = ((int) quantity.Value * Int32.Parse(price.Text));
                subtotal.BackColor = System.Drawing.Color.WhiteSmoke;
                subtotal.Text =sub.ToString();
                subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
                subtotal.TextAlign = HorizontalAlignment.Right;
                subtotal.Width = 100;
                subtotal.Height = 20;
                subtotal.Location = new Point(255, 70);
                subtotal.Name = "subtotal_" + i.ToString();

                group.Controls.Add(foodname);
                group.Controls.Add(quantity);
                group.Controls.Add(price);
                group.Controls.Add(del);
                group.Controls.Add(lbPrice);
                group.Controls.Add(lbsub);
                group.Controls.Add(subtotal);
                Orders.Controls.Add(group);
                total += sub;              
            }
            Orders.AutoScroll = true;
            tbtotal.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string foodname = (sender as Button).Parent.GetChildAtPoint(new Point(5,14)).Text;
            string sql_del = "delete from temp_Hoadon where SoBan =" + tableNo + "and TenThucDon =N'" +foodname +"';";
            connect.excute(sql_del);
            Orders.Controls.Clear();
            showOrder();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            
        }
    }
}
