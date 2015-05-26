using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDrinkOrderSystem
{
    public partial class Form1 : Form
    {
        CDrinkFactory factory;
        List<COrder> listOrders;
        Dictionary<Label, CDrink> dicLabelDrink;

        Label lblDrinkBefore;
        Label lblSizeBefore;
        Label lblSugarBefore;
        Color clrSugarBefore;
        Label lblIceBefore;
        Color clrIceBefore;
        Label lblNumberBefore;

        string useMode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            useMode = "edit";   //使用模式(編輯)
        }

        //-------------------------檔案開啟-------------------------//

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文件|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                factory = new CDrinkFactory(openFileDialog1.FileName);

                addLabels();    //加入Menu
                addOrder();     //加入訂單
            }     
        }

        private void addOrder()
        {
            listOrders = new List<COrder>();
            listOrders.Add(new COrder());
        }

        private void addLabels()
        {
            flowLayoutPanel1.Controls.Clear();
            dicLabelDrink = new Dictionary<Label, CDrink>();

            string strKindOfDrink = "分類1";

            foreach (CDrink drink in factory.getAll()) 
            {
                Label lblDrink = new Label();
                lblDrink.Image = global::prjDrinkOrderSystem.Properties.Resources.lblImage;
                lblDrink.Name = "lblDrink" + drink.id.ToString();
                lblDrink.Size = new System.Drawing.Size(100, 50);
                lblDrink.Text = drink.name;
                lblDrink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblDrink.Click += new System.EventHandler(lblDrink_Click);

                if (drink.kind != strKindOfDrink)   //加入分類
                {
                    strKindOfDrink = drink.kind;
                    Label lblKind = new Label();
                    lblKind.BackColor = System.Drawing.Color.DarkCyan;
                    lblKind.ForeColor = System.Drawing.Color.White;
                    lblKind.Size = new System.Drawing.Size(100, 50);
                    lblKind.Text = drink.kind;
                    lblKind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    flowLayoutPanel1.Controls.Add(lblKind);
                }

                dicLabelDrink.Add(lblDrink, drink);     //將label與drink的關係加入至Dictionary
                flowLayoutPanel1.Controls.Add(lblDrink);
            }

        }

        //-------------------------按鈕事件-------------------------//
        //-----說明
        private void tsbHelp_Click(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "\\help.htm";
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Index);
        }
        //-----飲料
        private void lblDrink_Click(object sender, EventArgs e)
        {
            Label lblDrink = sender as Label;

            if (lblDrinkBefore != null)     //重置前一個所選項目
            {
                this.lblDrinkBefore.Image = global::prjDrinkOrderSystem.Properties.Resources.lblImage;
                this.lblDrinkBefore.Enabled = true;
            }

            COrder order = listOrders.Last();
            
            lblDrink.Image = null;
            lblDrink.BackColor = System.Drawing.Color.Red;
            lblDrink.Enabled = false;
            order.name = dicLabelDrink[lblDrink].name;

            lblDrinkBefore = lblDrink;
        }
        //-----大小
        private void lblSize_Click(object sender, EventArgs e)
        {
            Label lblSize = sender as Label;        

            if (lblSizeBefore != null)     //重置前一個所選項目
            {
                this.lblSizeBefore.BackColor = System.Drawing.Color.Green;
                this.lblSizeBefore.Enabled = true;
            }

            if (listOrders != null)
            {
                COrder order = listOrders.Last();
                        
                lblSize.BackColor = System.Drawing.Color.Red;
                lblSize.Enabled = false;
                order.size = lblSize.Text;
                if (lblSize.Text == "中杯" && lblDrinkBefore != null)
                    order.unitPrice = dicLabelDrink[lblDrinkBefore].priceMiddle;
                else if (lblSize.Text == "大杯" && lblDrinkBefore != null)
                    order.unitPrice = dicLabelDrink[lblDrinkBefore].priceLarge;
                else
                {
                    MessageBox.Show("請先選擇項目！");
                    lblSize.BackColor = System.Drawing.Color.Green;
                    lblSize.Enabled = true;
                    lblSize = null;
                }

                lblSizeBefore = lblSize;
            }
        }
        //-----甜度
        private void lblSugarLevel_Click(object sender, EventArgs e)
        {
            Label lblSugar = sender as Label;

            if (lblSugarBefore != null)     //重置前一個所選項目
            {
                this.lblSugarBefore.BackColor = clrSugarBefore;
                this.lblSugarBefore.Enabled = true;
            }

            if (listOrders != null)
            {
                COrder order = listOrders.Last();
                
                clrSugarBefore = lblSugar.BackColor;
                lblSugar.BackColor = System.Drawing.Color.Red;
                lblSugar.Enabled = false;
                order.sugar = lblSugar.Text;

                lblSugarBefore = lblSugar;
            }
        }
        //-----冰塊
        private void lblIceLevel_Click(object sender, EventArgs e)
        {
            Label lblIce = sender as Label;

            if (lblIceBefore != null)     //重置前一個所選項目
            {
                this.lblIceBefore.BackColor = clrIceBefore;
                this.lblIceBefore.Enabled = true;
            }

            if (listOrders != null)
            {
                COrder order = listOrders.Last();
                
                clrIceBefore = lblIce.BackColor;
                lblIce.BackColor = System.Drawing.Color.Red;
                lblIce.Enabled = false;
                order.ice = lblIce.Text;

                lblIceBefore = lblIce;
            }
        }
        //-----數字
        private void lblNumber_Click(object sender, EventArgs e)
        {
            Label lblNumber = sender as Label;

            if (lblNumberBefore != null)     //重置前一個所選項目
                this.lblNumberBefore.BackColor = System.Drawing.Color.DarkGreen;

            if (listOrders != null && useMode == "edit")
            {
                COrder order = listOrders.Last();
                
                lblNumber.BackColor = System.Drawing.Color.Red;
                order.count = Convert.ToInt32(order.count.ToString() + lblNumber.Text);
                if (order.count == 0)
                {
                    MessageBox.Show("數量不可以為0！");
                    lblNumber.BackColor = System.Drawing.Color.DarkGreen;
                    lblNumber.Enabled = true;
                    lblNumber = null;
                }
                tbTotalCount.Text = order.count.ToString();

                lblNumberBefore = lblNumber;
            }

            if (listOrders != null && useMode == "pay") 
            {
                lblNumber.BackColor = System.Drawing.Color.Red;
                tbPay.Text += lblNumber.Text;
                if (tbPay.Text == "0") 
                    tbPay.Text = "";

                lblNumberBefore = lblNumber;
            }
        }
        //-----倒退
        private void lblBackSpace_Click(object sender, EventArgs e)
        {
            if (listOrders != null && useMode == "edit")
            {
                COrder order = listOrders.Last();
                tbTotalCount.Text = order.count.ToString().Remove(order.count.ToString().Length - 1);
                if (tbTotalCount.Text != "")
                    order.count = Convert.ToInt32(tbTotalCount.Text);
                else
                    order.count = 0;
            }

            if (listOrders != null && useMode == "pay")
            {
                if (tbPay.Text.Length > 0)
                    tbPay.Text = tbPay.Text.Remove(tbPay.Text.Length - 1);
            }
        }
        //-----確認
        private void lblConfirm_Click(object sender, EventArgs e)
        {
            if (lblDrinkBefore != null &&
                lblSizeBefore != null &&
                lblSugarBefore != null &&
                lblIceBefore != null &&
                lblNumberBefore != null)
            {
                COrder order = listOrders.Last();
                order.totalPrice = order.unitPrice * order.count;

                if (order.totalPrice != 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listOrders;

                    refreshControls();
                    refreshTotalAccount();

                    listOrders.Add(new COrder());
                }
            }
        }
        //-----取消
        private void lblCancel_Click(object sender, EventArgs e)
        {
            refreshControls();
        }
        //-----付款結帳
        private void lblPay_Click(object sender, EventArgs e)
        {
            if (useMode == "edit") 
            {
                useMode = "pay";
                lblUseMode.Text = "結帳";
                lblUseMode.BackColor = System.Drawing.Color.Red;
                lblPay.BackColor = System.Drawing.Color.Red;
                tbPay.Text = null;
                tbFeedBack.Text = null;
            }
            else if (useMode == "pay")
            {
                if (Convert.ToInt32(tbPay.Text) >= Convert.ToInt32(tbTotalPrice.Text))
                {
                    tbFeedBack.Text = (Convert.ToInt32(tbPay.Text) - Convert.ToInt32(tbTotalPrice.Text)).ToString();
                    useMode = "edit";
                    lblUseMode.Text = "付款";
                    lblUseMode.BackColor = System.Drawing.Color.GreenYellow;
                    lblPay.BackColor = System.Drawing.Color.DarkCyan;

                    tbTotalCount.Text = null;
                    tbTotalPrice.Text = null;
                    refreshControls();                    
                    dataGridView1.DataSource = null;
                    listOrders.Clear();
                    
                    addOrder();     //加入訂單
                }
                else
                    MessageBox.Show("金額不足！");
            }
        }

        //-------------------------刷新內容-------------------------//
        
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            tbTotalCount.Text = null;
            tbTotalPrice.Text = null;
            refreshControls();
            dataGridView1.DataSource = null;
            listOrders.Clear();

            addOrder();     //加入訂單
        }

        private void refreshTotalAccount()
        {
            int intTotalPrice = 0;
            foreach (COrder order in listOrders)
            {
                 intTotalPrice += order.totalPrice;
            }
            tbTotalPrice.Text = intTotalPrice.ToString();

            int intTotalCount = 0;
            foreach (COrder order in listOrders)
            {
                intTotalCount += order.count;
            }
            tbTotalCount.Text = intTotalCount.ToString();
        }

        private void refreshControls()
        {
            if (lblDrinkBefore != null)
            {
                this.lblDrinkBefore.Image = global::prjDrinkOrderSystem.Properties.Resources.lblImage;
                this.lblDrinkBefore.Enabled = true;
                this.lblDrinkBefore = null;
            }

            if (lblSizeBefore != null)
            {
                this.lblSizeBefore.BackColor = System.Drawing.Color.Green;
                this.lblSizeBefore.Enabled = true;
                this.lblSizeBefore = null;
            }

            if (lblSugarBefore != null)
            {
                this.lblSugarBefore.BackColor = clrSugarBefore;
                this.lblSugarBefore.Enabled = true;
                this.lblSugarBefore = null;
            }

            if (lblIceBefore != null)
            {
                this.lblIceBefore.BackColor = clrIceBefore;
                this.lblIceBefore.Enabled = true;
                this.lblIceBefore = null;
            }

            if (lblNumberBefore != null)
            {
                this.lblNumberBefore.BackColor = System.Drawing.Color.DarkGreen;
                this.lblNumberBefore.Enabled = true;
                this.lblNumberBefore = null;
            }
        }
    }
}
