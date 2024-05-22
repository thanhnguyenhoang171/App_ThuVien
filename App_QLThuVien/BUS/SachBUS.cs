using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable ChuyenListSangDGV(List<Sach> saches)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ma_sach", typeof(string));
            dt.Columns.Add("ten_sach", typeof(string));
            dt.Columns.Add("tac_gia", typeof(string));
            dt.Columns.Add("the_loai", typeof(string));
            dt.Columns.Add("so_luong_hien_co", typeof(int));
            dt.Columns.Add("mo_ta", typeof(string));
            dt.Columns.Add("gia", typeof(decimal));
            dt.Columns.Add("nam_xuat_ban", typeof(int));

            foreach (var sach in saches)
            {
                dt.Rows.Add(sach.MaSach, sach.TenSach, sach.TenTacGia, sach.TheLoai, sach.SoLuong, sach.MoTa, sach.GiaSach, sach.NamXB);
            }

            return dt;
        }

        public void Xem(DataGridView data)
        {
            List<Sach> saches = SachDAO.Instance.Xem();

            DataTable dt = ChuyenListSangDGV(saches);

            data.DataSource = dt;

            data.Columns["ma_sach"].HeaderText = "Mã Sách";
            data.Columns["ten_sach"].HeaderText = "Tên Sách";
            data.Columns["tac_gia"].HeaderText = "Tác Giả";
            data.Columns["the_loai"].HeaderText = "Thể Loại";
            data.Columns["so_luong_hien_co"].HeaderText = "Số Lượng Hiện Có";
            data.Columns["mo_ta"].HeaderText = "Mô Tả";
            data.Columns["gia"].HeaderText = "Giá Sách";
            data.Columns["nam_xuat_ban"].HeaderText = "Năm Xuất Bản";

            // data.DataSource = SachDAO.Instance.Xem();


        }
        public bool Sua (DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            
            string maSach = row.Cells["MaSach"].Value.ToString();
            string tenSach = row.Cells["TenSach"].Value.ToString();
            string tacGia = row.Cells["TenTacGia"].Value.ToString();
            string theLoai = row.Cells["TheLoai"].Value.ToString();
            int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
            string moTa = row.Cells["MoTa"].Value.ToString();
            decimal giaSach = Convert.ToDecimal(row.Cells["GiaSach"].Value); 
            int namXB = Convert.ToInt32(row.Cells["NamXB"].Value);

            Sach sach = new Sach(maSach, tenSach, tacGia, theLoai, soLuong, moTa, giaSach, namXB);
            return SachDAO.Instance.Sua(maSach, sach);
        }

        public bool Xoa(DataGridView data)
        {
            if (data.SelectedCells.Count > 0)
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                string maSach = row.Cells["MaSach"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá Sách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (SachDAO.Instance.Xoa(maSach))
                    {
                        Xem(data);
                        return true;
                    }
                }

            }
            return false;
        }
        public bool Them(string maSach, string tenSach, string tacGia, string theLoai, int soLuong, string moTa, decimal giaSach, int namXB)
        {
            Sach sach = new Sach(maSach, tenSach, tacGia, theLoai, soLuong, moTa, giaSach, namXB);
            return SachDAO.Instance.Them(sach);
        }
    }
}
