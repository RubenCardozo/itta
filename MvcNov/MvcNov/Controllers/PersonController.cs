using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcNov.Models;

namespace MvcNov.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Peson/

        public ActionResult Index()
        {
            List<Person> list = new List<Person>();

            Person per1 = new Person();
            per1.ID = 1;
            per1.surName = "Luk";
            per1.name = "Luis";
            per1.lastName = "Salinas";
            list.Add(per1);

            Person per2 = new Person();
            per2.ID = 2;
            per2.surName = "And";
            per2.name = "Andrea";
            per2.lastName = "Mora";
            list.Add(per2);

            Person per3 = new Person();
            per3.ID = 3;
            per3.surName = "Rub";
            per3.name = "Ruben";
            per3.lastName = "Cardozo";
            list.Add(per3);

            return View(list);
        }

    }
}
