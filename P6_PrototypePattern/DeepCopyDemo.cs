using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_PrototypePattern
{
    class DeepCopyDemo
    {
    }

    class DeepCopyDemoResume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperienceD workExperience;

        public DeepCopyDemoResume(string name)
        {
            this.name = name;
            workExperience = new WorkExperienceD();
        }

        private DeepCopyDemoResume(WorkExperienceD workExperience)
        {
            this.workExperience =(WorkExperienceD)workExperience.Clone();
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
            this.workExperience.TimeArea = timeArea;
            this.workExperience.Company = company;
        }

        /// <summary>
        /// 显示
        /// </summary>
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name.Length, sex, age);
            Console.WriteLine($"工作经历{workExperience.TimeArea } {workExperience.Company}");

        }
        public object Clone()
        {
            /*return (object)this.MemberwiseClone();*/
            DeepCopyDemoResume obj = new DeepCopyDemoResume(this.workExperience);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;

        }
    }


    public class WorkExperienceD:ICloneable
    {
        private string timeArea;
        private string company;

        public string TimeArea
        {
            get { return timeArea; }
            set { timeArea = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
                 
        }

        public object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
