using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BINGOBINGO
{
    public partial class BINGOBINGO : Form
    {
        //定義Variable
        public static Random random = new Random();
        public int times_Super = 1;
        public int times_Large = 1;
        public int times_Odd = 1;
        public int times_mix = 1;
        public int index = 0;
        public int _gamecode = 10; //遊戲代號，1~10是選號，101是大小，102是單雙，103是超級獎號
        int error_code = 0; //定義錯誤碼，0=無錯誤，1=空值，2=超過範圍，3=數字重複，4=跟LIST重複
        public List<TextBox> textBoxes = new List<TextBox>(); //用於遍歷textBoxes
        public List<System.Windows.Forms.Label> Labels = new List<System.Windows.Forms.Label>();
        public List<int> temp_number = new List<int>(); //暫存號碼
        public int Target_LuckyNumber = 0; //暫存中獎超級獎號
        public string Target_Large = ""; //暫存中獎大小
        public string Target_Odd = ""; //暫存中獎單雙
        public int LuckyNumber = 0; //暫存超級獎號
        public string Large = ""; //暫存大小
        public string Odd = ""; //暫存單雙
        public long bill = 0; //暫存應付金額
        public long total_award = 0; //暫存獎金

        //Method
        public void RangeChecking()
        {
            for (int i = 0; i < textBoxes.Count; i++) //檢查1~80
            {
                temp_number.Add(Convert.ToInt32(textBoxes[i].Text));
                if (temp_number[i] < 1 || temp_number[i] > 80)
                {
                    error_code = 2;
                    break;
                }
                error_code = 0;
            }
        }
        public void DupChecking()
        {
            temp_number.Sort();
            for (int i = 1; i < temp_number.Count - 1; i++) //檢查重複
            {
                if (temp_number[i] == temp_number[i - 1] || temp_number[i] == temp_number[i + 1])
                {
                    error_code = 3;
                    break;
                }
                error_code = 0;
            }
        }
        public void RepChecking()
        {
            error_code = 0;
            if ((_gamecode <= 10) && (_gamecode > 0))
            {
                List<int> temp_number3 = new List<int>();
                foreach (Bingo b in GlobalVar.choosed_number)
                {
                    int same_count = 0;
                    temp_number3.Clear();
                    if (b.inner_numbercount == 1)
                    {
                        temp_number3.Add(b.n1);
                    }
                    else if (b.inner_numbercount == 2)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                    }
                    else if (b.inner_numbercount == 3)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                    }
                    else if (b.inner_numbercount == 4)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                    }
                    else if (b.inner_numbercount == 5)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                    }
                    else if (b.inner_numbercount == 6)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                    }
                    else if (b.inner_numbercount == 7)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                        temp_number3.Add(b.n7);
                    }
                    else if (b.inner_numbercount == 8)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                        temp_number3.Add(b.n7);
                        temp_number3.Add(b.n8);
                    }
                    else if (b.inner_numbercount == 9)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                        temp_number3.Add(b.n7);
                        temp_number3.Add(b.n8);
                        temp_number3.Add(b.n9);
                    }
                    else if (b.inner_numbercount == 10)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                        temp_number3.Add(b.n7);
                        temp_number3.Add(b.n8);
                        temp_number3.Add(b.n9);
                        temp_number3.Add(b.n10);
                    }
                    else if (b.inner_numbercount == 11)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                        temp_number3.Add(b.n7);
                        temp_number3.Add(b.n8);
                        temp_number3.Add(b.n9);
                        temp_number3.Add(b.n10);
                        temp_number3.Add(b.n11);
                    }
                    else if (b.inner_numbercount == 12)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                        temp_number3.Add(b.n7);
                        temp_number3.Add(b.n8);
                        temp_number3.Add(b.n9);
                        temp_number3.Add(b.n10);
                        temp_number3.Add(b.n11);
                        temp_number3.Add(b.n12);
                    }
                    else if (b.inner_numbercount == 13)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                        temp_number3.Add(b.n7);
                        temp_number3.Add(b.n8);
                        temp_number3.Add(b.n9);
                        temp_number3.Add(b.n10);
                        temp_number3.Add(b.n11);
                        temp_number3.Add(b.n12);
                        temp_number3.Add(b.n13);
                    }
                    else if (b.inner_numbercount == 14)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                        temp_number3.Add(b.n7);
                        temp_number3.Add(b.n8);
                        temp_number3.Add(b.n9);
                        temp_number3.Add(b.n10);
                        temp_number3.Add(b.n11);
                        temp_number3.Add(b.n12);
                        temp_number3.Add(b.n13);
                        temp_number3.Add(b.n14);
                    }
                    else if (b.inner_numbercount == 15)
                    {
                        temp_number3.Add(b.n1);
                        temp_number3.Add(b.n2);
                        temp_number3.Add(b.n3);
                        temp_number3.Add(b.n4);
                        temp_number3.Add(b.n5);
                        temp_number3.Add(b.n6);
                        temp_number3.Add(b.n7);
                        temp_number3.Add(b.n8);
                        temp_number3.Add(b.n9);
                        temp_number3.Add(b.n10);
                        temp_number3.Add(b.n11);
                        temp_number3.Add(b.n12);
                        temp_number3.Add(b.n13);
                        temp_number3.Add(b.n14);
                        temp_number3.Add(b.n15);
                    }
                    if (b.inner_numbercount == GlobalVar.number_count)
                    {
                        for (int i = 0; i < temp_number.Count; i++)
                        {
                            for (int j = 0; j < temp_number3.Count; j++)
                            {
                                if (temp_number[i] == temp_number3[j])
                                {
                                    same_count += 1;
                                }
                            }
                        }
                        if (same_count == GlobalVar.number_count)
                        {
                            error_code = 4;
                            return;
                        }
                    }
                    else if (b.inner_numbercount > 10)
                    {
                        for (int i = 0; i < temp_number.Count; i++)
                        {
                            for (int j = 0; j < temp_number3.Count; j++)
                            {
                                if (temp_number[i] == temp_number3[j])
                                {
                                    same_count += 1;
                                }
                            }
                        }
                        if (same_count >= 10)
                        {
                            error_code = 4;
                            return;
                        }
                    }
                }
                error_code = 0;
            }
            else if (_gamecode == 101)
            {
                foreach (Bingo b in GlobalVar.choosed_number)
                {
                    if ((b.gamecode == 101) && (b.Large == Large))
                    {
                        error_code = 4;
                        return;
                    }
                }
                error_code = 0;
            }
            else if (_gamecode == 102)
            {
                foreach (Bingo b in GlobalVar.choosed_number)
                {
                    if ((b.gamecode == 102) && (b.Odd == Odd))
                    {
                        error_code = 4;
                        return;
                    }
                }
                error_code = 0;
            }
            else if (_gamecode == 103)
            {
                foreach (Bingo b in GlobalVar.choosed_number)
                {
                    if ((b.gamecode == 103) && (b.Super == LuckyNumber))
                    {
                        error_code = 4;
                        return;
                    }
                }
                error_code = 0;
            }
        }

        public BINGOBINGO()
        {
            InitializeComponent();
        }

        private void BINGOBINGO_Load(object sender, EventArgs e)
        {
            tbrmix.Value = 1;
            tbrLarge.Value = 1;
            tbrOdd.Value = 1;
            tbrSuper.Value = 1;
        }

        private void btnnumbercount_Click(object sender, EventArgs e)
        {
            error_code = 0; //重設error_code
            LuckyNumber = 0;
            Large = "";
            Odd = "";
            total_award = 0;
            txtaward.Text = "00000";
            do
            {
                temp_number.Clear();
                textBoxes.Clear();
                textBoxes.Add(tbxmix1);
                textBoxes.Add(tbxmix2);
                textBoxes.Add(tbxmix3);
                textBoxes.Add(tbxmix4);
                textBoxes.Add(tbxmix5);
                textBoxes.Add(tbxmix6);
                textBoxes.Add(tbxmix7);
                textBoxes.Add(tbxmix8);
                textBoxes.Add(tbxmix9);
                textBoxes.Add(tbxmix10);
                textBoxes.Add(tbxmix11);
                textBoxes.Add(tbxmix12);
                textBoxes.Add(tbxmix13);
                textBoxes.Add(tbxmix14);
                textBoxes.Add(tbxmix15);
                for (int i = textBoxes.Count - 1; i >= 0; i--) //由後向前遍歷可以避免index錯誤
                {
                    if (textBoxes[i].Text == "")
                    {
                        textBoxes.RemoveAt(i);
                    }
                }
                if ((error_code == 4) && (textBoxes.Count == GlobalVar.number_count)) //當數字組合重複時，確認是不是手填的，是的話就報錯，不是的話就往下重新生成一組隨機碼
                {
                    MessageBox.Show("這組號碼已經輸入過囉! 請更換一組號碼!");
                    foreach (TextBox t in textBoxes)
                    {
                        t.Text = "";
                    }
                    return;
                }
                RangeChecking();
                if (error_code == 0)
                {
                    DupChecking();
                }
                if (error_code == 2) //手動輸入部分還是得先報錯
                {
                    MessageBox.Show("請輸入'1~80之間'的數字，麻煩了");
                }
                else if (error_code == 3)
                {
                    MessageBox.Show("請輸入1~80之間的'不重複'數字，拜託一下好嗎?");
                }
                do
                {
                    temp_number.Clear();
                    for (int i = 0; i < textBoxes.Count; i++)
                    {
                        temp_number.Add(Convert.ToInt32(textBoxes[i].Text));
                    }
                    for (int i = 0; i < GlobalVar.number_count - textBoxes.Count; i++) //剩下用random填充
                    {
                        temp_number.Add(random.Next(1, 81));
                    }
                    DupChecking(); //確認重複
                }
                while (error_code == 3);
                RepChecking();
            }
            while (error_code == 4);
            index += 1;
            Bingo mixnumber = new Bingo
                (_gamecode,
                index,
                times_mix,
                temp_number[0],
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            switch (GlobalVar.number_count)
            {
                case 2:
                    mixnumber.n2 = temp_number[1];
                    break;
                case 3:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    break;
                case 4:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    break;
                case 5:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    break;
                case 6:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    break;
                case 7:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    mixnumber.n7 = temp_number[6];
                    break;
                case 8:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    mixnumber.n7 = temp_number[6];
                    mixnumber.n8 = temp_number[7];
                    break;
                case 9:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    mixnumber.n7 = temp_number[6];
                    mixnumber.n8 = temp_number[7];
                    mixnumber.n9 = temp_number[8];
                    break;
                case 10:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    mixnumber.n7 = temp_number[6];
                    mixnumber.n8 = temp_number[7];
                    mixnumber.n9 = temp_number[8];
                    mixnumber.n10 = temp_number[9];
                    break;
                case 11:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    mixnumber.n7 = temp_number[6];
                    mixnumber.n8 = temp_number[7];
                    mixnumber.n9 = temp_number[8];
                    mixnumber.n10 = temp_number[9];
                    mixnumber.n11 = temp_number[10];
                    break;
                case 12:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    mixnumber.n7 = temp_number[6];
                    mixnumber.n8 = temp_number[7];
                    mixnumber.n9 = temp_number[8];
                    mixnumber.n10 = temp_number[9];
                    mixnumber.n11 = temp_number[10];
                    mixnumber.n12 = temp_number[11];
                    break;
                case 13:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    mixnumber.n7 = temp_number[6];
                    mixnumber.n8 = temp_number[7];
                    mixnumber.n9 = temp_number[8];
                    mixnumber.n10 = temp_number[9];
                    mixnumber.n11 = temp_number[10];
                    mixnumber.n12 = temp_number[11];
                    mixnumber.n13 = temp_number[12];
                    break;
                case 14:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    mixnumber.n7 = temp_number[6];
                    mixnumber.n8 = temp_number[7];
                    mixnumber.n9 = temp_number[8];
                    mixnumber.n10 = temp_number[9];
                    mixnumber.n11 = temp_number[10];
                    mixnumber.n12 = temp_number[11];
                    mixnumber.n13 = temp_number[12];
                    mixnumber.n14 = temp_number[13];
                    break;
                case 15:
                    mixnumber.n2 = temp_number[1];
                    mixnumber.n3 = temp_number[2];
                    mixnumber.n4 = temp_number[3];
                    mixnumber.n5 = temp_number[4];
                    mixnumber.n6 = temp_number[5];
                    mixnumber.n7 = temp_number[6];
                    mixnumber.n8 = temp_number[7];
                    mixnumber.n9 = temp_number[8];
                    mixnumber.n10 = temp_number[9];
                    mixnumber.n11 = temp_number[10];
                    mixnumber.n12 = temp_number[11];
                    mixnumber.n13 = temp_number[12];
                    mixnumber.n14 = temp_number[13];
                    mixnumber.n15 = temp_number[14];
                    break;
            }
            lbxnumbers.Items.Add(mixnumber.Setinfo());
            bill += mixnumber.pay();
            txtpayment.Text = $"目前應付金額:{bill}";
            GlobalVar.choosed_number.Add(mixnumber);
            temp_number.Clear();


        }
        private void btnaward_Click(object sender, EventArgs e)
        {
            temp_number.Clear();
            total_award = 0;
            if (txttarget1.Text == "00")
            {
                MessageBox.Show("還沒開獎你在急甚麼?");
            }
            else
            {
                for (int i = 0; i < Labels.Count; i++)
                {
                    temp_number.Add(Convert.ToInt32(Labels[i].Text));
                }
                List<int> temp_number2 = new List<int>();
                foreach (Bingo b in GlobalVar.choosed_number)
                {
                    temp_number2.Clear();
                    if (b.inner_numbercount == 1)
                    {
                        temp_number2.Add(b.n1);
                    }
                    else if (b.inner_numbercount == 2)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                    }
                    else if (b.inner_numbercount == 3)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                    }
                    else if (b.inner_numbercount == 4)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                    }
                    else if (b.inner_numbercount == 5)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                    }
                    else if (b.inner_numbercount == 6)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                    }
                    else if (b.inner_numbercount == 7)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                        temp_number2.Add(b.n7);
                    }
                    else if (b.inner_numbercount == 8)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                        temp_number2.Add(b.n7);
                        temp_number2.Add(b.n8);
                    }
                    else if (b.inner_numbercount == 9)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                        temp_number2.Add(b.n7);
                        temp_number2.Add(b.n8);
                        temp_number2.Add(b.n9);
                    }
                    else if (b.inner_numbercount == 10)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                        temp_number2.Add(b.n7);
                        temp_number2.Add(b.n8);
                        temp_number2.Add(b.n9);
                        temp_number2.Add(b.n10);
                    }
                    else if (b.inner_numbercount == 11)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                        temp_number2.Add(b.n7);
                        temp_number2.Add(b.n8);
                        temp_number2.Add(b.n9);
                        temp_number2.Add(b.n10);
                        temp_number2.Add(b.n11);
                    }
                    else if (b.inner_numbercount == 12)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                        temp_number2.Add(b.n7);
                        temp_number2.Add(b.n8);
                        temp_number2.Add(b.n9);
                        temp_number2.Add(b.n10);
                        temp_number2.Add(b.n11);
                        temp_number2.Add(b.n12);
                    }
                    else if (b.inner_numbercount == 13)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                        temp_number2.Add(b.n7);
                        temp_number2.Add(b.n8);
                        temp_number2.Add(b.n9);
                        temp_number2.Add(b.n10);
                        temp_number2.Add(b.n11);
                        temp_number2.Add(b.n12);
                        temp_number2.Add(b.n13);
                    }
                    else if (b.inner_numbercount == 14)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                        temp_number2.Add(b.n7);
                        temp_number2.Add(b.n8);
                        temp_number2.Add(b.n9);
                        temp_number2.Add(b.n10);
                        temp_number2.Add(b.n11);
                        temp_number2.Add(b.n12);
                        temp_number2.Add(b.n13);
                        temp_number2.Add(b.n14);
                    }
                    else if (b.inner_numbercount == 15)
                    {
                        temp_number2.Add(b.n1);
                        temp_number2.Add(b.n2);
                        temp_number2.Add(b.n3);
                        temp_number2.Add(b.n4);
                        temp_number2.Add(b.n5);
                        temp_number2.Add(b.n6);
                        temp_number2.Add(b.n7);
                        temp_number2.Add(b.n8);
                        temp_number2.Add(b.n9);
                        temp_number2.Add(b.n10);
                        temp_number2.Add(b.n11);
                        temp_number2.Add(b.n12);
                        temp_number2.Add(b.n13);
                        temp_number2.Add(b.n14);
                        temp_number2.Add(b.n15);
                    }
                    int temp_hit_count = 0;
                    for (int i = 0; i < temp_number2.Count; i++)
                    {
                        for (int j = 0; j < temp_number.Count; j++)
                            if (temp_number2[i] == temp_number[j])
                            {
                                temp_hit_count += 1;
                            }
                    }
                    if (b.gamecode == 10)
                    {
                        switch (temp_hit_count)
                        {
                            case 0:
                                {
                                    if (b.inner_numbercount == 10) { b.award = 25; total_award += b.award; }
                                    else if (b.inner_numbercount == 11) { b.award = 275; total_award += b.award; }
                                    else if (b.inner_numbercount == 12) { b.award = 1650; total_award += b.award; }
                                    else if (b.inner_numbercount == 13) { b.award = 7150; total_award += b.award; }
                                    else if (b.inner_numbercount == 14) { b.award = 25025; total_award += b.award; }
                                    else if (b.inner_numbercount == 15) { b.award = 75075; total_award += b.award; }
                                    break;
                                }
                            case 1:
                                {
                                    if (b.inner_numbercount == 11) { b.award = 25; total_award += b.award; }
                                    else if (b.inner_numbercount == 12) { b.award = 275; total_award += b.award; }
                                    else if (b.inner_numbercount == 13) { b.award = 1650; total_award += b.award; }
                                    else if (b.inner_numbercount == 14) { b.award = 7150; total_award += b.award; }
                                    else if (b.inner_numbercount == 15) { b.award = 25025; total_award += b.award; }
                                    break;
                                }
                            case 2:
                                {
                                    if (b.inner_numbercount == 12) { b.award = 25; total_award += b.award; }
                                    else if (b.inner_numbercount == 13) { b.award = 275; total_award += b.award; }
                                    else if (b.inner_numbercount == 14) { b.award = 1650; total_award += b.award; }
                                    else if (b.inner_numbercount == 15) { b.award = 7150; total_award += b.award; }
                                    break;
                                }
                            case 3:
                                {
                                    if (b.inner_numbercount == 13) { b.award = 25; total_award += b.award; }
                                    else if (b.inner_numbercount == 14) { b.award = 275; total_award += b.award; }
                                    else if (b.inner_numbercount == 15) { b.award = 1650; total_award += b.award; }
                                    break;
                                }
                            case 4:
                                {
                                    if (b.inner_numbercount == 14) { b.award = 25; total_award += b.award; }
                                    else if (b.inner_numbercount == 15) { b.award = 275; total_award += b.award; }
                                    break;
                                }
                            case 5: { b.award = 25; total_award += b.award; break; }
                            case 6: { b.award = 250; total_award += b.award; break; }
                            case 7: { b.award = 2500; total_award += b.award; break; }
                            case 8: { b.award = 25000; total_award += b.award; break; }
                            case 9: { b.award = 250000; total_award += b.award; break; }
                            case 10: { b.award = 5000000; total_award += b.award; break; }
                            case 11: { b.award = 55000000; total_award += b.award; break; }
                            case 12: { b.award = 330000000; total_award += b.award; break; }
                            case 13: { b.award = 1430000000; total_award += b.award; break; }
                            case 14: { b.award = 5005000000; total_award += b.award; break; }
                            case 15: { b.award = 15015000000; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 9)
                    {
                        switch (temp_hit_count)
                        {
                            case 0: { b.award = 25; total_award += b.award; break; }
                            case 4: { b.award = 25; total_award += b.award; break; }
                            case 5: { b.award = 100; total_award += b.award; break; }
                            case 6: { b.award = 500; total_award += b.award; break; }
                            case 7: { b.award = 3000; total_award += b.award; break; }
                            case 8: { b.award = 100000; total_award += b.award; break; }
                            case 9: { b.award = 1000000; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 8)
                    {
                        switch (temp_hit_count)
                        {
                            case 0: { b.award = 25; total_award += b.award; break; }
                            case 4: { b.award = 25; total_award += b.award; break; }
                            case 5: { b.award = 200; total_award += b.award; break; }
                            case 6: { b.award = 1000; total_award += b.award; break; }
                            case 7: { b.award = 20000; total_award += b.award; break; }
                            case 8: { b.award = 500000; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 7)
                    {
                        switch (temp_hit_count)
                        {
                            case 3: { b.award = 25; total_award += b.award; break; }
                            case 4: { b.award = 50; total_award += b.award; break; }
                            case 5: { b.award = 300; total_award += b.award; break; }
                            case 6: { b.award = 3000; total_award += b.award; break; }
                            case 7: { b.award = 80000; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 6)
                    {
                        switch (temp_hit_count)
                        {
                            case 3: { b.award = 25; total_award += b.award; break; }
                            case 4: { b.award = 200; total_award += b.award; break; }
                            case 5: { b.award = 1000; total_award += b.award; break; }
                            case 6: { b.award = 25000; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 5)
                    {
                        switch (temp_hit_count)
                        {
                            case 3: { b.award = 50; total_award += b.award; break; }
                            case 4: { b.award = 500; total_award += b.award; break; }
                            case 5: { b.award = 7500; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 4)
                    {
                        switch (temp_hit_count)
                        {
                            case 2: { b.award = 25; total_award += b.award; break; }
                            case 3: { b.award = 100; total_award += b.award; break; }
                            case 4: { b.award = 1000; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 3)
                    {
                        switch (temp_hit_count)
                        {
                            case 2: { b.award = 50; total_award += b.award; break; }
                            case 3: { b.award = 500; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 2)
                    {
                        switch (temp_hit_count)
                        {
                            case 1: { b.award = 25; total_award += b.award; break; }
                            case 2: { b.award = 75; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 1)
                    {
                        switch (temp_hit_count)
                        {
                            case 1: { b.award = 50; total_award += b.award; break; }
                            default: { b.award = 0; break; }
                        }
                    }
                    else if (b.gamecode == 101)
                    {
                        if (b.Large == Target_Large)
                        {
                            b.award = 150;
                            total_award += b.award;
                        }
                    }
                    else if (b.gamecode == 102)
                    {
                        if (b.Odd == Target_Odd)
                        {
                            b.award = 150;
                            total_award += b.award;
                        }
                    }
                    else if (b.gamecode == 103)
                    {
                        if (b.Super == Target_LuckyNumber)
                        {
                            b.award = 1200;
                            total_award += b.award;
                        }
                    }
                }
                txtaward.Text = $"{total_award}";
                lbxnumbers.Items.Clear();
                GlobalVar.choosed_number.Clear();
                bill = 0;
                index = 0;
                error_code = 0;
                txtpayment.Text = $"目前應付金額:00000";
                tbrmix.Value = 1;
                txtmixx.Text = "1X";
                times_mix = 1;
                tbrSuper.Value = 1;
                txtSuperx.Text = "1X";
                times_Super = 1;
                tbrLarge.Value = 1;
                txtLargex.Text = "1X";
                times_Large = 1;
                tbrOdd.Value = 1;
                txtOddx.Text = "1X";
                times_Odd = 1;
                listBox2.SelectedItem = "10星";
            }
        }
        private void btntarget_Click(object sender, EventArgs e)
        {
            error_code = 0; //重設error_code
            temp_number.Clear();
            total_award = 0;
            Target_LuckyNumber = 0;
            Target_Large = "";
            Target_Odd = "";
            txtaward.Text = "00000";
            Labels.Clear();
            Labels.Add(txttarget1);
            Labels.Add(txttarget2);
            Labels.Add(txttarget3);
            Labels.Add(txttarget4);
            Labels.Add(txttarget5);
            Labels.Add(txttarget6);
            Labels.Add(txttarget7);
            Labels.Add(txttarget8);
            Labels.Add(txttarget9);
            Labels.Add(txttarget10);
            Labels.Add(txttarget11);
            Labels.Add(txttarget12);
            Labels.Add(txttarget13);
            Labels.Add(txttarget14);
            Labels.Add(txttarget15);
            Labels.Add(txttarget16);
            Labels.Add(txttarget17);
            Labels.Add(txttarget18);
            Labels.Add(txttarget19);
            Labels.Add(txttarget20);
            do
            {
                temp_number.Clear();
                for (int i = 0; i < 20; i++)
                {
                    temp_number.Add(random.Next(1, 81));
                }
                DupChecking();
            }
            while (error_code == 3);
            //大小判定
            int large_count = 0;
            for (int i = 0; i < temp_number.Count; i++)
            {
                if (temp_number[i] > 40)
                {
                    large_count += 1;
                }
            }
            //單雙判定
            int Even_count = 0;
            for (int i = 0; i < temp_number.Count; i++)
            {
                if (temp_number[i] % 2 == 0)
                {
                    Even_count += 1;
                }
            }
            for (int i = 0; i < Labels.Count; i++)
            {
                Labels[i].Text = Convert.ToString(temp_number[i]);
                Labels[i].ForeColor = System.Drawing.Color.Black;
            }
            int _LuckyNumber = random.Next(1, 21);
            Target_LuckyNumber = Convert.ToInt32(Labels[Labels.Count - _LuckyNumber].Text);
            if (large_count >= 13)
            {
                Target_Large = "大";
            }
            else if (large_count < 7)
            {
                Target_Large = "小";
            }
            else
            {
                Target_Large = "無";
            }
            if (Even_count >= 13)
            {
                Target_Odd = "雙";
            }
            else if (Even_count < 7)
            {
                Target_Odd = "單";
            }
            else
            {
                Target_Odd = "無";
            }
            Labels[Labels.Count - _LuckyNumber].ForeColor = System.Drawing.Color.Red;
            txtLarge.Text = $"大小: {Target_Large}";
            txtOdd.Text = $"單雙: {Target_Odd}";
            txttargettime.Text = $"開獎時間:{DateTime.Now:g}";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //從結帳&購物車清除
            string item = lbxnumbers.SelectedItem.ToString(); //把物件找出
            string[] sub = item.Split('-'); //分割-找出INDEX，就是sub[1]
            for (int i = GlobalVar.choosed_number.Count - 1; i >= 0; i--)
            {
                if (GlobalVar.choosed_number[i].inner_index == Convert.ToInt32(sub[1])) //BINGO INDEX=sub[1]時
                {
                    bill -= GlobalVar.choosed_number[i].shallpay; //讀取它的價格，從結帳金額刪掉
                    GlobalVar.choosed_number.RemoveAt(i); //然後從購物車刪掉它
                }
            }
            txtpayment.Text = $"目前應付金額:{bill}"; //寫出更新後的數字
            lbxnumbers.Items.Remove(lbxnumbers.SelectedItem);
        }

        private void btndeleteall_Click(object sender, EventArgs e)
        {
            lbxnumbers.Items.Clear();
            GlobalVar.choosed_number.Clear();
            bill = 0;
            index = 0;
            txtpayment.Text = $"目前應付金額:00000";
        }

        private void tbrmix_Scroll(object sender, EventArgs e)
        {
            txtmixx.Text = $"{tbrmix.Value.ToString()}X";
            times_mix = tbrmix.Value;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
            {
                GlobalVar.number_count = 15;
                _gamecode = 10;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = true;
                tbxmix8.Visible = true;
                tbxmix9.Visible = true;
                tbxmix10.Visible = true;
                tbxmix11.Visible = true;
                tbxmix12.Visible = true;
                tbxmix13.Visible = true;
                tbxmix14.Visible = true;
                tbxmix15.Visible = true;
            }
            else if (listBox2.SelectedIndex == 1)
            {
                GlobalVar.number_count = 14;
                _gamecode = 10;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = true;
                tbxmix8.Visible = true;
                tbxmix9.Visible = true;
                tbxmix10.Visible = true;
                tbxmix11.Visible = true;
                tbxmix12.Visible = true;
                tbxmix13.Visible = true;
                tbxmix14.Visible = true;
                tbxmix15.Visible = true;
            }
            else if (listBox2.SelectedIndex == 2)
            {
                GlobalVar.number_count = 13;
                _gamecode = 10;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = true;
                tbxmix8.Visible = true;
                tbxmix9.Visible = true;
                tbxmix10.Visible = true;
                tbxmix11.Visible = true;
                tbxmix12.Visible = true;
                tbxmix13.Visible = true;
                tbxmix14.Visible = true;
                tbxmix15.Visible = true;
            }
            else if (listBox2.SelectedIndex == 3)
            {
                GlobalVar.number_count = 12;
                _gamecode = 10;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = true;
                tbxmix8.Visible = true;
                tbxmix9.Visible = true;
                tbxmix10.Visible = true;
                tbxmix11.Visible = true;
                tbxmix12.Visible = true;
                tbxmix13.Visible = true;
                tbxmix14.Visible = true;
                tbxmix15.Visible = true;
            }
            else if (listBox2.SelectedIndex == 4)
            {
                GlobalVar.number_count = 11;
                _gamecode = 10;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = true;
                tbxmix8.Visible = true;
                tbxmix9.Visible = true;
                tbxmix10.Visible = true;
                tbxmix11.Visible = true;
                tbxmix12.Visible = true;
                tbxmix13.Visible = true;
                tbxmix14.Visible = true;
                tbxmix15.Visible = true;
            }
            else if (listBox2.SelectedIndex == 5)
            {
                GlobalVar.number_count = 10;
                _gamecode = 10;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = true;
                tbxmix8.Visible = true;
                tbxmix9.Visible = true;
                tbxmix10.Visible = true;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;

            }
            else if (listBox2.SelectedIndex == 6)
            {
                GlobalVar.number_count = 9;
                _gamecode = 9;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = true;
                tbxmix8.Visible = true;
                tbxmix9.Visible = true;
                tbxmix10.Visible = false;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;
            }
            else if (listBox2.SelectedIndex == 7)
            {
                GlobalVar.number_count = 8;
                _gamecode = 8;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = true;
                tbxmix8.Visible = true;
                tbxmix9.Visible = false;
                tbxmix10.Visible = false;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;
            }
            else if (listBox2.SelectedIndex == 8)
            {
                GlobalVar.number_count = 7;
                _gamecode = 7;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = true;
                tbxmix8.Visible = false;
                tbxmix9.Visible = false;
                tbxmix10.Visible = false;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;
            }
            else if (listBox2.SelectedIndex == 9)
            {
                GlobalVar.number_count = 6;
                _gamecode = 6;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = true;
                tbxmix7.Visible = false;
                tbxmix8.Visible = false;
                tbxmix9.Visible = false;
                tbxmix10.Visible = false;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;
            }
            else if (listBox2.SelectedIndex == 10)
            {
                GlobalVar.number_count = 5;
                _gamecode = 5;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = true;
                tbxmix6.Visible = false;
                tbxmix7.Visible = false;
                tbxmix8.Visible = false;
                tbxmix9.Visible = false;
                tbxmix10.Visible = false;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;
            }
            else if (listBox2.SelectedIndex == 11)
            {
                GlobalVar.number_count = 4;
                _gamecode = 4;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = true;
                tbxmix5.Visible = false;
                tbxmix6.Visible = false;
                tbxmix7.Visible = false;
                tbxmix8.Visible = false;
                tbxmix9.Visible = false;
                tbxmix10.Visible = false;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;
            }
            else if (listBox2.SelectedIndex == 12)
            {
                GlobalVar.number_count = 3;
                _gamecode = 3;
                tbxmix2.Visible = true;
                tbxmix3.Visible = true;
                tbxmix4.Visible = false;
                tbxmix5.Visible = false;
                tbxmix6.Visible = false;
                tbxmix7.Visible = false;
                tbxmix8.Visible = false;
                tbxmix9.Visible = false;
                tbxmix10.Visible = false;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;
            }
            else if (listBox2.SelectedIndex == 13)
            {
                GlobalVar.number_count = 2;
                _gamecode = 2;
                tbxmix2.Visible = true;
                tbxmix3.Visible = false;
                tbxmix4.Visible = false;
                tbxmix5.Visible = false;
                tbxmix6.Visible = false;
                tbxmix7.Visible = false;
                tbxmix8.Visible = false;
                tbxmix9.Visible = false;
                tbxmix10.Visible = false;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;
            }
            else if (listBox2.SelectedIndex == 14)
            {
                GlobalVar.number_count = 1;
                _gamecode = 1;
                tbxmix2.Visible = false;
                tbxmix3.Visible = false;
                tbxmix4.Visible = false;
                tbxmix5.Visible = false;
                tbxmix6.Visible = false;
                tbxmix7.Visible = false;
                tbxmix8.Visible = false;
                tbxmix9.Visible = false;
                tbxmix10.Visible = false;
                tbxmix11.Visible = false;
                tbxmix12.Visible = false;
                tbxmix13.Visible = false;
                tbxmix14.Visible = false;
                tbxmix15.Visible = false;
            }
        }

        private void tbrSuper_Scroll(object sender, EventArgs e)
        {
            txtSuperx.Text = $"{tbrSuper.Value.ToString()}X";
            times_Super = tbrSuper.Value;
        }

        private void tbrLarge_Scroll(object sender, EventArgs e)
        {
            txtLargex.Text = $"{tbrLarge.Value.ToString()}X";
            times_Large = tbrLarge.Value;
        }

        private void tbrOdd_Scroll(object sender, EventArgs e)
        {
            txtOddx.Text = $"{tbrOdd.Value.ToString()}X";
            times_Odd = tbrOdd.Value;
        }

        private void btnSuper_Click(object sender, EventArgs e)
        {
            _gamecode = 103;
            temp_number.Clear();
            total_award = 0;
            txtaward.Text = "00000";
            error_code = 0;
            LuckyNumber = 0;
            do
            {
                if (error_code == 4)
                {
                    MessageBox.Show("這組號碼已經輸入過囉! 請更換一組號碼!");
                    tbxSuper.Text = "";
                    return;
                }
                if ((tbxSuper.Text != "") && (Convert.ToInt32(tbxSuper.Text) > 0) && (Convert.ToInt32(tbxSuper.Text) <= 80))
                {
                    LuckyNumber = Convert.ToInt32(tbxSuper.Text);
                }
                else if (tbxSuper.Text == "")
                {
                    LuckyNumber = random.Next(1, 81);
                }
                else
                {
                    MessageBox.Show("請輸入'1~80之間'的數字，麻煩了");
                    tbxSuper.Text = "";
                    return;
                }
                RepChecking();
            }
            while (error_code == 4);
            index += 1;
            Bingo Lucky_bingo = new Bingo(_gamecode, index, times_Super, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Lucky_bingo.Super = LuckyNumber;
            lbxnumbers.Items.Add(Lucky_bingo.Setinfo());
            bill += Lucky_bingo.pay();
            txtpayment.Text = $"目前應付金額:{bill}";
            GlobalVar.choosed_number.Add(Lucky_bingo);
            tbxSuper.Text = "";
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            error_code = 0;
            temp_number.Clear();
            temp_number.Clear();
            _gamecode = 101;
            total_award = 0;
            txtaward.Text = "00000";
            Large = "大";
            RepChecking();
            if (error_code == 0)
            {
                index += 1;
                Bingo Large_bingo = new Bingo(_gamecode, index, times_Large, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                Large_bingo.Large = Large;
                lbxnumbers.Items.Add(Large_bingo.Setinfo());
                bill += Large_bingo.pay();
                txtpayment.Text = $"目前應付金額:{bill}";
                GlobalVar.choosed_number.Add(Large_bingo);
            }
            else
            {
                MessageBox.Show("本期已下過同樣的注了");
            }

        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            error_code = 0;
            _gamecode = 101;
            temp_number.Clear();
            total_award = 0;
            txtaward.Text = "00000";
            Large = "小";
            RepChecking();
            if (error_code == 0)
            {
                index += 1;
                Bingo Large_bingo = new Bingo(_gamecode, index, times_Large, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                Large_bingo.Large = Large;
                lbxnumbers.Items.Add(Large_bingo.Setinfo());
                bill += Large_bingo.pay();
                txtpayment.Text = $"目前應付金額:{bill}";
                GlobalVar.choosed_number.Add(Large_bingo);
            }
            else
            {
                MessageBox.Show("本期已下過同樣的注了");
            }
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            error_code = 0;
            _gamecode = 102;
            temp_number.Clear();
            total_award = 0;
            txtaward.Text = "00000";
            Odd = "單";
            RepChecking();
            if (error_code == 0)
            {
                index += 1;
                Bingo Odd_bingo = new Bingo(_gamecode, index, times_Odd, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                Odd_bingo.Odd = Odd;
                lbxnumbers.Items.Add(Odd_bingo.Setinfo());
                bill += Odd_bingo.pay();
                txtpayment.Text = $"目前應付金額:{bill}";
                GlobalVar.choosed_number.Add(Odd_bingo);
            }
            else
            {
                MessageBox.Show("本期已下過同樣的注了");
            }
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            error_code = 0;
            total_award = 0;
            temp_number.Clear();
            txtaward.Text = "00000";
            _gamecode = 102;
            Odd = "雙";
            RepChecking();
            if (error_code == 0)
            {
                index += 1;
                Bingo Odd_bingo = new Bingo(_gamecode, index, times_Odd, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                Odd_bingo.Odd = Odd;
                lbxnumbers.Items.Add(Odd_bingo.Setinfo());
                bill += Odd_bingo.pay();
                txtpayment.Text = $"目前應付金額:{bill}";
                GlobalVar.choosed_number.Add(Odd_bingo);
            }
            else
            {
                MessageBox.Show("本期已下過同樣的注了");
            }
        }
    }
}
