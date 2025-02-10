using HiringApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringApp.Data_Store
{
    internal class HiringData
    {
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();
        public List<JobPosition> JobPositions { get; set; } = new List<JobPosition>();

        private int nextCandidateId = 1;  // Simple ID generation
        private int nextJobId = 1;

        public int GetNextCandidateId() { return nextCandidateId++; }
        public int GetNextJobId() { return nextJobId++; }
    }
}
