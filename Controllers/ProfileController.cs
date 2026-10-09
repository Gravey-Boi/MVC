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

            profile1.firstName = "One so hollow";
            profile1.middleName = "";
            profile1.lastName = "";

            profile1.age = 535724;

            profile1.profileDescription = "I believe in God, the Father Almighty, Creator of Heaven and earth;\r\nand in Jesus Christ, His only Son Our Lord,\r\nWho was conceived by the Holy Spirit, born of the Virgin Mary, suffered under Pontius Pilate, was crucified, died, and was buried.\r\nHe descended into Hell; the third day He rose again from the dead;\r\nHe ascended into Heaven, and sitteth at the right hand of God, the Father almighty; from thence He shall come to judge the living and the dead.\r\nI believe in the Holy Spirit, the holy Catholic Church, the communion of saints, the forgiveness of sins, the resurrection of the body and life everlasting.";
            profile1.profileImageAddress = "~/Images/skull.jpg";

            profile1.profileItems = new List<ProfileItem>();

            ProfileItem profile1Item1 = new ProfileItem();

            profile1Item1.itemTitle = "Resting place";
            profile1Item1.itemDescription = "May it unite me more closely to you, the One true God, and lead me\r\nsafely through death to everlasting happiness with You. ";
            profile1Item1.itemImageAddress = "~/Images/hell.jpg";

            profile1.profileItems.Add(profile1Item1);

            ProfileItem profile1Item2 = new ProfileItem();

            profile1Item2.itemTitle = "Visions";
            profile1Item2.itemDescription = "O my God, I firmly believe that Thou art one God, in three Divine Persons, the Father, the Son and the Holy Ghost; I believe that Thy Divine Son became man and died for our sins and that He will come to judge the living and the dead. I believe these and all the truths which the holy Catholic Church teaches, because Thou hast revealed them, Who canst neither deceive nor be deceived.";
            profile1Item2.itemImageAddress = "~/Images/moloch.jpg";

            profile1.profileItems.Add(profile1Item2);

            Profile profile2 = new Profile();

            profile2.firstName = "Doctrine";
            profile2.middleName = "";
            profile2.lastName = "";

            profile2.age = 21;

            profile2.profileDescription = "You haven't bled my spirit yet.";
            profile2.profileImageAddress = "~/Images/sight.png";

            profile2.profileItems = new List<ProfileItem>();

            ProfileItem profile2Item1 = new ProfileItem();

            profile2Item1.itemTitle = "Beauty";
            profile2Item1.itemDescription = "please reveal to us your sublime beauty\r\nthat is everywhere, everywhere, everywhere,\r\nso that we will never again feel frightened";
            profile2Item1.itemImageAddress = "~/Images/earth.jpg";

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
            profileSelect1.displayName = "Benevolent";
            profileSelect1.profileID = 1;

            profileSelects.Add(profileSelect1);

            ProfileSelect profileSelect2 = new ProfileSelect();
            profileSelect2.displayName = "Painless";
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
