using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq; 

namespace PBL3_Project;

public partial class Form1 : Form
{
    private DataGridView dgvData;

    public Form1()
    {
        InitializeComponent();
        this.Size = new Size(600, 450);
        this.Text = "PBL3 - Quan Ly Shop Giay";

        dgvData = new DataGridView();
        dgvData.Location = new Point(20, 100);
        dgvData.Size = new Size(540, 280);
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.Controls.Add(dgvData);

        Button btnLoad = new Button();
        btnLoad.Text = "Tải danh sách loại giày";
        btnLoad.Location = new Point(20, 30);
        btnLoad.Size = new Size(150, 40);
        btnLoad.Click += (s, e) => {
            using (var db = new PBL3Context()) {
                dgvData.DataSource = db.Category.ToList(); 
            }
        };
        this.Controls.Add(btnLoad);
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
        try 
        {
            this.Text = "Đang kết nối... Đợi tí bro!";
            
            using (var db = new PBL3Context())
            {
                if (db.Database.CanConnect())
                {
                    db.SeedData();

                    int count = db.Category.Count();
                    
                    MessageBox.Show($"Kết nối thành công tới ShopGiayDB!\nTrong DB đang có {count} loại giày.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không kết nối được! Kiểm tra lại tên Server MSI hoặc Database ShopGiayDB nhé!", "Lỗi kết nối");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi");
        }
        finally
        {
            this.Text = "PBL3 - Quan Ly Shop Giay";
        }
    }
}