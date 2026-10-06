using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Security.Cryptography.X509Certificates;

namespace MVC.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            Profile profile = new Profile();

            profile.firstName = "Benito";
            profile.middleName = "Theo";
            profile.lastName = "Pantoja";

            profile.age = 20;

            profile.profileDescription = "This guy is a MASSIVE retard.\nHonestly he should be shot\nand burned at the stake.\n\nRanked Gold as USF, Brits, and DAK.";
            profile.profileImageAddress = "~/Images/Brot(Cropped).jpg";

            profile.profileItems = new List<ProfileItem>();

            ProfileItem profileItem1 = new ProfileItem();

            profileItem1.itemTitle = "Thing I did";
            profileItem1.itemDescription = "Insert description of thing I did here";
            profileItem1.itemImageAddress = "~/Images/1231-faunanod.gif";

            profile.profileItems.Add(profileItem1);

            ProfileItem profileItem2 = new ProfileItem();

            profileItem2.itemTitle = "Something fucking else";
            profileItem2.itemDescription = "Make some shit up idk";
            profileItem2.itemImageAddress = "~/Images/6017-purpleguy-dance.gif";

            profile.profileItems.Add(profileItem2);

            return View(profile);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
