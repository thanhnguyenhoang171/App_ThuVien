using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

            btnSuaTheThuVien.Enabled = false;
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
            cbxTrangThai.SelectedIndex = -1;

        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void lblTittle_Click(object sender, EventArgs e)
        {

        }
        private bool KTra_ThayDoiDLSach()
        {
            if (dGVSach.CurrentRow == null)
            {
                return false;
            }

            DataGridViewRow row = dGVSach.CurrentRow;

            if (txtMaSach.Text != row.Cells[0].Value.ToString()) return true;
            if (txtTenSach.Text != row.Cells[1].Value.ToString()) return true;
            if (txtTacGia.Text != row.Cells[3].Value.ToString()) return true;
            if (txtTheLoai.Text != row.Cells[4].Value.ToString()) return true;

            if (int.TryParse(txtSoLuong.Text, out int currentSoLuong))
            {
                if (currentSoLuong != Convert.ToInt32(row.Cells[6].Value)) return true;
            }
            else
            {
                // Nếu không thể parse txtTienPhat, coi như dữ liệu đã thay đổi
                return true;
            }
            if (txtMoTa.Text != row.Cells[5].Value.ToString()) return true;
            if (int.TryParse(txtGia.Text, out int currentGia))
            {
                if (currentGia != Convert.ToInt32(row.Cells[7].Value)) return true;
            }
            else
            {
                // Nếu không thể parse txtTienPhat, coi như dữ liệu đã thay đổi
                return true;
            }

            if (dtpNamXB.Value != new DateTime(Convert.ToInt32(row.Cells[7].Value), 1, 1)) return true;
    
            

            // Nếu tất cả đều không thay đổi, trả về false
            return false;
        }
        private void btnSuaSach_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMaSach.Text) &&
         string.IsNullOrWhiteSpace(txtTenSach.Text) &&
         string.IsNullOrWhiteSpace(txtTacGia.Text) &&
         string.IsNullOrWhiteSpace(txtTheLoai.Text) &&
         string.IsNullOrWhiteSpace(txtSoLuong.Text)
         &&
         string.IsNullOrWhiteSpace(txtMoTa.Text)
         &&
         string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KTra_ThayDoiDLSach())
            {
                DataGridViewRow row = dGVSach.CurrentRow;
            
                row.Cells[0].Value = txtMaSach.Text;
                row.Cells[1].Value = txtTenSach.Text;
                row.Cells[2].Value = txtTacGia.Text;
                row.Cells[3].Value = txtTheLoai.Text;
                row.Cells[4].Value = txtMoTa.Text;
              
                if (int.TryParse(txtSoLuong.Text, out int soLuong) && soLuong >=0)
                {
                    row.Cells[5].Value = soLuong;
                }
                else
                {
                    MessageBox.Show("Giá trị số lượng không hợp lệ, phải là số nguyên không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
               
                if (decimal.TryParse(txtGia.Text, out decimal giaSach) && giaSach>=0)
                {
                    row.Cells[6].Value = giaSach;
                }
                else
                {
                    MessageBox.Show("Giá trị giá sách không hợp lệ, phải là số thập phân không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                row.Cells[7].Value = Convert.ToInt32(dtpNamXB.Value.Year);




                if (SachBUS.Instance.Sua(dGVSach))
                {
                    MessageBox.Show("Sửa dữ liệu Sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                    SachBUS.Instance.Xem(dGVSach);
                    LamMoiTextbox();
                    btnThemSach.Enabled = true;
                    btnSuaSach.Enabled = false;
                    txtMaSach.ReadOnly = false;

                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu Sách thất bại! \nVui lòng kiểm tra lại dữ liệu nhập vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SachBUS.Instance.Xem(dGVSach);
                    btnSuaSach.Enabled = true;
                    txtMaSach.ReadOnly = true;

                }
                  

            }
            else
            {
                // Hiển thị thông báo nếu không có thay đổi dữ liệu
                MessageBox.Show("Không có dữ liệu nào được chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LamMoiTextbox();
                btnSuaSach.Enabled=false;
                btnThemSach.Enabled = true;
                txtMaSach.ReadOnly = false;

            }
       
           

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
            btnSuaSach.Enabled = false;
            btnThemSach.Enabled = true;
            LamMoiTextbox();
            MuonTraBUS.Instance.Xem(dGVMuonTra);
            txtMaSach.ReadOnly = false;
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
                    MessageBox.Show("Giá Sách phải số không âm", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (namXB.ToString().Length > 4)
                {
                    MessageBox.Show("Năm Xuất Bản không hợp lệ", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (SachBUS.Instance.Them(maSach, tenSach, tacGia, theLoai, moTa, soLuong, giaSach, namXB))
                {
                    MessageBox.Show("Thêm Sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SachBUS.Instance.Xem(dGVSach);
                    LamMoiTextbox();
                }
                else
                {
                    MessageBox.Show("Thêm Sách thất bại. Vui lòng kiểm tra: \n-Có thể Mã Sách đã tồn tại", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
   
        private bool KTra_ThayDoiDLTheThuVien()
        {
            if (dGVTheThuVien.CurrentRow == null)
            {
                return false;
            }

            DataGridViewRow row = dGVTheThuVien.CurrentRow;

            if (txtMaThe.Text != row.Cells[0].Value.ToString()) return true;
            if (txtHoTen.Text != row.Cells[1].Value.ToString()) return true;
            if (txtDiaChi.Text != row.Cells[2].Value.ToString()) return true;
            if (txtDienThoai.Text != row.Cells[3].Value.ToString()) return true;
            if (txtEmail.Text != row.Cells[4].Value.ToString()) return true;
            if (dtpNgayDK.Value != Convert.ToDateTime(row.Cells[5].Value)) return true;
            if (dtpNgayHH.Value != Convert.ToDateTime(row.Cells[6].Value)) return true;
            return false;
        }
       
        private void btnSuaTheThuVien_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtMaThe.Text) &&
                string.IsNullOrWhiteSpace(txtHoTen.Text) &&
                string.IsNullOrWhiteSpace(txtDiaChi.Text) &&
                string.IsNullOrWhiteSpace(txtDienThoai.Text) &&
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (KTra_ThayDoiDLTheThuVien())
            {
                DataGridViewRow row = dGVTheThuVien.CurrentRow;

             
                row.Cells[0].Value = txtMaThe.Text;
                row.Cells[1].Value = txtHoTen.Text;
                row.Cells[2].Value = txtDiaChi.Text;
                row.Cells[3].Value = txtDienThoai.Text;
                row.Cells[4].Value = txtEmail.Text;
                row.Cells[5].Value = Convert.ToDateTime(dtpNgayDK.Value);
                row.Cells[6].Value = Convert.ToDateTime(dtpNgayHH.Value);
               

                if (TheThuVienBUS.Instance.Sua(dGVTheThuVien))
                {
                    MessageBox.Show("Sửa dữ liệu Thẻ Thư Viện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
                   TheThuVienBUS.Instance.Xem(dGVTheThuVien);
                    LamMoiTextbox();
                    btnSuaTheThuVien.Enabled = false;
                    btnThemTheThuVien.Enabled = true;
                    txtMaThe.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu Thẻ Thư Viện thất bại!. \nVui lòng kiểm tra lại dữ liệu nhập vào", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TheThuVienBUS.Instance.Xem(dGVTheThuVien);
                    btnSuaTheThuVien.Enabled = true;
                    txtMaThe.ReadOnly = true;
                }

            }
            else
            {
                // Hiển thị thông báo nếu không có thay đổi dữ liệu
                MessageBox.Show("Không có dữ liệu nào được chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LamMoiTextbox();
                btnSuaTheThuVien.Enabled=false;
                btnThemTheThuVien.Enabled = true;
                txtMaThe.ReadOnly = false;
            }

         
        
      
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
                    MessageBox.Show("Thêm Thẻ Thư Viện thất bại!. Vui lòng kiểm tra:\n- Có thể Mã Thẻ đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                btnThemTheThuVien.Enabled = true;
                btnSuaTheThuVien.Enabled = false;
            LamMoiTextbox() ;
            txtMaThe.ReadOnly = false;

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
                    MessageBox.Show("Vui lòng kiểm tra: \n- Có thể Mã Giao Dịch đã tồn tại\n- Mã Thẻ, Mã Sách không tồn tại \n- Số Lượng hiện có cho sách này đã hết không thể mượn \n- Thẻ đã hết hạn", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btnSuaMuonTra.Enabled = false;
                btnThemMuonTra.Enabled = true;
            LamMoiTextbox() ;
            txtMaGD.ReadOnly = false;
        }
        private bool KTra_ThayDoiDLMuonTra()
        {
            if (dGVMuonTra.CurrentRow == null)
            {
                return false;
            }

            DataGridViewRow row = dGVMuonTra.CurrentRow;

            if (txtMaGD.Text != row.Cells[0].Value.ToString()) return true;
            if (txtMaSachMT.Text != row.Cells[1].Value.ToString()) return true;
            if (txtMaTheMT.Text != row.Cells[2].Value.ToString()) return true;
            if (dtpNgayMuon.Value != Convert.ToDateTime(row.Cells[3].Value)) return true;
            if (dtpNgayTra.Value != Convert.ToDateTime(row.Cells[4].Value)) return true;
            if (cbxTrangThai.Text != row.Cells[6].Value.ToString()) return true;
            if (decimal.TryParse(txtTienPhat.Text, out decimal currentTienPhat))
            {
                if (currentTienPhat != Convert.ToDecimal(row.Cells[5].Value)) return true;
            }
            else
            {
                // Nếu không thể parse txtTienPhat, coi như dữ liệu đã thay đổi
                return true;
            }

            // Nếu tất cả đều không thay đổi, trả về false
            return false;
        }
        private void btnSuaMuonTra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaGD.Text) &&
         string.IsNullOrWhiteSpace(txtMaSachMT.Text) &&
         string.IsNullOrWhiteSpace(txtMaTheMT.Text) &&
         string.IsNullOrWhiteSpace(cbxTrangThai.Text) &&
         string.IsNullOrWhiteSpace(txtTienPhat.Text))
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

                if (KTra_ThayDoiDLMuonTra())
                {
                    DataGridViewRow row = dGVMuonTra.CurrentRow;

                    // Cập nhật lại hàng trong DataGridView
                    row.Cells[0].Value = txtMaGD.Text;
                    row.Cells[1].Value = txtMaSachMT.Text;
                    row.Cells[2].Value = txtMaTheMT.Text;
                    row.Cells[3].Value = Convert.ToDateTime(dtpNgayMuon.Value);
                    row.Cells[4].Value = Convert.ToDateTime(dtpNgayTra.Value);
                    row.Cells[6].Value = cbxTrangThai.Text;
                //row.Cells[5].Value = decimal.TryParse(txtTienPhat.Text, out decimal tienPhat) ? tienPhat : 0; 
                // Kiểm tra và gán giá trị cho ô thứ 5 nếu nó là decimal
                if (decimal.TryParse(txtTienPhat.Text, out decimal tienPhat) && tienPhat >=0)
                {
                    row.Cells[5].Value = tienPhat;
                }
                else
                {
                    MessageBox.Show("Giá trị tiền phạt không hợp lệ, phải là số không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Không tiếp tục nếu giá trị không hợp lệ
                }
                if (MuonTraBUS.Instance.Sua(dGVMuonTra))
                    {
                        MessageBox.Show("Sửa dữ liệu Mượn trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MuonTraBUS.Instance.Xem(dGVMuonTra);
                        LamMoiTextbox();
                         btnSuaMuonTra.Enabled = false;
                        btnThemMuonTra.Enabled = true;
                    txtMaGD.ReadOnly = false;

                }
                    else
                    {
                        MessageBox.Show("Không thể sửa đổi Mượn trả có thể do số lượng hiện có của sách đã hết hoặc bạn đã nhập sai dữ liệu sửa đổi", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         MuonTraBUS.Instance.Xem(dGVMuonTra);
                        btnSuaMuonTra.Enabled = true;
                    txtMaGD.ReadOnly = true;

                    }


                }
                else
                {
                    // Hiển thị thông báo nếu không có thay đổi dữ liệu
                    MessageBox.Show("Không có dữ liệu nào được chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSuaMuonTra.Enabled = false;
                    btnThemMuonTra.Enabled= true;
                     LamMoiTextbox();
                    txtMaGD.ReadOnly = false;
            }
      
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

        private void dGVTheThuVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dGVMuonTra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dGVSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
   
        private void dGVTheThuVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnThemTheThuVien.Enabled = false;
                btnSuaTheThuVien.Enabled = true;
                txtMaThe.ReadOnly = true;
                DataGridViewRow row = dGVTheThuVien.Rows[e.RowIndex];
        
                txtMaThe.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtDienThoai.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                dtpNgayHH.Value = Convert.ToDateTime(row.Cells[6].Value);
                dtpNgayDK.Value = Convert.ToDateTime(row.Cells[5].Value);
             
            }
        }

        private void dGVMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnThemMuonTra.Enabled = false;
                btnSuaMuonTra.Enabled=true;
               txtMaGD.ReadOnly = true;
                DataGridViewRow row = dGVMuonTra.Rows[e.RowIndex];
                // Lấy dữ liệu từ các ô trong hàng được chọn và đặt vào các TextBox và điều khiển khác
                txtMaGD.Text = row.Cells[0].Value.ToString();
                txtMaSachMT.Text = row.Cells[1].Value.ToString();
                txtMaTheMT.Text = row.Cells[2].Value.ToString();
                // Giả sử bạn lưu trữ ngày dưới dạng DateTime
                dtpNgayMuon.Value = Convert.ToDateTime(row.Cells[3].Value);
                dtpNgayTra.Value = Convert.ToDateTime(row.Cells[4].Value);
                cbxTrangThai.Text = row.Cells[6].Value.ToString();
                txtTienPhat.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dGVSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnThemSach.Enabled= false;
                btnSuaSach.Enabled=true; 
                txtMaSach.ReadOnly = true;
                DataGridViewRow row = dGVSach.Rows[e.RowIndex];
                // Lấy dữ liệu từ các ô trong hàng được chọn và đặt vào các TextBox và điều khiển khác
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtTacGia.Text = row.Cells[2].Value.ToString();
                txtTheLoai.Text = row.Cells[3].Value.ToString();
                txtMoTa.Text = row.Cells[4].Value.ToString();
                txtSoLuong.Text = row.Cells[5].Value.ToString();
                txtGia.Text = row.Cells[6].Value.ToString();

                dtpNamXB.Value = new DateTime(Convert.ToInt32(row.Cells[7].Value), 1, 1);


            }
        }

        private void btnResetTxtSach_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTenSach.Clear();
            txtTheLoai.Clear();
            txtMoTa.Clear();
            txtSoLuong.Clear();
            txtGia.Clear();
            txtTacGia.Clear();
            txtMaSach.ReadOnly = false;
            btnSuaSach.Enabled = false;
            btnThemSach.Enabled = true;
            btnSuaTheThuVien.Enabled = false;
            btnThemTheThuVien.Enabled = true;
            btnSuaMuonTra.Enabled= false;
            btnThemMuonTra.Enabled = true;

        }

        private void btnRestTxtTheThuVien_Click(object sender, EventArgs e)
        {
            txtMaThe.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtMaThe.ReadOnly = false;
            btnSuaTheThuVien.Enabled = false;
            btnThemTheThuVien.Enabled = true;
            btnSuaSach.Enabled = false;
            btnThemSach.Enabled = true;
            btnSuaMuonTra.Enabled = false;
            btnThemMuonTra.Enabled = true;

        }

        private void btnResetTxtMuonTra_Click(object sender, EventArgs e)
        {
            txtMaGD.Clear();
            txtMaSachMT.Clear();
            txtMaTheMT.Clear();
            txtTienPhat.Clear();
            cbxTrangThai.SelectedIndex = -1;
            txtMaGD.ReadOnly = false;
            btnSuaMuonTra.Enabled = false;
            btnThemMuonTra.Enabled = true;
            btnSuaTheThuVien.Enabled = false;
            btnThemTheThuVien.Enabled = true;
            btnSuaSach.Enabled = false;
            btnThemSach.Enabled = true;
        }
    }
}
