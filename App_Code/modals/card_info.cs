using System;
using System.Collections.Generic;
using System.Web;

namespace com.dooqu.weixin.modals
{
    public enum card_type
    {
        GROUPON,
        DISCOUNT,
        GIFT,
        CASH,
        GENERAL_COUPON,
        MEMBER_CARD,
        SCENIC_TICKET,
        MOVIE_TICKET,
        BOARDING_PASS,
        MEETING_TICKET,
        BUS_TICKET
    }


    public enum card_status
    {
        //待审核；
        CARD_STATUS_NOT_VERIFY = 1,

        //审核失败
        CARD_STATUS_VERIFY_FALL = 2,

        //通过审核
        CARD_STATUS_VERIFY_OK = 4,

        //卡券被用户删除
        CARD_STATUS_USER_DELETE = 8,

        //在公众平台投放过的卡券
        CARD_STATUS_USER_DISPATCH = 16,


        CARD_STATUS_DISPATCH = 32,

        CARD_STATUS_ALL = 63
    }

    public enum date_info_type
    {
        DATE_TYPE_FIX_TIME_RANGE,
        DATE_TYPE_FIX_TERM
    }

    public class date_info
    {
        public date_info_type type;//	使用时间的类型。DATE_TYPE_FIX_TIME_RANGE 表示固定日期区间，DATE_TYPE_FIX_TERM表示固定时长（自领取后按天算），DATE_TYPE_PERMANENT 表示永久有效（会员卡类型专用）。
        public long begin_timestamp;//	type为DATE_TYPE_FIX_TIME_RANGE时专用，表示起用时间。从1970年1月1日00:00:00至起用时间的秒数，最终需转换为字符串形态传入，下同。（单位为秒）
        public long end_timestamp;//	type为DATE_TYPE_FIX_TIME_RANGE时专用，表示结束时间。（单位为秒）

        public int fixed_term;	//type为DATE_TYPE_FIX_TERM时专用，表示自领取后多少天内有效，领取后当天有效填写0。（单位为天）
        public int fixed_begin_term;//	type为DATE_TYPE_FIX_TERM时专用，表示自领取后多少天开始生效。（单位为天）

        public string ToString()
        {
            switch(type)
            {
                case date_info_type.DATE_TYPE_FIX_TERM:
                    if (fixed_term == 0)
                        return "领取后当天有效";

                    else
                        return string.Format("领取后{0}天有效", fixed_term.ToString());

                case date_info_type.DATE_TYPE_FIX_TIME_RANGE:
                    return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(begin_timestamp).ToString("yyyy年MM月dd日") + " 至 " + new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(end_timestamp).ToString("yyyy年MM月dd日");

                default:
                    return "时间未知";
            }
        }
    }

    public class sku_info
    {
        private int quantity_;

        public int quantity
        {
            get { return quantity_; }
            set { quantity_ = value; }
        }
        private int total_quantity_;

        public int total_quantity
        {
            get { return total_quantity_; }
            set { total_quantity_ = value; }
        }
    }

    public class card_id_arg
    {
        public string card_id;
    }

    public class card_list_arg
    {
        public int offset;
        public int count;//	是	int	10	需要查询的卡片的数量（数量最大50）。
        public List<string> status_list;//	否	int	CARD_STATUS_VERIFY_OK	支持开发者拉出指定状态的卡券列表，例：仅拉出通过审核的卡券。
    }

    public class card_id_list_data : sns_api_response_data
    {
        public List<String> card_id_list;
        public int total_num;
    }



    public class card_info_base
    {
        protected card_type type_;

        public card_type type
        {
            get
            {
                return this.type_;
            }
            set
            {
                this.type_ = value;
            }
        }
        private string id_;

        public string id
        {
            get { return id_; }
            set { id_ = value; }
        }
        private string title_;

        public string title
        {
            get { return title_; }
            set { title_ = value; }
        }
        public string sub_title_;
        private string logo_url_;

