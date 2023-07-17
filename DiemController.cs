using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hocsinh_MVC.Model;
using Hocsinh_MVC.Helper;

namespace Hocsinh_MVC.Controller
{
    class DiemController
    {
        /* List<HocSinh> DanhSachHS = new List<HocSinh>() { new HocSinh() { MaHS = 1, TenHS = "abc", NgaySinh=DateTime.Now } };
         List<MonHoc> DanhSachMH = new List<MonHoc>() { new MonHoc() { MaMH = 1, SoTiet = 1, TenMH = "1" }, new MonHoc() { MaMH = 2, SoTiet = 2, TenMH = "2" }, };
         List<Diem> DanhSachDiem = new List<Diem>() { new Diem() { MaHS=1, DiemHS=1, MaMH=1 }, new Diem() { MaHS = 2, DiemHS = 9, MaMH = 1 } };*/
        List<HocSinh> DanhSachHS = new List<HocSinh>();
        List<MonHoc> DanhSachMH = new List<MonHoc>();
        List<Diem> DanhSachDiem = new List<Diem>();
        public ErrorType ThemHocSinh(HocSinh hs)
        {
            if (DanhSachHS.Count == 0)
            {
                DanhSachHS.Add(hs);
                return ErrorType.ThanhCong;
            }
            else
            {
                int pos = DanhSachHS.FindIndex(x => x.MaHS == hs.MaHS);
                if (pos != -1)
                {
                    return ErrorType.HSDaTonTai;
                }
                else
                {
                    DanhSachHS.Add(hs);
                    return ErrorType.ThanhCong;
                }
            }
        }
        public ErrorType ThemMonHoc(MonHoc mh)
        {
            if (DanhSachMH.Count == 0)
            {
                DanhSachMH.Add(mh);
                return ErrorType.ThanhCong;
            }
            else
            {
                int pos = DanhSachMH.FindIndex(x => x.MaMH == mh.MaMH);
                if (pos != -1)
                {
                    return ErrorType.MHDaTonTai;
                }
                else
                {
                    DanhSachMH.Add(mh);
                    return ErrorType.ThanhCong;
                }
            }
        }
        public ErrorType ChamDiem(int maHS, int maMH)
        {
            if (DanhSachHS.Count == 0)
            {
                return ErrorType.DanhSachTrong;
            }
            else
            {
                int posHS = DanhSachHS.FindIndex(x => x.MaHS == maHS);
                int posMH = DanhSachMH.FindIndex(x => x.MaMH == maMH);
                if (posHS == -1)
                {
                    return ErrorType.HSChuaTonTai;
                }
                else if (posMH == -1)
                {
                    return ErrorType.MHChuaTonTai;
                }
                else
                {
                    DanhSachDiem.Add(new Diem(InputType.ChamDiem) { MaMH = maMH, MaHS = maHS });
                    return ErrorType.ThanhCong;
                }
            }
        }
        public ErrorType BangDiem(int maHS)
        {
            if (DanhSachDiem.Count == 0)
            {
                return ErrorType.DanhSachTrong;
            }
            else
            {
                int pos = DanhSachHS.FindIndex(x => x.MaHS == maHS);
                int pos2 = DanhSachDiem.FindIndex(x => x.MaHS == maHS);
                if (pos == -1) return ErrorType.HSChuaTonTai;
                else if (pos2 == -1) return ErrorType.HocSinhChuaCoDiem;
                else
                {
                    DanhSachDiem.FindAll(x => x.MaHS == maHS).ForEach(x=>x.HienThi());
                    return ErrorType.ThanhCong;
                }
            }
        }
        public ErrorType TongKetMon(int maMH)
        {
            if (DanhSachDiem.Count == 0)
            {
                return ErrorType.DanhSachTrong;
            }
            else
            {
                int pos = DanhSachMH.FindIndex(x => x.MaMH == maMH);
                int pos2 = DanhSachDiem.FindIndex(x => x.MaMH == maMH);
                if (pos == -1) return ErrorType.MHChuaTonTai;
                else if (pos2 == -1) return ErrorType.MonHocChuaCoDiem;
                else
                {
                    DanhSachDiem.FindAll(x => x.MaMH == maMH).ForEach(x => x.HienThi());
                    return ErrorType.ThanhCong;
                }
            }
        }
        public ErrorType InDanhSach()
        {
            DanhSachDiem.ForEach(x => x.HienThi());
            return ErrorType.ThanhCong;
        }

    }
}
