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

            profile1.firstName = "Vain";
            profile1.middleName = "";
            profile1.lastName = "";

            profile1.age = 535724;

            profile1.profileDescription = "I believe in God, the Father Almighty, Creator of Heaven and earth;\r\nand in Jesus Christ, His only Son Our Lord,\r\nWho was conceived by the Holy Spirit, born of the Virgin Mary, suffered under Pontius Pilate, was crucified, died, and was buried.\r\nHe descended into Hell; the third day He rose again from the dead;\r\nHe ascended into Heaven, and sitteth at the right hand of God, the Father almighty; from thence He shall come to judge the living and the dead.\r\nI believe in the Holy Spirit, the holy Catholic Church, the communion of saints, the forgiveness of sins, the resurrection of the body and life everlasting.";
            profile1.profileImageAddress = "~/Images/skulls.png";

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

            Profile profile3 = new Profile();

            profile3.firstName = "Dead";
            profile3.middleName = "and";
            profile3.lastName = "Buried";

            profile3.age = 156;

            profile3.profileDescription = "Do not take me for granted.";
            profile3.profileImageAddress = "~/Images/ground.jpg";

            profile3.profileItems = new List<ProfileItem>();

            ProfileItem profile3Item1 = new ProfileItem();

            profile3Item1.itemTitle = "I wish this room was vacant";
            profile3Item1.itemDescription = "I wish that I could disappear\r\nThat I could fade into the grey\r\nWithout the burden of anyone missing me";
            profile3Item1.itemImageAddress = "~/Images/treatment.jpg";

            profile3.profileItems.Add(profile3Item1);

            ProfileItem profile3Item2 = new ProfileItem();

            profile3Item2.itemTitle = "No longer I";
            profile3Item2.itemDescription = "When our limbs long no longer crave to continue despite\r\nWhen every urge of living has been stolen by life\r\nVengeance in worldly ruin held back beyond God's grasp\r\nI am oppressed by such strange thoughts, seeking the gloss of dawn\r\nDominated by demented perceptions, blood clung cloth told of this tempest\r\nAt the hands of a machine made for violence and murdering";
            profile3Item2.itemImageAddress = "~/Images/folly.webp";

            profile3.profileItems.Add(profile3Item2);

            ProfileItem profile3Item3 = new ProfileItem();

            profile3Item3.itemTitle = "I belong here";
            profile3Item3.itemDescription = "Sitting in your bedroom\r\nAll alone you wait to hear the sound\r\nOf a door once locked now opening\r\n\r\nEvery time your frozen memories come to thaw\r\nBit by bit melts away until there's nothing at all\r\nEven when they're gone you hold so tightly to them\r\nIn your heart, you will never forget";
            profile3Item3.itemImageAddress = "~/Images/room.webp";

            profile3.profileItems.Add(profile3Item3);

            switch (profileID)
            {
                case 1: return View(profile1); break;
                case 2: return View(profile2); break;
                case 3: return View(profile3); break;
                default: return View(profile1); break;
            }
        }

        public IActionResult ProfileSelect()
        {
            List<ProfileSelect> profileSelects = new List<ProfileSelect>();
            
            ProfileSelect profileSelect1 = new ProfileSelect();
            profileSelect1.displayName = "Followers";
            profileSelect1.profileID = 1;

            profileSelects.Add(profileSelect1);

            ProfileSelect profileSelect2 = new ProfileSelect();
            profileSelect2.displayName = "Persist";
            profileSelect2.profileID = 2;

            profileSelects.Add(profileSelect2);

            ProfileSelect profileSelect3 = new ProfileSelect();
            profileSelect3.displayName = "Memories";
            profileSelect3.profileID = 3;

            profileSelects.Add(profileSelect3);

            return View(profileSelects);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
