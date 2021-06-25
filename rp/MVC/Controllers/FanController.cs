using ApplicarionService.DTOs;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class FanController : Controller
    {

        public ActionResult Index(string Search_Data = "")
        {
            List<FanVM> fansVM = new List<FanVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetFans(Search_Data))
                {
                    fansVM.Add(new FanVM(item));
                }
            }
            return View(fansVM);
        }

        public ActionResult Details(int id)
        {
            FanVM fanVM = new FanVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var fanDto = service.GetFansById(id);
                fanVM = new FanVM(fanDto);
            }
            return View(fanVM);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FanVM fanVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        FanDTO fanDTO = new FanDTO
                        {
                            Id = fanVM.Id,
                            FirstName = fanVM.FirstName,
                            LastName = fanVM.LastName,
                            Age = fanVM.Age
                        };

                        service.PostFan(fanDTO);

                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            FanVM fanVM = new FanVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var fanDto = service.GetFansById(id);
                fanVM = new FanVM(fanDto);
            }
            return View(fanVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FanVM fanVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        FanDTO fanDto = new FanDTO
                        {
                            Id = fanVM.Id,
                            FirstName = fanVM.FirstName,
                            LastName = fanVM.LastName,
                            Age = fanVM.Age
                        };

                        service.PostFan(fanDto);
                    }
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            FanVM fanVM = new FanVM();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                FanDTO fanDto = service.GetFansById(id);

                fanVM = new FanVM(fanDto);
            }
            return View(fanVM);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteFan(id);
            }
            return RedirectToAction("Index");
        }
    }
}