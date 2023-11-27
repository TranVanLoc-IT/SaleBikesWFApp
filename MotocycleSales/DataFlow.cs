using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotocycleSales
{
    class DataFlow
    {
        public QLXMEntities2 db = new QLXMEntities2();

        public NhanVien VaLidCompanyAgent(string agentId, string password)
        {
            return this.db.NhanViens.Where(nv => nv.MaNV == agentId && nv.Password == password && nv.TinhTrang == true).FirstOrDefault();
        }
        public QuanLy VaLidCompanyManager(string managerId, string password)
        {
            return this.db.QuanLies.Where(nv => nv.MaQuanLy == managerId && nv.Password == password).FirstOrDefault();
        }
        public string GetStoreWorkingName(string id)
        {
            return this.db.CuaHangs.Where(st => st.MaQuanLy == id || st.MaCuaHang == id).FirstOrDefault().TenCuaHang;
        }
        public List<ProductDTO> GetAllMotocycles()
        {
            return this.db.SanPhams
            .Join(
                // LẤY ĐIỀU KIỆN NGÀY KK GẦN NHẤT
                this.db.KiemKes.Where(kk => kk.NgayKiemKe == (this.db.KiemKes.Where(k => k.MaXe == kk.MaXe).Max(k => k.NgayKiemKe))),
                sp => sp.MaXe,
                kk => kk.MaXe,
                (sp, kk) => new ProductDTO{ _maLoaiXe = sp.MaLX, _maXe= sp.MaXe, _tenXe = sp.TenXe,_mauXe = sp.MauSac, _soLuongCon = (int)kk.SoLuongCon, _giaban = (double)sp.GiaBan }
            )
            .ToList();
        }
        public bool EditProduct(SanPham sp, string option)
        {
            try
            {
                switch (option)
                {
                    case "Add":
                        this.db.SanPhams.Add(sp);
                        this.db.Entry<SanPham>(sp).State = System.Data.Entity.EntityState.Added;
                        break;
                    case "Delete":
                        this.db.SanPhams.Attach(sp);
                        this.db.Entry<SanPham>(sp).State = System.Data.Entity.EntityState.Deleted;
                        break;
                    case "Update":
                        this.db.SanPhams.Attach(sp);
                        this.db.Entry<SanPham>(sp).State = System.Data.Entity.EntityState.Modified;
                        break;
                }
                this.db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool EditAgent(NhanVien nv, string option)
        {
            try
            {
                switch (option)
                {
                    case "Add":
                        this.db.NhanViens.Add(nv);
                        this.db.Entry<NhanVien>(nv).State = System.Data.Entity.EntityState.Added;
                        break;
                    case "Delete":
                        this.db.NhanViens.Attach(nv);
                        this.db.Entry<NhanVien>(nv).State = System.Data.Entity.EntityState.Deleted;
                        break;
                    case "Update":
                        this.db.NhanViens.Attach(nv);
                        this.db.Entry<NhanVien>(nv).State = System.Data.Entity.EntityState.Modified;
                        break;

                }
                this.db.SaveChanges();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool EditCustomer(KhachHang kh, string option)
        {
            try
            {
                    switch (option)
                    {
                        case "Add":
                            this.db.KhachHangs.Add(kh);
                            this.db.Entry<KhachHang>(kh).State = System.Data.Entity.EntityState.Added;
                            break;
                        case "Delete":
                            this.db.KhachHangs.Attach(kh);
                            this.db.Entry<KhachHang>(kh).State = System.Data.Entity.EntityState.Deleted;
                            break;
                        case "Update":
                            this.db.KhachHangs.Attach(kh);
                            this.db.Entry<KhachHang>(kh).State = System.Data.Entity.EntityState.Modified;
                            break;

                    }
                this.db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool ImportProduct(NhapHang nh, string option)
        {
            try
            {
                switch (option)
                {
                    case "Add":
                        this.db.NhapHangs.Add(nh);
                        this.db.Entry<NhapHang>(nh).State = System.Data.Entity.EntityState.Added;
                        break;
                    case "Update":
                        this.db.NhapHangs.Attach(nh);
                        this.db.Entry<NhapHang>(nh).State = System.Data.Entity.EntityState.Modified;
                        break;

                }
                this.db.SaveChanges();
            }   
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool AddCTKM(ChuongTrinhKM km)
        {
            try
            {

                this.db.ChuongTrinhKMs.Add(km);
                this.db.Entry<ChuongTrinhKM>(km).State = System.Data.Entity.EntityState.Added;
                this.db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool RemoveCTKM(string name)
        {
            try
            {
                ChuongTrinhKM km = this.db.ChuongTrinhKMs.Where(itm => itm.DanhSachQuaTang == name).FirstOrDefault();
                this.db.ChuongTrinhKMs.Attach(km);
                this.db.Entry<ChuongTrinhKM>(km).State = System.Data.Entity.EntityState.Deleted;
                this.db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool EditBike(SanPham sp, string option)
        {
            try
            {
                switch (option)
                {
                    case "Add":
                        this.db.SanPhams.Add(sp);
                        this.db.Entry<SanPham>(sp).State = System.Data.Entity.EntityState.Added;
                        break;
                    case "Delete":
                        this.db.SanPhams.Attach(sp);
                        this.db.Entry<SanPham>(sp).State = System.Data.Entity.EntityState.Deleted;
                        break;
                    case "Update":
                        this.db.SanPhams.Attach(sp);
                        this.db.Entry<SanPham>(sp).State = System.Data.Entity.EntityState.Modified;
                        break;

                }
                this.db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<SanPham> GetHotBikes()
        {
            var get = from itm in this.db.KiemKes
                      join sp in this.db.SanPhams
                      on itm.MaXe equals sp.MaXe
                      where itm.MauSac == sp.MauSac
                      && itm.SoLuongDaBan > 10 && itm.NgayKiemKe == (this.db.KiemKes.Where(kk => kk.MaXe == itm.MaXe && kk.MauSac == itm.MauSac).Max(itm => itm.NgayKiemKe))
                      select sp;
            return get.ToList();
        }    
        public bool EditImport(NhapHang nh, string option)
        {
            try
            {
                switch (option)
                {
                    case "Add":
                        this.db.NhapHangs.Add(nh);
                        this.db.Entry<NhapHang>(nh).State = System.Data.Entity.EntityState.Added;
                        break;
                    case "Delete":
                        this.db.NhapHangs.Attach(nh);
                        this.db.Entry<NhapHang>(nh).State = System.Data.Entity.EntityState.Deleted;
                        break;
                    case "Update":
                        this.db.NhapHangs.Attach(nh);
                        this.db.Entry<NhapHang>(nh).State = System.Data.Entity.EntityState.Modified;
                        break;

                }
                this.db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public KhachHang FindKHById(string makh)
        {
            return this.db.KhachHangs.Where(item => item.MaKH == makh).FirstOrDefault();
        }
        public HoaDon FindHDById(string ma)
        {
            return this.db.HoaDons.Where(item => item.MaHD == ma).FirstOrDefault();
        }
        public List<HoaDon> GetAllBills()
        { 
            return this.db.HoaDons.ToList();
        }

        public List<NhanVien> GetAllStaff()
        {
            return this.db.NhanViens.ToList();
        }
        public ChiTietHoaDon GetBillDetailsById(string ma)
        {
            return this.db.ChiTietHoaDons.Where(item => item.MaHD == ma).FirstOrDefault();
        }

        public NhanVien FindNVById(string manv)
        {
            return this.db.NhanViens.Where(item => item.MaNV == manv).FirstOrDefault();
        }
        public List<string> GetColorsOfProduct(string bikeId)
        {
            var colorsBelongTo = this.db.SanPhams.Where(sp => sp.MaXe == bikeId).Select(sp => sp.MauSac).ToList();
            colorsBelongTo.RemoveAt(0);
            return colorsBelongTo;
        }
        public SanPham TakeProductSelect(string dataSearch)
        {
            return this.db.SanPhams.Where(sp => sp.MaXe == dataSearch || sp.TenXe.Contains(dataSearch)).FirstOrDefault();
        }
        // lấy thông tin khách  

        public List<KhachHang> GetAllCustomer()
        {
            return this.db.KhachHangs.ToList();
        }
        // tt khách theo mã
        public KhachHang GetCustomerById(string kh)
        {
            return this.db.KhachHangs.Where(item => item.MaKH == kh).FirstOrDefault();
        }
        public List<InventoryDTO> GetInventoryInfomationByBike(string maxe, string tenxe)
        {
            DateTime latestInventory = this.db.KiemKes.Where(kk => kk.MaXe == maxe).Max(kk => kk.NgayKiemKe);
            var inventory = from kk in this.db.KiemKes
                                where kk.MaXe == maxe
                                && kk.NgayKiemKe == latestInventory
                                select new InventoryDTO{_maxe = kk.MaXe, _tenxe = tenxe, _soluongban = kk.SoLuongDaBan, _soluongcon = kk.SoLuongCon, _mausac = kk.MauSac, _tinhtrang = kk.TinhTrang};
            return inventory.ToList();
        }
        public List<InventoryDTO> GetInventoryInfomationByType(string maxe)
        {
            DateTime latestInventory = this.db.KiemKes.Where(kk => kk.MaXe == maxe).Max(kk => kk.NgayKiemKe);
            var inventory = from kk in this.db.KiemKes
                            join sp in this.db.SanPhams
                            on kk.MaXe equals sp.MaXe
                            where kk.MaXe.Contains(maxe.Substring(0, 4))
                            && kk.NgayKiemKe == latestInventory
                            select new InventoryDTO { _maxe = kk.MaXe, _tenxe = sp.TenXe, _soluongban = kk.SoLuongDaBan, _soluongcon = kk.SoLuongCon, _mausac = kk.MauSac, _tinhtrang = kk.TinhTrang };
            return inventory.ToList();
        }
        public bool UpdateInfo(object user)
        {
            if (user == null) return false;
            else
            {
                try
                {
                    if(user is NhanVien)
                    {
                        NhanVien nv = (user as NhanVien);
                        this.db.NhanViens.Attach(nv);
                        this.db.Entry<NhanVien>(nv).State = System.Data.Entity.EntityState.Modified;
                    }    
                    else
                    {
                        QuanLy ql = (user as QuanLy);
                        this.db.QuanLies.Attach(ql);
                        this.db.Entry<QuanLy>(ql).State = System.Data.Entity.EntityState.Modified;
                    }    
                        this.db.SaveChanges();
                }
                catch(Exception ex)
                {
                    return false;
                }
                return true;
            }    
        }
        public object[] GetAllStores()
        {
            return (from itm in this.db.CuaHangs
                    select new { _mach = itm.MaCuaHang, _tench = itm.TenCuaHang}).ToArray();
        }
        public List<InventoryDTO> GetInventoryAll()
        {
            var inventory = from kk in this.db.KiemKes
                            join sp in this.db.SanPhams
                            on kk.MaXe equals sp.MaXe
                            where kk.NgayKiemKe == (this.db.KiemKes.Where(item => item.MaXe == kk.MaXe).Max(item => item.NgayKiemKe))
                            select new InventoryDTO { _maxe = kk.MaXe, _tenxe = sp.TenXe, _soluongban = kk.SoLuongDaBan, _soluongcon = kk.SoLuongCon, _mausac = kk.MauSac, _tinhtrang = kk.TinhTrang };
            return inventory.ToList();
        }
        public List<StatisticDTO> GetStatisticInfomationByType(string maxe)
        {
            var inventory = from kk in this.db.KiemKes
                           join cthd in this.db.ChiTietHoaDons
                            on kk.MaXe equals cthd.MaXe
                            join sp in this.db.SanPhams
                            on cthd.MaXe equals sp.MaXe
                            where kk.MaXe.Contains(maxe.Substring(0, 4))
                            select new StatisticDTO { _maxe = kk.MaXe, _tenxe = sp.TenXe, _doanhthu = (double)cthd.ThanhTien, _mausac = kk.MauSac,_soluong = cthd.SoLuong??1, _thoigian = this.db.HoaDons.Where(item => item.MaHD == cthd.MaHD).Select(item => item.NgayLap).FirstOrDefault() };
            return inventory.Distinct().ToList();
        }
        public double? GetDiscountByType(string malk)
        {
            var totalDiscount = (from km in this.db.ChuongTrinhKMs
                                   join ud in this.db.LoaiKhachHangs
                                   on km.MaLoaiKhach equals ud.MaLoaiKhach
                                   where km.MaLoaiKhach == malk
                                   select new { giamgia = km.VoucherGiamGia, uudai = ud.uudai }).FirstOrDefault();


            return totalDiscount.giamgia + totalDiscount.uudai;
        }
        public double? GetDiscountFollowByCustomerType(string type)
        {   
            return this.db.ChuongTrinhKMs.Where(km => km.MaLoaiKhach == type && km.NgayHH > DateTime.Now).Select(item => item.VoucherGiamGia).FirstOrDefault();
        }
        public KiemKe TakeInventory(string maxe)
        {
            return this.db.KiemKes.Where(sp => sp.MaXe == maxe).FirstOrDefault();
        }
        public string UpdateWorkDay(object ob)
        {
            try
            {
                if(ob is NhanVien)
                {
                    this.db.NhanViens.Attach(ob as NhanVien);
                    this.db.Entry<NhanVien>(ob as NhanVien).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {

                    this.db.QuanLies.Attach(ob as QuanLy);
                    this.db.Entry<QuanLy>(ob as QuanLy).State = System.Data.Entity.EntityState.Modified;
                }
                this.db.SaveChanges();
            }
            catch (Exception ex)
            {
                return "Lỗi đăng xuất";
            }
            return "Đăng xuất thành công";
        }
        public bool AddBill(HoaDon hd, ChiTietHoaDon cthd)
        {
            try
            {
                db.HoaDons.Attach(hd);
                db.ChiTietHoaDons.Attach(cthd);
                db.Entry<HoaDon>(hd).State = System.Data.Entity.EntityState.Added;
                db.Entry<ChiTietHoaDon>(cthd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public string GenerateBillCode()
        {
            return db.Database.SqlQuery<string>("select dbo.fn_GenerateBillCode(1) as s").ToString();
        }
        public string GenerateKMCode()
        {
            return db.Database.SqlQuery<string>("select dbo.fn_GenerateKMCode(1) as s").ToString();
        }
        public List<ChuongTrinhKM> GetAllKms()
        {
            return this.db.ChuongTrinhKMs.ToList();
        }
        public ManageBillDTO GetBillInfo(string billCode)
        {

            var getInfo = from hd in this.db.HoaDons
                          join kh in this.db.KhachHangs
                           on hd.MaKH equals kh.MaKH
                           join cthd in this.db.ChiTietHoaDons
                           on hd.MaHD equals cthd.MaHD
                           join xe in this.db.SanPhams
                           on cthd.MaXe equals xe.MaXe
                          where hd.MaHD == billCode
                          select new ManageBillDTO { _tenkh = kh.TenKH, _mahd=hd.MaHD, _ngaylap=hd.NgayLap??DateTime.Now, _thanhtoan = (double)hd.TongTien,_xemua = xe.TenXe, _mausac = xe.MauSac };
            return getInfo.FirstOrDefault();
        }
        public List<int> GetMonthStatisticBillInStore(string storeId)
        {
            var getDates = (from itm in this.db.CuaHangs
                             join nv in this.db.NhanViens
                             on itm.MaCuaHang equals nv.MaCuaHang
                             join hd in this.db.HoaDons
                             on nv.MaNV equals hd.MaNV
                             where itm.MaCuaHang == storeId
                             group hd by hd.NgayLap
                            into gr
                             select new { date = gr.Key.ToString() }).ToList();
            List<int> getMonths = new List<int>();
            foreach( var d in getDates)
            {
                int parse = 0;
                if(int.TryParse(d.date.Split('/')[0], out parse))
                {
                    getMonths.Add(parse);
                }    
            }
            return getMonths;
        }
    }
}
