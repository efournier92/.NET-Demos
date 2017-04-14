using System;
using System.Collections.Generic;
using System.Diagnostics;

public partial class Index : System.Web.UI.Page
{
    protected void ShowButton_Click(object sender, EventArgs e)
    {
        Label.Text = "";
        var filePrograms = new Dictionary<string, string>
        {
            {"notepad.exe", @"c:\sampleFile.txt"},
            {"chrome.exe", "http://www.google.com"}
        };
        foreach (var kvp in filePrograms)
        {
            Process.Start(kvp.Key, kvp.Value);
        }
        foreach (var key in filePrograms.Keys)
        {
            Label.Text += "<br>" + key;
        }
    }
}
