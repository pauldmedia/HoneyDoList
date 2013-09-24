using System.Web.Mvc;

namespace HoneyDoList.Controllers
{
  public class HomeController : Controller
  {
    //
    // GET: /Home/

    public ActionResult Index()
    {
      return View();
    }
  }
}