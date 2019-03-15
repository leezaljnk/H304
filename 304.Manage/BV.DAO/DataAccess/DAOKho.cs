using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BV.AppCommon;
using BV.DataModel;
using Common.Winforms;

namespace BV.DAO
{
    public class DAOKho
    {
        public static Thuoc_VatTuYteTonKho GetThuocTonKho(Guid thuocId)
        {
            return DAOApp.DbContext.Thuoc_VatTuYteTonKho.FirstOrDefault(t => t.ThuocVtytID == thuocId);
        }

        public static DinhGiaHangHoa GetGiaThuoc(Guid thuocID)
        {
            //var giaThuoc = DAOApp.DbContext.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == thuocID);
            //DAOApp.DbContext.Entry(giaThuoc).State = EntityState.Detached;
            //return giaThuoc;
            return DAOApp.DbContext.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == thuocID);
        }

        public static List<ChuyenDoiDonViHangHoa> GetChuyenDoiDonViThuoc(Guid hangHoaID)
        {
            return DAOApp.DbContext.ChuyenDoiDonViHangHoa.Where(t => t.HangHoaID == hangHoaID).ToList();
        }

        public static void SaveThuoc304(HangHoa oThuoc, DinhGiaHangHoa giaThuoc, List<ChuyenDoiDonViHangHoa> lstDonVi)
        {
            var thuoc = DAOApp.DbContext.HangHoa.FirstOrDefault(t => t.ID == oThuoc.ID);
            if (thuoc == null)
            {
                DAOApp.DbContext.HangHoa.Add(oThuoc);
            }
            else
            {
                thuoc.Ten = oThuoc.Ten;
                thuoc.TenKhac = oThuoc.TenKhac;
                thuoc.Ma = oThuoc.Ma;
                thuoc.HoatChat = oThuoc.HoatChat;
                thuoc.HamLuong = oThuoc.HamLuong;
                thuoc.DuongDung = oThuoc.DuongDung;
                thuoc.DongGoi = oThuoc.DongGoi;
                thuoc.HoTriLieu = oThuoc.HoTriLieu;
                thuoc.DonViID = oThuoc.DonViID;
            }

            var updateItem = DAOApp.DbContext.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == giaThuoc.HangHoaID);
            if (updateItem == null)
            {
                DAOApp.DbContext.DinhGiaHangHoa.Add(giaThuoc);
            }
            else
            {
                if (giaThuoc.GiaDichVu != updateItem.GiaDichVu || giaThuoc.GiaBaoHiem != updateItem.GiaBaoHiem)
                {
                    //Save change
                    giaThuoc.GiaDichVu = updateItem.GiaDichVu;
                    giaThuoc.GiaBaoHiem = updateItem.GiaBaoHiem;
                    //giaThuoc.GhiChu = updateItem.GhiChu;
                    giaThuoc.MaNguoiDinhGia = updateItem.MaNguoiDinhGia;
                    giaThuoc.TenNguoiDinhGia = updateItem.TenNguoiDinhGia;
                    giaThuoc.ThoiGianCapNhat = DateTime.Now;
                }
            }
            //var lstOriginalGiaThuoc = KhoChungProvider.KhoTong.DinhGiaHangHoa.Where(t => t.HangHoaID == oThuoc.ID).ToList();
            //foreach (var updateItem in lstGiaThuoc)
            //{
            //    //var giaThuoc = KhoChungProvider.KhoTong.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == updateItem.HangHoaID && t.LoaiGiaID == updateItem.LoaiGiaID);
            //    var giaThuoc = lstOriginalGiaThuoc.FirstOrDefault(t => t.HangHoaID == updateItem.HangHoaID && t.LoaiGiaID == updateItem.LoaiGiaID);
            //    if (giaThuoc == null)
            //    {
            //        KhoChungProvider.KhoTong.DinhGiaHangHoa.Add(updateItem);
            //    }
            //    else
            //    {
            //        lstOriginalGiaThuoc.Remove(giaThuoc);
            //        if (giaThuoc.GiaTien != updateItem.GiaTien)
            //        {
            //            //Save change
            //            giaThuoc.GiaTien = updateItem.GiaTien;
            //            giaThuoc.GhiChu = updateItem.GhiChu;
            //            giaThuoc.MaNguoiDinhGia = updateItem.MaNguoiDinhGia;
            //            giaThuoc.TenNguoiDinhGia = updateItem.TenNguoiDinhGia;
            //            giaThuoc.ThoiGianCapNhat = DateTime.Now;
            //        }
            //    }
            //}

