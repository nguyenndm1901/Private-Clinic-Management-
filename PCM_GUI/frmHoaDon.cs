using PCM_DTO;
using PCM_BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PCM_GUI.Properties;
using System.Data.SqlClient;
using System.Configuration;

namespace PCM_GUI
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private List<HoaDon_DTO> HoaDon = new List<HoaDon_DTO>();
        public enum Save
        {
            save = 1,
        }
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        private int TK = 30000;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                bool hasSameThuoc = false;
                foreach(DataGridViewRow row in dgvHD.Rows)
                {
                    if (Convert.ToInt16(row.Cells["maThuoc"].Value) == Convert.ToInt16(cbThuoc.SelectedValue))
                    {
                        row.Cells["SoLuong"].Value = Convert.ToInt16(row.Cells["SoLuong"].Value) + Convert.ToInt16(txtSoLuong.Text);
                        row.Cells["ThanhTien"].Value = Convert.ToInt16(row.Cells["SoLuong"].Value) * Convert.ToDecimal(row.Cells["DonGia"].Value);
                        hasSameThuoc = true;
                    }
                }

                if (hasSameThuoc == false)
                {
                    HoaDon_DTO hd = new HoaDon_DTO()
                    {
                        maThuoc = Convert.ToInt32(cbThuoc.SelectedValue),
                        Thuoc = cbThuoc.Text,
                        DonViTinh = txtDVT.Text,
                        SoLuong = Convert.ToInt32(txtSoLuong.Text.Trim()),
                        DonGia = Convert.ToDecimal(txtDonGia.Text.Trim()),
                        ThanhTien = Convert.ToInt32(txtSoLuong.Text.Trim()) * Convert.ToDecimal(txtDonGia.Text.Trim())
                    };
                    HoaDon.Add(hd);

                    dgvHD.DataSource = null;
                    dgvHD.DataSource = HoaDon;
                }
                dgvHD.Columns[0].HeaderText = "Mã Thuốc";
                dgvHD.Columns[1].HeaderText = "Thuốc";
                dgvHD.Columns[2].HeaderText = "Đơn Vị Tính";
                dgvHD.Columns[3].HeaderText = "Số Lượng";
                dgvHD.Columns[4].HeaderText = "Đơn Giá";
                dgvHD.Columns[5].HeaderText = "Thành Tiền";

                decimal total = HoaDon.Sum(x => x.ThanhTien);
                txtTotal.Text = total.ToString();

                decimal tienkham = TK;
                txtTienKham.Text = tienkham.ToString();

                decimal tongcong = total + tienkham;
                txtTongCong.Text = tongcong.ToString();

                cbThuoc.SelectedIndex = -1;
                txtSoLuong.Clear();
                txtDonGia.Clear();
                txtDVT.Clear();
                cbLoaiBenh.Enabled = false;
            }
        }

        private bool IsValidated()
        {
            if (txtMaHoaDon.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu mã hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHoaDon.Focus();
                return false;
            }
            if (txtTenBN.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu tên bệnh nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenBN.Focus();
                return false;
            }
            if (txtTrieuChung.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu triệu chứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrieuChung.Focus();
                return false;
            }
            if (cbLoaiBenh.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn loại bệnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbThuoc.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn thuốc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSoLuong.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return false;
            }
            else
            {
                int tempSoLuong;
                bool isNumberic = int.TryParse(txtSoLuong.Text.Trim(), out tempSoLuong);
                if (!isNumberic)
                {
                    MessageBox.Show("Số lượng phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong.Clear();
                    txtSoLuong.Focus();
                    return false;
                }
            }
            if (txtDVT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu chọn đơn vị tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            string maHD;
            bool isMaHoaDonExisted = true;
            while (isMaHoaDonExisted)
            {
                maHD = GenerateMaHoaDon();
                isMaHoaDonExisted = check(maHD);
                txtMaHoaDon.Text = maHD;
            }
            dateNgayTao.Value = DateTime.Now;
            btnNew.Enabled = false;
            btnPrint.Enabled = true;
            btnPreview.Enabled = true;
            cbLoaiBenh.Enabled = true;
            ItemGroupBox.Enabled = true;
            txtTenBN.Focus();
        }

        private bool check(string maHD)
        {
            bool MaHoaDonExist = false;
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            int tongcong = Convert.ToInt16(txtTongCong.Text);
            using (SqlConnection cnn=new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon WHERE [maHD] = @maHD", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.Parameters.AddWithValue("@tongcong", tongcong);
                    DataTable dtAnyData = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtAnyData.Load(reader);
                    if (dtAnyData.Rows.Count > 0)
                    {
                        MaHoaDonExist = true;
                    }
                }
            }
            return MaHoaDonExist;
        }

        private static readonly Random _random = new Random();
        private string GenerateMaHoaDon()
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnPrint.Enabled = false;
            btnPreview.Enabled = false;
            ItemGroupBox.Enabled = false;
            cbLoaiBenh.Enabled = true;
            
            txtMaHoaDon.Clear();
            txtTenBN.Clear();
            txtTrieuChung.Clear();
            cbLoaiBenh.SelectedItem = -1;
            cbThuoc.SelectedItem = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaHoaDon.Clear();
            dgvHD.Focus();
            txtTotal.Text = "0";
            txtTienKham.Text = "0";
            txtTongCong.Text = "0";
            dgvHD.DataSource = null;            
        }

        private void DgvHD_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hit = dgvHD.HitTest(e.X, e.Y);
                dgvHD.Rows[hit.RowIndex].Selected = true;
                contextMenuStrip1.Show(dgvHD, e.X, e.Y);
            }
        }

        private void XóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvHD.CurrentCell.RowIndex;
            HoaDon.RemoveAt(index);
            dgvHD.DataSource = null;
            dgvHD.DataSource = HoaDon;
            decimal total = HoaDon.Sum(x => x.ThanhTien);
            txtTotal.Text = total.ToString();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.banner;
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            e.Graphics.DrawString("# Mã Hóa Đơn: " + txtMaHoaDon.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(25, 145));
            e.Graphics.DrawString("Ngày tạo: " + DateTime.Now, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(25, 175));           
            e.Graphics.DrawString("Tên bệnh nhân: " + txtTenBN.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 205));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 325));
            e.Graphics.DrawString("Triệu chứng: " + txtTrieuChung.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 235));
            e.Graphics.DrawString("Loại bệnh: " + cbLoaiBenh.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 265));
            e.Graphics.DrawString("Thuốc", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(30, 355));
            e.Graphics.DrawString("Đơn vị tính", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(310, 355));
            e.Graphics.DrawString("Số lượng", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(200, 355));
            e.Graphics.DrawString("Đơn giá", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(450, 355));
            e.Graphics.DrawString("Thành tiền", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(600, 355));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 385));

            int yPos = 415;
            for (int i = numberOfItemsPrintedSoFar; i < HoaDon.Count; i++)
            {
                numberOfItemsPerPage++;
                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrintedSoFar++;
                    if(numberOfItemsPrintedSoFar<= HoaDon.Count)
                    {
                        e.Graphics.DrawString(HoaDon[i].Thuoc, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                        e.Graphics.DrawString(HoaDon[i].DonViTinh, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(340, yPos));
                        e.Graphics.DrawString(HoaDon[i].SoLuong.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(225, yPos));
                        e.Graphics.DrawString(HoaDon[i].DonGia.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(465, yPos));
                        e.Graphics.DrawString(HoaDon[i].ThanhTien.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(625, yPos));                
                        yPos += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
            e.Graphics.DrawString("Tiền thuốc", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 30));
            e.Graphics.DrawString(txtTotal.Text.Trim() + " vnđ", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(625, yPos + 30));
            e.Graphics.DrawString("Tiền khám", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 60));
            e.Graphics.DrawString(txtTienKham.Text.Trim() + " vnđ", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(625, yPos + 60));
            e.Graphics.DrawString("Tổng cộng", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 90));
            e.Graphics.DrawString(txtTongCong.Text.Trim() + " vnđ", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(625, yPos + 90));

            //reset giá trị
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            cbThuoc.SelectedValueChanged -= cbThuoc_SelectedValueChanged;
            cbThuoc.DataSource = GettenThuoc();
            cbThuoc.DisplayMember = "tenThuoc";
            cbThuoc.ValueMember = "ID";
            cbThuoc.SelectedIndex = -1;
            cbThuoc.SelectedValueChanged += cbThuoc_SelectedValueChanged;
        }

        private DataTable GettenThuoc()
        {
            DataTable dtThuoc = new DataTable();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ID, tenThuoc FROM Thuoc", cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtThuoc.Load(reader);
                }
            }
            return dtThuoc;
        }

        private void cbThuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbThuoc.SelectedValue != null)
            {
                int maThuoc = Convert.ToInt16(cbThuoc.SelectedValue);
                decimal giaThuoc = GetgiaThuoc(maThuoc);
                txtDonGia.Text = giaThuoc.ToString();
                string donVi = GetdonVi(maThuoc);
                txtDVT.Text = donVi.ToString(); ;
            }
        }

        private decimal GetgiaThuoc(int maThuoc)
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT giaThuoc FROM Thuoc WHERE ID=@ID", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@ID", maThuoc);
                    return (decimal)cmd.ExecuteScalar();
                }
            }
        }
        private string GetdonVi(int maThuoc)
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT donviTinh FROM Thuoc WHERE ID=@ID", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@ID", maThuoc);
                    return (string)cmd.ExecuteScalar();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có thuốc để in hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                LuuHoaDon((int)Save.save);
                ResetForm();
            }
        }

        private void ResetForm()
        {
            // Clear text and data
            txtMaHoaDon.Clear();
            txtTenBN.Clear();
            txtTrieuChung.Clear();
            cbLoaiBenh.SelectedIndex = -1;
            cbThuoc.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtDVT.Clear();
            txtTotal.Text = "0";
            txtTienKham.Text = "0";
            txtTongCong.Text = "0";

            // Clear the DataGridView and the internal List
            HoaDon.Clear();
            dgvHD.DataSource = null;

            // Handle Control States
            btnNew.Enabled = true;         // Enable New
            btnPrint.Enabled = false;       // Disable Print
            btnPreview.Enabled = false;     // Disable Preview
            ItemGroupBox.Enabled = false;   // Disable GroupBox containing inputs

            // Specifically keep DateNgayTao enabled or untouched as requested
            // dateNgayTao.Value = DateTime.Now; // Uncomment this if you want to refresh the time too

            dgvHD.Focus();
        }

        private void LuuHoaDon(int luu)
        {
            try
            {
                string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [HoaDon](maHD,ngaytao,tenBN,tienthuoc,tongcong,donviTinh) VALUES (@maHD,@ngaytao,@tenBN,@tienthuoc,@tongcong,@donviTinh)", cnn))
                    {
                        cmd.Parameters.AddWithValue("@maHD", txtMaHoaDon.Text);
                        cmd.Parameters.AddWithValue("@ngaytao", dateNgayTao.Value);
                        cmd.Parameters.AddWithValue("@tenBN", txtTenBN.Text);
                        cmd.Parameters.AddWithValue("@tienthuoc", Convert.ToDecimal(txtTotal.Text));
                        cmd.Parameters.AddWithValue("@tongcong", Convert.ToDecimal(txtTongCong.Text));
                        cmd.Parameters.AddWithValue("@donviTinh", txtDVT.Text);

                        cmd.ExecuteNonQuery();
                    }

                    foreach (DataGridViewRow row in dgvHD.Rows)
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO [ThongKe](maHD,maThuoc,tenThuoc,donviTinh,soLuong,donGia,thanhTien) VALUES (@maHD,@maThuoc,@tenThuoc,@donviTinh,@soLuong,@donGia,@thanhTien)", cnn))
                        {
                            cmd.Parameters.AddWithValue("@maHD", txtMaHoaDon.Text);
                            cmd.Parameters.AddWithValue("@maThuoc", Convert.ToInt32(row.Cells["maThuoc"].Value));
                            cmd.Parameters.AddWithValue("@tenThuoc", Convert.ToString(row.Cells["Thuoc"].Value));
                            cmd.Parameters.AddWithValue("@donviTinh", Convert.ToString(row.Cells["DonViTinh"].Value));
                            cmd.Parameters.AddWithValue("@soLuong", Convert.ToInt32(row.Cells["SoLuong"].Value));
                            cmd.Parameters.AddWithValue("@donGia", Convert.ToDecimal(row.Cells["DonGia"].Value));
                            cmd.Parameters.AddWithValue("@thanhTien", Convert.ToDecimal(row.Cells["ThanhTien"].Value));

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Đã in hóa đơn", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DateNgayTao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtTongCong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
