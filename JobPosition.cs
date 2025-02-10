using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringApp.Entities
{
    internal class JobPosition
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public int AvailableSlots { get; set; }
        public List<Candidate> AssignedCandidates { get; set; } = new List<Candidate>(); // List of assigned candidates

        public bool HasAvailableSlots()
        {
            return AvailableSlots > AssignedCandidates.Count;
        }
    }
}