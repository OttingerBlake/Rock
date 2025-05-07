<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BO-SmallGroupDetail.ascx.cs" Inherits="RockWeb.Blocks.Utility.BO_SmallGroupDetail" %>

<asp:UpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>
        <asp:Panel ID="pnlView" runat="server" CssClass="panel panel-block">
            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-users"></i> Small Group Detail</h1>
            </div>
            <div class="panel-body">
                <dl class="dl-horizontal">
                    <dt>Name</dt>
                    <dd><Rock:RockLiteral ID="ltName" runat="server" /></dd>

                    <dt>Description</dt>
                    <dd><Rock:RockLiteral ID="ltDescription" runat="server" /></dd>

                    <dt>Date Created</dt>
                    <dd><Rock:RockLiteral ID="ltCreated" runat="server" /></dd>

                    <dt>Date Modified</dt>
                    <dd><Rock:RockLiteral ID="ltModified" runat="server" /></dd>

                    <dt>Group Capacity</dt>
                    <dd><Rock:RockLiteral ID="ltCapacity" runat="server" /></dd>
                </dl>
            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>
