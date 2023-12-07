using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    struct Worker
    {
        public int id { get; set; }
        public String dateString { get; set; }
        public String fullName { get; set; }
        public int age { get; set; }
        public int height { get; set; }
        public String birthdayString { get; set; }
        public String city { get; set; }

        public Worker(int id, String dateString,  String fullName, int age, int height, String birthdayString, String city)
        {
            this.id = id;   
            this.dateString = dateString; 
            this.fullName = fullName;
            this.age = age;
            this.height = height;
            this.birthdayString = birthdayString;
            this.city = city;
        }



        public string Print()
        {
            return ("ID: " + id + ", Дата записи: " + dateString + ", ФИО: " + fullName + ", Возраст: " + age + ", Рост: " + height + ", День рождения: " + birthdayString + ", " + city);
        }
    }
}
