using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetQuote.AppServices;
using PetQuote.Models.ViewModel;

namespace PetQuote.Web.Controllers
{
    public class QuoteController : Controller
    {
        #region private property
        private IQuoteService _iquoteService = null;
        #endregion

        #region public region
        public QuoteController(IQuoteService quoteService)
        {
            _iquoteService = quoteService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([FromBody]Quote quote)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _iquoteService.GetQuote(quote);

            return Json(new { Success = result });
        }

        public async Task<JsonResult> GetPetAges()
        {
            var result = await _iquoteService.GetPetAges();

            return new JsonResult(result);
        }

        public async Task<JsonResult> GetBreed(int petType)
        {
            List<PetDetail> result = null;
            if (petType > 0)
            {
                result = await _iquoteService.GetPetBreed(petType);
            }

            return new JsonResult(result);
        }
        #endregion
    }
}