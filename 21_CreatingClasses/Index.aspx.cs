using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    class BankAccount
    {
        private decimal balance;// instance variable, reachable only within this class

        public BankAccount(decimal bal)
        {
            balance = bal;
        }
    }



    protected void Page_Load(object sender, EventArgs e)
    {

    }
}