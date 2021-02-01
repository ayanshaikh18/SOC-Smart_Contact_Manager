﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.GroupServiceReference;
namespace WebClient
{
    public partial class DeleteGroup : System.Web.UI.Page
    {
        GroupServiceClient grpProxy;
        int UserId, GroupId;

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            var grp = new Group1();
            grp.GroupId = GroupId;
            ((IGroupService)grpProxy).DeleteGroup(grp);
            Response.Redirect("~/GroupList.aspx");
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewGroup.aspx?GroupId=" + GroupId);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            grpProxy = new GroupServiceClient();
            GroupId = Int32.Parse(Request.QueryString["GroupId"]);
            UserId = Int32.Parse(Session["UserId"].ToString());
            var group = new Group1();
            group.UserId = UserId;
            group.GroupId = GroupId;
            var fetchedGroup = ((IGroupService)grpProxy).GetGroup(group);
            if (fetchedGroup.UserId != UserId)
            {
                Response.Redirect("~/Login.aspx");
            }
            GrpData.Text = "Name :- " + fetchedGroup.Name + 
                            "<br>Description :- " +fetchedGroup.Description+
                            "<br>Total Contacts :- "+ ((IGroupService)grpProxy).GetGroupContacts(GroupId).Length;
        }
    }
}