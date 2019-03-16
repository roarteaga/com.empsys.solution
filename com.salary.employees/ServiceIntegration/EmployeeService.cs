using BusinessObjects;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace ServiceIntegration
{
    public class EmployeeService
    {
        protected static readonly ILog log = LogManager.GetLogger(typeof(EmployeeService));
        static string BaseurlGetEmployees = ConfigurationManager.AppSettings["ServiceGetEmployeesRoute"];
        public async Task<List<Employee>> GetEmployees()
        {
            List<JsonHeaders> parametros = new List<JsonHeaders>();
            //parametros.Add(new JsonHeaders("Authorization", token));
            JsonAdapters jadapters = new JsonAdapters();
            string response = await jadapters.GetJson(parametros, BaseurlGetEmployees, null, BaseurlGetEmployees, HttpMethod.GET);
            List<Employee> retObj = JsonConvert.DeserializeObject<List<Employee>>(response);
            return retObj;
        }

    }
}
