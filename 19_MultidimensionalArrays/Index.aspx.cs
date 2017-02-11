using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_Click(object sender, EventArgs e)
    {
        double[,] arr = new double[2, 2]; // Deckares and sets 2x2 array (has 4 cells)
        arr[0, 0] = 45;
        arr[0, 1] = 34;
        arr[1, 0] = 23;
        arr[1, 0] = 78;
    }
}