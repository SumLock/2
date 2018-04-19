using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //設定人數(加分*1*)                    
            int Count = 1;
            string man;
            Console.Write("請設定每組人數: ");
            man = Console.ReadLine();
            //除錯,如果輸入的不是數字就結束程式
            try
                {
                Count = Convert.ToInt32(man);
                }
                catch
                {
                    Console.Write("請輸入數字喔!");
                    Console.Read();
                }           
            //設定組數,(因為班上同學資料太雜假設為69人)
            int T = (69 / Count)+1;
            //建立一個空的List
            List<string> member = new List<string>();
            //太多人了吧..
            string[] memberName = new string[] { "葉俊廷", "張澤瑜", "王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜",
                "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔",
                "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )", "陳昱嘉",
                "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷",
                "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "張鈺慈", "鍾宜珊", "raer_tsai",
                "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新張豐愷", "世新遲正雯", "世新周詮" };

            // 放入班上人數
            for (int i = 0; i < 69; i++)
            {
                member.Add(memberName[i]);
            }

            for (int a = 1; a <= T; a++)
            {

                // 產生亂數元件
                Random rand = new Random();

                for (int i = 0; i < Count; i++)
                {
                    //隨機挑選一個數字放入R
                    int R = rand.Next(0, member.Count);

                    //嘗試印出number[R],如果有錯誤就離開迴圈
                    try
                    {
                        Console.Write(member[R] + " ");
                    }
                    catch { break; }
                    member.RemoveAt(R);
                }
                Console.WriteLine("第" + a + "組");
            }
            // 暫停
            Console.Read();
        }
    }
}
