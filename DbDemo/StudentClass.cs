using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DbDemo
{
    class StudentClass
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Contact { get; set; }
        public String Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Gender { get; set; }
        public String RegistrationNo { get; set; }
        public String Genders { get; set; }
        public int GroupId { get; set; }
        public DateTime AssignmentDate { get; set; }
        public String Status { get; set; }

    }
}
