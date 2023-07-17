using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocsinh_MVC.Helper
{
    enum InputType
    {
        Them, ChamDiem, BangDiem, TongKetMon
    }
    class InputHelper
    {
        public static int InputINT(string msg, string err, int min = 0)
        {
            bool check;
            int ret;
            do
            {
                Console.WriteLine(msg);
                check = int.TryParse(Console.ReadLine(), out ret);
                check = check && ret > min;
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
        public static string InputSTR(string msg, string err, int min, int max)
        {
            bool check;
            string ret;
            do
            {
                Console.WriteLine(msg);
                ret = Console.ReadLine();
                check = ret.Length >= min && ret.Length <= max;
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
        public static DateTime InputDATE(string msg, string err, DateTime min, DateTime max)
        {
            bool check;
            DateTime ret;
            do
            {
                Console.WriteLine(msg);
                check = DateTime.TryParse(Console.ReadLine(), out ret);
                check = check && ret >= min && ret <= max;
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
        public static double InputDOUBLE(string msg, string err, double min = 0, double max = 10)
        {
            bool check;
            double ret;
            do
            {
                Console.WriteLine(msg);
                check = double.TryParse(Console.ReadLine(), out ret);
                check = check && ret >= min && ret <= max && ret % 0.25 == 0;
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
    }
}
