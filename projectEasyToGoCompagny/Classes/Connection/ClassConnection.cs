using EasyToGoCompany.Classes.Config;
using System.IO;

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
