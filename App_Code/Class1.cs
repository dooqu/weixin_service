//<%@ page language="c#" Inherits="data_provider_base" CodeFile="access_token.cs"%>
//<%@ import namespace="System.Net" %>
//<%@ import namespace="System.Web" %>
//<%@ import namespace="System.Web.Script.Serialization" %>


//<script language="c#" runat=server>

//class snsapi_base_user_info
//{
//    /*
//   "access_token":"ACCESS_TOKEN",
//   "expires_in":7200,
//   "refresh_token":"REFRESH_TOKEN",
//   "openid":"OPENID",
//   "scope":"SCOPE",
//   "unionid": "o6_bmasdasdsad6_2sgVt7hMZOPfL"
//    */
//    public string access_token;
//    public int expires_in;
//    public string refresh_token;
//    public string openid;
//    public string scope;
//    public string unionid;
//    public int errcode;
//    public string errmsg;
//}


//class snsapi_user_info
//{
//    public string openid;//	用户的唯一标识
//    public string nickname;//	用户昵称
//    public int sex;       //	用户的性别，值为1时是男性，值为2时是女性，值为0时是未知
//    public string province;//	用户个人资料填写的省份
//    public string city;//	普通用户个人资料填写的城市
//    public string country;//	国家，如中国为CN
//    public string headimgurl;//	用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。
//    public string[] privilege;//	用户特权信息，json 数组，如微信沃卡用户为（chinaunicom）
//    public string unionid;	//只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。详见：获取用户个人信息（UnionID机制）
//    public int errcode;
//    public string errmsg;
//}

//string getResponseString(string url)
//{

//    HttpWebResponse response = null;
//    try
//    {
//        System.Net.WebRequest wReq = System.Net.WebRequest.Create(url); 
//        // Get the response instance.  
//        response = (HttpWebResponse)wReq.GetResponse(); 
//        System.IO.Stream respStream = response.GetResponseStream();
//        {
//            // Dim reader As StreamReader = New StreamReader(respStream);
//            using(System.IO.StreamReader reader = new System.IO.StreamReader(respStream,Encoding.GetEncoding("UTF-8")))
//            {
//                return reader.ReadToEnd();
//            }
//        }
		 
//    }
//    catch(Exception ex)
//    {
//        return null;
//    }
//    finally
//    {
//        if(response != null)
//            response.Close();
//    }
//}

//void Page_Load(object sender, EventArgs e)
//{
//    string secret = "22d1a7039fd99765ad7e92d78f83f7df";
//    string url = "http%3A%2F%2Fweixin.dooqu.com%3A8080%2Fdefault.aspx";
//    string appid = "wx314cb0c63e89ad5f";
		

//    if(string.IsNullOrEmpty(Request.Params["code"]) && string.IsNullOrEmpty(Request.Params["state"]))
//    {
//        string jumpUrl = string.Format("https://open.weixin.qq.com/connect/oauth2/authorize?appid={0}&redirect_uri={1}&response_type=code&scope=snsapi_userinfo&state=STATE#wechat_redirect",
//                        appid, url);

//        Response.Redirect(jumpUrl);
//        Response.End();		
//    }
//    else
//    {

//        if(string.IsNullOrEmpty(Request.Params["code"]))
//        {
//            Response.Write("授权失败");
//            Response.End();
//            return;
//        }

		
//        //Response.Write(string.Format("<div style='display:none'>code={0} && state={1}</div>", Request.Params["code"], "haha"));

//        string content = getResponseString(string.Format("https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code",
//            appid, secret, Request.Params["code"]));

//        var serializer = new JavaScriptSerializer();
   	

//                snsapi_base_user_info user = serializer.Deserialize<snsapi_base_user_info >(content);

//        if(user == null)
//        {
//            Response.Write("<p>deserialize snsapi_base_user_info error.</p>");
//            Response.End();
//            return;
//        }

//        if(user.errcode > 0)
//        {
//            Response.Write(string.Format("<p>error at get snsapi_base_user_info:{0}</p>", user.errmsg));
//            Response.End();
//            return;
//        }

//        string user_info_content = getResponseString(string.Format("https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid={1}&lang=zh_CN", user.access_token, user.openid));

//        if(user_info_content == null)
//        {
//            Response.Write("<p>server response snsapi_user_info error.</p>");
//            Response.End();
//            return;
//        }



//        //Response.Write(string.Format("<p style='display:none'>{0}</p>", user_info_content));

//        snsapi_user_info user_info = serializer.Deserialize<snsapi_user_info>(user_info_content);

//        if(user_info == null)
//        {
//            Response.Write("<p>deserialize snsapi_user_info error.</p>");
//            Response.End();
//        }

//        if(user_info.errcode > 0)
//        {
//            Response.Write(string.Format("<p>error at get snsapi_user_info:{0}</p>", user.errmsg));
//            Response.End();
//            return;
//        }

//        Response.Write(string.Format("<p style='font-size=1.5rem;text-align:center'><h1>{0}</h1></p>", user_info.nickname));
//        Response.Write(string.Format("<center><img src='{0}' style='width:100%'/></center>", user_info.headimgurl));
//        Response.End();
//    }
//}
//</script>