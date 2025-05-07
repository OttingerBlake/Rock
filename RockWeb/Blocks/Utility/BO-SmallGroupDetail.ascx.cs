using System;
using System.ComponentModel;
using Rock;
using Rock.Data;
using Rock.Model;
using Rock.Web.UI;
using Rock.Attribute;

namespace RockWeb.Blocks.Utility
{
    [DisplayName("Small Group Detail")]
    [Category("Utility")]
    [Description("Displays detailed information about a small group")]
    public partial class BO_SmallGroupDetail : RockBlock
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!Page.IsPostBack)
            {
                ShowDetails();
            }
        }

        private void ShowDetails()
        {
            // Verify group ID
            int groupId = PageParameter("GroupId").AsInteger();
            if (groupId == 0)
            {
                ltName.Text = "Error: Could not find that small group.";
                return;
            }

            var rockContext = new RockContext();
            var group = new GroupService(rockContext).Get(groupId);
            if (group == null)
            {
                ltName.Text = "Error: Could not find that small group.";
                return;
            }

            ltName.Text = group.Name;
            ltName.Text = group.Name;
            if (string.IsNullOrWhiteSpace(group.Description))
            {
                ltDescription.Text = string.Empty;
            }
            else
            {
                ltDescription.Text = group.Description;
            }
            ltCreated.Text = group.CreatedDateTime?.ToShortDateString() ?? "";
            ltModified.Text = group.ModifiedDateTime?.ToShortDateString() ?? "";
            ltCapacity.Text = group.GroupCapacity.HasValue ? group.GroupCapacity.Value.ToString() : "Unlimited";
        }
    }
}
