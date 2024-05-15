using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace BUS
{
    public class TheThuVienBUS
    {
        private static TheThuVienBUS instance;
        public static TheThuVienBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new TheThuVienBUS();
                return instance;
            }
        }
        private TheThuVienBUS() { }

        public void Xem(DataGridView data)
        {
            data.DataSource = TheThuVienDAO.Instance.Xem();
        }
    }
}
