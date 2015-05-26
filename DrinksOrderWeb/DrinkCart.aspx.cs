using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DrinkCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["listOrders"] != null)
        {
            List<COrder> listOrders = Session["listOrders"] as List<COrder>;

            GridView1.DataSource = listOrders;
            GridView1.DataBind();

            int intTotalPrice = 0;
            foreach (COrder order in listOrders)
                intTotalPrice += order.totalPrice;
            lblTotalPrice.Text = intTotalPrice.ToString();
        }
        else
            Response.Redirect("DrinkOrder.aspx");
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }

    protected void btnAccounting_Click(object sender, EventArgs e)
    {
        try
        {
            if (Convert.ToInt32(tbPay.Text) >= Convert.ToInt32(lblTotalPrice.Text))
            {
                lblFeedBack.Text = (Convert.ToInt32(tbPay.Text) - Convert.ToInt32(lblTotalPrice.Text)).ToString();
                Session["listOrders"] = null;
            }
            else
                lblError.Visible = true;
        }
        catch 
        {
            Response.Redirect("DrinkCart.aspx");
        }
    }
}