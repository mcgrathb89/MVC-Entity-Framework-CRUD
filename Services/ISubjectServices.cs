using WebApplication4.Models;

namespace WebApplication4.Services
{
    public interface ISubjectServices
    {
        public IEnumerable<Subject> GetAllSubjects();
        public void DeleteASubject(int id);
    }
}
