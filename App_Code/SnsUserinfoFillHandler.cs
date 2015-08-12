using System;
using System.Collections.Generic;
using System.Web;
using com.dooqu.weixin.data;
using com.dooqu.weixin.modals;

/// <summary>
/// SnsUserinfoFillHandler 的摘要说明
/// </summary>
public abstract class SnsUserinfoFillHandler : System.Web.IHttpHandler
{
    public virtual bool IsSnSBaseUserInfo()
    {
        return true;
    }
    public void ProcessRequest(HttpContext context)
    {
        CheckSNSUserInfo(context);
        ProcessRequestHandle(context);
    }

    /// <summary>
    /// SnsUserinfoFillHandler已经重新实现了ProcessRequest， 实现逻辑请放入ProcessRequestHandle
    /// </summary>
    /// <param name="context"></param>
    protected abstract void ProcessRequestHandle(HttpContext context);

    protected virtual void CheckSNSUserInfo(HttpContext context)
    {
        //string secret = "22d1a7039fd99765ad7e92d78f83f7df";
        string url = context.Server.UrlEncode(context.Request.Url.ToString());
        string appid = "wx314cb0c63e89ad5f";

        if (string.IsNullOrEmpty(context.Request.Params["code"]) && string.IsNullOrEmpty(context.Request.Params["state"]))
        {
            string jumpUrl = string.Format("https://open.weixin.qq.com/connect/oauth2/authorize?appid={0}&redirect_uri={1}&response_type=code&scope=snsapi_userinfo&state=STATE#wechat_redirect",
                            appid, url);

            context.Response.Redirect(jumpUrl);
            context.Response.End();
        }
        else
        {
            if (string.IsNullOrEmpty(context.Request.Params["code"]))
            {
                throw new Exception("授权失败，参数错误");
            }

            context.Items.Add("USER_INFO", GetSnsUserInfo(context, context.Request.Params["code"], IsSnSBaseUserInfo()));
        }
    }

    protected virtual object GetSnsUserInfo(HttpContext context, string code, bool isBaseInfo)
    {
        string secret = "22d1a7039fd99765ad7e92d78f83f7df";
        string appid = "wx314cb0c63e89ad5f";

        WeixinServiceProvider service = new WeixinServiceProvider(appid, secret);

        user_info_base usertoken = service.GetOAuthUserInfoBase(code);

        if (usertoken == null)
            throw new Exception("user_info_base无法获取");

        user_info userinfo = service.GetOAuthUserInfo(usertoken);

        if (userinfo == null)
            throw new Exception("user_info无法获取");

        return userinfo;
    }


    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}