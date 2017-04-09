using System;
using System.Collections.Generic;

public partial class Index : System.Web.UI.Page
{
    // void = don't send any value back to the calling code
    private static void ChangeArray(IList<int> arr)
    {
        // changes index[0] value
        // change is visible int he calling code
        arr[0] = 10;
    }

    private static void ChangeValue(double x)
    {
        x = 30;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        int[] arr1 = { 1, 2 };
        // calls method, passing in simple array
        ChangeArray(arr1);
        Label.Text = "The value at index 0 is " + arr1[0];

        const double z = 25;
        ChangeValue(z);
        Label.Text += "<br>The value of z was changed to " + z;
    }
}
