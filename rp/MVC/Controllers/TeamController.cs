using ApplicarionService.DTOs;
using MVC.Helpers;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class TeamController : Controller
    {

        public ActionResult Index(string Search_Data = "")
        {
            List<TeamVM> teamsVM = new List<TeamVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetTeams(Search_Data))
                {
                    teamsVM.Add(new TeamVM(item));
                }
            }
            return View(teamsVM);
        }

        public ActionResult Details(int id)
        {
            TeamVM teamVM = new TeamVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var teamDto = service.GetTeamById(id);
                teamVM = new TeamVM(teamDto);
            }
            return View(teamVM);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeamVM teamVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        TeamDTO teamDTO = new TeamDTO
                        {
                            Name = teamVM.Name,
                            Country = teamVM.Country,
                            Year = teamVM.Year
                        };
                        service.PostTeam(teamDTO);

                        return RedirectToAction("Index");
                    }
                }
                ViewBag.Teams = Utilities.LoadTeamData();
                return View();
            }
            catch
            {
                ViewBag.Teams = Utilities.LoadTeamData();
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            TeamVM teamVM = new TeamVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var teamDto = service.GetTeamById(id);
                teamVM = new TeamVM(teamDto);
            }

            return View(teamVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TeamVM teamVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        TeamDTO teamDto = new TeamDTO
                        {
                            Id = teamVM.Id,
                            Name = teamVM.Name,
                            Country = teamVM.Country,
                            Year = teamVM.Year
                        };
                        service.PostTeam(teamDto);
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
            TeamVM teamVM = new TeamVM();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                TeamDTO teamDto = service.GetTeamById(id);
                teamVM = new TeamVM(teamDto);
            }
            return View(teamVM);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteTeam(id);
            }
            return RedirectToAction("Index");
        }

    }
}