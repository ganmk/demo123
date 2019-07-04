using demo123.Manager;
using demo123.Model;
using demo123.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo123.Controllers
{
    [Route("api/[controller]")]
    public class SchoolDataController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<School> ShcoolList()
        {
            var cm = new SchoolManager();
            //不能把StudentManager变成静对象保证每次都NEW出来
            //cm.GetList();
            //cm.Delete(1);
            return cm.GetList();
        }

        public dynamic AddShcool(SchoolViewModel model)
        {
            var cm = new SchoolManager();
            cm.Insert(model);
            return Ok();
        }
    }
}
