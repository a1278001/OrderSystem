using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GlobalVar
    {
        public static CustomerInterface form點餐畫面;
        public static CustomerOrder form訂單資訊;
        public static MainMenu formMain;
        public static CustomerMenu formCustomer;
        public static EmployeeMenu formEmployee;
        public static string 使用者名稱 = "";
        public static string 登入帳號 = "";
        public static int 登入者ID;
        public static string 使用者電話 = "";
        public static bool 登入判定 = false;
        public static bool 管理員判定 = false;
        public static string 使用者身分 = "";
        public static List<Order> OrderList = new List<Order>();
    }
}
