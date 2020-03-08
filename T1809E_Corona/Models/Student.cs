using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T1809E_Corona.Models
{
    public class Student
    {
        [Key]

        public int Id { get; set; }
        [Display(Name ="Mã sinh viên")]
        public string CodeID { get; set; }
        public enum Fines
        {
            [Display(Name ="Chống đẩy")]
            pushUp = 1,

            [Display(Name = "Nộp tiền")]
            money = 2
        }
        
        [Display(Name ="Hình thức phạt")]
        public  Fines fines { get; set; }
        [Display(Name = "Số lượt chống đẩy")]
        public int Push_Up { get; set; }
        [Display(Name ="Tiền nộp phạt")]
        public decimal Money { get; set; }
        [Display(Name ="Ngày lập biên bản")]
        public DateTime CreatedDate { get; set; }
        
    }
}