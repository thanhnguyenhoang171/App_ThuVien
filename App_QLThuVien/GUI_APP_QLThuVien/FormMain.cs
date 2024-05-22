using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace GUI_APP_QLThuVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SachBUS.Instance.Xem(dGVSach);
       
            
            TheThuVienBUS.Instance.Xem(dGVTheThuVien);
            MuonTraBUS.Instance.Xem(dGVMuonTra);
        }

        private void LamMoiTextbox ()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtSoLuong.Clear();
            txtMoTa.Clear();
            txtTheLoai.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtGia.Clear();
            txtHoTen.Clear();
            txtMaGD.Clear();
            txtMaSachMT.Clear();
            txtMaThe.Clear();
            txtMaTheMT.Clear();
            txtTienPhat.Clear();
      
            
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void lblTittle_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (SachBUS.Instance.Sua(dGVSach))
            {
                MessageBox.Show("Sửa dữ liệu Sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                     
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu Sách thất bại! \nVui lòng kiểm tra lại dữ liệu nhập vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      
            }
            SachBUS.Instance.Xem(dGVSach);
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {

            if (SachBUS.Instance.Xoa(dGVSach))
            {
                MessageBox.Show("Xoá dữ liệu Sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể xoá Sách này vì vẫn còn giao dịch Mượn Trả chưa hoàn thành.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MuonTraBUS.Instance.Xem(dGVMuonTra);
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            string tacGia = txtTacGia.Text;
            string theLoai = txtTheLoai.Text;

            int soLuong ;
            string moTa = txtMoTa.Text;

            decimal giaSach;
        

            int namXB = dtpNamXB.Value.Year;

            if (string.IsNullOrWhiteSpace(txtMaSach.Text) || string.IsNullOrWhiteSpace(txtTenSach.Text) || string.IsNullOrWhiteSpace(txtTacGia.Text) || string.IsNullOrWhiteSpace(txtTheLoai.Text) || string.IsNullOrWhiteSpace(txtMoTa.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtGia.Text) || dtpNamXB.Value == null)
            {
                MessageBox.Show("Vui lòng không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

             
            
                if (maSach.Length > 5)
                {  
                    MessageBox.Show("Mã Sách phải tối đa là 5 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (tenSach.Length > 255)
                {
                    MessageBox.Show("Tên Sách phải tối đa là 255 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (theLoai.Length > 150)
                {
                    MessageBox.Show("Thể Loại phải tối đa là 150 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (moTa.Length > 150)
                {
                    MessageBox.Show("Mô Tả phải tối đa là 150 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tacGia.Length > 100)
                {
                    MessageBox.Show("Tác Giả phải tối da là 100 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong < 0)
                {
                    MessageBox.Show("Số Lượng Hiện có phải là số nguyên không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtGia.Text, out giaSach) || giaSach < 0)
                {
                    MessageBox.Show("Giá Sách phải số âm", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (namXB.ToString().Length > 4)
                {
                    MessageBox.Show("Năm Xuất Bản không hợp lệ", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (SachBUS.Instance.Them(maSach, tenSach, tacGia, theLoai, soLuong, moTa, giaSach, namXB))
                {
                    MessageBox.Show("Thêm Sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SachBUS.Instance.Xem(dGVSach);
                    LamMoiTextbox();
                }
                else
                {
                    MessageBox.Show("Thêm Sách thất bại. \nCó thể Mã Sách đã tồn tại \nVui lòng kiểm tra lại.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQLTheTV_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTheThuVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuaTheThuVien_Click(object sender, EventArgs e)
        {
            if (TheThuVienBUS.Instance.Sua(dGVTheThuVien))
            {
                MessageBox.Show("Sửa dữ liệu Thẻ Thư Viện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

            }
            else
            {
                MessageBox.Show("Sửa dữ liệu Thẻ Thư Viện thất bại!. \nVui lòng kiểm tra lại dữ liệu nhập vào", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
            }
            TheThuVienBUS.Instance.Xem(dGVTheThuVien);
        }

        private void btnThemTheThuVien_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text;
            string hoTen = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string dienThoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            DateTime ngayDK = dtpNgayDK.Value; 
            DateTime ngayHH = dtpNgayHH.Value;

            if (string.IsNullOrWhiteSpace(txtMaThe.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || dtpNgayDK.Value == null || dtpNgayDK.Value == DateTime.MinValue || dtpNgayHH.Value == null || dtpNgayHH.Value == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Kiểm tra dữ liệu
                if (maThe.Length > 5)
                {
                    MessageBox.Show("Mã Thẻ phải tối đa là 5 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (hoTen.Length > 100)
                {
                    MessageBox.Show("Họ Tên phải tối đa là 100 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (diaChi.Length > 255)
                {
                    MessageBox.Show("Địa Chỉ phải tối đa là 255 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dienThoai.Length != 10)
                {
                    MessageBox.Show("Số Điện Thoại không hợp lệ", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (email.Length > 255)
                {
                    MessageBox.Show("Email phải tối da là 255 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ngayDK > ngayHH)
                {
                    MessageBox.Show("Ngày Đăng Ký đang lớn hơn Ngày Hết Hạn", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TheThuVienBUS.Instance.Them(maThe, hoTen, diaChi, dienThoai, email, ngayDK, ngayHH))
                {
                    MessageBox.Show("Thêm Thẻ Thư Viện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TheThuVienBUS.Instance.Xem(dGVTheThuVien);
                    LamMoiTextbox();
                }
                else
                {
                    MessageBox.Show("Thêm Thẻ Thư Viện thất bại!. \n Có thể Mã Thẻ đã tồn tại. Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btnXoaTheThuVien_Click(object sender, EventArgs e)
        {
            if (TheThuVienBUS.Instance.Xoa(dGVTheThuVien))
            {
                MessageBox.Show("Xoá dữ liệu Thẻ Thư Viện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MuonTraBUS.Instance.Xem(dGVMuonTra);
     
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu Thẻ Thư Viện thất bại thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
  

            }
        }

        private void panelSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTittleSachMN_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMuonTra_Click(object sender, EventArgs e)
        {
            string maGiaoDich = txtMaGD.Text;
            string maSach = txtMaSachMT.Text;
            string maThe = txtMaTheMT.Text;
            
            DateTime ngayMuon = dtpNgayMuon.Value; 
            DateTime ngayTra = dtpNgayTra.Value;
            string trangThai = cbxTrangThai.Text;
            decimal tienPhat;
            if (string.IsNullOrWhiteSpace(txtMaGD.Text) || string.IsNullOrWhiteSpace(txtMaSachMT.Text) || string.IsNullOrWhiteSpace(txtMaTheMT.Text) || string.IsNullOrWhiteSpace(cbxTrangThai.Text) || string.IsNullOrWhiteSpace(txtTienPhat.Text) || dtpNgayMuon.Value == null || dtpNgayMuon.Value == DateTime.MinValue || dtpNgayTra.Value == null || dtpNgayTra.Value == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Kiểm tra dữ liệu
                if (maGiaoDich.Length > 5)
                {
                    MessageBox.Show("Giao Dịch phải tối đa là 5 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (maSach.Length > 5)
                {
                    MessageBox.Show("Mã Sách phải tối đa là 5 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (maThe.Length > 5)
                {
                    MessageBox.Show("Mã Thẻ phải tối đa là 5 ký tự.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ngayMuon > ngayTra)
                {
                    MessageBox.Show("Ngày Mượn đang lớn hơn Ngày Trả", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtTienPhat.Text, out tienPhat) || tienPhat < 0)
                {
                    MessageBox.Show("Số Tiền Phạt phải là số không âm", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MuonTraBUS.Instance.Them(maGiaoDich, maSach, maThe, ngayMuon, ngayTra, tienPhat, trangThai))
                {
                    MessageBox.Show("Thêm Mượn Trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MuonTraBUS.Instance.Xem(dGVMuonTra);
                    SachBUS.Instance.Xem(dGVSach);
                    LamMoiTextbox();
                }
                else
                {
                    MessageBox.Show("Có thể Mã Giao Dịch đã tồn tại\nHoặc Mã Thẻ, Mã Sách không tồn tại \nHoặc do Số Lượng hiện có cho sách này đã hết không thể mượn.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaMuonTra_Click(object sender, EventArgs e)
        {
            if (MuonTraBUS.Instance.Xoa(dGVMuonTra))
            {
                MessageBox.Show("Xoá dữ liệu Mượn Trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu Mượn Trả thất bại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSuaMuonTra_Click(object sender, EventArgs e)
        {
            if (MuonTraBUS.Instance.Sua(dGVMuonTra))
            {
                MessageBox.Show("Sửa dữ liệu Mượn trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SachBUS.Instance.Xem(dGVSach);
            }
            else
            {
                MessageBox.Show("Không thể sửa đổi Mượn trả có thể do số lượng hiện có của sách đã hết hoặc bạn đã nhập sai dữ liệu sửa đổi", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MuonTraBUS.Instance.Xem(dGVMuonTra);
        }

        private void dGVMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thanhnguyenhoang171/BT_QTCSDL_App_ThuVien");
        }
    }
}
