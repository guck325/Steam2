using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam2
{
    public partial class Form1 : Form
    {
        static private List<Product> steam = new List<Product>()
    {
        new Product(){Name = "스타듀밸리", Buy=7200000, Price=25000},
        new Product(){Name = "뱀파이어서바이벌", Buy=4240000, Price=3000},
        new Product(){Name = "오버쿡드1", Buy=1201000, Price=7000},
        new Product(){Name = "오버쿡드2", Buy=12210000, Price=7000},
        new Product(){Name = "오버쿡드3", Buy=1200200, Price=7000},
        new Product(){Name = "오버워치", Buy=600000, Price = 0},
        new Product(){Name = "포탈1", Buy=668000, Price = 12000},
        new Product(){Name = "포탈2", Buy=534000, Price = 12000},
        new Product(){Name = "심즈", Buy=802000, Price = 17000},
        new Product(){Name = "림버스컴퍼니", Buy=756000, Price = 7000},
        new Product(){Name = "데드바이데이라이트", Buy=122000, Price = 23000},
        new Product(){Name = "배틀그라운드", Buy=9032200, Price =0},
        new Product(){Name = "에이펙스레전드", Buy=1423000, Price = 12000},
        new Product(){Name = "다크소울", Buy=280000, Price = 22000},
        new Product(){Name = "테라리아", Buy=502300, Price = 6000},
        new Product(){Name = "사이버펑크", Buy=200000, Price = 5000},
        new Product(){Name = "러스트", Buy=31200000, Price=32000},
        new Product(){Name = "컵헤드", Buy=2402300, Price=27000},
        new Product(){Name = "몬스터헌터", Buy=2304000, Price=27000},
        new Product(){Name = "피자타워", Buy=1423000, Price = 12000}
    };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource2.DataSource = steam;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource2.DataSource = from item in steam
                                              orderby item.Name ascending
                                              select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productBindingSource2.DataSource = from item in steam
                                              orderby item.Name descending
                                              select item;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productBindingSource2.DataSource = from item in steam
                                              orderby item.Buy descending
                                              select item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productBindingSource2.DataSource = from item in steam
                                              orderby item.Buy ascending
                                              select item;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productBindingSource2.DataSource = from item in steam
                                              orderby item.Price descending
                                              select item;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            productBindingSource2.DataSource = from item in steam
                                               orderby item.Price ascending
                                               select item;
        }
    }
}
