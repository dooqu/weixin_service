using System;
using System.Collections.Generic;
using System.Web;

namespace com.dooqu.weixin.modals
{

    public class user_info_base : sns_api_response_data
    {
        /*
       "access_token":"ACCESS_TOKEN",
       "expires_in":7200,
       "refresh_token":"REFRESH_TOKEN",
       "openid":"OPENID",
       "scope":"SCOPE",
       "unionid": "o6_bmasdasdsad6_2sgVt7hMZOPfL"
        */
        public string access_token;
        public int expires_in;
        public string refresh_token;
        public string openid;
        public string scope;
        public string unionid;
    }


    public class user_info : sns_api_response_data
    {
        //	用户的唯一标识
        public string openid;

        //	用户昵称
        public string nickname;

        //	用户的性别，值为1时是男性，值为2时是女性，值为0时是未知
        public int sex;

        //	用户个人资料填写的省份
        public string province;

        //	普通用户个人资料填写的城市
        public string city;

        //	国家，如中国为CN
        public string country;

        //	用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。
        public string headimgurl;

        //	用户特权信息，json 数组，如微信沃卡用户为（chinaunicom）
        public string[] privilege;

        //只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。详见：获取用户个人信息（UnionID机制）
        public string unionid;

    }
}
