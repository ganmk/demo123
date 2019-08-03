using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using demo123.Common;
using demo123.Manager;
using demo123.Model;
using demo123.ViewModel;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace demo123.Controllers
{
    [Route("api/[controller]")]
    public class UserMenuController : Controller
    {
        [HttpPost("[action]")]
        public ResponseBaseModel UserMenuList([FromBody]SelectBaseModel model)
        {
            var vm = new UserMenuManager();
            int _count = vm.GetList(i=>i.um_id>0).Count;
            int _pageCount = _count / model.pageSize+1;
            List<user_menu> _list = vm.GetPageList(i=>i.um_id>0,
                new PageModel { PageIndex=model.current,PageSize=model.pageSize, PageCount= _pageCount });
            ResponseBaseModel responseBaseModel = new ResponseBaseModel();
            responseBaseModel.Data = _list;
            responseBaseModel.pageCount = _pageCount;
            responseBaseModel.currentIndex = model.current;
            responseBaseModel.totalCount = _count;
            return responseBaseModel;

        }

        [HttpGet("[action]")]
        public List<MenuTree> MenuTree()
        {
            var vm = new UserMenuManager();
            return vm.GetTreeMenu();
        }


        [HttpPost("[action]")]
        public dynamic AddUserMenu([FromBody]UserMenuViewModel model)
        {
            var vm = new UserMenuManager();
            List<ExpandoObject> sugarQueryable=vm.GetMaxid("user_menu", "um_id",1,1);
            model.um_id = sugarQueryable.First().ObjToInt();
            //vm.Insert(model);
            return Ok();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
