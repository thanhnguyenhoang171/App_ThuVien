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
            this.lblTittle = new System.Windows.Forms.Label();
            this.panelSach = new System.Windows.Forms.Panel();
            this.dtpNamXB = new System.Windows.Forms.DateTimePicker();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnXemSach = new System.Windows.Forms.Button();
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
            this.panelSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTittle.Location = new System.Drawing.Point(788, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(338, 45);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Quản Lý Thư Viện";
            // 
            // panelSach
            // 
            this.panelSach.BackColor = System.Drawing.Color.Azure;
            this.panelSach.Controls.Add(this.dtpNamXB);
            this.panelSach.Controls.Add(this.dgvSach);
            this.panelSach.Controls.Add(this.btnXemSach);
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
            this.panelSach.Location = new System.Drawing.Point(55, 99);
            this.panelSach.Name = "panelSach";
            this.panelSach.Size = new System.Drawing.Size(1082, 390);
            this.panelSach.TabIndex = 1;
            // 
            // dtpNamXB
            // 
            this.dtpNamXB.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNamXB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNamXB.Location = new System.Drawing.Point(165, 161);
            this.dtpNamXB.Name = "dtpNamXB";
            this.dtpNamXB.Size = new System.Drawing.Size(223, 22);
            this.dtpNamXB.TabIndex = 4;
            // 
            // dgvSach
            // 
            this.dgvSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSach.Location = new System.Drawing.Point(506, 24);
            this.dgvSach.Name = "dgvSach";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(527, 309);
            this.dgvSach.TabIndex = 3;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // btnXemSach
            // 
            this.btnXemSach.BackColor = System.Drawing.Color.Yellow;
            this.btnXemSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXemSach.Location = new System.Drawing.Point(728, 343);
            this.btnXemSach.Name = "btnXemSach";
            this.btnXemSach.Size = new System.Drawing.Size(77, 33);
            this.btnXemSach.TabIndex = 2;
            this.btnXemSach.Text = "Xem";
            this.btnXemSach.UseVisualStyleBackColor = false;
            this.btnXemSach.Click += new System.EventHandler(this.btnXemSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuaSach.Location = new System.Drawing.Point(319, 343);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(77, 33);
            this.btnSuaSach.TabIndex = 2;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = false;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoaSach.Location = new System.Drawing.Point(205, 343);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(77, 33);
            this.btnXoaSach.TabIndex = 2;
            this.btnXoaSach.Text = "Xoá";
            this.btnXoaSach.UseVisualStyleBackColor = false;
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemSach.Location = new System.Drawing.Point(98, 343);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(77, 33);
            this.btnThemSach.TabIndex = 2;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = false;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(165, 310);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(223, 22);
            this.txtGia.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(165, 271);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(223, 22);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(165, 199);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(223, 57);
            this.txtMoTa.TabIndex = 1;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(165, 124);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(223, 22);
            this.txtTacGia.TabIndex = 1;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(165, 88);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(223, 22);
            this.txtTheLoai.TabIndex = 1;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(165, 53);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(223, 22);
            this.txtTenSach.TabIndex = 1;
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
            this.lblMaSach.Location = new System.Drawing.Point(18, 18);
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
            this.lblTittleSachMN.Location = new System.Drawing.Point(51, 74);
            this.lblTittleSachMN.Name = "lblTittleSachMN";
            this.lblTittleSachMN.Size = new System.Drawing.Size(120, 20);
            this.lblTittleSachMN.TabIndex = 0;
            this.lblTittleSachMN.Text = "Quản Lý Sách";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DateTimePicker dtpNamXB;
        private System.Windows.Forms.Button btnXemSach;
    }
}