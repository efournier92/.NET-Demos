using System;
using System.Xml;

delegate double CompareValues(double x, double y);
public partial class Index : System.Web.UI.Page
{
    double FromStringToDouble(string s)
    {
        return Convert.ToDouble(s);
    }

    protected void FindMaxButton_Click(object sender, EventArgs e)
    {
        var vals = TextBox.Text.Split(new char[] { ',' });
        var doubleVals = Array.ConvertAll(vals, new Converter<string, double>(FromStringToDouble));
        CompareValues compareValues = (xin, yin) =>
        {
            double x = xin, y = yin;
            return x > y ? x : y;
        };
        Label.Text = CompareValuesInList(compareValues, doubleVals[0], doubleVals[1], doubleVals[2]).ToString();
    }

    static double CompareValuesInList(CompareValues compFirstTwo, double first, double second, double third)
    {
        return third > compFirstTwo(first, second) ? third : compFirstTwo(first, second);
    }
}