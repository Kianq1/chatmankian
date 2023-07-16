using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"]!=null)
			{
				pnlLogin.Visible=false;
				pnlChat.Visible=true;
			}
			else
			{
				pnlLogin.Visible=true;
				pnlChat.Visible=false;
			}
    }

    	protected void btnLogin_Click(object sender, System.EventArgs e)
		{
			Session["UserName"]=txtUserName.Text;
			pnlLogin.Visible=false;
			pnlChat.Visible=true;
		}

		protected void btnChat_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Chat.aspx?rid="+ lstRooms.SelectedValue );
		}
}