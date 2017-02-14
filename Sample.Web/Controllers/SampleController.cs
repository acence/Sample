using Sample.Logic.Interfaces;
using Sample.Logic.TransferModels;
using Sample.Web.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sample.Web.Controllers
{
    public class SampleController : BaseController
    {
        private readonly IExampleFirstLogic _exampleFirstLogic;
        public SampleController(IExampleFirstLogic exampleFirstLogic)
        {
            _exampleFirstLogic = exampleFirstLogic;
        }

        // GET: Sample
        public async Task<ActionResult> Index()
        {
            var test = await _exampleFirstLogic.GetAll();
            return View();
        }
    }
}