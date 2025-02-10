using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HiringApp.Entities
{
    public enum CandidateStatus
    { Applies, Interviewing, Hired, Rejected }
    internal class Candidate
    {

        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppliedDate { get; set; }
        public CandidateStatus Status { get; set; }

        public bool IsValidEmail()
        {
            return Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Basic email validation
        }
    }
}
