using Furion.DynamicApiController;
using Furion.FriendlyException;
using Furion.JsonSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Web.Core.Services
{
    public class TestAppService : IDynamicApiController
    {
        [LoggingMonitor]
        public async Task<dynamic> GetDynamic()
        {
            string json = "{\"name\":\"张三\",\"age\":18}";
            var result = JSON.Deserialize<object>(json);
            return result;

        }
    }
}
