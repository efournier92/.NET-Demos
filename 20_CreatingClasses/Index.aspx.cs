using System;

public partial class Index : System.Web.UI.Page
{
    private class BankAccount
    {
        private readonly decimal _balance;// instance variable, reachable only within this class

        public BankAccount(decimal bal)
        {
            _balance = bal;
        }

        public string GetBalance()
        {
            return $"<b>Balance:</b> {_balance:C}";
        }
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        var ba = new BankAccount(5002);
        Label.Text = ba.GetBalance();
    }
}
