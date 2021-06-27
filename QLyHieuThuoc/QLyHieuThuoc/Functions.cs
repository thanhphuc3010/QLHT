using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyHieuThuoc
{
    class Functions
    {
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            Database db = new Database();
            DataTable data = db.excuteQuery(sql);
            cbo.DisplayMember = ten; //Trường hiển thị
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DataSource = data;
        }

        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        public static bool CheckKey(string query)
        {
            Database db = new Database();
            DataTable data = db.excuteQuery(query);
            if (data.Rows.Count > 0)
                return true;
            else return false;
        }

        // Hàm tạo mã tự động
        public static string CreateKey(string tiento)
        {
            string key = tiento;

            string[] partsDay;

            partsDay = DateTime.Now.ToShortDateString().Split('/');
            
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);

            key = key + d;

            string[] partsTime;

            partsTime = DateTime.Now.ToLongTimeString().Split(':');
                       
            if (partsTime[2].Substring(3, 2) == "PM")

                partsTime[0] = Functions.ConvertTimeTo24(partsTime[0]);

            if (partsTime[2].Substring(3, 2) == "AM")

                if (partsTime[0].Length == 1)

                    partsTime[0] = "0" + partsTime[0];

            partsTime[2] = partsTime[2].Remove(2, 3);

            string t;

            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);

            key = key + t;

            return key;
        }
    }
}
