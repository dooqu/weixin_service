using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using com.dooqu.weixin.data;
using com.dooqu.weixin.modals;

public partial class _default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // WeixinServiceProvider data_provider = new WeixinServiceProvider("wx314cb0c63e89ad5f", "22d1a7039fd99765ad7e92d78f83f7df");

       // List<card_info> list = data_provider.GetCardlist(card_status.CARD_STATUS_DISPATCH | card_status.CARD_STATUS_NOT_VERIFY | card_status.CARD_STATUS_VERIFY_FALL | card_status.CARD_STATUS_VERIFY_OK, 0, 50);


        //card_list_obj list = data_provider.GetCardlist(card_status.CARD_STATUS_DISPATCH | card_status.CARD_STATUS_VERIFY_OK | card_status.CARD_STATUS_NOT_VERIFY, 0, 50);

    }

    protected void Page_Error(object  sender, EventArgs e)
    {
        Response.Clear();
        Response.Write(Server.GetLastError().Message);
        Response.End();
    }
}