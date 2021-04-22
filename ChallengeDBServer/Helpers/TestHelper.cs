using System.IO;
using System.Reflection;

namespace ChallengeDBServer.Helpers
{
    public static class TestHelper
    {
        public static string ExeFolder => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}
