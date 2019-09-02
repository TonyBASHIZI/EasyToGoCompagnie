using EasyToGoCompany.Forms;

namespace EasyToGoCompany.Classes.Model
{
    public class User : Base
    {
        private static User _instance;

        public static User Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new User();
                }
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public int IdSession { get; set; }

        public string Description { get; set; }

        public string DescriptionSession { get; set; }

        public string Username { get; set; }

        public string UsernameSession { get; set; }

        public string Password { get; set; }

        public int Niveau { get; set; }

        public int NiveauSession { get; set; }

        public void UpdateFormMain()
        {
            FormMain.Instance.RefreshOnlineStatus();
        }

        public bool IsAuthenticate()
        {
            if (User.Instance.DescriptionSession != null && User.Instance.NiveauSession != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
