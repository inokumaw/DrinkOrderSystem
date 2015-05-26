using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DrinkOrder : System.Web.UI.Page
{
    CDrinkFactory factory;
    Dictionary<Button, CDrink> dicButtonDrink;
    COrder order;
    List<COrder> listOrders;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["factory"] != null && Session["listOrders"] != null)
        {
            factory = Session["factory"] as CDrinkFactory;
            listOrders = Session["listOrders"] as List<COrder>;
            addLabels();
        }
    }

    protected void btnOpen_Click(object sender, EventArgs e)
    {
        if (FileUpload1.FileName.Length > 0)
        {
            factory = new CDrinkFactory(Server.MapPath("Menu/" + FileUpload1.FileName));
            Session["factory"] = factory;
            listOrders = new List<COrder>();
            Session["listOrders"] = listOrders;

            addLabels();
        }
    }

    private void addLabels()
    {
        PlaceHolder1.Controls.Clear();

        dicButtonDrink = new Dictionary<Button, CDrink>();
        string strKindOfDrink = "分類1";

        foreach (CDrink drink in factory.getAll())
        {
            Button btnDrink = new Button();
            btnDrink.ID = "btnDrink" + drink.id.ToString();
            btnDrink.Height = 50;
            btnDrink.Width = 100;
            btnDrink.Text = drink.name;
            btnDrink.Click += new System.EventHandler(btnDrink_Click);

            if (drink.kind != strKindOfDrink)   //加入分類標籤
            {
                Literal literal = new Literal();
                literal.Text = "<br />";
                PlaceHolder1.Controls.Add(literal);

                strKindOfDrink = drink.kind;
                Label lblKind = new Label();
                lblKind.Width = 100;
                lblKind.Text = drink.kind;
                lblKind.BackColor = System.Drawing.Color.FromArgb(255, 255, 0);
                PlaceHolder1.Controls.Add(lblKind);                  

                Label label = new Label();
                label.Text = "<br />";
                PlaceHolder1.Controls.Add(label);
            }

            dicButtonDrink.Add(btnDrink, drink);     //將button與drink的關係加入至Dictionary
            PlaceHolder1.Controls.Add(btnDrink);            
        }

    }

    private void btnDrink_Click(object sender, EventArgs e)
    {
        Button btnDrink = sender as Button;

        lblDrinkName.Text = dicButtonDrink[btnDrink].name;
        rbListSize.Items[0].Text = "大杯：" + dicButtonDrink[btnDrink].priceLarge.ToString();
        rbListSize.Items[0].Value = dicButtonDrink[btnDrink].priceLarge.ToString();
        rbListSize.Items[1].Text = "中杯：" + dicButtonDrink[btnDrink].priceMiddle.ToString();
        rbListSize.Items[1].Value = dicButtonDrink[btnDrink].priceMiddle.ToString();

        tbCount.Text = "1";
    }
    protected void btnAddToCart_Click(object sender, EventArgs e)
    {
        order = new COrder();

        order.name = lblDrinkName.Text;

        if (rbListSize.SelectedIndex.Equals(0))
            order.size = "大杯";
        else
            order.size = "中杯";

        order.sugar = rbListSugar.SelectedValue;
        order.ice = rbListIce.SelectedValue;
        order.count = Convert.ToInt32(tbCount.Text);
        order.unitPrice = Convert.ToInt32(rbListSize.SelectedValue);
        order.totalPrice = order.unitPrice * order.count;

        listOrders.Add(order);
        Session["listOrders"] = listOrders;

        Response.Redirect("DrinkCart.aspx");
    }
}