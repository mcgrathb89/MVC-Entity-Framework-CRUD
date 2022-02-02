using WebApplication4.Context;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    public class SubjectServices : ISubjectServices
    {
        MVCContext db;

        public SubjectServices(MVCContext _db)
        {
            db = _db;
        }

        public void DeleteASubject(int id)
        {
            Subject subject = db.Subjects.FirstOrDefault(s => s.SubjetId == id);

            if (subject != null)
            {
                db.Remove(subject);
                db.SaveChanges();
            }
        }

        public IEnumerable<Subject> GetAllSubjects()
        {
            return (db.Subjects.Select(s => s).ToList());
        }
    }
}
