using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiScaffolding.Models
{
    public class RTInfo
    {
        public RTInfo()
        {
            IsSuccess = false;
            MsgError = string.Empty;
        }
        /// <summary>
        /// 是否执行成功
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string MsgError { get; set; }
        /// <summary>
        /// 错误详细信息
        /// </summary>
        public string MsgErrorDetail { get; set; }
        /// <summary>
        /// 扩展信息
        /// </summary>
        public string Extention { get; set; }
    }
}