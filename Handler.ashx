<%@ webhandler language="C#" class="Handler" %>

using System;
using System.Web;

public class Handler : SnsUserinfoFillHandler 
{    
    protected override void ProcessRequestHandle (HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }
}