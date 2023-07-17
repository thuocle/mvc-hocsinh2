using System;
using Hocsinh_MVC.Controller;
using Hocsinh_MVC.View;
using Hocsinh_MVC.Model;
using Hocsinh_MVC.Helper;
namespace Hocsinh_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            HocSinhView view = new HocSinhView();
            view.MENU();
        }
    }
}
