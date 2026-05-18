using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitityFramwork
{
   public class student
    {
        public int id {  get; set; }
        public string name {  get; set; }
        public int age {  get; set; }

        // One-to-One
        public Passport ? Passport { get; set; }

        // One-to-Many
        public Department ? Department { get; set; }

        // Many-to-Many
        public List<courses> ? Courses { get; set; } = new List<courses>();
    }
}
