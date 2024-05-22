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

        public DataTable ChuyenListSangDGV(List<MuonTra> muonTra)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ma_giao_dich", typeof(string));
            dt.Columns.Add("ma_sach", typeof(string));
            dt.Columns.Add("ma_the", typeof(string));
            dt.Columns.Add("ngay_muon", typeof(DateTime));
            dt.Columns.Add("ngay_tra", typeof(DateTime));
            dt.Columns.Add("so_tien_phat", typeof(Decimal));
            dt.Columns.Add("trang_thai", typeof(string));


            foreach (var muontra in muonTra)
            {
                dt.Rows.Add(muontra.MaGiaoDich, muontra.MaSach, muontra.MaThe, muontra.NgayMuon, muontra.NgayTra, muontra.SoTienPhat, muontra.TrangThai);
            }
                return dt;
            
        }
            public void Xem(DataGridView data)
        {

            List<MuonTra> muonTra = MuonTraDAO.Instance.Xem();

            DataTable dt = ChuyenListSangDGV(muonTra);

            data.DataSource = dt;

            data.Columns["ma_giao_dich"].HeaderText = "Mã Giao Dịch";
            data.Columns["ma_sach"].HeaderText = "Mã Sách";
            data.Columns["ma_the"].HeaderText = "Mã Thẻ";
            data.Columns["ngay_muon"].HeaderText = "Ngày Mượn";
            data.Columns["ngay_tra"].HeaderText = "Ngày Trả";
            data.Columns["so_tien_phat"].HeaderText = "Số Tiền Phạt";
            data.Columns["trang_thai"].HeaderText = "Trạng Thái";
         
            //data.DataSource = MuonTraDAO.Instance.Xem();
        }
        public bool Sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string maGiaoDich = row.Cells[0].Value.ToString();
            string maSach = row.Cells[1].Value.ToString();
            string maThe = row.Cells[2].Value.ToString();
            DateTime ngayMuon = Convert.ToDateTime(row.Cells[3].Value);
            DateTime ngayTra = Convert.ToDateTime(row.Cells[4].Value);
            decimal tienPhat = Convert.ToDecimal(row.Cells[5].Value);
            string trangThai = row.Cells[6].Value.ToString();

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
                string maGiaoDich = row.Cells[0].Value.ToString();

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
