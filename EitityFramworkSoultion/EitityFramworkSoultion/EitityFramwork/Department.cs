using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitityFramwork
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public List<student> ? Students { get; set; }
    }
}
