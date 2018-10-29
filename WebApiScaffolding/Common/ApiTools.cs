using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WebApiScaffolding.Common
{
    public class ApiTools
    {
        //private string msgModel = "{{\"code\":{0},\"message\":\"{1}\",\"result\":{2}}}";

        public ApiTools()
        {
        }

        //public HttpResponseMessage MsgFormat(ResponseCode code, string explanation, string result)
        //{
        //    string r = @"^(\-|\+)?\d+(\.\d+)?$";
        //    string json = string.Empty;
        //    if (Regex.IsMatch(result, r) || result.ToLower() == "true" || result.ToLower() == "false" || result == "[]" || result.Contains('{'))
        //    {
        //        json = string.Format(msgModel, (int)code, explanation, result);
        //    }
        //    else
        //    {
        //        if (result.Contains('"'))
        //        {
        //            json = string.Format(msgModel, (int)code, explanation, result);
        //        }
        //        else
        //        {
        //            json = string.Format(msgModel, (int)code, explanation, "\"" + result + "\"");
        //        }
        //    }
        //    return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
        //}

        /// <summary>
        /// 将所需要的对象转成JSON格式的数据并返回
        /// </summary>
        /// <param name="obj">任意对象</param>
        /// <returns></returns>
        public HttpResponseMessage GetReturnResult(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            HttpResponseMessage m = new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            return m;
        }
    }
}