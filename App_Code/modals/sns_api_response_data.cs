using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// sns_api_response_data 的摘要说明
/// </summary>
namespace com.dooqu.weixin.modals
{
    public class sns_api_response_data
    {
        public int errcode;
        public string errmsg;

        public sns_api_response_data()
        {
            this.errcode = 0;
            this.errmsg = null;
        }

        public bool no_error
        {
            get
            {
                return errcode == 0;
            }
        }
    }
}