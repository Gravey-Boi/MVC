namespace MVC.Models
{
    public class Profile
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }

        public int age { get; set; }

        public string profileDescription { get; set; }
        public string profileImageAddress { get; set;  }

        public List<ProfileItem> profileItems { get; set; }
    }

    public class ProfileItem
    {
        public string itemTitle { get; set; }
        public string itemDescription { get; set; }
        public string itemImageAddress { get; set; }
    }

    public class ProfileSelect
    {
        public string displayName { get; set; }
        public int profileID { get; set; }
    }
}
