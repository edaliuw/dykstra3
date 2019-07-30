using System;
using System.ComponentModel.DataAnnotations;
/* Ed Ali - Replaced code with code that has a nullable datetime regarding the enrollment date and also has a count for students */
namespace ContosoUniversity.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}
