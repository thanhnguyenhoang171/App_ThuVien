using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MuonTra
    {
        private string maGiaoDich;
        private string maSach;
        private string maThe;
        private DateTime ngayMuon;
        private DateTime ngayTra;
        private decimal tienPhat;
        private string trangThai;

        public string MaGiaoDich
        { get { return maGiaoDich; } set { maGiaoDich = value; } }

        public string MaSach
        { get { return maSach; } set { maSach = value; } }
        public string MaThe
        { get { return maThe; } set { maThe= value; } }
        public DateTime NgayMuon
        { get { return ngayMuon; } set { ngayMuon = value; } }

        public DateTime NgayTra
        { get { return ngayTra; } set { ngayTra = value; } }

        public decimal SoTienPhat
        { get { return tienPhat; } set { tienPhat = value; } }

        public string TrangThai
        { get { return trangThai; } set { trangThai = value; } }

        public MuonTra (string maGiaoDich, string maSach, string maThe, DateTime ngayMuon, DateTime ngayTra, decimal soTienPhat, string trangThai)
        {
           
           this.MaGiaoDich = maGiaoDich;
           this.MaSach = maSach;
            this.MaThe = maThe;
            this.NgayMuon = ngayMuon;
            this.NgayTra = ngayTra;
            this.SoTienPhat = soTienPhat;
            this.TrangThai = trangThai;
        }
    }
}
