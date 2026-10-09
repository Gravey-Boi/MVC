using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Security.Cryptography.X509Certificates;

namespace MVC.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile(int profileID)
        {
            Profile profile1 = new Profile();

            profile1.firstName = "Earl";
            profile1.middleName = "Vincent";
            profile1.lastName = "Medina";

            profile1.age = 20;

            profile1.profileDescription = "This guy is a MASSIVE retard.\nHonestly he should be shot\nand burned at the stake.\n\nRanked Gold as USF, Brits, and DAK.";
            profile1.profileImageAddress = "~/Images/Brot(Cropped).jpg";

            profile1.profileItems = new List<ProfileItem>();

            ProfileItem profile1Item1 = new ProfileItem();

            profile1Item1.itemTitle = "Thing I did";
            profile1Item1.itemDescription = "Insert description of thing I did here";
            profile1Item1.itemImageAddress = "~/Images/1231-faunanod.gif";

            profile1.profileItems.Add(profile1Item1);

            ProfileItem profile1Item2 = new ProfileItem();

            profile1Item2.itemTitle = "Something fucking else";
            profile1Item2.itemDescription = "Make some shit up idk";
            profile1Item2.itemImageAddress = "~/Images/6017-purpleguy-dance.gif";

            profile1.profileItems.Add(profile1Item2);

            Profile profile2 = new Profile();

            profile2.firstName = "Darren";
            profile2.middleName = "Martin";
            profile2.lastName = "Manreza";

            profile2.age = 21;

            profile2.profileDescription = "Possibly braindead";
            profile2.profileImageAddress = "~/Images/1231-faunanod.gif";

            profile2.profileItems = new List<ProfileItem>();

            ProfileItem profile2Item1 = new ProfileItem();

            profile2Item1.itemTitle = "Some batshit insane shit";
            profile2Item1.itemDescription = "I think it might be illegal to write this down";
            profile2Item1.itemImageAddress = "~/Images/Brot(Cropped).jpg";

            profile2.profileItems.Add(profile2Item1);

            switch (profileID)
            {
                case 1: return View(profile1); break;
                case 2: return View(profile2); break;
                default: return View(profile1); break;
            }
        }

        public IActionResult ProfileSelect()
        {
            List<ProfileSelect> profileSelects = new List<ProfileSelect>();
            
            ProfileSelect profileSelect1 = new ProfileSelect();
            profileSelect1.displayName = "Medina";
            profileSelect1.profileID = 1;

            profileSelects.Add(profileSelect1);

            ProfileSelect profileSelect2 = new ProfileSelect();
            profileSelect2.displayName = "Manreza";
            profileSelect2.profileID = 2;

            profileSelects.Add(profileSelect2);

            return View(profileSelects);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
