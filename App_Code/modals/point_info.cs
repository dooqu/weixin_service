using System;
using System.Collections.Generic;
using System.Web;

namespace com.dooqu.weixin.modals
{
    public class point_list_arg
    {
        public int begin;
        public int limit;
    }

    public class photo
    {
        public string photo_url;
    }

    public class point_base_info
    {
        public string business_name;//	门店名称（仅为商户名，如：国美、麦当劳，不应包含地区、地址、分店名等信息，错误示例：北京国美）	是
        public string branch_name;//	分店名称（不应包含地区信息，不应与门店名有重复，错误示例：北京王府井店）	是
        public string province;//	门店所在的省份（直辖市填城市名,如：北京市）	是
        public string city;//	门店所在的城市	是
        public string district;//	门店所在地区	是
        public string address;//	门店所在的详细街道地址（不要填写省市信息）	是
        public string telephone;//	门店的电话（纯数字，区号、分机号均由“-”隔开）	是
        public List<string> categories;//	门店的类型（不同级分类用“,”隔开，如：美食，川菜，火锅。详细分类参见附件：微信门店类目表）	是
        public int offset_type;//	坐标类型，1 为火星坐标（目前只能选1）	是
        public string longitude;//	门店所在地理位置的经度	是
        public string latitude;//	门店所在地理位置的纬度（经纬度均为火星坐标，最好选用腾讯地图标记的坐标）	是
        public List<photo> photo_list; //	图片列表，url 形式，可以有多张图片，尺寸为640*340px。必须为上一接口生成的url。图片内容不允许与门店不相关，不允许为二维码、员工合照（或模特肖像）、营业执照、无门店正门的街景、地图截图、公交地铁站牌、菜单截图等 是
        public string special;//	特色服务，如免费wifi，免费停车，送货上门等商户能提供的特色功能或服务	是
        public string open_time;//	营业时间，24 小时制表示，用“-”连接，如 8:00-20:00	是
        public int avg_price;//	人均价格，大于0 的整数	是
        public string sid;//	商户自己的id，用于后续审核通过收到poi_id 的通知时，做对应关系。请商户自己保证唯一识别性	否
        public string introduction;//	商户简介，主要介绍商户信息等	否
        public string recommend;//	推荐品，餐厅可为推荐菜；酒店为推荐套房；景点为推荐游玩景点等，针对自己行业的推荐内容	否
    }

    public class point_info
    {
        public point_base_info base_info;
    }

    public class point_list_data : sns_api_response_data
    {
        public List<point_info> business_list;
    }
}
