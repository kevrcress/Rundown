using Rundown.Core.Services;

namespace Rundown.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            var configurationService = new ConfigurationService();
            configurationService.InitializeAutoMapper();
        }
    }
}