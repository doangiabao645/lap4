using SachOnline.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SachOnline.Models
{
    public class GioHang
    {
        private string connection;
        private dbSachOnlineDataContext db;
        public int iMaSach {  get; set; }
        public string sTenSach { get; set; }
        public string sAnhBia { get; set; }
        public double dDonGia { get; set; }
        public int iSoLuong { get; set; }
        public double dThanhTien {

            get { return iSoLuong * dDonGia; }
        }

        public GioHang(int ms)
        {
            connection = "Data Source=LAPTOP-O5R6LPBI;Initial Catalog=SachOnline;Integrated Security=True";
            db = new dbSachOnlineDataContext(connection);
            iMaSach = ms;
            SACH s = db.SACHes.Single(n => n.MaSach == iMaSach);
            sTenSach = s.TenSach;
            sAnhBia = s.AnhBia;
            dDonGia = double.Parse(s.GiaBan.ToString());
            iSoLuong = 1;
        }
    }
}