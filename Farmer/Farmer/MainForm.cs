using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class MainForm : Form
    {
        private Connect dbHelper;
        public MainForm()
        {
            InitializeComponent();
            dbHelper = new Connect();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            int cowQuantity, sheepQuantity, goatQuantity;
            if (!int.TryParse(txtCow.Text, out cowQuantity))
            {
                MessageBox.Show("Vui lòng nhập số lượng bò hợp lệ.");
                return;
            }
            if (!int.TryParse(txtSheep.Text, out sheepQuantity))
            {
                MessageBox.Show("Vui lòng nhập số lượng cừu hợp lệ.");
                return;
            }
            if (!int.TryParse(txtGoat.Text, out goatQuantity))
            {
                MessageBox.Show("Vui lòng nhập số lượng dê hợp lệ.");
                return;
            }
            dbHelper.UpdateAnimalQuantity(1, cowQuantity);  
            dbHelper.UpdateAnimalQuantity(2, sheepQuantity); 
            dbHelper.UpdateAnimalQuantity(3, goatQuantity);  

            MessageBox.Show("Đã cập nhật số lượng động vật vào cơ sở dữ liệu!");
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            DataTable dt = dbHelper.GetAnimalDetails();
            string result = "";

            foreach (DataRow row in dt.Rows)
            {
                string type = row["Type"].ToString();
                int quantity = Convert.ToInt32(row["Quantity"]);
                string sound = row["Sound"].ToString();

                if (quantity > 0)
                {
                    // Tạo chuỗi tiếng kêu cho số lượng động vật
                    string repeatedSound = string.Join(" ", Enumerable.Repeat(sound, quantity));
                    result += $"{type}: {repeatedSound}\n";
                }
                else
                {
                    result += $"{type}: Không có động vật.\n";
                }
            }

            lblSounds.Text = result;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {

        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            dbHelper.AddOffSpring();
            dbHelper.AddMilk();
            MessageBox.Show("Sinh con thanhf công");
        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DataTable dt = dbHelper.GetStatistics();
            string result = "Thống kê gia súc:\n";

            foreach (DataRow row in dt.Rows)
            {
                string type = row["Type"].ToString();
                int quantity = Convert.ToInt32(row["TotalQuantity"]);
                int totalMilk = Convert.ToInt32(row["TotalMilk"]);

                result += $"{type}: Số lượng = {quantity}, Tổng sữa = {totalMilk} lít\n";
            }

            lblShow.Text = result;
        }
    }
}
