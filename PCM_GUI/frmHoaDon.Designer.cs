namespace PCM_GUI
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.ItemGroupBox = new System.Windows.Forms.GroupBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.lbDVT = new System.Windows.Forms.Label();
            this.dateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.lbNgayTao = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.cbLoaiBenh = new System.Windows.Forms.ComboBox();
            this.cbThuoc = new System.Windows.Forms.ComboBox();
            this.lbThuoc = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lbLoaiBenh = new System.Windows.Forms.Label();
            this.lbTrieuChung = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.lbTenBN = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbUnit = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.Controls.Add(this.txtDVT);
            this.ItemGroupBox.Controls.Add(this.lbDVT);
            this.ItemGroupBox.Controls.Add(this.dateNgayTao);
            this.ItemGroupBox.Controls.Add(this.lbNgayTao);
            this.ItemGroupBox.Controls.Add(this.txtMaHoaDon);
            this.ItemGroupBox.Controls.Add(this.lbMaHoaDon);
            this.ItemGroupBox.Controls.Add(this.btnAdd);
            this.ItemGroupBox.Controls.Add(this.txtDonGia);
            this.ItemGroupBox.Controls.Add(this.txtSoLuong);
            this.ItemGroupBox.Controls.Add(this.lbDonGia);
            this.ItemGroupBox.Controls.Add(this.lbSoLuong);
            this.ItemGroupBox.Controls.Add(this.cbLoaiBenh);
            this.ItemGroupBox.Controls.Add(this.cbThuoc);
            this.ItemGroupBox.Controls.Add(this.lbThuoc);
            this.ItemGroupBox.Controls.Add(this.txtTrieuChung);
            this.ItemGroupBox.Controls.Add(this.lbLoaiBenh);
            this.ItemGroupBox.Controls.Add(this.lbTrieuChung);
            this.ItemGroupBox.Controls.Add(this.txtTenBN);
            this.ItemGroupBox.Controls.Add(this.lbTenBN);
            this.ItemGroupBox.Enabled = false;
            this.ItemGroupBox.Location = new System.Drawing.Point(16, 15);
            this.ItemGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemGroupBox.Size = new System.Drawing.Size(973, 315);
            this.ItemGroupBox.TabIndex = 0;
            this.ItemGroupBox.TabStop = false;
            // 
            // txtDVT
            // 
            this.txtDVT.BackColor = System.Drawing.SystemColors.Control;
            this.txtDVT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDVT.Location = new System.Drawing.Point(119, 272);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.ReadOnly = true;
            this.txtDVT.Size = new System.Drawing.Size(123, 15);
            this.txtDVT.TabIndex = 21;
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Location = new System.Drawing.Point(27, 272);
            this.lbDVT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(70, 16);
            this.lbDVT.TabIndex = 20;
            this.lbDVT.Text = "Đơn vị tính:";
            this.lbDVT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateNgayTao
            // 
            this.dateNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTao.Location = new System.Drawing.Point(492, 37);
            this.dateNgayTao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateNgayTao.Name = "dateNgayTao";
            this.dateNgayTao.Size = new System.Drawing.Size(121, 22);
            this.dateNgayTao.TabIndex = 19;
            this.dateNgayTao.ValueChanged += new System.EventHandler(this.DateNgayTao_ValueChanged);
            // 
            // lbNgayTao
            // 
            this.lbNgayTao.AutoSize = true;
            this.lbNgayTao.Location = new System.Drawing.Point(415, 41);
            this.lbNgayTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayTao.Name = "lbNgayTao";
            this.lbNgayTao.Size = new System.Drawing.Size(65, 16);
            this.lbNgayTao.TabIndex = 18;
            this.lbNgayTao.Text = "Ngày tạo:";
            this.lbNgayTao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHoaDon.Location = new System.Drawing.Point(145, 37);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(261, 15);
            this.txtMaHoaDon.TabIndex = 17;
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Location = new System.Drawing.Point(27, 41);
            this.lbMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(85, 16);
            this.lbMaHoaDon.TabIndex = 16;
            this.lbMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(701, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 229);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm vào hóa đơn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonGia.Location = new System.Drawing.Point(492, 226);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(123, 15);
            this.txtDonGia.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(319, 226);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 22);
            this.txtSoLuong.TabIndex = 11;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(488, 207);
            this.lbDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(56, 16);
            this.lbDonGia.TabIndex = 10;
            this.lbDonGia.Text = "Đơn giá:";
            this.lbDonGia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(315, 207);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(63, 16);
            this.lbSoLuong.TabIndex = 9;
            this.lbSoLuong.Text = "Số lượng:";
            this.lbSoLuong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbLoaiBenh
            // 
            this.cbLoaiBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiBenh.FormattingEnabled = true;
            this.cbLoaiBenh.Items.AddRange(new object[] {
            "Nhức đầu",
            "Đau bụng",
            "Đau bao tử",
            "Sốt",
            "Tiêu chảy"});
            this.cbLoaiBenh.Location = new System.Drawing.Point(145, 158);
            this.cbLoaiBenh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLoaiBenh.Name = "cbLoaiBenh";
            this.cbLoaiBenh.Size = new System.Drawing.Size(468, 24);
            this.cbLoaiBenh.TabIndex = 8;
            // 
            // cbThuoc
            // 
            this.cbThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThuoc.FormattingEnabled = true;
            this.cbThuoc.Items.AddRange(new object[] {
            "Paracetamol",
            "Alaxan",
            "Decolgen",
            "Hapacol Codein",
            "Panadol Extra",
            "Phosphalugel",
            "Yumangel",
            "Gastropulgite",
            "Gaviscon",
            "Trimafort",
            "Penicillin",
            "Amoxillin",
            "Aspirin",
            "Codein Sunfat",
            "Pepto-Bismol",
            "Domperidon",
            "Maalox",
            "Carbotrim",
            "Floctafenine",
            "Tramadol",
            "Opioid Morphin",
            "Fentanyl",
            "Oxycodone",
            "Naproxen",
            "Acetaminophen",
            "Efferalgan",
            "Tiffy",
            "Yuraf",
            "Coldacmin",
            "E-cox 90"});
            this.cbThuoc.Location = new System.Drawing.Point(31, 226);
            this.cbThuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbThuoc.Name = "cbThuoc";
            this.cbThuoc.Size = new System.Drawing.Size(237, 24);
            this.cbThuoc.TabIndex = 7;
            this.cbThuoc.SelectedValueChanged += new System.EventHandler(this.cbThuoc_SelectedValueChanged);
            // 
            // lbThuoc
            // 
            this.lbThuoc.AutoSize = true;
            this.lbThuoc.Location = new System.Drawing.Point(27, 207);
            this.lbThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThuoc.Name = "lbThuoc";
            this.lbThuoc.Size = new System.Drawing.Size(48, 16);
            this.lbThuoc.TabIndex = 6;
            this.lbThuoc.Text = "Thuốc:";
            this.lbThuoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(145, 114);
            this.txtTrieuChung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(468, 22);
            this.txtTrieuChung.TabIndex = 5;
            // 
            // lbLoaiBenh
            // 
            this.lbLoaiBenh.AutoSize = true;
            this.lbLoaiBenh.Location = new System.Drawing.Point(27, 161);
            this.lbLoaiBenh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiBenh.Name = "lbLoaiBenh";
            this.lbLoaiBenh.Size = new System.Drawing.Size(69, 16);
            this.lbLoaiBenh.TabIndex = 3;
            this.lbLoaiBenh.Text = "Loại bệnh:";
            this.lbLoaiBenh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTrieuChung
            // 
            this.lbTrieuChung.AutoSize = true;
            this.lbTrieuChung.Location = new System.Drawing.Point(27, 118);
            this.lbTrieuChung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTrieuChung.Name = "lbTrieuChung";
            this.lbTrieuChung.Size = new System.Drawing.Size(80, 16);
            this.lbTrieuChung.TabIndex = 2;
            this.lbTrieuChung.Text = "Triệu chứng:";
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(145, 75);
            this.txtTenBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(468, 22);
            this.txtTenBN.TabIndex = 1;
            // 
            // lbTenBN
            // 
            this.lbTenBN.AutoSize = true;
            this.lbTenBN.Location = new System.Drawing.Point(27, 79);
            this.lbTenBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenBN.Name = "lbTenBN";
            this.lbTenBN.Size = new System.Drawing.Size(99, 16);
            this.lbTenBN.TabIndex = 0;
            this.lbTenBN.Text = "Tên bệnh nhân:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(997, 44);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(179, 70);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Hóa Đơn Mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(997, 154);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 70);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In Hóa Đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(997, 260);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(179, 70);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Xem Trước Hóa Đơn";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AllowUserToDeleteRows = false;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(16, 352);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHD.MultiSelect = false;
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD.Size = new System.Drawing.Size(1159, 222);
            this.dgvHD.TabIndex = 4;
            this.dgvHD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvHD_MouseDown);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(997, 607);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(123, 15);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(899, 609);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(72, 16);
            this.lbTotal.TabIndex = 18;
            this.lbTotal.Text = "Tiền thuốc:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(1135, 609);
            this.lbUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(29, 16);
            this.lbUnit.TabIndex = 20;
            this.lbUnit.Text = "vnđ";
            this.lbUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.XóaToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1135, 633);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "vnđ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTienKham
            // 
            this.txtTienKham.BackColor = System.Drawing.SystemColors.Control;
            this.txtTienKham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienKham.Location = new System.Drawing.Point(997, 630);
            this.txtTienKham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.ReadOnly = true;
            this.txtTienKham.Size = new System.Drawing.Size(123, 15);
            this.txtTienKham.TabIndex = 22;
            this.txtTienKham.Text = "0";
            this.txtTienKham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(899, 633);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tiền khám:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1135, 656);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "vnđ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTongCong
            // 
            this.txtTongCong.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongCong.Location = new System.Drawing.Point(997, 654);
            this.txtTongCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.Size = new System.Drawing.Size(123, 15);
            this.txtTongCong.TabIndex = 25;
            this.txtTongCong.Text = "0";
            this.txtTongCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTongCong.TextChanged += new System.EventHandler(this.TxtTongCong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 656);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tổng cộng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1192, 764);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongCong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTienKham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.ItemGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.ItemGroupBox.ResumeLayout(false);
            this.ItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemGroupBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.ComboBox cbLoaiBenh;
        private System.Windows.Forms.ComboBox cbThuoc;
        private System.Windows.Forms.Label lbThuoc;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lbLoaiBenh;
        private System.Windows.Forms.Label lbTrieuChung;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label lbTenBN;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNgayTao;
        private System.Windows.Forms.Label lbNgayTao;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.TextBox txtDVT;
    }
}