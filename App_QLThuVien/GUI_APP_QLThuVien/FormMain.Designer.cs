namespace GUI_APP_QLThuVien
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTittle = new System.Windows.Forms.Label();
            this.panelSach = new System.Windows.Forms.Panel();
            this.dGVSach = new System.Windows.Forms.DataGridView();
            this.dtpNamXB = new System.Windows.Forms.DateTimePicker();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblNamXB = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTittleSachMN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGVTheThuVien = new System.Windows.Forms.DataGridView();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.btnSuaTheThuVien = new System.Windows.Forms.Button();
            this.btnXoaTheThuVien = new System.Windows.Forms.Button();
            this.btnThemTheThuVien = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNgayDK = new System.Windows.Forms.Label();
            this.lblNgayHH = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaThe = new System.Windows.Forms.Label();
            this.lblQLTheTV = new System.Windows.Forms.Label();
            this.panelSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTheThuVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTittle.Location = new System.Drawing.Point(732, 7);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(338, 45);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Quản Lý Thư Viện";
            this.lblTittle.Click += new System.EventHandler(this.lblTittle_Click);
            // 
            // panelSach
            // 
            this.panelSach.BackColor = System.Drawing.Color.Azure;
            this.panelSach.Controls.Add(this.dGVSach);
            this.panelSach.Controls.Add(this.dtpNamXB);
            this.panelSach.Controls.Add(this.btnSuaSach);
            this.panelSach.Controls.Add(this.btnXoaSach);
            this.panelSach.Controls.Add(this.btnThemSach);
            this.panelSach.Controls.Add(this.txtGia);
            this.panelSach.Controls.Add(this.txtSoLuong);
            this.panelSach.Controls.Add(this.txtMoTa);
            this.panelSach.Controls.Add(this.txtTacGia);
            this.panelSach.Controls.Add(this.txtTheLoai);
            this.panelSach.Controls.Add(this.txtTenSach);
            this.panelSach.Controls.Add(this.txtMaSach);
            this.panelSach.Controls.Add(this.lblNamXB);
            this.panelSach.Controls.Add(this.lblGia);
            this.panelSach.Controls.Add(this.lblMoTa);
            this.panelSach.Controls.Add(this.lblSoLuong);
            this.panelSach.Controls.Add(this.lblTheLoai);
            this.panelSach.Controls.Add(this.lblTacGia);
            this.panelSach.Controls.Add(this.lblTenSach);
            this.panelSach.Controls.Add(this.lblMaSach);
            this.panelSach.ForeColor = System.Drawing.Color.White;
            this.panelSach.Location = new System.Drawing.Point(60, 70);
            this.panelSach.Name = "panelSach";
            this.panelSach.Size = new System.Drawing.Size(1256, 390);
            this.panelSach.TabIndex = 1;
            // 
            // dGVSach
            // 
            this.dGVSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVSach.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dGVSach.Location = new System.Drawing.Point(413, 18);
            this.dGVSach.Name = "dGVSach";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVSach.RowHeadersWidth = 51;
            this.dGVSach.RowTemplate.Height = 24;
            this.dGVSach.Size = new System.Drawing.Size(815, 314);
            this.dGVSach.TabIndex = 12;
            // 
            // dtpNamXB
            // 
            this.dtpNamXB.CustomFormat = "yyyy";
            this.dtpNamXB.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNamXB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamXB.Location = new System.Drawing.Point(165, 161);
            this.dtpNamXB.Name = "dtpNamXB";
            this.dtpNamXB.Size = new System.Drawing.Size(223, 22);
            this.dtpNamXB.TabIndex = 5;
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuaSach.Location = new System.Drawing.Point(319, 343);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(77, 33);
            this.btnSuaSach.TabIndex = 11;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = false;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoaSach.Location = new System.Drawing.Point(205, 343);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(77, 33);
            this.btnXoaSach.TabIndex = 10;
            this.btnXoaSach.Text = "Xoá";
            this.btnXoaSach.UseVisualStyleBackColor = false;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemSach.Location = new System.Drawing.Point(98, 343);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(77, 33);
            this.btnThemSach.TabIndex = 9;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(165, 310);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(223, 22);
            this.txtGia.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(165, 271);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(223, 22);
            this.txtSoLuong.TabIndex = 7;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(165, 199);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(223, 57);
            this.txtMoTa.TabIndex = 6;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(165, 124);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(223, 22);
            this.txtTacGia.TabIndex = 4;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(165, 88);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(223, 22);
            this.txtTheLoai.TabIndex = 3;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(165, 53);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(223, 22);
            this.txtTenSach.TabIndex = 2;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(165, 18);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(223, 22);
            this.txtMaSach.TabIndex = 1;
            // 
            // lblNamXB
            // 
            this.lblNamXB.AutoSize = true;
            this.lblNamXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamXB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNamXB.Location = new System.Drawing.Point(18, 164);
            this.lblNamXB.Name = "lblNamXB";
            this.lblNamXB.Size = new System.Drawing.Size(112, 19);
            this.lblNamXB.TabIndex = 0;
            this.lblNamXB.Text = "Năm Xuất Bản:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGia.Location = new System.Drawing.Point(18, 313);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(38, 19);
            this.lblGia.TabIndex = 0;
            this.lblGia.Text = "Giá:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoTa.Location = new System.Drawing.Point(18, 219);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(58, 19);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Mô Tả:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoLuong.Location = new System.Drawing.Point(18, 274);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(141, 19);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số Lượng Hiện Có:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTheLoai.Location = new System.Drawing.Point(18, 90);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(74, 19);
            this.lblTheLoai.TabIndex = 0;
            this.lblTheLoai.Text = "Thể Loại:";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTacGia.Location = new System.Drawing.Point(18, 124);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(66, 19);
            this.lblTacGia.TabIndex = 0;
            this.lblTacGia.Text = "Tác Giả:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTenSach.Location = new System.Drawing.Point(18, 55);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(75, 19);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên Sách:";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaSach.Location = new System.Drawing.Point(21, 19);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(72, 19);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã Sách:";
            // 
            // lblTittleSachMN
            // 
            this.lblTittleSachMN.AutoSize = true;
            this.lblTittleSachMN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittleSachMN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTittleSachMN.Location = new System.Drawing.Point(20, 44);
            this.lblTittleSachMN.Name = "lblTittleSachMN";
            this.lblTittleSachMN.Size = new System.Drawing.Size(120, 20);
            this.lblTittleSachMN.TabIndex = 0;
            this.lblTittleSachMN.Text = "Quản Lý Sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.dGVTheThuVien);
            this.panel1.Controls.Add(this.dtpNgayHH);
            this.panel1.Controls.Add(this.dtpNgayDK);
            this.panel1.Controls.Add(this.btnSuaTheThuVien);
            this.panel1.Controls.Add(this.btnXoaTheThuVien);
            this.panel1.Controls.Add(this.btnThemTheThuVien);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDienThoai);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtMaThe);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblNgayDK);
            this.panel1.Controls.Add(this.lblNgayHH);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.lblHoTen);
            this.panel1.Controls.Add(this.lblMaThe);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 329);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dGVTheThuVien
            // 
            this.dGVTheThuVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVTheThuVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVTheThuVien.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVTheThuVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVTheThuVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVTheThuVien.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGVTheThuVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dGVTheThuVien.Location = new System.Drawing.Point(412, 18);
            this.dGVTheThuVien.Name = "dGVTheThuVien";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVTheThuVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGVTheThuVien.RowHeadersWidth = 51;
            this.dGVTheThuVien.RowTemplate.Height = 24;
            this.dGVTheThuVien.Size = new System.Drawing.Size(517, 236);
            this.dGVTheThuVien.TabIndex = 5;
            // 
            // dtpNgayHH
            // 
            this.dtpNgayHH.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayHH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHH.Location = new System.Drawing.Point(165, 232);
            this.dtpNgayHH.Name = "dtpNgayHH";
            this.dtpNgayHH.Size = new System.Drawing.Size(223, 22);
            this.dtpNgayHH.TabIndex = 4;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayDK.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDK.Location = new System.Drawing.Point(165, 197);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(223, 22);
            this.dtpNgayDK.TabIndex = 4;
            // 
            // btnSuaTheThuVien
            // 
            this.btnSuaTheThuVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaTheThuVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTheThuVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuaTheThuVien.Location = new System.Drawing.Point(284, 286);
            this.btnSuaTheThuVien.Name = "btnSuaTheThuVien";
            this.btnSuaTheThuVien.Size = new System.Drawing.Size(77, 33);
            this.btnSuaTheThuVien.TabIndex = 2;
            this.btnSuaTheThuVien.Text = "Sửa";
            this.btnSuaTheThuVien.UseVisualStyleBackColor = false;
            this.btnSuaTheThuVien.Click += new System.EventHandler(this.btnSuaTheThuVien_Click);
            // 
            // btnXoaTheThuVien
            // 
            this.btnXoaTheThuVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaTheThuVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTheThuVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoaTheThuVien.Location = new System.Drawing.Point(171, 286);
            this.btnXoaTheThuVien.Name = "btnXoaTheThuVien";
            this.btnXoaTheThuVien.Size = new System.Drawing.Size(77, 33);
            this.btnXoaTheThuVien.TabIndex = 2;
            this.btnXoaTheThuVien.Text = "Xoá";
            this.btnXoaTheThuVien.UseVisualStyleBackColor = false;
            this.btnXoaTheThuVien.Click += new System.EventHandler(this.btnXoaTheThuVien_Click);
            // 
            // btnThemTheThuVien
            // 
            this.btnThemTheThuVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemTheThuVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTheThuVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemTheThuVien.Location = new System.Drawing.Point(63, 286);
            this.btnThemTheThuVien.Name = "btnThemTheThuVien";
            this.btnThemTheThuVien.Size = new System.Drawing.Size(77, 33);
            this.btnThemTheThuVien.TabIndex = 2;
            this.btnThemTheThuVien.Text = "Thêm";
            this.btnThemTheThuVien.UseVisualStyleBackColor = false;
            this.btnThemTheThuVien.Click += new System.EventHandler(this.btnThemTheThuVien_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(165, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(165, 124);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(223, 22);
            this.txtDienThoai.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(165, 88);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(223, 22);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(165, 53);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(223, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Location = new System.Drawing.Point(165, 18);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(223, 22);
            this.txtMaThe.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(19, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblNgayDK
            // 
            this.lblNgayDK.AutoSize = true;
            this.lblNgayDK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNgayDK.Location = new System.Drawing.Point(19, 198);
            this.lblNgayDK.Name = "lblNgayDK";
            this.lblNgayDK.Size = new System.Drawing.Size(112, 19);
            this.lblNgayDK.TabIndex = 0;
            this.lblNgayDK.Text = "Ngày Đăng Ký:";
            // 
            // lblNgayHH
            // 
            this.lblNgayHH.AutoSize = true;
            this.lblNgayHH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNgayHH.Location = new System.Drawing.Point(19, 234);
            this.lblNgayHH.Name = "lblNgayHH";
            this.lblNgayHH.Size = new System.Drawing.Size(109, 19);
            this.lblNgayHH.TabIndex = 0;
            this.lblNgayHH.Text = "Ngày Hết Hạn:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiaChi.Location = new System.Drawing.Point(18, 90);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(66, 19);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSDT.Location = new System.Drawing.Point(18, 124);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(43, 19);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoTen.Location = new System.Drawing.Point(18, 55);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(82, 19);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và Tên:";
            // 
            // lblMaThe
            // 
            this.lblMaThe.AutoSize = true;
            this.lblMaThe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaThe.Location = new System.Drawing.Point(18, 18);
            this.lblMaThe.Name = "lblMaThe";
            this.lblMaThe.Size = new System.Drawing.Size(65, 19);
            this.lblMaThe.TabIndex = 0;
            this.lblMaThe.Text = "Mã Thẻ:";
            // 
            // lblQLTheTV
            // 
            this.lblQLTheTV.AutoSize = true;
            this.lblQLTheTV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLTheTV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQLTheTV.Location = new System.Drawing.Point(20, 474);
            this.lblQLTheTV.Name = "lblQLTheTV";
            this.lblQLTheTV.Size = new System.Drawing.Size(189, 20);
            this.lblQLTheTV.TabIndex = 5;
            this.lblQLTheTV.Text = "Quản Lý Thẻ Thư Viện";
            this.lblQLTheTV.Click += new System.EventHandler(this.lblQLTheTV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblQLTheTV);
            this.Controls.Add(this.panelSach);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblTittleSachMN);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Quản Lý Thư Viện - HQTCSDL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSach.ResumeLayout(false);
            this.panelSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTheThuVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel panelSach;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTittleSachMN;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.DateTimePicker dtpNamXB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.Button btnSuaTheThuVien;
        private System.Windows.Forms.Button btnXoaTheThuVien;
        private System.Windows.Forms.Button btnThemTheThuVien;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNgayDK;
        private System.Windows.Forms.Label lblNgayHH;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaThe;
        private System.Windows.Forms.Label lblQLTheTV;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dGVSach;
        private System.Windows.Forms.DataGridView dGVTheThuVien;
    }
}