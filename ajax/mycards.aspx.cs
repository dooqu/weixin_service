using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.dooqu.weixin.data;
using com.dooqu.weixin.modals;

public partial class ajax_mycards : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WeixinServiceProvider data_provider = new WeixinServiceProvider("wx314cb0c63e89ad5f", "22d1a7039fd99765ad7e92d78f83f7df");

        List<card_info> card_list = data_provider.GetCardlist(card_status.CARD_STATUS_ALL, 0, 20);

        List<card_info_base> base_card_list = new List<card_info_base>(card_list.Count);

        for(int i = 0; i < card_list.Count; i++)
        {
            card_info cardinfo = card_list[i];

            switch(cardinfo.card_type)
            {
                case card_type.GENERAL_COUPON:
                    cardinfo.general_coupon.base_info.type = card_type.GENERAL_COUPON;
                    base_card_list.Add(cardinfo.general_coupon.base_info);
                    break;

                case card_type.GIFT:
                    cardinfo.gift.base_info.type = card_type.GIFT;
                    base_card_list.Add(cardinfo.gift.base_info);
                    break;

                case card_type.CASH:
                    cardinfo.cash.base_info.type = card_type.CASH;
                    base_card_list.Add(cardinfo.cash.base_info);
                    break;

                case card_type.DISCOUNT:
                    cardinfo.discount.base_info.type = card_type.DISCOUNT;
                    base_card_list.Add(cardinfo.discount.base_info);
                    break;

                case card_type.GROUPON:
                    cardinfo.groupon.base_info.type = card_type.GROUPON;
                    base_card_list.Add(cardinfo.groupon.base_info);
                    break;
            }
        }

        this.Repeater1.DataSource = base_card_list;
        this.Repeater1.DataBind();
    }
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

    }
    protected void Repeater1_ItemCreated(object sender, RepeaterItemEventArgs e)
    {

    }

    protected string getOptionStatus(string status)
    {
        card_status c_s = (card_status)Enum.Parse(typeof(card_status), status);

        if (c_s == card_status.CARD_STATUS_NOT_VERIFY || c_s == card_status.CARD_STATUS_VERIFY_FALL)
        {
            return "none";
        }
        return "block";
    }
}