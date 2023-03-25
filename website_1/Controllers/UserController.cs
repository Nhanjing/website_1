using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website_1.Models;

namespace website_1.Controllers
{
    public class UserController : Controller
    {
        datawebsiteDataContext db = new datawebsiteDataContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangky(FormCollection fc, TAIKHOAN kh)
        {

            var hote = fc["Hotenkh"];
            var tendn = fc["Tendn"];
            var matkhau = fc["Matkhau"];
            var matkhaunhaplai = fc["Matkhaunhaplai"];
            var diachi = fc["Diachi"];
            var email = fc["Email"];
            var dienthoai = fc["Dienthoai"];
            var ngaysinh = String.Format("{0:MM/dd/yyyy}", fc["Ngaysinh"]);
            if (String.IsNullOrEmpty(hote))
            {
                ViewData["loi1"] = "Kkông Được Bỏ Trống Dòng Này ";
            }
            else if (String.IsNullOrEmpty(tendn))
            {
                ViewData["loi2"] = "Xin Mời Ban Nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["loi3"] = "Xin Mời Ban Nhập";
            }
            else if (String.IsNullOrEmpty(matkhaunhaplai))
            {
                ViewData["loi4"] = "Xin Mời Ban Nhập Một Lần Nữa ";
            }
            else if (!String.IsNullOrEmpty(diachi))
            {
                ViewData["loi7"] = "Xin Mời Ban Nhập ";
            }
            if (String.IsNullOrEmpty(email))
            {
                ViewData["loi5"] = "Kkông Được Bỏ Trống Dòng Này";
            }
            if (String.IsNullOrEmpty(dienthoai))
            {
                ViewData["loi6"] = "Kkông Được Bỏ Trống Dòng Này";
            }
            else
            {
                kh.HoTen = hote;
                kh.TaiKhoan1 = tendn;
                kh.MatKhau = matkhau;
                kh.Email = email;
                kh.Diachi = diachi;
                kh.Dienthoai = dienthoai;
                kh.Ngaysinh = DateTime.Parse(ngaysinh);
                db.TAIKHOANs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return RedirectToAction("DangNhap");
            }
            return this.DangKy();
        }
        [HttpGet]
        public ActionResult DANGNHAP()
        {
            return View();
        }
    }
}