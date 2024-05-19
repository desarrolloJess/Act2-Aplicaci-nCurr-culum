using Microsoft.AspNetCore.Mvc;

namespace AplicacionCurriculum.Controllers
{
    public class AcademicaController : Controller
    {
        public IActionResult PreparacionAcademica()
        {
            return View();
        }
    }
}
