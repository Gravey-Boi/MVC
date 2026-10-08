using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Security.Cryptography.X509Certificates;

namespace MVC.Controllers
{
    public class ProfileSelectController : Controller
    {
        public IActionResult ProfileSelect()
        {
            List<ProfileSelectItem> profiles = new List<ProfileSelectItem>();

            ProfileSelectItem profile1 = new ProfileSelectItem();

            profile1.profileName = "Benito";
            profile1.profile = null;

            profiles.Add(profile1);

            ProfileSelectItem profile2 = new ProfileSelectItem();

            profile2.profileName = "Example";
            profile2.profile = null;

            profiles.Add(profile2);

            return View(profiles);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
