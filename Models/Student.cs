using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        #region PROPERTIES
                
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "The Phone field is not a valid phone number")]
        public string Phone { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        #endregion
    }
}
