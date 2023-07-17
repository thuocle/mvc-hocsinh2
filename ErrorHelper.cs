using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocsinh_MVC.Helper
{
    enum ErrorType
    {
        HSDaTonTai, MHDaTonTai, HSChuaTonTai, MHChuaTonTai, DanhSachTrong, ThanhCong, HocSinhChuaCoDiem, MonHocChuaCoDiem
    }
    class ErrorHelper
    {
        public static void Log(ErrorType et)
        {
            switch (et)
            {
                case ErrorType.HSDaTonTai:
                    Console.WriteLine(Resource.HSDaTonTai);
                    break;
                case ErrorType.MHDaTonTai:
                    Console.WriteLine(Resource.MHDaTonTai);
                    break;
                case ErrorType.HSChuaTonTai:
                    Console.WriteLine(Resource.HSChuaTonTai);
                    break;
                case ErrorType.MHChuaTonTai:
                    Console.WriteLine(Resource.MHChuaTonTai);
                    break;
                case ErrorType.DanhSachTrong:
                    Console.WriteLine(Resource.DanhSachTrong);
                    break;
                case ErrorType.ThanhCong:
                    Console.WriteLine(Resource.ThanhCong);
                    break;
                case ErrorType.HocSinhChuaCoDiem:
                    Console.WriteLine(Resource.HocSinhChuaCoDiem);
                    break;
                case ErrorType.MonHocChuaCoDiem:
                    Console.WriteLine(Resource.MonHocChuaCoDiem);
                    break;
            }
        }
    }
}
