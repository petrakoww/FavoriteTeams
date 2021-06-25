using ApplicarionService.DTOs;
using Data.Entities;
using MVC.Helpers;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ReviewController : Controller
    {

        public ActionResult Index(string Search_Data = "")
        {
            List<ReviewVM> reviewVM = new List<ReviewVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetReviews(Search_Data))
                {
                    reviewVM.Add(new ReviewVM(item));
                }
            }
            return View(reviewVM);
        }

        public ActionResult Create()
        {
            ViewBag.Teams = Utilities.LoadTeamData();
            ViewBag.Fans = Utilities.LoadFanData();
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReviewVM reviewVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        ReviewDTO reviewDTO = new ReviewDTO
                        {
                            Id = reviewVM.Id,
                            Comment = reviewVM.Comment,
                            Grade = reviewVM.Grade,

                            Fan = new Fan
                            {
                                Id = reviewVM.FanID
                            },

                            Team = new Team
                            {
                                Id = reviewVM.TeamID
                            }
                        };

                        service.PostReview(reviewDTO);

                        return RedirectToAction("Index");
                    }
                }
                ViewBag.Teams = Utilities.LoadTeamData();
                ViewBag.Fans = Utilities.LoadFanData();
                return View();
            }
            catch
            {
                ViewBag.Teams = Utilities.LoadTeamData();
                ViewBag.Fans = Utilities.LoadFanData();
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            ReviewVM reviewVM = new ReviewVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                ReviewDTO reviewDto = service.GetReviewsById(id);
                reviewVM = new ReviewVM(reviewDto);
            }
            return View(reviewVM);
        }

        public ActionResult Edit(int id)
        {
            ReviewVM reviewVM = new ReviewVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var reviewDto = service.GetReviewsById(id);
                reviewVM = new ReviewVM(reviewDto);
            }
            ViewBag.Fans = Utilities.LoadFanData();
            ViewBag.Teams = Utilities.LoadTeamData();

            return View(reviewVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReviewVM reviewVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        ReviewDTO reviewDto = new ReviewDTO
                        {
                            Id = reviewVM.Id,
                            Comment = reviewVM.Comment,
                            Grade = reviewVM.Grade,
                            Fan = new Fan
                            {
                                Id = reviewVM.FanID
                            },

                            Team = new Team
                            {
                                Id = reviewVM.TeamID
                            }
                        };
                        service.PostReview(reviewDto);
                    }
                    return RedirectToAction("Index");
                }
                ViewBag.Teams = Utilities.LoadTeamData();
                ViewBag.Fans = Utilities.LoadFanData();
                return View();
            }
            catch
            {
                ViewBag.Teams = Utilities.LoadTeamData();
                ViewBag.Fans = Utilities.LoadFanData();
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            ReviewVM reviewVM = new ReviewVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                ReviewDTO reviewDto = service.GetReviewsById(id);
                reviewVM = new ReviewVM(reviewDto);
            }
            return View(reviewVM);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteReview(id);
            }
            return RedirectToAction("Index");
        }
    }
}