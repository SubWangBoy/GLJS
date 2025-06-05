using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 平移电机功率计算
{
    public class Class平移电机功率计算
    {
        public  double 汽车重量;
        public  double 搬运器质量;
        public  double 横移车质量;
        public  double 行走轮直径;
        public  double 行走轮轴径;
        public  double 设备运行稳定速度;
        public  double 重力加速度;
        public  double 停车设备启动时间;
        public  double 滚动摩擦轴承系数;
        public  double 车轮沿轨道的滚动摩擦力臂;
        public  double 附加阻力系数;
        public  double 坡度阻力系数;
        public  double 减速机数量;
        public  double 系统效率;
        public Class平移电机功率计算(double 汽车重量 ,double 搬运器质量,double 横移车质量,double 行走轮直径, double 行走轮轴径, double 设备运行稳定速度,double 重力加速度,
            double 停车设备启动时间,double 滚动摩擦轴承系数,double 车轮沿轨道的滚动摩擦力臂,double 附加阻力系数,double 坡度阻力系数,
            double 减速机数量,double 系统效率)
        {
            if (this.汽车重量<=0)
            {

            }
            this.汽车重量 = 汽车重量;
            this.搬运器质量 = 搬运器质量;
            this.横移车质量 = 横移车质量;
            this.行走轮直径 = 行走轮直径;
            this.行走轮轴径 =行走轮轴径;
            this.设备运行稳定速度 = 设备运行稳定速度;
            this.重力加速度 = 重力加速度;
            this.停车设备启动时间 = 停车设备启动时间;
            this.滚动摩擦轴承系数 = 滚动摩擦轴承系数;
            this.车轮沿轨道的滚动摩擦力臂 = 车轮沿轨道的滚动摩擦力臂;
            this.附加阻力系数 = 附加阻力系数;
            this.坡度阻力系数 = 坡度阻力系数;
            this.减速机数量 = 减速机数量;
            this.系统效率 = 系统效率;
        }

        public  double 加速度() { return 设备运行稳定速度 / 停车设备启动时间; }
        public  double 运行部分重力() { return(汽车重量+搬运器质量+横移车质量)*重力加速度; }
        public double 爬坡阻力() { return 运行部分重力() * 坡度阻力系数; }
        public double 运行摩擦阻力() {return 运行部分重力() * (滚动摩擦轴承系数*行走轮轴径+2* 车轮沿轨道的滚动摩擦力臂)*附加阻力系数/行走轮直径; }
        public double 小车平稳运行阻力() { return 运行摩擦阻力() + 爬坡阻力(); }
        public double 克服惯性力() { return (汽车重量 + 搬运器质量 + 横移车质量) * 加速度(); }
        public double 减速机扭矩() { return (克服惯性力() + 小车平稳运行阻力()) * 行走轮直径 / (2 * 1000 * 减速机数量 * 系统效率); }
        public double 需求功率() { return (克服惯性力() + 小车平稳运行阻力()) * 设备运行稳定速度 / (1000 * 减速机数量 * 系统效率); }
        public double 需求转速() { return 设备运行稳定速度 * 1000 * 60 / (Math.PI*行走轮直径); }


    }
}
