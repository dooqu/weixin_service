using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using com.dooqu.weixin.modals;
using com.dooqu.weixin.data;

public partial class ajax_card : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(Request.Params["id"]))
        {
            throw new Exception("card id未提供");
        }

        WeixinServiceProvider provider = new WeixinServiceProvider("wx314cb0c63e89ad5f", "22d1a7039fd99765ad7e92d78f83f7df");

        card_info cardinfo = provider.GetCardInfoById(Request.Params["id"]);

        if (cardinfo == null)
            throw new Exception("card id对应的数据未找到");

        
        
    }
}