        public string logo_url
        {
            get { return logo_url_; }
            set { logo_url_ = value; }
        }
        public string code_type;
        public string brand_name;
        public string color;
        public string notice;
        public string service_phone;
        public string description;
        private date_info date_info_;

        public date_info date_info
        {
            get { return date_info_; }
            set { date_info_ = value; }
        }
        public int quantity;
        private sku_info sku_;

        public sku_info sku
        {
            get { return sku_; }
            set { sku_ = value; }
        }
        private card_status status_;

        public card_status status
        {
            get { return status_; }
            set { status_ = value; }
        }


        ///以下为可选字段
        public List<string> location_id_list;
        public bool use_custom_code;
        public bool bind_openid;
        public string source;
        public string custom_url_name;
        public string custom_url;
        public string custom_url_sub_title;
        public string promotion_url_name;
        public string promotion_url;//入口跳转外链的地址链接。
        public string promotion_url_sub_title;	//	显示在营销入口右侧的提示语。
        public int get_limit;//每人可领券的数量限制,不填写默认为50。
        public bool can_share;//	否	bool	false	卡券领取页面是否可分享。
        public bool can_give_friend;//	否	bool	false	卡券是否可转赠。


    }

    public class groupon_card
    {
        public card_info_base base_info;
        public string deal_detail;
    }

    public class general_coupon_card
    {
        public card_info_base base_info;
        public string default_detail;
    }

    public class gift_card
    {
        public card_info_base base_info;
        public string gift;
    }

    public class discount_card
    {
        public card_info_base base_info;
        public int discount;
    }

    public class cash_card
    {
        public card_info_base base_info;
        public int least_cost;
        public int reduce_cost;
    }



    public class card_info
    {
        public card_type card_type;
        public general_coupon_card general_coupon;
        public gift_card gift;
        public groupon_card groupon;
        public cash_card cash;
        public discount_card discount;

        public static string get_card_type_string(card_type type)
        {          
             //* 团购券：GROUPON; 折扣券：DISCOUNT; 礼品券：GIFT; 代金券：CASH; 通用券：GENERAL_COUPON; 
            //会员卡：MEMBER_CARD; 景点门票：SCENIC_TICKET； 电影票：MOVIE_TICKET； 
            //飞机票：BOARDING_PASS； 会议门票：MEETING_TICKET； 汽车票：BUS_TICKET;
            
            switch (type)
            {
                case card_type.SCENIC_TICKET:
                    return "景点门票";

                case card_type.MOVIE_TICKET:
                    return "电影票";

                case card_type.BOARDING_PASS:
                    return "飞机票";

                case card_type.MEETING_TICKET:
                    return "会议门票";

                case card_type.BUS_TICKET:
                    return "汽车票";

                case card_type.GROUPON:
                    return "团购券";

                case card_type.GENERAL_COUPON:
                    return "通用券";

                case card_type.DISCOUNT:
                    return "折扣券";

                case card_type.CASH:
                    return "代金券";


                case card_type.MEMBER_CARD:
                    return "会员卡";

                case card_type.GIFT:
                    return "礼品券";

                default:
                    return "未知类型";
            }
        }

        public static string get_card_status_string(card_status status)
        {
            switch(status)
            {
                case card_status.CARD_STATUS_DISPATCH:
                    return "已投放";
                case card_status.CARD_STATUS_VERIFY_OK:
                    return "待投放";
                case card_status.CARD_STATUS_VERIFY_FALL:
                    return "审核失败";
                case card_status.CARD_STATUS_NOT_VERIFY:
                    return "待审核";

                case card_status.CARD_STATUS_USER_DELETE:
                    return "用户删除";

                case card_status.CARD_STATUS_USER_DISPATCH:
                    return "已投放";

                default:
                    return "未知状态";
            }
        }
    }

    public class card_data : sns_api_response_data
    {
        public card_info card;
    }
}