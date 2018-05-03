using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rundown.Core.Services
{
    public class ConfigurationService
    {
        public void InitializeAutoMapper()
        {
            Data.Configuration.InitializeAutoMapper();
        }
    }
}