            //KhoChungProvider.KhoTong.DinhGiaHangHoa.RemoveRange(lstOriginalGiaThuoc);


            //Save thông tin các đơn vị thuốc
            var removeDonvi = DAOApp.DbContext.ChuyenDoiDonViHangHoa.Where(d => d.HangHoaID == oThuoc.ID).ToList();
            //Don vi chinh
            {
                var donvi = DAOApp.DbContext.ChuyenDoiDonViHangHoa.FirstOrDefault(d =>
                    d.DonViID == oThuoc.DonViID && d.HangHoaID == oThuoc.ID);
                if (donvi == null)
                {
                    var dv = new ChuyenDoiDonViHangHoa();
                    dv.ID = Guid.NewGuid();
                    dv.HangHoaID = oThuoc.ID;
                    dv.DonViID = oThuoc.DonViID.Value;
                    dv.TiLeChuyenDoi = 1;
                    dv.PhuongThucChuyenDoi = 1;
                    dv.MoTa = "Đơn vị chính";

                    DAOApp.DbContext.ChuyenDoiDonViHangHoa.Add(dv);
                }
                else
                {
                    removeDonvi.RemoveAll(d => d.ID == oThuoc.ID);
                    donvi.TiLeChuyenDoi = 1;
                    donvi.PhuongThucChuyenDoi = 1;
                    donvi.MoTa = "Đơn vị chính";
                }
            }

            //Đơn vị chuyển đổi
            foreach (var dv in lstDonVi)
            {
                var donvi = DAOApp.DbContext.ChuyenDoiDonViHangHoa.FirstOrDefault(d => d.ID == dv.ID);
                if (donvi == null)
                {
                    DAOApp.DbContext.ChuyenDoiDonViHangHoa.Add(dv);
                }
                else
                {
                    removeDonvi.RemoveAll(d => d.ID == dv.ID);
                    donvi.DonViID = dv.DonViID;
                    donvi.TiLeChuyenDoi = dv.TiLeChuyenDoi;
                    donvi.PhuongThucChuyenDoi = dv.PhuongThucChuyenDoi;
                    donvi.MoTa = dv.MoTa;
                }
            }

            DAOApp.DbContext.ChuyenDoiDonViHangHoa.RemoveRange(removeDonvi);
            //foreach (var item in removeDonvi)
            //{
            //    KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.RemoveRange(removeDonvi);
            //}

