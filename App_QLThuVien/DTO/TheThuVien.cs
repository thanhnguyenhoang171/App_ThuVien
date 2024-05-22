using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheThuVien
    {
        private string maThe;
        private string hoTen;
        private string diaChi;
        private string dienThoai;
        private string email;
        private DateTime ngayDK;
        private DateTime ngayHH;
        public string MaThe
        { get { return maThe; } set {  maThe = value; } }
        public string HoTen
        { get { return hoTen; } set {  hoTen = value; } }
        public string DiaChi
        { get { return diaChi; } set { diaChi = value; } }
        public string Email
        { get { return email; } set {  email = value; } }

        public string DienThoai
        { get { return dienThoai; } set {  dienThoai = value; } }

        public DateTime NgayDK
        { get { return ngayDK; } set { ngayDK = value; } }
        public DateTime NgayHH
        { get { return ngayHH; } set { ngayHH = value; } }

        public TheThuVien(string maThe, string hoTen, string diaChi, string dienThoai, string email, DateTime ngayDK, DateTime ngayHH)
        {
            this.MaThe = maThe;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
            this.Email = email;
            this.NgayDK = ngayDK;
            this.NgayHH = ngayHH;
        
        }
    }
}
