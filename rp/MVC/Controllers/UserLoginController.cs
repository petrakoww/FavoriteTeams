using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace MVC.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginClass lc)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select Email,UserPassword from [dbo].[UserReg] where Email=@Email and UserPassword=@UserPassword";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Email", lc.UserName);
            sqlcomm.Parameters.AddWithValue("@UserPassword", lc.Password);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if (sdr.Read())
            {
                Session["username"] = lc.UserName.ToString();
                return RedirectToAction("welcome");
            }
            else
            {
                ViewData["Message"] = "User login details failed!";
            }
            sqlconn.Close();
            return View();
        }

        public ActionResult welcome()
        {
            return View();
        }
    }
}