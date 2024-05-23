using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        private string maSach;
        private string tenSach;
        private string tenTacGia;
        private string theLoai;
        private string moTa;
        private int soLuong;
        private decimal giaSach;
        private int namXB;

        public string MaSach
        { get { return maSach; } set { maSach = value; } }

        public string TenSach
        { get { return tenSach; } set { tenSach = value; } }

        public string TenTacGia
        { get { return tenTacGia; } set { tenTacGia = value; } }
        public string TheLoai
        { get { return theLoai; } set { theLoai = value; } }

        public string MoTa
        { get { return moTa; } set {  moTa = value; } }
        public int SoLuong
        { get { return soLuong; } set { soLuong = value; } }


        public decimal GiaSach
        { get { return giaSach; } set { giaSach = value; } }

        public int NamXB
        { get { return namXB; } set {  namXB = value; } }

        public Sach(string maSach, string tenSach, string tenTacGia, string theLoai, string moTa, int soLuong, decimal giaSach, int namXB)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tenTacGia = tenTacGia;
            this.theLoai = theLoai;
            this.moTa = moTa;
            this.soLuong = soLuong;
            this.giaSach = giaSach;
            this.namXB = namXB;
        }
    }
}
