using System;

namespace CSharpLib
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Random
            DisplayLottery();
            DisplayAbs();
            DisplayMax();
            DisplayMin();
            DisplayRound();
            DisplayFloor();
            DisplayCeiling();
            DisplayCompareTo();
            DisplayIndexof();
            DisplayLastIndexOf();
            DisplayReplace();
            DisplaySplit();
            DisplaySubstring();
            DisplayToLower();
            DisplayToUpper();
            DisplayTrim();
        }

        private static void DisplayLottery()
        {
            string msg = "";
            string[] Lotterys = BigLottery();
            foreach (string num in Lotterys)
            {
                msg = msg + num + ",";
            }
            msg = msg.Substring(0, msg.LastIndexOf(",")); //去除最後一個逗號
            Console.WriteLine("本期樂透開獎：" + msg);
        }

        private static void DisplayAbs()
        {
            int n = -5;
            int m = Math.Abs(n);
            string msg = string.Format("{0} to abs -> {1}", n, m);
            Console.WriteLine("Abs:" + msg);
        }

        private static void DisplayMax()
        {
            int n = 5;
            int m = 10;
            string msg = string.Format("n = {0}, m = {1} 二數最大值為 {2}", n, m, Math.Max(n, m));
            Console.WriteLine("Max:" + msg);
        }

        private static void DisplayMin()
        {
            int n = 5;
            int m = 10;
            string msg = string.Format("n = {0}, m = {1} 二數最小值為 {2}", n, m, Math.Min(n, m));
            Console.WriteLine("Min:" + msg);
        }

        private static void DisplayRound()
        {
            double x = 100.4;
            double y = 100.5;
            double x1 = Math.Round(x, 0, MidpointRounding.AwayFromZero);//四捨五入
            double y1 = Math.Round(y, 0, MidpointRounding.AwayFromZero);//四捨五入
            string msg = string.Format("x={0} , y={1}  \n x1={2} , y1={3} ",
                x, y, x1, y1);
            Console.WriteLine("Round:" + msg);
        }

        private static void DisplayFloor()
        {
            double x = 10.125;
            double y = 20.675;
            double x1 = Math.Floor(x);
            double y1 = Math.Floor(y);
            string msg = string.Format("x={0} , y={1}  \n x1={2} , y1={3} ",
                x, y, x1, y1);
            Console.WriteLine("Math.Floor:" + msg);
        }

        private static void DisplayCeiling()
        {
            double x = 10.125;
            double y = 20.675;
            double x1 = Math.Ceiling(x);
            double y1 = Math.Ceiling(y);
            string msg = string.Format("x={0} , y={1}  \n x1={2} , y1={3} ",
                x, y, x1, y1);
            Console.WriteLine("Ceiling:" + msg);
        }

        private static void DisplayCompareTo()
        {
            string s1 = "these";
            string s2 = "those";
            string msg = "s1 =" + s1 + ",s2=" + s2 + "\n";
            int result = s1.CompareTo(s2);

            if (result == 0)
            {
                msg = msg + "字串相等,結果為[" + result + "]\n";
            }
            else if (result == -1)
            {
                msg = msg + s1 + "小於" + s2 + ",結果為[" + result + "]\n";
            }
            else if (result == 1)
            {
                msg = msg + s1 + "大於" + s2 + ",結果為[" + result + "]\n";
            }

            Console.WriteLine("CompareTo() method:" + msg);
        }

        private static void DisplayIndexof()
        {
            string msg = "A103012-E大大";
            string key = "-";

            int index = msg.IndexOf(key);

            Console.WriteLine(msg + "\n的[" + key
                              + "]索引位置=" + index.ToString());
        }

        public static void DisplayLastIndexOf()
        {
            string filePath;
            filePath = @"C:\WINDOWS\System32\notepad.exe";

            int index = filePath.LastIndexOf("\\");

            string fileName = filePath.Substring(index + 1);

            Console.WriteLine(filePath + "\n其檔案名稱為[" +
                              fileName + "]", "LastIndexOf()方法");
        }

        public static void DisplayReplace()
        {
            string SQL = "You Haven't Seen The Last Of Me ";
            string safeSQL = SQL.Replace("'", "''");

            string msg = "原先的字串為:" + SQL + "\n";
            msg = msg + "取代後字串為:" + safeSQL;
            Console.WriteLine("Replace()方法" + msg);
        }

        public static void DisplaySplit()
        {
            string Customer = "C1030001-新蛋科技";
            string CustomerCode = Customer.Split('-')[0];
            string CustomerName = Customer.Split('-')[1];
            string msg = "客戶編號:" + CustomerCode + "\n" +
                         "客戶名稱:" + CustomerName;
            Console.WriteLine("Split()方法:" + msg);
        }

        public static void DisplaySubstring()
        {
            string Manufacturer = "Newegg-新蛋科技";
            string ManufacturerID = Manufacturer.Substring(0, Manufacturer.IndexOf("-"));
            string msg = "廠商英文名稱:" + ManufacturerID;
            Console.WriteLine("Substring()方法:" + msg);
        }

        public static void DisplayToLower()
        {
            string s1 = "RYU";
            string s2 = s1.ToLower();
            string msg = "轉換小寫前:" + s1 + "\n";
            msg = msg + "轉換小寫後:" + s2;
            Console.WriteLine("ToLower()方法:" + msg);
        }

        public static void DisplayToUpper()
        {
            string s1 = "ItemsInfo";
            string s2 = s1.ToUpper();
            string msg = "轉換大寫前:" + s1 + "\n";
            msg = msg + "轉換大寫後:" + s2;
            Console.WriteLine("ToUpper()方法" + msg);
        }

        public static void DisplayTrim()
        {
            string searchKey = "  Epson  ";
            int n1 = searchKey.Length;

            string searchKeyTrim = searchKey.Trim();

            int n2 = searchKeyTrim.Length;
            string msg = "原字串:[" + searchKey + "],字串長度=" + n1 + "\n";
            msg = msg + "去空白:[" + searchKeyTrim + "],字串長度= " + n2;
            Console.WriteLine("Trim()方法:" + msg);
        }

        private static string[] BigLottery()
        {
            string[] result = new string[7];
            int[] d = new int[50];
            int n = 0;
            int RanValue;
            bool flag;

            n = 0;     //n代表已經開獎號碼個數
            do
            {
                Random rnd = new Random(Guid.NewGuid().GetHashCode());//DateTime.Now.Millisecond
                RanValue = (int)rnd.Next(1, 49);
                if (n == 0)
                {
                    result[n] = string.Format("{0:D2}", RanValue);
                    n = n + 1;
                }
                else
                {
                    flag = false;
                    foreach (var obj in result)
                    {
                        if (obj != null)
                        {
                            if (int.Parse(obj) == RanValue)
                            {
                                flag = true;
                            }
                        }
                    }

                    if (flag == false)
                    {
                        result[n] = string.Format("{0:D2}", RanValue);
                        n = n + 1;
                    }
                }
            } while (!(n == 7));

            return result;
        }
    }
}