using HiringApp.Data_Store;
using HiringApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringApp.Service_Layer
{
    internal class HiringService
    {

        private HiringData data;

        public HiringService()
        {
            data = new HiringData();
        }

        // ... (Add methods for all the required operations)

        public void AddCandidate(Candidate candidate)
        {
            if (!candidate.IsValidEmail())
            {
                throw new ArgumentException("Invalid email format.");
            }
            candidate.CandidateId = data.GetNextCandidateId();
            data.Candidates.Add(candidate);
        }

        public void AssignCandidate(int candidateId, int jobId)
        {
            var candidate = data.Candidates.Find(c => c.CandidateId == candidateId);
            var job = data.JobPositions.Find(j => j.JobId == jobId);

            if (candidate == null || job == null)
            {
                throw new ArgumentException("Invalid candidate or job ID.");
            }

            if (!job.HasAvailableSlots())
            {
                throw new InvalidOperationException("No available slots for this job.");
            }

            job.AssignedCandidates.Add(candidate);
            candidate.Status = CandidateStatus.Interviewing; // Update status
            job.AvailableSlots--; // Decrease available slots
        }

        // ... (Implement other operations: UpdateCandidate, DeleteCandidate, AddJobPosition, etc.)
    }
}
