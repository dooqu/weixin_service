using System;
using System.Collections.Generic;
using System.Web;


namespace com.dooqu.weixin.modals
{
    /// <summary>
    /// sns_api_exception 的摘要说明
    /// </summary>
    public class sns_api_exception : Exception
    {
        public sns_api_exception(sns_api_response_data err_data)
            : base(string.Format("WeiXin SNS API Error:code={0},message={1}", err_data.errcode, err_data.errmsg))
        {

        }
    }
}