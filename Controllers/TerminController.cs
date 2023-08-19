using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using NToastNotify;
using PregledPlus.Data;
using PregledPlus.Models;
using PregledPlus.Repository;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace PregledPlus.Controllers
{
    public class TerminController : Controller
    {
        private IUnitOfWork unitOfWork;
        private IToastNotification toast;
        public TerminController(IUnitOfWork _unitOfWork, IToastNotification _toast)
        {
            unitOfWork = _unitOfWork;  
            toast = _toast;
        }
        public IActionResult Index()
        {
            return View();
        }

       
        [HttpGet]
        public IActionResult GetAll() 
        {
            var item = unitOfWork.TerminRepository.GetAll();
            return Json(item);
        }
        [HttpGet]
        public IActionResult GetOne(int id)
        {
            var item=unitOfWork.TerminRepository.GetFirstOrDefault(x=>x.id==id);    
            return Json(item);
        }
        [HttpPost]
        
        public IActionResult Create(Termin termin)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.TerminRepository.Add(termin);
                unitOfWork.Save();
                toast.AddSuccessToastMessage("Termin je uspesno dodat!");
                return RedirectToAction("Index", "CMS");
            }
            else
            {
                toast.AddErrorToastMessage("Doslo je do greske pri kreiranju termina!");
                return RedirectToAction("Index", "CMS");
            }

        }
    }
}
