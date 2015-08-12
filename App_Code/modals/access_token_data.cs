using System;
using System.Collections.Generic;
using System.Web;

namespace com.dooqu.weixin.modals
{
    public class access_token_data : sns_api_response_data
    {
        public string access_token;
        public int expires_in_;
        public DateTime expires_date;
        public int expires_in
        {
            get
            {
                return expires_in_;
            }
            set
            {
                this.expires_in_ = value;
                this.expires_date = DateTime.Now.AddSeconds(value);
            }
        }
    }
}