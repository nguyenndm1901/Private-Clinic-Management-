using PCM_BUS;
using PCM_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;

namespace PCM_GUI
{
    public partial class frmThemBenhNhan : Form
    {
        private DanhSachBenhNhan_BUS dsbnBus;
        public frmThemBenhNhan()
        {
            InitializeComponent();
        }
        private void FrmThemBenhNhan_Load(object sender, EventArgs e)
        {
            dsbnBus = new DanhSachBenhNhan_BUS();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            DanhSachBenhNhan_DTO dsbn = new DanhSachBenhNhan_DTO();
            dsbn.BN_maBN = txtMaBN.Text;
            dsbn.BN_hoten = txtTen.Text;
            dsbn.BN_namsinh = txtYear.Text;
            dsbn.BN_sdt = txtSDT.Text;
            dsbn.BN_gioitinh = txtGioiTinh.Text;
            dsbn.BN_diachi = txtDiaChi.Text;
            dsbn.BN_ngaykham = txtDate.Text;
            dsbn.BN_loaibenh = txtLoaiBenh.Text;
            dsbn.BN_trieuchung = txtTrieuChung.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = dsbnBus.them(dsbn);
            if (kq == false)
                MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm thành công");
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showmain()
        {
            frmMain main = new frmMain();
            main.ShowDialog();
        }
        private void TrởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showmain));
            thread.Start();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Auto-Generate maBN
            string maBN;
            bool isMaBenhNhanExisted = true;
            while (isMaBenhNhanExisted)
            {
                maBN = GenerateMaBenhNhan();
                isMaBenhNhanExisted = check(maBN);
                txtMaBN.Text = maBN;
            }
            //Enable buttons
            groupBox.Enabled = true;
            BtnAdd.Enabled = true;
        }
        private static readonly Random _random = new Random();
        private string GenerateMaBenhNhan()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd");

            // Define allowed characters
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] randomChars = new char[6];

            for (int i = 0; i < 6; i++)
            {
                randomChars[i] = chars[_random.Next(chars.Length)];
            }

            return $"{timestamp}{new string(randomChars)}";
        }
        private bool check(string maBN)
        {
            bool MaBenhNhanExist = false;
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM DanhSachBenhNhan WHERE [BN_maBN] = @BN_maBN", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@BN_maBN", maBN);
                    DataTable dtAnyData = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtAnyData.Load(reader);
                    if (dtAnyData.Rows.Count > 0)
                    {
                        MaBenhNhanExist = true;
                    }
                }
            }
            return MaBenhNhanExist;
        }
    }
}
