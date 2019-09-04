using EasyToGoCompany.Classes.Config;

namespace EasyToGoCompany.Classes.Connection
{
    public class Connection
    {
        public string path;

        public void Connect()
        {
            path = Constant.Database.Path;
        }
    }
}
