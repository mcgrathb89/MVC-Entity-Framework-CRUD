using Microsoft.AspNetCore.Mvc;
using WebApplication4.Context;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class SubjectController : Controller
    {
        ISubjectServices iss;

        public SubjectController(ISubjectServices _iss)
        {
            iss = _iss;
        }

        public IActionResult Index() // READ
        {
            return View(iss.GetAllSubjects());
        }

        public IActionResult Delete(int id) // DELETE
        {
            iss.DeleteASubject(id);
            return RedirectToAction("Index");
        }
    }
}
