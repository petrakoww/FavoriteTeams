using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Helpers
{
    public static class Utilities
    {
        public static SelectList LoadFanData()
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                return new SelectList(service.GetFans(""), "Id", "FirstName", "LastName");
            }
        }

        public static SelectList LoadTeamData()
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                return new SelectList(service.GetTeams(""), "Id", "Name", "Country");
            }
        }
    }
}