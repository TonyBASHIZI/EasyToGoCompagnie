using projectEasyToGoCompagny.Classes.Config;
using System.IO;

namespace projectEasyToGoCompagny.Classes.Connection
{
    public class Connection
    {
        public string path;

        public void Connect()
        {
            path = File.ReadAllText(Constant.Database.Path).Trim();
        }
    }
}
