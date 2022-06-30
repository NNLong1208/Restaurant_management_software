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
    public partial class frmBanAn : Form
    {
        public frmBanAn()
        {
            InitializeComponent();
        }
        SQL_Connection connect = new SQL_Connection();
        private void frmBanAn_Load(object sender, EventArgs e)
        {
            DataTable datas = new DataTable();
            datas = connect.getData("select * from BanAn ");
            int baselineX = 10;
            int baselineY = -50;
            foreach (DataRow row in datas.Rows)
            {
                if ((int) row[0] % 8 == 1  && (int) row[0]!=1)
                {
                    baselineX += 100;
                    baselineY = 50;
                } else
                {
                    baselineY = baselineY  + 100;
                }
                Button square = new Button();
                square.Width = 80;
                square.Height = 70;
                square.Name = "square" + "_" + row[0].ToString();
                if ((int) row[2] == 0)
                {
                    square.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                }
                else
                {
                    square.BackColor = System.Drawing.Color.FromArgb(214, 58, 58);
                }
                
                square.BackgroundImage = Image.FromFile(@"C:\Users\USER\Desktop\Restaurant_management_software\assets\images\table1.png");
                square.BackgroundImageLayout = ImageLayout.Stretch;
                square.Margin = new Padding(5, 5, 5, 5);
                square.Location = new Point(baselineY, baselineX);
                square.TextAlign = ContentAlignment.BottomCenter;
                square.Text = row[0].ToString();
                square.TextImageRelation = TextImageRelation.ImageAboveText;
                square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                square.Click += button6_Click;
                this.tabAvailableTable.Controls.Add(square);
            }
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tableNo = (sender as Button).Text;
            frmOrder order = new frmOrder(tableNo);
            order.Show();
        }
        
    }
}
