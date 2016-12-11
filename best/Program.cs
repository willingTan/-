using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace best
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bus.numberplate = "渝 12345";
            bus.line = "642";
            bus.number = 666;
            bus.startpoint = "菜园坝火车站";
            bus.destination = "重庆邮电大学";

            process();
            speedup(); 
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("正在行驶");
                Thread.Sleep(100);
            }

            Driver driver = new Driver();
            driver.Birthdate = new DateTime(1995, 8, 30);
            driver.Name = "室长";
            driver.Driveyears = 4;
            driver.Sex = "男";

            Police jiaojing = new Police();
            jiaojing.name = "城管";
            jiaojing.number = 573;

            Console.WriteLine("----------------------");
            Console.WriteLine("在交警的办公室里");

            jiaojing.punish();

            Console.WriteLine("超速人基本信息：");
            Console.WriteLine("姓名：{0}；年龄：{1}；驾龄：{2}；出生日期：{3}",driver.Name,driver.Ages,driver.Driveyears,driver.Birthdate);
            Console.WriteLine("超速车辆基本信息：");
            Console.WriteLine("车牌号：{0}；线路：{1}；起点：{2}；终点：{3}",bus.numberplate,bus.line,bus.startpoint,bus.destination);
            Console.WriteLine("负责人姓名：{0}；编号：{1}",jiaojing.name,jiaojing.number);

            Console.WriteLine("-----------------------");
            Console.WriteLine("最后告诫各个驾驶员：珍爱生命，切莫急躁！！！");



        }
        public async static void process()
        {
            Console.WriteLine("公交车从'菜园坝火车站'开出");
            await Task.Delay(1100);
            Console.WriteLine("公交车在‘重庆邮电大学’停车");
        }
        public async static void speedup()
        {
            await Task.Delay(500);  
            Console.WriteLine("这时超速了");
        }
    }
}
