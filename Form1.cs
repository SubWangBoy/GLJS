using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 平移电机功率计算
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            
            InitializeComponent();
        }

        private void panel_参数_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_搬运器重量_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_滚动轴承摩擦系数_Click(object sender, EventArgs e)
        {
            Form 滚动轴承系数Form=new 轴承系数Form();
            滚动轴承系数Form.Show();
        }

        private void btn_摩擦力臂_Click(object sender, EventArgs e)
        {
            Form 摩擦力臂form = new 滚动摩擦力臂Form();
            摩擦力臂form.Show();
        }

        private void btn_附加阻力系数_Click(object sender, EventArgs e)
        {
            Form 附加阻力系数Form = new 附加阻力系数Form();
               附加阻力系数Form.Show();
        }

        private void btn_坡度阻力系数_Click(object sender, EventArgs e)
        {
            Form form = new 坡度阻力系数Form();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool ValidateNumericInput(TextBox textBox, out double result)
        {
            result = 0;

            // 检查空值
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("不能为空！");
                return false;
            }

            // 检查数字格式
            if (!double.TryParse(textBox.Text, out double value))
            {
                MessageBox.Show("请输入有效的数字！");
                return false;
            }

            // 检查正数
            if (value <= 0)
            {
                MessageBox.Show("数字必须大于0！");
                return false;
            }

            result = value;
            return true;
        }

        private void btn_计算_Click(object sender, EventArgs e)
        {
            
            if (!ValidateNumericInput(txb_汽车重量, out double a))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_搬运器重量, out double b))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_横移车重量, out double c))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_行走轮直径, out double d))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_行走轮轴径, out double f))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_设备稳定运行速度, out double g))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_重力加速度, out double h))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_停车设备启动时间, out double i))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_滚动摩擦轴承系数, out double j))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_车轮沿轨道的滚动摩擦力臂, out double k))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_附加阻力系数, out double l))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_爬坡阻力系数, out double m))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_减速机数量, out double n))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_系统效率, out double o))
            {
                return; // 验证失败时退出
            }

            //double a = Convert.ToDouble(txb_汽车重量.Text.ToString());
            //double b = Convert.ToDouble(txb_搬运器重量.Text.ToString());
            //double c = Convert.ToDouble(txb_横移车重量.Text.ToString());
            // double d = Convert.ToDouble(txb_行走轮直径.Text.ToString());
            //double f = Convert.ToDouble(txb_行走轮轴径.Text.ToString());
            // double g = Convert.ToDouble(txb_设备稳定运行速度.Text.ToString());
            //double h = Convert.ToDouble(txb_重力加速度.Text.ToString());
            //double i = Convert.ToDouble(txb_停车设备启动时间.Text.ToString());
            //double j = Convert.ToDouble(txb_滚动摩擦轴承系数.Text.ToString());
            //double k = Convert.ToDouble(txb_车轮沿轨道的滚动摩擦力臂.Text.ToString());
            //double l = Convert.ToDouble(txb_附加阻力系数.Text.ToString());
            //double m = Convert.ToDouble(txb_爬坡阻力系数.Text.ToString());
            //double n = Convert.ToDouble(txb_减速机数量.Text.ToString());
            //double o = Convert.ToDouble(txb_系统效率.Text.ToString());

            var 功率计算 = new Class平移电机功率计算(a, b, c, d, f, g, h, i, j, k, l, m, n, o);
            txb_加速度.Text = 功率计算.加速度().ToString("F2");
            txb_爬坡阻力.Text=功率计算.爬坡阻力().ToString("F2");
            txb_运动部分重力.Text = 功率计算.运行部分重力().ToString("F2");
            txb_运动摩擦阻力.Text = 功率计算.运行摩擦阻力().ToString("F2");
            txb_小车平稳运行阻力.Text = 功率计算.小车平稳运行阻力().ToString("F2");
            txb_克服惯性力.Text = 功率计算.克服惯性力().ToString("F2");
            txb_最大需求扭矩.Text = 功率计算.减速机扭矩().ToString("F2");
            txb_需求功率.Text = 功率计算.需求功率().ToString("F2");
            txb_需求转速.Text = 功率计算.需求转速().ToString("F2");
            //MessageBox.Show(功率计算.需求功率().ToString());
            this.Width = 949;
            this.Height = 650;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            this.Width = 450;
            this.Height = 640;
           this.MaximizeBox = false;
        }

        private void btn_超频计算_Click(object sender, EventArgs e)
        {
            if (!ValidateNumericInput(txb_额定转速, out double 额定转速))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_需求转速, out double 需求转速))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_最大需求扭矩, out double 最大需求扭矩))
            {
                return; // 验证失败时退出
            }   

            string 超频 = (50 * 需求转速 / 额定转速).ToString("F2");
            string 超频扭矩 = (50 * 最大需求扭矩 / Convert.ToDouble( 超频)).ToString("F2");
            if (!ValidateNumericInput(txb_小车平稳运行阻力, out double 小车平稳运行阻力))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_行走轮直径, out double 行走轮直径))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_减速机数量, out double 减速机数量))
            {
                return; // 验证失败时退出
            }
            if (!ValidateNumericInput(txb_系统效率, out double 系统效率))
            {
                return; // 验证失败时退出
            }
            string 平稳扭矩 = (小车平稳运行阻力* 行走轮直径 /(2*1000*减速机数量*系统效率) ).ToString("F2");
            if (!ValidateNumericInput(txb_克服惯性力, out double 克服惯性力))
            {
                return; // 验证失败时退出
            }
            string 超频功率 = ((克服惯性力+小车平稳运行阻力)*3.14*行走轮直径*额定转速/(减速机数量 * 系统效率*1000*1000*60)).ToString("F2");
            txb_超频.Text = 超频;
            txb_超频功率.Text = 超频功率;
            txb_超频扭矩.Text = 超频扭矩;
            txb_平稳扭矩.Text = 平稳扭矩;
        }
    }
}
