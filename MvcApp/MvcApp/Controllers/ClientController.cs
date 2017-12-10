using MvcApp.Models;
using MvcNov17.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNov2017.Controllers
{
    public class ClientController : Controller
    {
       
        public ActionResult Index()
        {
            return View(ClientsDAO.GetAllClients() );
        }

        public ActionResult Afficher(String id)
        {
            Client c= ClientsDAO.GetClientById(id);
            return View(c);
        }
        public ActionResult Supprimer(String id)
        {
            ClientsDAO.RemoveClient(id);
            return View();
        }
         [HttpGet]public ActionResult Ajouter()
        {
            return View(new Client());
        }
        
        [HttpPost]public ActionResult AjouterBack(String id, String nom, String prenom, DateTime DateNaissance)
        {
            
            Client c = new Client(id, nom, prenom, DateNaissance);
            ClientsDAO.UpdateOrAddClient(c);
            return View("Index",ClientsDAO.GetAllClients());
        }
        [HttpPost]public ActionResult Ajouter(Client client)//, String firstname)
        {
            //client.Prenom = firstname;
            //client.Prenom = Request.Form["firstname"]
            //client.Prenom = Request.Form.GetValues("firstname")[0];

            if (ModelState.IsValid) {
                ClientsDAO.UpdateOrAddClient(client);
                return View("Index",ClientsDAO.GetAllClients());
            }
            return View(client);
        }
        [HttpGet]
        public ActionResult Editer(String id)
        {
            return View(ClientsDAO.GetClientById(id));
        }
        [HttpPost]public ActionResult Editer(Client client, String Birthday)
        {
            ModelState.Remove("Id");
            DateTime dd;
            DateTime.TryParseExact(Birthday, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None,  out dd);
            client.DateNaissance = dd;
            if(client.DateNaissance!=null 
                && client.DateNaissance.CompareTo(DateTime.Now) > 0)
            {
                ModelState.AddModelError("DateNaissance", "Trop fort!");
            }
            
            if (ModelState.IsValid)
            {
                ClientsDAO.UpdateOrAddClient(client);
                return View("Index",ClientsDAO.GetAllClients());
            }
            return View(client);
        }
    }
}