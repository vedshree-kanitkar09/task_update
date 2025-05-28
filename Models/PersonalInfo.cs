using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace ApplicationForm.Models
{
    public class PersonalInfo
    {
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string Surname { get; set; }
        [Required]
        public required string FathersName { get; set; }

        [Required]
        public required string Nationality { get; set; }
        [Required]
        public int DateOfBirth { get; set; }

        [Required]
        public required string Gender { get; set; }

        [Required]
        public required string Marital { get; set; }
        [Required]
        public int Phone_no { get; set; }

        [Required]
        public required string Email { get; set; }
        [Required]
        public required string presentAddress { get; set; }

        [Required]
        public required string permanentAddress { get; set; }

        public int PassportNo { get; set; }

        public int PassIssueDate { get; set; }

        public int ExpiryDate { get; set; }

        public int VisaType { get; set; }

        public required string SchoolName { get; set; }

        public required string UniName1 { get; set; }

        public int SccMarks { get; set; }

        public int FromDateSC { get; set; }
        public int ToDateSC { get; set; }

        public required string JRName { get; set; }
        public required string UniName2 { get; set; }

        public int HSCMarks { get; set; }

        public int FromDateJR { get; set; }
        public int ToDateJR { get; set; }

        public required string SeniorName { get; set; }

        public required string SeniorCLG { get; set; }

        public int CGPA { get; set; }

        public int FromDateSR { get; set; }
        public int ToDateSR { get; set; }

        public required string Program { get; set; }

        public required string Institute { get; set; }
        public required string AFrom { get; set; }

        public required string ATo { get; set; }

        public required string description { get; set; }

        public int Year { get; set; }

        public required string Topic { get; set; }

        public required string Company1 { get; set; }

        public required string Strengths { get; set; }

        public required string Weakness { get; set; }

        public  string NameDesignation { get; set; }

        public  string CurrentCompany { get; set; }

        public  string Address { get; set; }

        public int ContactDetails {get; set;}
    }
}
