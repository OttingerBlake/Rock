using System;
using System.ComponentModel;
using System.Linq;

using Rock;
using Rock.Data;
using Rock.Model;
using Rock.Web.UI;
using Rock.Web.UI.Controls;

namespace RockWeb.Blocks.Utility
{
    [DisplayName("Small Group List")]
    [Category("Utility")]
    [Description("Lists small groups.")]
    public partial class BO_SmallGroupList : RockBlock
    {
        private const string DETAIL_PAGE_ROUTE = "/SmallGroups/Detail";

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            gGroups.DataKeyNames = new[] { "Id" };
            gGroups.RowItemText = "Small Group";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            var rockContext = new RockContext();
            var groupTypeId = new GroupTypeService(rockContext)
                                .Queryable()
                                .Where(gt => gt.Name == "Small Group")
                                .Select(gt => gt.Id)
                                .FirstOrDefault();

            var groups = new GroupService(rockContext)
                            .Queryable()
                            .Where(g => g.IsActive && g.GroupTypeId == groupTypeId)
                            .Select(g => new
                            {
                                g.Id,
                                g.Name,
                                g.Description,
                                g.GroupCapacity
                            })
                            .ToList();

            gGroups.DataSource = groups;
            gGroups.DataBind();
        }

        // Set up link to detail page
        protected void gGroups_RowSelected(object sender, RowEventArgs e)
        {
            int groupId = (int)e.RowKeyId;
            Response.Redirect($"{DETAIL_PAGE_ROUTE}?GroupId={groupId}");
        }
    }
}
