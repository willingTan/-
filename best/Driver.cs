using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace best
{
    class Driver
    {
        //public string name; 两种定义方法，建议使用属性，对体验更好
        //public string sex;
        //public DateTime birthdate;
        //public int driveyears;
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public int Ages
        {
            get//只用get，表示只读，不能赋值
            {
                return DateTime.Now.Year - this.Birthdate.Year;//对出生和现在年龄进行同步
            }
        }
        private int driveyears;

        public int Driveyears
        {
            get { return this.driveyears; }
            set
            {
                if (value <= 0)
                {
                    this.driveyears = 0;
                }
                else this.driveyears = value;
            }
        }

        public void Drive()
        {
            Console.WriteLine($"{this.Name}在开车");
        }

    }
}
