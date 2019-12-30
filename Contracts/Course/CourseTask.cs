using System;

namespace Contracts.Course
{
    public class CourseTask
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int MaxScore { get; set; }
        public bool IsAdmissionRequired { get; set; }
        public int AdmissionScore { get; set; }
    }
}