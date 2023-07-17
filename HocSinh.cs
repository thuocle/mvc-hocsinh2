using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hocsinh_MVC.Helper;
namespace Hocsinh_MVC.Model
{
    class HocSinh
    {
        #region public proprety
        public int MaHS { get; set; }
        public string TenHS { get; set; }
        public DateTime NgaySinh { get; set; }

        #endregion

        #region Constructor
        public HocSinh()
        {
             
            MaHS = InputHelper.InputINT(Resource.InpIDHS, Resource.ErrID);
            TenHS = InputHelper.InputSTR(Resource.InpTenHS, Resource.ErrTenHS, 6, 20);
            NgaySinh = InputHelper.InputDATE(Resource.InpNgSinh, Resource.ErrNgSinh, new DateTime(2005,01,01), new DateTime(2016, 12,31));
            
        }

        #endregion
        #region Public Method
        public void InThongTin()
        {
            Console.WriteLine($"Ma hoc sinh: {MaHS} co ten la {TenHS} - sinh ngay {NgaySinh}");
        }
        #endregion
    }
}
