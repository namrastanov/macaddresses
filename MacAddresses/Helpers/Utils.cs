namespace MacAddresses.Helpers
{
    public class Utils
    {
        public static string GetApplicationPath()
        {
            var path = System.Configuration.ConfigurationManager.AppSettings["MACS_PATH"];
            if (string.IsNullOrEmpty(path))
            {
                path = "N:\\VisualStudioProjects\\Test\\MacAddresses\\MacAddresses\\Macs\\";
            }
            return path;
        }
    }
}