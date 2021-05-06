using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CetStudent.Models
{
    public class Student
    {
        public Student()
        {
            CreatedDate = DateTime.Today;
            LastUpdateDate = DateTime.Now;

        }

        /*public int get_age(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            return age;
        }*/
         
        

        public int Id { get; set; }

        [DisplayName("Ad")]
        public string Name { get; set; }
        [DisplayName("Soyad")]
        public string Surname { get; set; }
        [DisplayName("Bölüm")]
        public string Departmant { get; set; }
        [DisplayName("Doğum Tarihi")]
        public DateTime Birthdate { get; set; }
        [DisplayName("Boy")]
        public decimal Height { get; set; }
        [DisplayName("Kilo")]
        public decimal Weight { get; set; }
        [DisplayName("Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; } 
        [DisplayName("Son Güncelleme Tarihi")]
        public DateTime LastUpdateDate { get; set; }

    }
}
