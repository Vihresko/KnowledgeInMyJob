using KIJ.Data.DtoModels;
using Microsoft.AspNetCore.Mvc;

namespace KIJ.Application.Controllers
{
    public class AlgorithmController : Controller
    {
        [HttpGet]
        public IActionResult CreateAlgorithm()
        {
            return View(new CreateAlgorithmDto());
        }
    }
}
