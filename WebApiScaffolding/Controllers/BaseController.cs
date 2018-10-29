using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiScaffolding.Common;
using WebApiScaffolding.Models;

namespace WebApiScaffolding.Controllers
{
    public class BaseController : ApiController
    {
        protected ApiTools apiTool = new ApiTools();

        #region 服务链接测试
        [Route("~/api/base/LinkTest")]
        [HttpGet]
        public RTInfo LinkTest()
        {
            RTInfo rtinfo = new RTInfo();
            rtinfo.IsSuccess = true;
            return rtinfo;
        }
        #endregion
    }
}