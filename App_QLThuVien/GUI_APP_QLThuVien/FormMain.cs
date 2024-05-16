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

      

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemSach_Click(object sender, EventArgs e)
        {
            //SachBUS.Instance.Xem(dgvSach);
        }

        private void lblTittle_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (SachBUS.Instance.Sua(dGVSach))
            {
                MessageBox.Show("Sửa dữ liệu Sách thành công!");
                     
            }
            else
            {
                MessageBox.Show("Lỗi!");
            } 
                
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (SachBUS.Instance.Xoa(dGVSach))
            {
                MessageBox.Show("Xoá dữ liệu Sách thành công!");
            } else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            string tacGia = txtTacGia.Text;
            string theLoai = txtTheLoai.Text;

            int soLuong;
            if (!int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số nguyên.");
                return; 
            }

            string moTa = txtMoTa.Text;

            decimal giaSach;
            if (!decimal.TryParse(txtGia.Text, out giaSach))
            {
                MessageBox.Show("Giá sách không hợp lệ. Vui lòng nhập số thập phân.");
                return; 
            }

            int namXB = dtpNamXB.Value.Year;
            

            if (SachBUS.Instance.Them(maSach,tenSach,tacGia,theLoai,soLuong,moTa,giaSach,namXB))
            {
                MessageBox.Show("Thêm Sách thành công!");
                SachBUS.Instance.Xem(dGVSach);
            }
            else
            {
                MessageBox.Show("Thêm Sách thất bại!");
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
                MessageBox.Show("Sửa dữ liệu Thẻ Thư Viện thành công!");

            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnThemTheThuVien_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text;
            string hoTen = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string dienThoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            DateTime ngayDK = dtpNgayDK.Value; // Không cần chuyển đổi ở đây
            DateTime ngayHH = dtpNgayHH.Value; // Không cần chuyển đổi ở đây

            if (TheThuVienBUS.Instance.Them(maThe, hoTen, diaChi, dienThoai, email, ngayDK, ngayHH))
            {
                MessageBox.Show("Thêm Thẻ Thư Viện thành công!");
                TheThuVienBUS.Instance.Xem(dGVTheThuVien);
            }
            else
            {
                MessageBox.Show("Thêm Thẻ Thư Viện thất bại!");
            }

        }

        private void btnXoaTheThuVien_Click(object sender, EventArgs e)
        {
            if (TheThuVienBUS.Instance.Xoa(dGVTheThuVien))
            {
                MessageBox.Show("Xoá dữ liệu Thẻ Thư Viện thành công!");
            }
            else
            {
                MessageBox.Show("                                Lỗi!" + Environment.NewLine + "Có thể thẻ thư viện này đang mượn sách");

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
            string maSach = txtMaSach.Text;
            string maThe = txtMaThe.Text;
            
            DateTime ngayMuon = dtpNgayMuon.Value; 
            DateTime ngayTra = dtpNgayTra.Value;
            string trangThai = txtTrangThai.Text;
            decimal tienPhat;
            if (!decimal.TryParse(txtTienPhat.Text, out tienPhat))
            {
                MessageBox.Show("Số tiền phạt không hợp lệ. Vui lòng nhập số thập phân.");
                return;
            }

            if (MuonTraBUS.Instance.Them(maGiaoDich, maSach, maThe, ngayMuon,ngayTra, tienPhat, trangThai))
            {
                MessageBox.Show("Thêm Thẻ Thư Viện thành công!");
                MuonTraBUS.Instance.Xem(dGVMuonTra);
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnXoaMuonTra_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaMuonTra_Click(object sender, EventArgs e)
        {
            if (MuonTraBUS.Instance.Sua(dGVMuonTra))
            {
                MessageBox.Show("Sửa dữ liệu Mượn trả thành công!");

            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }
    }
}
