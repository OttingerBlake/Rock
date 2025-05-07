<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BO-SmallGroupList.ascx.cs" Inherits="RockWeb.Blocks.Utility.BO_SmallGroupList" %>

<asp:UpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>
        <asp:Panel ID="pnlView" runat="server" CssClass="panel panel-block">
            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-users"></i> Small Groups</h1>
            </div>
            <div class="panel-body">
                <div class="grid grid-panel">
                    <Rock:Grid ID="gGroups"
                               runat="server"
                               AllowSorting="true"
                               DataKeyNames="Id">

                        <Columns>
                            <asp:HyperLinkField HeaderText="Name"
                                                DataTextField="Name"
                                                DataNavigateUrlFields="Id"
                                                DataNavigateUrlFormatString="~/page/837?GroupId={0}"
                                                SortExpression="Name" />
                            <Rock:RockBoundField DataField="Description"
                                                  HeaderText="Description"
                                                  SortExpression="Description" />
                            <Rock:RockBoundField DataField="GroupCapacity"
                                                  HeaderText="Capacity"
                                                  SortExpression="GroupCapacity" />

                        </Columns>
                    </Rock:Grid>
                </div>
            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>
