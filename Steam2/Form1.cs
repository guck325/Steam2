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
        new Product(){Name = "스타듀밸리", Buy=7200000},
        new Product(){Name = "뱀파이어서바이벌", Buy=4240000},
        new Product(){Name = "오버쿡드1", Buy=1201000},
        new Product(){Name = "오버쿡드2", Buy=12210000},
        new Product(){Name = "오버쿡드3", Buy=1200200},
        new Product(){Name = "오버워치", Buy=600000},
        new Product(){Name = "포탈1", Buy=668000},
        new Product(){Name = "포탈2", Buy=534000},
        new Product(){Name = "심즈", Buy=802000},
        new Product(){Name = "림버스컴퍼니", Buy=756000},
        new Product(){Name = "데드바이데이라이트", Buy=122000},
        new Product(){Name = "배틀그라운드", Buy=9032200},
        new Product(){Name = "에이펙스레전드", Buy=1423000},
        new Product(){Name = "다크소울", Buy=280000},
        new Product(){Name = "테라리아", Buy=502300},
        new Product(){Name = "사이버펑크", Buy=200000},
        new Product(){Name = "러스트", Buy=31200000},
        new Product(){Name = "컵헤드", Buy=2402300},
        new Product(){Name = "몬스터헌터", Buy=2304000},
        new Product(){Name = "피자타워", Buy=1423000}
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
            productBindingSource.DataSource = steam;
        }
    }
}
