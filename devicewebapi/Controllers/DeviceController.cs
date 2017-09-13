using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dataaccess;
using System.Web.Script.Serialization;


namespace devicewebapi.Controllers
{
    public class DeviceController : ApiController
    {
        public IEnumerable<Device_details> Get()
        {
            Console.WriteLine("hi 75F");
            JavaScriptSerializer json = new JavaScriptSerializer();
            using (CRUDexEntities entities = new CRUDexEntities())
            {
                // IEnumerable<Device_details> List = entities.Device_details.ToList();
                //return json.Serialize(entities.Device_details.ToList());
                return entities.Device_details.ToList();
               
            }
        }
    }
}
