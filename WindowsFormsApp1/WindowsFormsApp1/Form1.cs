using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
            SaveData();
        }
        [LogAttritas] // AOP 적용
        public void LoadData()
        {
            Console.WriteLine("데이터 로드 중...");
            System.Threading.Thread.Sleep(500);
        }

        [LogAttritas] // AOP 적용
        public void SaveData()
        {
            Console.WriteLine("데이터 저장 중...");
            System.Threading.Thread.Sleep(300);
        }
    }
}
