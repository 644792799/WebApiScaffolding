namespace WebApiScaffolding.Controllers
{
    using Models;
    using Permissions;
    using System.Web.Http;

    [AuthFilter]
    public class ValuesController : BaseController
    {
        /// <summary>
        /// 权限管理内
        /// </summary>
        /// <returns></returns>
        [Route("~/api/values/values")]
        [HttpGet]
        public IHttpActionResult GetValues()
        {
            return Ok(new[] { "a", "b", "c" });
        }

        /// <summary>
        /// 权限管理外
        /// </summary>
        /// <returns></returns>
        [Route("~/api/values/valueswithoutpermession"), AllowAnonymous]
        public IHttpActionResult GetValuesWithoutPermession()
        {
            return Ok(new[] { "b", "c", "d" });
        }
    }
}
