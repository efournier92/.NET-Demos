using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void DivideButton_Click(object sender, EventArgs e)
    {
        try
        {
            var val1 = Convert.ToDouble(ValueBox1.Text);
            var val2 = Convert.ToDouble(ValueBox2.Text);
            if (val2 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                var quotient = val1/val2;
                Label.Text = val1 + "/" + val2 + " = " + quotient;
            }
        }
    }
}