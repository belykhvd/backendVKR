using System;

namespace Contracts.Solution
{
    public class SolutionCheckResult
    {
        public Guid CourseId { get; set; }
        public Guid CourseTaskId { get; set; }
        public Guid StudentId { get; set; }
        public Guid MentorId { get; set; }
        public SolutionStatus Status { get; set; }
        public int Score { get; set; }
        public int PlagScore { get; set; }
        public DateTime CheckTime { get; set; }
    }
}