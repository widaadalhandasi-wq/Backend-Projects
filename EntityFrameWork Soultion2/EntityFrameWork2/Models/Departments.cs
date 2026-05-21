using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork2.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string ? Name { get; set; }

        public List<Student>? Students { get; set; }    //Navigation property يشاور على student
    }
}
