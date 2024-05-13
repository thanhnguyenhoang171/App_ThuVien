using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class SachBUS
    {
        private static SachBUS instance;
        public static SachBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new SachBUS();
                return instance;
            }
        }
        private SachBUS() { }
        public void Xem(DataGridView data)
        {
            //// Xóa tất cả các cột trong DataGridView trước khi thêm mới
            //data.Columns.Clear();

            //// Thiết lập AutoGenerateColumns thành false để ngăn DataGridView tự động tạo cột
            //data.AutoGenerateColumns = false;

            //// Tạo cột cho Mã Sách
            //DataGridViewTextBoxColumn colMaSach = new DataGridViewTextBoxColumn();
            //colMaSach.DataPropertyName = "MaSach";
            //colMaSach.HeaderText = "Mã Sách";
            //data.Columns.Add(colMaSach);

            //// Tạo cột cho Tên Sách
            //DataGridViewTextBoxColumn colTenSach = new DataGridViewTextBoxColumn();
            //colTenSach.DataPropertyName = "TenSach";
            //colTenSach.HeaderText = "Tên Sách";
            //data.Columns.Add(colTenSach);

            //// Tạo cột cho Tác Giả
            //DataGridViewTextBoxColumn colTacGia = new DataGridViewTextBoxColumn();
            //colTacGia.DataPropertyName = "TenTacGia";
            //colTacGia.HeaderText = "Tác Giả";
            //data.Columns.Add(colTacGia);

            //// Tạo cột cho Thể Loại
            //DataGridViewTextBoxColumn colTheLoai = new DataGridViewTextBoxColumn();
            //colTheLoai.DataPropertyName = "TheLoai";
            //colTheLoai.HeaderText = "Thể Loại";
            //data.Columns.Add(colTheLoai);

            //// Tạo cột cho Số Lượng Hiện Có
            //DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            //colSoLuong.DataPropertyName = "SoLuong";
            //colSoLuong.HeaderText = "Số Lượng Hiện Có";
            //data.Columns.Add(colSoLuong);

            //// Tạo cột cho Mô Tả
            //DataGridViewTextBoxColumn colMoTa = new DataGridViewTextBoxColumn();
            //colMoTa.DataPropertyName = "MoTa";
            //colMoTa.HeaderText = "Mô Tả";
            //data.Columns.Add(colMoTa);

            //// Tạo cột cho Giá
            //DataGridViewTextBoxColumn colGia = new DataGridViewTextBoxColumn();
            //colGia.DataPropertyName = "GiaSach";
            //colGia.HeaderText = "Giá";
            //data.Columns.Add(colGia);

            //// Tạo cột cho Năm Xuất Bản
            //DataGridViewTextBoxColumn colNamXB = new DataGridViewTextBoxColumn();
            //colNamXB.DataPropertyName = "NamXB";
            //colNamXB.HeaderText = "Năm Xuất Bản";
            //data.Columns.Add(colNamXB);

            data.DataSource = SachDAO.Instance.Xem();
        }
        public bool Sua (DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string maSach = row.Cells["ma_sach"].Value.ToString();
            string tenSach = row.Cells["ten_sach"].Value.ToString();
            string tacGia = row.Cells["tac_gia"].Value.ToString();
            string theLoai = row.Cells["the_loai"].Value.ToString();
            int soLuong = Convert.ToInt32(row.Cells["so_luong_hien_co"].Value);
            string moTa = row.Cells["mo_ta"].Value.ToString();
            decimal giaSach = Convert.ToDecimal(row.Cells["gia"].Value); 
            int namXB = Convert.ToInt32(row.Cells["nam_xuat_ban"].Value);

            Sach sach = new Sach(maSach, tenSach, tacGia, theLoai, soLuong, moTa, giaSach, namXB);
            return SachDAO.Instance.Sua(maSach, sach);
        }
    }
}
