namespace BINGOBINGO
{
    internal class Bingo
    {
        public int inner_numbercount = 10;
        public int inner_index = 0;
        public int gamecode = 10; //遊戲代號，1~10是選號，101是大小，102是單雙，103是超級獎號
        public int Super = 0;
        public string Large = "大";
        public string Odd = "單";
        public int n1 = 0;
        public int n2 = 0;
        public int n3 = 0;
        public int n4 = 0;
        public int n5 = 0;
        public int n6 = 0;
        public int n7 = 0;
        public int n8 = 0;
        public int n9 = 0;
        public int n10 = 0;
        public int n11 = 0;
        public int n12 = 0;
        public int n13 = 0;
        public int n14 = 0;
        public int n15 = 0;
        public int times = 1;
        public int shallpay = 0; //結帳金額
        private long _award; //計算獎金用
        public long award //紀錄獎金
        {
            get 
            { 
                return _award;
            }
            set
            {
                if (times * value > 100000000) //超過1億就只記1億
                {
                    _award = 100000000;
                }
                else
                {
                    _award = times * value;
                }
            }
        }

        public Bingo(int _gamecode, int _index, int _times, int _n1, int _n2, int _n3, int _n4, int _n5, int _n6, int _n7, int _n8, int _n9, int _n10, int _n11, int _n12, int _n13, int _n14, int _n15)
        {
            gamecode = _gamecode;
            inner_index = _index;
            times = _times;
            n1 = _n1;
            n2 = _n2;
            n3 = _n3;
            n4 = _n4;
            n5 = _n5;
            n6 = _n6;
            n7 = _n7;
            n8 = _n8;
            n9 = _n9;
            n10 = _n10;
            n11 = _n11;
            n12 = _n12;
            n13 = _n13;
            n14 = _n14;
            n15 = _n15;
        }

        public string Setinfo()
        {
            string strMsg = "";
            string game = "";
            switch (gamecode)
            {
                case 1: { game = "1星"; break; }
                case 2: { game = "2星"; break; }
                case 3: { game = "3星"; break; }
                case 4: { game = "4星"; break; }
                case 5: { game = "5星"; break; }
                case 6: { game = "6星"; break; }
                case 7: { game = "7星"; break; }
                case 8: { game = "8星"; break; }
                case 9: { game = "9星"; break; }
                case 10: { game = "10星"; break; }
                case 101: { game = "押大小"; break; }
                case 102: { game = "押單雙"; break; }
                case 103: { game = "超級獎號"; break; }
            }
            if (GlobalVar.number_count == 1)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1}";
                inner_numbercount = 1;
            }
            else if (GlobalVar.number_count == 2)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2}";
                inner_numbercount = 2;
            }
            else if (GlobalVar.number_count == 3)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3}";
                inner_numbercount = 3;
            }
            else if (GlobalVar.number_count == 4)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4}";
                inner_numbercount = 4;
            }
            else if (GlobalVar.number_count == 5)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5}";
                inner_numbercount = 5;
            }
            else if (GlobalVar.number_count == 6)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6}";
                inner_numbercount = 6;
            }
            else if (GlobalVar.number_count == 7)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6},{n7}";
                inner_numbercount = 7;
            }
            else if (GlobalVar.number_count == 8)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6},{n7},{n8}";
                inner_numbercount = 8;
            }
            else if (GlobalVar.number_count == 9)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6},{n7},{n8},{n9}";
                inner_numbercount = 9;
            }
            else if (GlobalVar.number_count == 10)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6},{n7},{n8},{n9},{n10}";
                inner_numbercount = 10;
            }
            else if (GlobalVar.number_count == 11)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6},{n7},{n8},{n9},{n10},{n11}";
                inner_numbercount = 11;
            }
            else if (GlobalVar.number_count == 12)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6},{n7},{n8},{n9},{n10},{n11},{n12}";
                inner_numbercount = 12;
            }
            else if (GlobalVar.number_count == 13)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6},{n7},{n8},{n9},{n10},{n11},{n12},{n13}";
                inner_numbercount = 13;
            }
            else if (GlobalVar.number_count == 14)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6},{n7},{n8},{n9},{n10},{n11},{n12},{n13},{n14}";
                inner_numbercount = 14;
            }
            else if (GlobalVar.number_count == 15)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; {n1},{n2},{n3},{n4},{n5},{n6},{n7},{n8},{n9},{n10},{n11},{n12},{n13},{n14},{n15}";
                inner_numbercount = 15;
            }
            if (gamecode == 103)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; 超級獎號:{Super}";
            }
            else if (gamecode == 101)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; 大小:{Large}";
            }
            else if (gamecode == 102)
            {
                strMsg = $"組合-{inner_index}- 玩法:{game} 倍率:{times}X; 單雙:{Odd}";
            }
                return strMsg;
        }
        public long levels(int x)
        {
            long result = 1;
            for (long i = 1; i <= x; i++)
            {
                result = result * i;
            }
            return result;
        }
        public int pay()
        {
            if (gamecode <= 10)
            {
                shallpay = times * 25 * System.Convert.ToInt32(levels(inner_numbercount) / (levels(gamecode) * levels(inner_numbercount - gamecode)));
                return shallpay;
            }
            else
            {
                shallpay = times * 25;
                return shallpay;
            }
        }
    }
}
