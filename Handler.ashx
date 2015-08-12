<%@ webhandler language="C#" class="Handler" %>

using System;
using System.Web;

public class Handler : SnsUserinfoFillHandler {
    
    public void ProcessRequest (HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }
 
    public bool IsReusable 
    {
        get
        {
            return false;
        }
    }
}