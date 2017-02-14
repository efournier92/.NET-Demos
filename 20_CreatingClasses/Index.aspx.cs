using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    public class BankAccount
    {
        private decimal balance;// instance variable, reachable only within this class

        public BankAccount(decimal bal)
        {
            balance = bal;
        }

        public string GetBalance()
        {
            return "Balance: " + balance;
        }
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        var ba = new BankAccount(5002);
        Label.Text = ba.GetBalance();
    }
}