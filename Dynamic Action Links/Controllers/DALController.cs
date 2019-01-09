using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dynamic_Action_Links.Models;
namespace Dynamic_Action_Links.Controllers
{
    public class DALController : Controller
    {
        // GET: DAL
        public ActionResult Index()
        {
            var dalp = new DALProcessor();
            dalp.AddDAL("Index", "Home","Home Page");
            dalp.AddDAL("Index", "Home", "Home Page2");
            dalp.AddDAL("Index", "Home", "Home Page3");
            //var dal = new DAL();


            ////dalp.dal[0] = dal;

            //dal.Action = "Index";
            //dal.Controller = "Home";
            //dal.href = "@Url.Action(" + dal.Action + "," + dal.Controller + ")";

            //href="@Url.Action(item.Action,item.Controller)"

            return View(dalp);
        }
    }
}