using System.Web.Mvc;

namespace Hackney.Controllers
{
    public class TicketController : Controller
    {
        public ActionResult Index()
        {
            string ticketId = Request.QueryString["id"];
            if (string.IsNullOrEmpty(ticketId)) return View();
            else return View("~/Views/Ticket/Ticket.cshtml");
        }
    }
}