using KIJ.Core.Interfaces;
using KIJ.Data.DtoModels;
using Microsoft.AspNetCore.Mvc;

namespace KIJ.Application.Controllers
{
    public class AlgorithmController : Controller
    {
        private readonly IAlgorithmService _algorithmService;

        public AlgorithmController(IAlgorithmService algorithmService)
        {
            _algorithmService = algorithmService;
        }
        [HttpGet]
        public IActionResult CreateAlgorithm()
        {
            return View(new CreateAlgorithmDto());
        }

        [HttpPost]
        public async Task<IActionResult> CreateAlgorithm(CreateAlgorithmDto model)
        {
            await _algorithmService.CreateAlgorithm(model);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAlgorithmes()
        {
            var model =  await _algorithmService.CollectAllAlgorithmesInfo();
            return View(model);
        }
    }
}
