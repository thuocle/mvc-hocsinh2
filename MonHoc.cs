using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hocsinh_MVC.Helper;
namespace Hocsinh_MVC.Model
{
    class MonHoc
    {
        #region Property
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public int SoTiet { get; set; }
        #endregion
        #region Constructor
        public MonHoc(InputType it)
        {
            if(it == InputType.Them)
            {
                MaMH = InputHelper.InputINT(Resource.InpIDMH, Resource.ErrIDMH);
                TenMH = InputHelper.InputSTR(Resource.InpTenMH, Resource.ErrTenMH, 1, 100);
                SoTiet = InputHelper.InputINT(Resource.InpSoTiet, Resource.ErrSoTiet);
            }
          
        }
        #endregion

        #region Public Method
        public void InThongTin()
        {
            Console.WriteLine($"Ma mon hoc: {MaMH} co ten la {TenMH} - so tiet {SoTiet}");
        }
        #endregion
    }
}
