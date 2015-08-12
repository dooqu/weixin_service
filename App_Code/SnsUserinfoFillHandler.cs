using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// SnsUserinfoFillHandler 的摘要说明
/// </summary>
public class SnsUserinfoFillHandler : System.Web.IHttpHandler
{
    public virtual bool IsSnSBaseUserInfo()
    {
        return true;
    }
    public  void ProcessRequest(HttpContext context)
    {
        context.Items.Add("USER_INFO", GetSnsUserInfo(IsSnSBaseUserInfo()));          
    }

    protected virtual object GetSnsUserInfo(bool isBaseInfo)
    {
        return null;
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}