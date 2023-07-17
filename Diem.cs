using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hocsinh_MVC.Helper;
namespace Hocsinh_MVC.Model
{
    class Diem
    {
        #region Property
        public int MaMH { get; set; }
        public int MaHS { get; set; }
        public double DiemHS { get; set; }

        #endregion
        #region Constructor
        public Diem(InputType it)
        {
            if (it == InputType.ChamDiem) 
            {
                DiemHS = InputHelper.InputDOUBLE(Resource.InpDiem, Resource.ErrDiem);
            }
        }
        
        #endregion
        #region public method
        public void HienThi()
        {
            Console.WriteLine($"Hoc sinh ID: {MaHS}, Mon hoc ID {MaMH}, Diem: {DiemHS}");
        }
        #endregion
    }
}
