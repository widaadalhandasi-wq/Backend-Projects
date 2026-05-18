using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitityFramwork
{
    public class Passport
    {
        public int Id { get; set; }
        public string PassportNumber { get; set; }

        // 1. إضافة المفتاح الأجنبي (الربط الرقمي)
        public int StudentId { get; set; }

        public student Student { get; set; }
    }
}
