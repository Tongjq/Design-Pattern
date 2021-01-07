using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_PrototypePattern
{
    class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;

        public Resume(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        /// <summary>
        /// 设置工作经历
        /// </summary>
        /// <param name="timeArea"></param>
        /// <param name="company"></param>
        public void SetWorkExperience(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        /// <summary>
        /// 显示
        /// </summary>
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}",name.Length, sex ,age);
            Console.WriteLine($"工作经历{timeArea} {company}");

        }
        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
