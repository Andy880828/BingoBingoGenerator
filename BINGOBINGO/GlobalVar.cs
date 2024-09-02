using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINGOBINGO
{
    internal class GlobalVar
    {
        public static int number_count = 10; //玩法，預設10星。
        public static List<Bingo> choosed_number = new List<Bingo>(); //暫存所有所選號碼
    }
}
