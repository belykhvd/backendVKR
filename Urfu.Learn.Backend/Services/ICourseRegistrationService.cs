using System;
using System.Threading.Tasks;

namespace Urfu.Learn.Backend.Services
{
    public interface ICourseRegistrationService
    {
        Task<bool> Enroll(Guid courseId, Guid userId);
        Task Leave(Guid courseId, Guid userId);
    }
}