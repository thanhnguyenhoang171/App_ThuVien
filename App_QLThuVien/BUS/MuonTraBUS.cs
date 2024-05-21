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
    public  class MuonTraBUS
    {
        private static MuonTraBUS instance;
        public static MuonTraBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new MuonTraBUS();
                return instance;
            }
        }
        private MuonTraBUS() { }
        public void Xem(DataGridView data)
        {

            data.DataSource = MuonTraDAO.Instance.Xem();
        }
        public bool Sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string maGiaoDich = row.Cells["MaGiaoDich"].Value.ToString();
            string maSach = row.Cells["MaSach"].Value.ToString();
            string maThe = row.Cells["MaThe"].Value.ToString();
            DateTime ngayMuon = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
            DateTime ngayTra = Convert.ToDateTime(row.Cells["NgayTra"].Value);
            decimal tienPhat = Convert.ToDecimal(row.Cells["SoTienPhat"].Value);
            string trangThai = row.Cells["TrangThai"].Value.ToString();

            MuonTra muonTra = new MuonTra(maGiaoDich, maSach, maThe, ngayMuon, ngayTra, tienPhat, trangThai);
            return MuonTraDAO.Instance.Sua(maGiaoDich, muonTra);
        }
        public bool Them(string maGiaoDich, string maSach, string maThe, DateTime ngayMuon, DateTime ngayTra, decimal tienPhat, string trangThai)
        {
            MuonTra muonTra = new MuonTra(maGiaoDich, maSach, maThe, ngayMuon, ngayTra, tienPhat, trangThai);
            return MuonTraDAO.Instance.Them(muonTra);
        }
        public bool Xoa (DataGridView data)
        {
            if (data.SelectedCells.Count > 0)
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                string maGiaoDich = row.Cells["MaGiaoDich"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá giao dịch mượn trả này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (MuonTraDAO.Instance.Xoa(maGiaoDich))
                    {
                        Xem(data);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
