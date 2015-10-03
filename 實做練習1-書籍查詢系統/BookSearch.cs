using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        
             BOOK[] BookList = new BOOK[15];
           
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BookList[0] = new BOOK(3654, "高第一簡介", "陳振遠", "高第一出版社", category.其它, 250);
            BookList[1] = new BOOK(6391, "系統分析與設計", "黃文楨", "高第一出版社", category.科學, 200);
            BookList[2] = new BOOK(2269, "管理學概論", "周棟詳", "資管出版社", category.商管, 100);
            BookList[3] = new BOOK(9541, "哈利波特", "JK羅琳", "皇冠出版社", category.小說, 450);
            BookList[4] = new BOOK(2301, "迷霧之子", "山德森", "Tor Books", category.小說, 550);
            BookList[5] = new BOOK(1265, "台灣歷史", "孫博士", "年遠出版社", category.歷史, 150);
            BookList[6] = new BOOK(8851, "商業週刊", "蔡明德", "商業出版社", category.商管, 50);
            BookList[7] = new BOOK(3302, "龍槍編年史", "西克曼", "奇幻基地", category.小說, 400);
            BookList[8] = new BOOK(9993, "世界史概論", "王明那", "年遠出版社", category.歷史, 80);
            BookList[9] = new BOOK(4567, "股票理論", "王董", "賺錢出版社", category.商管, 250);
            BookList[10] = new BOOK(3336, "三十三年夢", "朱天心", "印刻出版社", category.文學, 100);
            BookList[11] = new BOOK(5541, "解讀台灣的經濟", "吳私文", "經管出版社", category.商管, 250);
            BookList[12] = new BOOK(3985, "兩代人的十二月", "陳振遠", "高第一出版社", category.其它, 250);
            BookList[13] = new BOOK(1009, "旅行式一場修行", "林輝", "時報出版社", category.文學, 330);
            BookList[14] = new BOOK(1985, "程式設計流程", "賈伯斯", "蘋果出版社", category.科學, 750);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            booklist.Text = "ISDN  \t 書名\t\t作者\t出版社\t\t類型\t售價 " + Environment.NewLine;
            booklist.Text += "-------------------------------------------------------------" + Environment.NewLine; ;
            for (int i = 0; i <= 14; i++)
            {
                booklist.Text += BookList[i].isdn + "\t" + BookList[i].name + "\t" + BookList[i].auth + "\t" + BookList[i].pub
                    + "\t" + BookList[i].cate + "\t" + BookList[i].pri + Environment.NewLine;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            int isdnhave = 0;//判斷是否有這本書
           int  i = 0;//判斷書入是否為數字的變數
            bool judgenumber = int.TryParse(searchISDN.Text,out i);
            if (i == 0)
            {
                MessageBox.Show("請輸入數字!");
                searchISDN.Text = "請輸入ISDN，為四碼數字";
            }
            else if (searchISDN.Text.ToString().Length == 4)
            {

                for (int k = 0; k <= 14; k++)
                {
                    if (BookList[k].isdn == int.Parse(searchISDN.Text))
                    {
                        result.Text = "ISDN \t書名\t\t作者\t出版社\t\t類型\t售價 " + Environment.NewLine;
                        result.Text += "-----------------------------------------------------------------------------------------" + Environment.NewLine; ;
                        result.Text += BookList[k].isdn + "\t" + BookList[k].name + "\t" + BookList[k].auth + "\t" + BookList[k].pub
                    + "\t" + BookList[k].cate + "\t" + BookList[k].pri;
                        isdnhave  = 1;
                        break;
                    }

                }
                if (isdnhave == 0)
                {
                    result.Text = "查無此ISDN，請至書籍清單查詢!";
                }
            }
            else
            {
                MessageBox.Show("請輸入4碼數字!");
                searchISDN.Text = "請輸入ISDN，為四碼數字";
            }
        }

        
    }
    public enum category 
    {
        科學 ,
        小說 ,
        商管, 
        歷史 ,
        文學 ,
        其它
    }
    class BOOK
    {
        public int isdn;
        public string name;
        public string auth;
        public string pub;
        public category cate;
        public int pri;
        public BOOK(int ISDN, string BookName, string Author ,string Publisher,category cate,int Price)
    {
        this.isdn = ISDN;
        this.name = BookName;
        this.auth = Author;
        this.pub = Publisher;
        this.cate = cate;
        this.pri = Price;
    }
    }
}
