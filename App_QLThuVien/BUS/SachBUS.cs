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
            
            data.DataSource = SachDAO.Instance.Xem();
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

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá sách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if( SachDAO.Instance.Xoa(maSach))
                    {
                        Xem(data);
                        return true;
                    }    
                }
            }
            return false;
        }
        public bool Them(Sach sach)
        {
            return SachDAO.Instance.Them(sach);
        }
    }
}
