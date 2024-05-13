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
using DTO;

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
            SachBUS.Instance.Xem(dgvSach);
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
            if (SachBUS.Instance.Sua(dgvSach))
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
            if (SachBUS.Instance.Xoa(dgvSach))
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
            

            Sach sach = new Sach(maSach, tenSach, tacGia, theLoai, soLuong, moTa, giaSach, namXB);

            if (SachBUS.Instance.Them(sach))
            {
                MessageBox.Show("Thêm Sách thành công!");
                SachBUS.Instance.Xem(dgvSach);
            }
            else
            {
                MessageBox.Show("Thêm Sách thất bại!");
            }    

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
