using excelToDb.Data.Context;
using excelToDb.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace excelToDb.Api.Controllers
{
    public class DataController : ApiController
    {
        public List<Sample> Get()
        {
            DataContext dataContext = new DataContext();
            return dataContext.Samples.ToList();
        }

    }
}
