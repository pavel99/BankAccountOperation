using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperation
{
    public partial class AccountOperationUI : Form
    {
        public AccountOperationUI()
        {
            InitializeComponent();
        }
        Account account=new Account();

        private void creatButton_Click(object sender, EventArgs e)
        {
            account.accountNumber = accountTextBox.Text;
            account.customerName = nameTextBox.Text;
            account.balance = 0.0;
            MessageBox.Show("Account Created");
            accountTextBox.Clear();
            nameTextBox.Clear();

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
          
            double dAmount = Convert.ToDouble(amountTextBox.Text);
            if (dAmount<0)
            {
                MessageBox.Show("you can not insert negative balance!");
            }
           MessageBox.Show("Your deposited Money :"+dAmount+"\nYour total Balance is : " +account.DepositMoney(dAmount).ToString());

            amountTextBox.Clear();
        }

        private void withDrawButton_Click(object sender, EventArgs e)
        {
            double wAmount = Convert.ToDouble(amountTextBox.Text);
            if (wAmount>account.balance || wAmount <0.0)
            {
                MessageBox.Show("You have not adequate Balance!");
            }
            else
            {
                MessageBox.Show("Your Withdrawn Money :" + wAmount+"\n Your Reamining Balance is :"+account.WithdrawMoney(wAmount).ToString());

                amountTextBox.Clear();
            }
          
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.Report());
        }

       

       
    }
}
