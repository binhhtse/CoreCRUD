using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Data.Repository;
using jQueryDatatables.Models;
using Microsoft.AspNetCore.Mvc;

namespace jQueryDatatables.Controllers
{
    public class ReportController : Controller
    {
        private readonly IPersonalInfoRepository _personalInfoRepository;
        public ReportController(IPersonalInfoRepository personalInfoRepository)
        {
            _personalInfoRepository = personalInfoRepository;
        }
        public IActionResult Index()
        {
            var personalInfoData = _personalInfoRepository.GetAll().GroupBy(x=> x.Country).Select(r => new SimpleReportViewModel 
            { 
                DimensionOne = r.First().Country,
                Quantity = r.Count()
            });;
            
            var lstModel = personalInfoData.ToList();
            
            return View(lstModel);
        }
    }
}
