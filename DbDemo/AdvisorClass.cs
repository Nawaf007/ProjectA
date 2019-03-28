using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo
{
    class AdvisorClass
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Contact { get; set; }
        public String Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Gender { get; set; }
        public int Designation { get; set; }
        public string Designations { get; set; }
        public decimal? Salary { get; set; }
        public String Genders { get; set; }
        public String AdvisorRole { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
}
