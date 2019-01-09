using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dynamic_Action_Links.Models
{
    public class DALProcessor
    {
        public List<DAL> DL { get; set; }

        public DALProcessor()
        {
            DL = new List<DAL>();
        }

        public void AddDAL(string Action, string Controller,string Name)
        {
            var dal = new DAL();
            dal.Action = Action;
            dal.Controller = Controller;
            dal.Name = Name;

            DL.Add(dal);
            
        }
    }
}