            DAOApp.DbContext.SaveChanges();
        }

        public static QuyetDinhThau SaveThongTinQuyetDinhThau(QuyetDinhThau oEntity)
        {
            QuyetDinhThau oRet = null;
            if (oEntity.ID == Guid.Empty)
            {
                //Add
                oRet = DAOApp.DbContext.QuyetDinhThau.FirstOrDefault(l => l.Ma == oEntity.Ma);
                if (oRet != null) throw new Exception("Quyết định đã có trên hệ thống.");

                oEntity.ID = Guid.NewGuid();
                oRet = DAOApp.DbContext.QuyetDinhThau.Add(oEntity);
            }
            else
            {
                oRet = DAOApp.DbContext.QuyetDinhThau.FirstOrDefault(l => l.ID == oEntity.ID);
                oRet.Ma = oEntity.Ma;
                oRet.MoTa = oEntity.MoTa;
                oRet.NgayQuyetDinh = oEntity.NgayQuyetDinh;
                oRet.HieuLuc = oEntity.HieuLuc;
            }

            DAOApp.DbContext.SaveChanges();
            return oRet;
        }

        public static LoHangHoa SaveThongTinLoHang(LoHangHoa oEntity)
        {
            LoHangHoa oRet = null;
            if (oEntity.ID == Guid.Empty)
            {
                //Add
                oRet = DAOApp.DbContext.LoHangHoa.FirstOrDefault(l =>
                    l.ThuocVtytID == oEntity.ThuocVtytID && l.SoLo == oEntity.SoLo);
                if (oRet != null) throw new Exception("Lô hàng này đã có trên hệ thống.");

                oEntity.ID = Guid.NewGuid();
                oRet = DAOApp.DbContext.LoHangHoa.Add(oEntity);
            }
            else
            {
                oRet = DAOApp.DbContext.LoHangHoa.FirstOrDefault(l => l.ID == oEntity.ID);
                oRet.SoLo = oEntity.SoLo;
                oRet.HanSuDung = oEntity.HanSuDung;
            }

            DAOApp.DbContext.SaveChanges();
            return oRet;
        }

        public static NhaCungCap SaveNhaCungCap(NhaCungCap oEntity)
        {
            var ncc = DAOApp.DbContext.NhaCungCap.FirstOrDefault(n => n.ID == oEntity.ID);
            if (ncc == null)
            {
                ncc = DAOApp.DbContext.NhaCungCap.Add(oEntity);
            }
            else
            {
                ncc.Ten = oEntity.Ten;
                ncc.DiaChi = oEntity.DiaChi;
                ncc.TinhThanh = oEntity.TinhThanh;
                ncc.QuocGia = oEntity.QuocGia;
                ncc.DienThoai = oEntity.DienThoai;
                ncc.Fax = oEntity.Fax;
                ncc.GhiChu = oEntity.GhiChu;
                ncc.Email = oEntity.Email;
                ncc.WebSite = oEntity.WebSite;
            }

            DAOApp.DbContext.SaveChanges();
            return ncc;
        }

        /// <summary>
        ///     Insert into PhieuNhapKho and Thuoc_VatTuYteTonKho
        /// </summary>
        /// <param name="oEntity"></param>
        /// <returns></returns>
        public static bool SavePhieuNhapKhoTuNhaCungCap(PhieuNhapKho oEntity)
        {
            var phieuNhap = new PhieuNhapKho
            {
                ID = Guid.NewGuid(),
                Ma = oEntity.Ma,
                MaNhaCungCap = oEntity.MaNhaCungCap,
                MaPhanLoaiHoaDon = oEntity.MaPhanLoaiHoaDon,
                NgayHoaDon = oEntity.NgayHoaDon,
                NgayTao = oEntity.NgayTao,
                NguoiCungCap = oEntity.NguoiCungCap,
                NguoiTao = oEntity.NguoiTao,
                NhaCungCap = oEntity.NhaCungCap,
                PhanLoaiHoaDon = oEntity.PhanLoaiHoaDon,
                PhieuDeNghiId = oEntity.PhieuDeNghiId,
                SoHoaDon = oEntity.SoHoaDon,
                TenPhanLoaiHoaDon = oEntity.TenPhanLoaiHoaDon,
                ThanhTien = oEntity.ThanhTien,
                TongTien = oEntity.TongTien,
                VAT = oEntity.VAT,
                KhoId = oEntity.KhoId,
                GhiChu = oEntity.GhiChu
            };
            //DAOApp.DbContext.PhieuNhapKho.Add(phieuNhap);
            //DAOApp.DbContext.SaveChanges();

            foreach (var chiTietPhieu in oEntity.PhieuNhapChiTiet)
            {
                var chiTiet = new PhieuNhapChiTiet
                {
                    ID = Guid.NewGuid(),
                    LoaiChietKhau = chiTietPhieu.LoaiChietKhau,
                    ThanhTien = chiTietPhieu.ThanhTien,
                    ChietKhau = chiTietPhieu.ChietKhau,
                    DonGia = chiTietPhieu.DonGia,
                    HanSuDung = chiTietPhieu.HanSuDung,
                    HangHoaID = chiTietPhieu.HangHoaID,
                    LoHangID = chiTietPhieu.LoHangID,
                    MaDonVi = chiTietPhieu.MaDonVi,
                    //PhieuID = phieuNhap.ID,
                    SoLuong = chiTietPhieu.SoLuong,
                    SoQuyeDinh = chiTietPhieu.SoQuyeDinh,
                    TenDonVi = chiTietPhieu.TenDonVi
                };
                // DAOApp.DbContext.PhieuNhapChiTiet.Add(chiTiet);
                var thuocTonKho = GetThuocTonKho(chiTiet.HangHoaID);
                if (thuocTonKho == null)
                {
                    var tonKho = new Thuoc_VatTuYteTonKho
                    {
                        ID = Guid.NewGuid(),
                        HanSuDung = chiTietPhieu.HanSuDung,
                        MaHoatChat = chiTietPhieu.HangHoa?.HoatChat,
                        PhanLoaiDuocID = chiTietPhieu.HangHoa?.PhanLoaiDuocID,
                        SoLo = chiTietPhieu.LoHangHoa?.SoLo,
                        SoLuongDaNhap = Converter.Obj2decimal(chiTietPhieu.SoLuong),
                        SoLuongDaXuat = 0,
                        SoLuongTon = Converter.Obj2decimal(chiTietPhieu.SoLuong),
                        SoQuyetDinh = chiTietPhieu.SoQuyeDinh,
                        ThuocVtytID = chiTietPhieu.HangHoaID
                    };
                    DAOApp.DbContext.Thuoc_VatTuYteTonKho.Add(tonKho);
                }
                else
                {
                    thuocTonKho.HanSuDung = chiTietPhieu.HanSuDung;
                    thuocTonKho.MaHoatChat = chiTietPhieu.HangHoa?.HoatChat;
                    thuocTonKho.PhanLoaiDuocID = chiTietPhieu.HangHoa?.PhanLoaiDuocID;
                    thuocTonKho.SoLo = chiTietPhieu.LoHangHoa?.SoLo;
                    thuocTonKho.SoLuongDaNhap = thuocTonKho.SoLuongDaNhap + Converter.Obj2decimal(chiTietPhieu.SoLuong);
                    thuocTonKho.SoLuongDaXuat = thuocTonKho.SoLuongDaXuat;
                    thuocTonKho.SoLuongTon = thuocTonKho.SoLuongTon + Converter.Obj2decimal(chiTietPhieu.SoLuong);
                    thuocTonKho.SoQuyetDinh = chiTietPhieu.SoQuyeDinh;
                    thuocTonKho.ThuocVtytID = chiTietPhieu.HangHoaID;
                    if (DAOApp.DbContext.Entry(thuocTonKho).State == EntityState.Detached)
                        DAOApp.DbContext.Thuoc_VatTuYteTonKho.Attach(thuocTonKho);
                    DAOApp.DbContext.Entry(thuocTonKho).State = EntityState.Modified;
                }

                phieuNhap.PhieuNhapChiTiet.Add(chiTiet);
            }

            //DAOApp.DbContext.ChiTietPhieu.AddRange(oEntity.ChiTietPhieus);
            DAOApp.DbContext.SaveChanges();

            return true;
        }


        #region Tra thuoc

        public static IQueryable<PhieuTraThuoc> GetPhieuTraThuoc(string maPhieu, DateTime? tuNgay, DateTime? denNgay)
        {
            //IQueryable<PhieuTraThuoc> phieuTra;
            if (!string.IsNullOrEmpty(maPhieu))
                return DAOApp.DbContext.PhieuTraThuoc.Where(m => m.MaPhieuTra == maPhieu);
            if (string.IsNullOrEmpty(maPhieu) && tuNgay != null)
                return DAOApp.DbContext.PhieuTraThuoc.Where(m => m.NgayLap >= tuNgay && m.NgayLap <= denNgay);
            if (!string.IsNullOrEmpty(maPhieu) && tuNgay != null)
                return DAOApp.DbContext.PhieuTraThuoc.Where(m =>
                    m.MaPhieuTra == maPhieu && m.NgayLap >= tuNgay && m.NgayLap <= denNgay);

            return null;
        }

        #endregion

        //TODO: Need more debug and fix Save Tra Thuoc
        public static bool SaveXuatTraThuoc(PhieuTraThuoc phieuTra, string maPhieuNhap, string maXuatTra)
        {
            // update phieu tra
            phieuTra.TinhTrang = (int)PhieuTraThuocType.DaDuyet;
            if (DAOApp.DbContext.Entry(phieuTra).State == EntityState.Detached)
                DAOApp.DbContext.PhieuTraThuoc.Attach(phieuTra);
            DAOApp.DbContext.Entry(phieuTra).State = EntityState.Modified;
            //tao xuat tra thuoc
            var xuatTra = new XuatTra
            {
                ID = Guid.NewGuid(),
                MaPhieu = maXuatTra,
                PhieuTraThuoc = phieuTra,
                Kho = phieuTra.Kho,
                LyDo = phieuTra.LyDoLuuThuHoi,
                Ngay = DateTime.Now,
                NguoiLap = phieuTra.NguoiLap,
                XuatTraChiTiet = new List<XuatTraChiTiet>()
            };
            //tao phieu nhap

            var phieuNhap = new PhieuNhapKho
            {
                ID = Guid.NewGuid(),
                Ma = maPhieuNhap,
                //MaNhaCungCap = oEntity.MaNhaCungCap,
                //MaPhanLoaiHoaDon = oEntity.MaPhanLoaiHoaDon,
                NgayHoaDon = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCungCap = "nguoi cung cap",
                NguoiTao = xuatTra.NguoiLap.ToString(),
                //NhaCungCap = oEntity.NhaCungCap,
                //PhanLoaiHoaDon = oEntity.PhanLoaiHoaDon,
                //PhieuDeNghiId = oEntity.PhieuDeNghiId,
                SoHoaDon = "so hoa don",
                TenPhanLoaiHoaDon = "ten phan loai hoa don",
                //ThanhTien = oEntity.ThanhTien,
                TongTien = Converter.obj2double(xuatTra.XuatTraChiTiet.Sum(e => e.Gia * e.SoLuong)),
                VAT = 0,
                KhoId = PublicVariable.CurrentKhoId,
                GhiChu = $"Nhập xuất trả thuốc-{phieuTra.MaPhieuTra}"
            };
            //chi tiet phieu xuat tra va phieu nhap chi tiet
            foreach (var phieuTraChiTiet in phieuTra.PhieuTraThuocChiTiet)
            {

                var chiTiet = new PhieuNhapChiTiet
                {
                    ID = Guid.NewGuid(),
                    //LoaiChietKhau = chiTietPhieu.LoaiChietKhau,
                    ThanhTien = Converter.obj2double(xuatTra.XuatTraChiTiet.Sum(e => e.Gia * e.SoLuong)),
                    //ChietKhau = chiTietPhieu.ChietKhau,
                    DonGia = phieuTraChiTiet.DonGia,
                    HanSuDung = phieuTraChiTiet.HanSuDung,
                    HangHoaID = phieuTraChiTiet.HangHoa.ID,
                    LoHangID = phieuTraChiTiet.LoHangHoa?.ID,
                    MaDonVi = phieuTraChiTiet.HangHoa?.DonViID,
                    //PhieuID = phieuNhap.ID,
                    SoLuong = phieuTraChiTiet.SoLuongTra,
                    SoQuyeDinh = "SoQuyetDinh",
                    TenDonVi = phieuTraChiTiet.HangHoa.DonViHangHoa.Ten
                };

                var xuatTraChiTiet = new XuatTraChiTiet
                {
                    ID = Guid.NewGuid(),
                    HangHoa = phieuTraChiTiet.HangHoa,
                    SoLuong = (int)phieuTraChiTiet.SoLuongTra,
                    SoLo = phieuTraChiTiet.LoHangHoa?.SoLo,
                    Gia = Converter.obj2decimal(phieuTraChiTiet.DonGia),
                    HoaDonID = "Hoa don Id",
                    PhieuNhapID = chiTiet.ID
                };
                xuatTra.XuatTraChiTiet.Add(xuatTraChiTiet);

                // DAOApp.DbContext.PhieuNhapChiTiet.Add(chiTiet);
                var thuocTonKho = GetThuocTonKho(chiTiet.HangHoaID);
                if (thuocTonKho == null)
                {
                    var tonKho = new Thuoc_VatTuYteTonKho
                    {
                        ID = Guid.NewGuid(),
                        HanSuDung = phieuTraChiTiet.HanSuDung,
                        MaHoatChat = phieuTraChiTiet.HangHoa?.HoatChat,
                        PhanLoaiDuocID = phieuTraChiTiet.HangHoa?.PhanLoaiDuocID,
                        SoLo = phieuTraChiTiet.LoHangHoa?.SoLo,
                        SoLuongDaNhap = Converter.Obj2decimal(phieuTraChiTiet.SoLuongTra),
                        SoLuongDaXuat = 0,
                        SoLuongTon = Converter.Obj2decimal(phieuTraChiTiet.SoLuongTra),
                        SoQuyetDinh = "SoQuyetDinh", //phieuTraChiTiet.SoQuyeDinh,
                        ThuocVtytID = phieuTraChiTiet.HangHoaID
                    };
                    DAOApp.DbContext.Thuoc_VatTuYteTonKho.Add(tonKho);
                }
                else
                {
                    thuocTonKho.HanSuDung = phieuTraChiTiet.HanSuDung;
                    thuocTonKho.MaHoatChat = phieuTraChiTiet.HangHoa?.HoatChat;
                    thuocTonKho.PhanLoaiDuocID = phieuTraChiTiet.HangHoa?.PhanLoaiDuocID;
                    thuocTonKho.SoLo = phieuTraChiTiet.LoHangHoa?.SoLo;
                    thuocTonKho.SoLuongDaNhap =
                        thuocTonKho.SoLuongDaNhap + Converter.Obj2decimal(phieuTraChiTiet.SoLuongTra);
                    thuocTonKho.SoLuongDaXuat = thuocTonKho.SoLuongDaXuat;
                    thuocTonKho.SoLuongTon = thuocTonKho.SoLuongTon + Converter.Obj2decimal(phieuTraChiTiet.SoLuongTra);
                    thuocTonKho.SoQuyetDinh = "SoQuyetDinh"; // chiTietPhieu.SoQuyeDinh;
                    thuocTonKho.ThuocVtytID = phieuTraChiTiet.HangHoaID;
                    if (DAOApp.DbContext.Entry(thuocTonKho).State == EntityState.Detached)
                        DAOApp.DbContext.Thuoc_VatTuYteTonKho.Attach(thuocTonKho);
                    DAOApp.DbContext.Entry(thuocTonKho).State = EntityState.Modified;
                }

                phieuNhap.PhieuNhapChiTiet.Add(chiTiet);
            }

            DAOApp.DbContext.XuatTra.Add(xuatTra);
            DAOApp.DbContext.PhieuNhapKho.Add(phieuNhap);

            DAOApp.DbContext.SaveChanges();
            return true;
        }

        public static IQueryable<XuatTra> GetXuatTra(DateTime? tuNgay, DateTime? denNgay, Guid? nguoiLap)
        {
            if (nguoiLap != null)
                return DAOApp.DbContext.XuatTra.Where(m => m.NguoiLap == nguoiLap);
            if (tuNgay != null)
                return DAOApp.DbContext.XuatTra.Where(m => m.Ngay >= tuNgay && m.Ngay <= denNgay);

            return DAOApp.DbContext.XuatTra.Where(m =>
                m.NguoiLap == nguoiLap && m.Ngay >= tuNgay && m.Ngay <= denNgay);
        }

        public static IQueryable<PhieuDeNghi> GetPhieuDeNghi(DateTime? tuNgay, DateTime? denNgay, Guid? khoId, PhieuDeNghiLoaiType phieuDeNghiLoai, PhieuDeNghiTinhTrangType tinhTrang)
        {
            if (tuNgay == null && khoId == null)
                return null;
            var loai = (int)phieuDeNghiLoai;
            var tTrang = (int)tinhTrang;
            if (tuNgay != null && khoId == null)
                return DAOApp.DbContext.PhieuDeNghi.Where(d => d.NgayDeNghi >= tuNgay && d.NgayDeNghi <= denNgay && d.LoaiPhieu == loai && d.TinhTrang == tTrang);
            if (tuNgay != null && khoId != null)
                return DAOApp.DbContext.PhieuDeNghi.Where(d => d.NgayDeNghi >= tuNgay && d.NgayDeNghi <= denNgay && d.MaKhoNhap == khoId && d.LoaiPhieu == loai && d.TinhTrang == tTrang);
            if (tuNgay == null && khoId != null)
                return DAOApp.DbContext.PhieuDeNghi.Where(d => d.MaKhoNhap == khoId && d.LoaiPhieu == loai && d.TinhTrang == tTrang);
            return null;
        }

        public static PhieuDeNghi GetPhieuDeNghi(string maPhieu, PhieuDeNghiLoaiType type)
        {
            var phieuType = (int) type;
            return DAOApp.DbContext.PhieuDeNghi.FirstOrDefault(d => d.Ma == maPhieu && d.LoaiPhieu == phieuType);
        }

        public static void HuyPhieuDenghi(Guid phieuDeNghiId, string lyDoHuy)
        {
            var phieuDeNghi = DAOApp.DbContext.PhieuDeNghi.AsNoTracking().FirstOrDefault(e => e.ID == phieuDeNghiId);
            phieuDeNghi.TinhTrang = (int)PhieuDeNghiTinhTrangType.DaHuy;
            phieuDeNghi.LyDoHuy = lyDoHuy;
            phieuDeNghi.NgayHuy = DateTime.Now;
            phieuDeNghi.NguoiHuy = "Nguoi Huy";
            //if (DAOApp.DbContext.Entry(phieuDeNghi).State == EntityState.Detached)
            //DAOApp.DbContext.PhieuDeNghi.Attach(phieuDeNghi);
            //DAOApp.DbContext.Entry(phieuDeNghi).State = EntityState.Modified;
            DAOApp.DbContext.SaveChanges();
        }

        public static IEnumerable<Thuoc_VatTuYteTonKho> GetThuocTonKhoByIds(IEnumerable<Guid?> thuocIds)
        {
            return DAOApp.DbContext.Thuoc_VatTuYteTonKho.AsNoTracking().Where(e => thuocIds.Contains(e.ThuocVtytID));
        }
    }
}