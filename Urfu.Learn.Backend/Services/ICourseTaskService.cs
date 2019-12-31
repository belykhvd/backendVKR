using System;
using System.Threading.Tasks;
using Contracts.Solution;

namespace Urfu.Learn.Backend.Services
{
    public interface ICourseTaskService
    {
        Task<Solution> FetchSolution(Guid courseTaskId, Guid studentId);
        Task SendSolution(Solution soluction);
    }
}