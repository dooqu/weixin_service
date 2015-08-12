<%@ Page Language="C#" AutoEventWireup="true" CodeFile="card.aspx.cs" Inherits="ajax_card" %>

<div class="main_bd">

    <div id="js_detail_container">
        <div class="highlight_box group">
            <div class="msg_pre_view msg_preview_l l">
                <ul>
                    <li class="group">
                        <span class="l title">卡券状态</span>
                        <div class="msg" data-x="-80" data-y="-6">待投放</div>
                    </li>
                    <li class="group">
                        <span class="l title">卡券ID</span>
                        <div class="msg">ppRKvjjQikZC_sHT3QKtXFMfUvMM</div>
                    </li>


                </ul>
            </div>

        </div>
        <div>
            <div id="js_showinfo">
                <div class="intro card_msg">
                    <div class="list_img group">
                        <div class="msg_preview_panel r">
                            <div class="msg_section msg_pre_view">
                                <ul>
                                    <li class="section_title">券面信息</li>
                                    <li class="group">
                                        <span class="l title">卡券类型</span>
                                        <div class="msg">代金券</div>
                                    </li>
                                    <li class="group">
                                        <span class="l title">卡券标题</span>
                                        <div class="msg">美食工厂代金券</div>
                                    </li>

                                    <li class="group">
                                        <span class="l title">减免金额</span>
                                        <div class="msg">
                                            <span>10元
									</span>
                                        </div>
                                    </li>
                                    <li class="group">
                                        <span class="l title">抵扣条件</span>
                                        <div class="msg">
                                            <span id="js_least_cost_preview">满100元可用
									</span>
                                        </div>
                                    </li>

                                    <li class="group">
                                        <span class="l title">副标题</span>
                                        <div class="msg">消费100元，减10元</div>
                                    </li>

                                    <li class="group">
                                        <span class="l title">卡券颜色</span>
                                        <div class="msg"><span class="colour_block" style="background-color: #3D78DA;">#3D78DA</span></div>
                                    </li>
                                    <li class="group">
                                        <span class="l title">有效期</span>
                                        <div class="msg">
                                            <span id="js_time_container">2015-08-20至2015-09-30</span>

                                            &nbsp;&nbsp;<a href="javascript:void(0);" id="js_modifytime_btn">延长有效期</a>

                                        </div>
                                    </li>
                                    <li class="group">
                                        <span class="l title">商家名称</span>
                                        <div class="msg">美食汇火锅送</div>
                                    </li>
                                    <li class="group">
                                        <span class="l title">商家Logo</span>
                                        <div class="msg">
                                            <img data-src="https://mmbiz.qlogo.cn/mmbiz/2F5gNyicjc8qBpicEvI75ostAD1LUYYNuSfKjptf7q5xe8bjPKkA9OzmuGNpzDiatc1UoEe1wTwNErkyqibAnVBVxA/0" class="js_noreferimg" src="https://mmbiz.qlogo.cn/mmbiz/2F5gNyicjc8qBpicEvI75ostAD1LUYYNuSfKjptf7q5xe8bjPKkA9OzmuGNpzDiatc1UoEe1wTwNErkyqibAnVBVxA/0"></div>
                                    </li>
                                </ul>
                            </div>
                            <div class="msg_section msg_pre_view">
                                <ul>
                                    <li class="section_title">投放设置</li>
                                    <li class="group">
                                        <span class="l title">库存</span>
                                        <div class="msg">10</div>
                                    </li>
                                    <li class="group">
                                        <span class="l title">销券条码</span>
                                        <div class="msg">
                                            二维码									
								
                                        </div>
                                    </li>
                                    <li class="group">
                                        <span class="l title">操作提示</span>
                                        <div class="msg">扫码肖卷提示</div>
                                    </li>
                                    <li class="group">
                                        <span class="l title">领取限制</span>
                                        <div class="msg">每个用户限领2张</div>
                                    </li>

                                    <li class="group">
                                        <span class="l title">分享设置</span>
                                        <div class="msg">用户可以分享领券链接</div>
                                    </li>


                                    <li class="group">
                                        <span class="l title">转赠设置</span>
                                        <div class="msg">用户领券后可转赠其他好友</div>
                                    </li>


                                </ul>
                            </div>

                            <div class="msg_section msg_pre_view">
                                <ul>
                                    <li class="section_title">代金券详情</li>
                                    <li class="group">
                                        <span class="l title">使用须知</span>
                                        <div class="msg">到店的使用须知</div>
                                    </li>
                                    <li class="group">
                                        <span class="l title">优惠详情</span>
                                        <div class="msg">
                                            价值10元代金券1张											，满100元可使用。
										
								
                                        </div>
                                    </li>

                                    <li class="group">
                                        <span class="l title">客服电话</span>
                                        <div class="msg">4008927927</div>
                                    </li>
                                </ul>
                            </div>
                            <div class="msg_section msg_pre_view">
                                <ul>
                                    <li class="section_title">服务信息&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           
                                        <a href="javascript:void(0);" id="js_modifyservice_btn">修改</a></li>
                                    <li class="group">
                                        <span class="l title">适用门店</span>
                                        <div class="msg msg_table">
                                            <div class="table_wrp shop_list" id="js_shoplist">
                                                <table class="table" cellspacing="0">
                                                    <thead class="thead">
                                                        <tr>
                                                            <th class="table_cell name">
                                                                <div class="td_panel tl">门店名称</div>
                                                            </th>
                                                            <th class="table_cell addr">
                                                                <div class="td_panel tl">地址</div>
                                                            </th>
                                                        </tr>
                                                    </thead>
                                                    <tbody class="tbody">


                                                        <tr>
                                                            <td class="table_cell name">
                                                                <div class="td_panel tl">
                                                                    石景山万达广场
				
                    (审核中)
                
		
                                                                </div>
                                                            </td>
                                                            <td class="table_cell addr">
                                                                <div class="td_panel tl">石景山路乙18号院(石景山路与鲁谷大街交汇处西南角)</div>
                                                            </td>
                                                        </tr>


                                                    </tbody>
                                                </table>
                                                <div id="js_pagerbar"></div>
                                            </div>
                                        </div>
                                    </li>

                                </ul>
                            </div>

                            <div class="msg_section msg_pre_view">
                                <ul>
                                    <li class="section_title">自定义入口&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                
                                </li>
                                    <li class="group">
                                        <span class="l title">&nbsp; </span>
                                        <div class="msg">
                                            <ul class="info_list custom_list">

                                                <li class="info_li">
                                                    <p class="info"><a href="http://www.qq.com" target="_blank">入口1</a></p>
                                                    <span class="supply_area">入口1引导语<i class="ic ic_go"></i></span>
                                                </li>

                                            </ul>
                                        </div>
                                    </li>
                                </ul>
                            </div>


                        </div>
                        <div class="img_panel l">
                            <div class="client_side">
                                <div class="banner">代金券</div>
                                <div class="wrp">
                                    <div class="top" style="background-color: #3D78DA; border-bottom-color: #3D78DA;">
                                        <div class="logo group">
                                            <div class="avartar l">
                                                <img data-src="https://mmbiz.qlogo.cn/mmbiz/2F5gNyicjc8qBpicEvI75ostAD1LUYYNuSfKjptf7q5xe8bjPKkA9OzmuGNpzDiatc1UoEe1wTwNErkyqibAnVBVxA/0" class="js_noreferimg" src="https://mmbiz.qlogo.cn/mmbiz/2F5gNyicjc8qBpicEvI75ostAD1LUYYNuSfKjptf7q5xe8bjPKkA9OzmuGNpzDiatc1UoEe1wTwNErkyqibAnVBVxA/0"></div>
                                            <p>美食汇火锅送</p>
                                        </div>
                                        <div class="msg">
                                            <div class="main_msg">
                                                <p>美食工厂代金券</p>
                                                <p class="title_sub">消费100元，减10元</p>
                                            </div>
                                            <p class="time">有效期 2015-08-20至2015-09-30</p>
                                        </div>
                                        <div class="deco"></div>
                                    </div>
                                    <div class="wrp_content">
                                        <div class="wrp_section section_dispose">

                                            <div class="qr_code_panel">
                                                <div class="main_msg qr_code"></div>
                                                <p class="sn">1513-2290-1878</p>
                                            </div>


                                            <p>扫码肖卷提示</p>
                                        </div>
                                        <div class="wrp_section">
                                            <ul class="info_list">
                                                <li class="info_li">
                                                    <p class="info">代金券详情</p>
                                                    <span class="supply_area"><i class="ic ic_go"></i></span>
                                                </li>
                                                <li class="info_li">
                                                    <p class="info">适用门店</p>
                                                    <span class="supply_area">1家<i class="ic ic_go"></i></span>
                                                </li>
                                            </ul>
                                        </div>
                                        <div id="js_wepay_item" style="display: none;" class="wrp_section">
                                            <ul class="info_list">
                                                <li class="info_li">
                                                    <p class="info">快速买单</p>
                                                </li>
                                            </ul>
                                        </div>

                                        <div class="wrp_section">
                                            <ul class="info_list">

                                                <li class="info_li">
                                                    <p class="info">入口1</p>
                                                    <span class="supply_area">入口1引导语<i class="ic ic_go"></i></span>
                                                </li>

                                            </ul>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <form class="detail_card" id="js_modifyservice_container" style="display: none;" novalidate="novalidate">
                <input type="hidden" value="ppRKvjjQikZC_sHT3QKtXFMfUvMM" name="card_id">
                <h2 class="title">服务信息</h2>
                <div class="frm_control_group" id="js_cardshop_container">
                    <div class="js_edit_card_shop">
                        <label for="" class="frm_label">适用门店</label>
                        <div class="radio_row">
                            <div class="frm_controls">
                                <div class="radio_control_group group">
                                    <label class="frm_radio_label" for="checkbox1">
                                        <i class="icon_radio"></i>
                                        <span class="lbl_content">指定门店适用</span>
                                        <input type="radio" value="2" class="frm_radio js_shop_type" id="checkbox1">
                                    </label>
                                    <div class="table_wrp js_fix_shop" style="display: none;">
                                        <table class="table js_shop_table" cellspacing="0">
                                            <thead class="thead">
                                                <tr>
                                                    <th class="table_cell store_name">
                                                        <div class="td_panel">门店名称</div>
                                                    </th>
                                                    <th class="table_cell store_adr">
                                                        <div class="td_panel">地址</div>
                                                    </th>
                                                    <th class="table_cell store_oper no_extra">
                                                        <div class="td_panel group">操作</div>
                                                    </th>
                                                </tr>
                                            </thead>
                                            <tbody class="tbody js_shop_list">

                                                <tr data-id="272977454">
                                                    <td class="table_cell store_name ">
                                                        <div class="td_panel">石景山万达广场<i class="icon18 store_excellent"></i></div>
                                                    </td>
                                                    <td class="table_cell store_adr">
                                                        <div class="td_panel">石景山路乙18号院(石景山路与鲁谷大街交汇处西南角)</div>
                                                    </td>
                                                    <td class="table_cell store_oper no_extra">
                                                        <div class="td_panel group"></div>
                                                    </td>
                                                </tr>


                                            </tbody>
                                        </table>
                                        <div class="table_foot">
                                            <a href="javascript:void(0);" class="js_add_shop">添加适用门店</a>
                                            <div class="r js_shop_pager"></div>
                                        </div>
                                        <input type="hidden" value="272977454" name="location_id_list" class="js_hidden_shop_id_list">
                                    </div>
                                </div>
                                <div class="radio_control_group group last_radio_control_group">
                                    <label class="frm_radio_label selected" for="checkbox2">
                                        <i class="icon_radio"></i>
                                        <span class="lbl_content">全部门店适用</span>
                                        <input type="radio" checked="" value="1" class="frm_radio js_shop_type" id="checkbox2">
                                    </label>
                                </div>
                                <div class="radio_control_group group">
                                    <label class="frm_radio_label" for="checkbox3">
                                        <i class="icon_radio"></i>
                                        <span class="lbl_content">无门店限制</span>
                                        <input type="radio" value="3" class="frm_radio js_shop_type" id="checkbox3">
                                        <p class="frm_tips">创建虚拟卡券或商户无门店</p>
                                    </label>
                                    <p class="mini_tips" style="display: none;" id="js_card_pay_money_tips">支持微信买单，消费者凭券可以在已配置核销员的门店用券付款</p>
                                </div>
                            </div>
                            <input type="hidden" name="shop_type" value="1" class="js_hidden_shop_type">
                            <input type="hidden" name="card_pay_money" value="0" id="js_hidden_card_pay_money">
                        </div>
                    </div>
                </div>
                <div class="frm_control_group">
                    <label for="" class="frm_label">客服电话</label>
                    <span class="frm_input_box">
                        <input id="js_service_phone" name="service_phone" value="" type="text" class="frm_input" placeholder=""></span>
                    <p class="frm_tips">手机或固话</p>
                </div>
                <div id="js_nearby_container" style="display: none;">
                    <div class="frm_control_group">
                        <label class="frm_checkbox_label" for="js_nearby">
                            <i class="icon_checkbox"></i>
                            <span class="lbl_content">用户可在“附近”领取卡券</span>
                            <input type="checkbox" value="1" class="frm_radio frm_checkbox" id="js_nearby">
                            <p class="frm_tips" id="">
                                选择后，若指定的适用门店是优质门店，用户在微信"发现"-"附近"-"附近的门店"可领取本次添加的卡券。<a href="http://mp.weixin.qq.com/s?__biz=MjM5NDAwMTA2MA==&amp;mid=205032311&amp;idx=1&amp;sn=167fa91e8bc7816d3e38d827f19f3b80#rd" target="_blank">如何成为附近的商户</a>
                                <br>
                                可在<a href="/merchant/entityshop?action=list&amp;lang=zh_CN&amp;token=64613618" target="_blank">门店管理</a>中补充门店信息使其成为优质门店。               
                            </p>
                            <input type="hidden" name="show_in_nearby" value="0" id="js_show_in_nearby">
                        </label>
                    </div>

                    <div id="js_poi_pic_url" class="frm_control_group upload_item" style="display: none;">
                        <label class="frm_label frm_label_top">
                            卡券缩略图           
                        </label>
                        <div class="upload_box has_demo" style="width: 491px;">
                            <div class="upload_demo demo_card">
                                <strong>预览</strong>
                                <div class="card_item">
                                    <span class="card_item_name">卡券</span>
                                    <span class="card_item_avatar" id="js_preview_logo">示意图
                        </span>
                                    <span class="card_item_ic"></span>
                                </div>
                            </div>
                            <input type="hidden" class="file_field" value="" name="poi_pic_url" id="poi_pic_url_hidden">
                            <p class="upload_tips">用于附近门店的商家详情页，请提交与卡券相关的图片，图片建议尺寸150像素x96像素。仅支持.jpg .jpeg .bmp .png格式的照片，大小不超过5M</p>
                            <div class="upload_area">
                                <a class="btn btn_upload js_select_file" id="poi_pic_url">上传图片</a>
                            </div>
                            <div id="poi_pic_url_preview" class="upload_preview">
                            </div>
                        </div>

                    </div>
                </div>
                <div class="tool_bar border tc">
                    <a href="javascript:void(0);" id="js_submitmodifyservice" class="btn btn_primary">确定</a>
                    <a href="javascript:void(0);" id="js_cancelmodifyservice" class="btn btn_default">取消</a>
                </div>
            </form>


            <form class="detail_card" id="js_edit_msg_operation" style="display: none;" novalidate="novalidate">
                <h2 class="title">消息通知 <i data-x="-132" id="js_msg_operate_tips" class="icon_msg_mini ask"></i></h2>


                <div id="js_msg_operate_contenttype" class="frm_control_group msg_notification">
                    <label for="" class="frm_label">内容设置</label>
                    <div class="frm_controls frm_vertical_lh">
                        <label class="frm_radio_label">
                            <i class="icon_radio"></i>
                            <span class="lbl_content">图文消息</span>
                            <input type="radio" value="1" class="frm_radio">
                        </label>
                        <label class="frm_radio_label selected">
                            <i class="icon_radio"></i>
                            <span class="lbl_content">网页链接</span>
                            <input type="radio" value="4" class="frm_radio">
                        </label>
                        <label class="frm_radio_label">
                            <i class="icon_radio"></i>
                            <span class="lbl_content">卡券</span>
                            <input type="radio" value="5" class="frm_radio">
                        </label>
                        <label class="frm_radio_label">
                            <i class="icon_radio"></i>
                            <span class="lbl_content">卡券货架</span>
                            <input type="radio" value="2" class="frm_radio">
                        </label>
                        <label class="frm_radio_label">
                            <i class="icon_radio"></i>
                            <span class="lbl_content">不设置</span>
                            <input type="radio" value="0" class="frm_radio">
                        </label>
                    </div>
                </div>



                <div id="js_msg_operate_content">
                    <div class="frm_control_group frm_card_extend js_msg_operate_content_item js_1_show">
                        <label for="" class="frm_label">图文消息</label>
                        <div class="frm_controls">
                            <div class="frm_media_priview js_msg_operate_1_preview">
                            </div>
                            <a class="btn btn_default js_msg_operate_select_appmsg" href="javascript:;">选择图文消息</a>
                        </div>
                    </div>


                    <div class="appmsg_edit_item frm_control_group frm_card_extend js_msg_operate_content_item js_4_show">
                        <label for="" class="frm_label">网页链接</label>
                        <div class="frm_controls">
                            <span class="frm_input_box">
                                <input value="" name="msg_operation_url" type="text" class="frm_input js_msg_operate_link_url" placeholder="">
                            </span>
                        </div>
                    </div>


                    <div class="frm_control_group frm_card_extend js_msg_operate_content_item js_2_show">
                        <label for="" class="frm_label">卡券货架</label>
                        <div class="frm_controls">
                            <div class="frm_media_priview js_msg_operate_2_preview">
                            </div>
                            <a class="btn btn_default js_msg_operate_select_cardshelf" href="javascript:;">选择卡券货架</a>
                        </div>
                    </div>


                    <div class="frm_control_group frm_card_extend js_msg_operate_content_item js_5_show">
                        <label for="" class="frm_label">卡券</label>
                        <div class="frm_controls">
                            <div class="frm_media_priview js_msg_operate_5_preview">
                            </div>
                            <a class="btn btn_default js_msg_operate_select_cardticket" href="javascript:;">选择卡券</a>
                        </div>
                    </div>



                    <div class="appmsg_edit_item frm_control_group frm_card_extend js_msg_operate_content_item js_1_show js_2_show js_4_show">
                        <label for="" class="frm_label">介绍文字</label>
                        <div class="frm_controls">
                            <span class="frm_input_box">
                                <input id="js_msg_operation_url_text" value="" name="msg_operation_url_text" type="text" class="frm_input js_maxlength" target="#js_urltext_hint" data-maxlength="16" placeholder="">
                            </span>
                            <span class="tips"><span id="js_urltext_hint">0</span>/16</span>
                        </div>
                    </div>
                </div>
                <div class="frm_control_group frm_card_extend" id="js_msg_operate_endtime_container">
                    <label for="" class="frm_label">通知截止日期</label>
                    <div class="frm_controls">
                        <div class="time_picker">
                            <div id="js_msg_operate_endtime_select"></div>
                        </div>
                        <input type="hidden" name="msg_operation_endtime" value="" id="js_msg_operate_endtime">
                    </div>
                </div>



                <div class="tool_bar border tc">
                    <a href="javascript:void(0);" class="btn btn_primary js_edit_msg_operation_submit">确定</a>
                    <a href="javascript:void(0);" class="btn btn_default js_edit_msg_operation_cancel">取消</a>
                </div>
            </form>

        </div>
    </div>

</div>
