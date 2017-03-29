using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

public partial class Index : System.Web.UI.Page
{
    protected void ShowButton_Click(object sender, EventArgs e)
    {
        var filePrograms = new Dictionary<string, string>();
        filePrograms.Add("notepad.exe", @"c:\sampleFile.txt");
        filePrograms.Add("chrome.exe", "http://www.google.com");
        foreach(var kvp in filePrograms)
        {
            Process.Start(kvp.Key, kvp.Value);
        }
        foreach(var key in filePrograms.Keys)
        {
            Label.Text += "<br>" + key;
        }
    }
}