<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mycards.aspx.cs" Inherits="ajax_mycards" %>
<%@ Import Namespace="com.dooqu.weixin.modals" %>
<div class="row">
    <div id="breadcrumb" class="col-xs-12">
        <a href="#" class="show-sidebar">
            <i class="fa fa-bars"></i>
        </a>
        <ol class="breadcrumb pull-left">
            <li><a href="#">我的卡卷</a></li>
            <li><a href="#">浏览</a></li>
        </ol>
        <div id="social" class="pull-right">
            <!--
			<a href="#"><i class="fa fa-google-plus"></i></a>
			<a href="#"><i class="fa fa-facebook"></i></a>
			<a href="#"><i class="fa fa-twitter"></i></a>
			<a href="#"><i class="fa fa-linkedin"></i></a>
			<a href="#"><i class="fa fa-youtube"></i></a>-->
        </div>
    </div>
</div>

<div class="row">
    <div class="col-xs-12">
        <div class="box">
            <div class="box-header">
                <div class="box-name">
                    <i class="fa fa-credit-card"></i>
                    <span>卡卷列表</span>
                </div>
                <div class="box-icons">
                    <a class="collapse-link">
                        <i class="fa fa-chevron-up"></i>
                    </a>
                    <a class="expand-link">
                        <i class="fa fa-expand"></i>
                    </a>
                    <a class="close-link">
                        <i class="fa fa-times"></i>
                    </a>
                </div>
                <div class="no-move"></div>
            </div>
            <div class="box-content no-padding">
                <table class="table table-bordered table-striped table-hover table-heading table-datatable" id="datatable-3">
                    <thead>
                        <tr>
                            <th>类型</th>
                            <th>名称</th>
                            <th>有效期</th>
                            <th>状态</th>
                            <th>库存</th>
                            <th>操作</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:repeater id="Repeater1" runat="server" onitemcreated="Repeater1_ItemCreated" onitemdatabound="Repeater1_ItemDataBound">
                            <ItemTemplate>
						<tr>
							<td><%# card_info.get_card_type_string((com.dooqu.weixin.modals.card_type)Enum.Parse(typeof(com.dooqu.weixin.modals.card_type), Eval("type").ToString())) %></td>
							<td><%# Eval("title").ToString() %></td>
							<td><%# ((date_info)Eval("date_info")).ToString() %></td>
							<td><%# card_info.get_card_status_string((card_status)Enum.Parse(typeof(com.dooqu.weixin.modals.card_status), Eval("status").ToString())) %></td>
							<td><%# Eval("sku.quantity") %> / <%#Eval("sku.total_quantity") %></td>
							<td>
                                <a href="#" style="display:<%#getOptionStatus(Eval("status").ToString()) %>"><i class="fa fa-user fa-fw"></i> 投放</a>
                                <a href="javascript:LoadAjaxContent('ajax/card.aspx?id=<%#Eval("id").ToString() %>');"><i class="fa fa-pencil fa-fw"></i> 详情</a>
					            <a href="#"><i class="fa fa-trash-o fa-fw"></i> 删除</a>
							</td>
						</tr>
                            </ItemTemplate>
                        </asp:repeater>
                    </tbody>
                    <tfoot>
                        <tr>
                            <th>类型</th>
                            <th>名称</th>
                            <th>有效期</th>
                            <th>所有</th>
                            <th>库存/总量</th>
                            <th>操作</th>
                        </tr>
                    </tfoot>
                </table>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    // Run Datables plugin and create 3 variants of settings
    function AllTables() {
        //TestTable1();
        //TestTable2();
        TestTable3();
        LoadSelect2Script(MakeSelect2);
    }
    function MakeSelect2() {
        $('select').select2();
        $('.dataTables_filter').each(function () {
            $(this).find('label input[type=text]').attr('placeholder', 'Search');
        });
    }
    $(document).ready(function () {
        // Load Datatables and run plugin on tables 
        LoadDataTablesScripts(AllTables);
        // Add Drag-n-Drop feature
        WinMove();
    });
</script>
