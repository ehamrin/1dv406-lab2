using Kvitto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kvitto
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Receipt.Visible = true;

            Receipt receipt = new Receipt(double.Parse(SumInput.Text));
            SubTotal.Text = String.Format("{0:c}", receipt.Subtotal);
            Rate.Text = String.Format("{0:p0}", receipt.Rate);
            Discount.Text = String.Format("{0:c}", receipt.Discount);
            Total.Text = String.Format("{0:c}", receipt.Total);
        }
    }
}