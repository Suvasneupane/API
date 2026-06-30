using System;
using System.Collections.Generic;
using System.Text;

namespace Mobilebanking.Banking
{
    public class Transcation : Accounts
    {
        public int loanamt;
        public static int l_interest;

        public void deposit(int index)
        {
            Console.Write("Enter the amount: ");
            int depositeamount = int.Parse(Console.ReadLine());
            balance[index] = balance[index] + depositeamount;
            Console.WriteLine("Successfully Deposited ");
            Console.WriteLine("Current Balance: " + balance[index]);
        }

        public void withdraw(int index)
        {
            Console.Write("Enter the Withdraw Amount: ");
            int withdrawamount = int.Parse(Console.ReadLine());
            if (withdrawamount > balance[index])
            {
                Console.WriteLine("Insufficient Balance. Your balance: " + balance[index]);
            }
            else
            {
                balance[index] = balance[index] - withdrawamount;
                bank_tejori = bank_tejori - withdrawamount;
                Console.WriteLine("Successfully Withdrawn ");
                Console.WriteLine("Current balance: " + balance[index]);
            }
        }

        public void loan(int index)
        {
            Console.Write("Enter the Loan amount: ");
            loanamt = int.Parse(Console.ReadLine());
            Console.Write("Enter the month: ");
            int month = int.Parse(Console.ReadLine());
            l_interest = (loanamt * month * 5) / 100;
            balance[index] = balance[index] + loanamt;
            Console.WriteLine("Enjoy You Gareeb. Loan Approved ");
            Console.WriteLine("Loan Interest: " + l_interest);
            Console.WriteLine("Current balance: " + balance[index]);
            Console.WriteLine("Bank Tejori: " + bank_tejori);
        }

        public void transfer(int senderIndex)
        {
            Console.Write("Enter Recipient Username: ");
            string recipientUsername = Console.ReadLine();

            int ri = -1;
            for (int i = 0; i < count; i++)
                if (username[i] == recipientUsername) { ri = i; break; }

            if (ri == -1) { Console.WriteLine("Recipient '" + recipientUsername + "' not found."); return; }
            if (ri == senderIndex) { Console.WriteLine("Cannot transfer to yourself."); return; }

            Console.WriteLine("Recipient Found: " + name[ri]);
            Console.Write("Enter the Transfer Amount: ");
            int transferamount = int.Parse(Console.ReadLine());

            if (transferamount > balance[senderIndex])
            {
                Console.WriteLine("Insufficient balance: " + balance[senderIndex]);
            }
            else
            {
                balance[senderIndex] = balance[senderIndex] - transferamount;
                balance[ri] = balance[ri] + transferamount;
                Console.WriteLine("Successfully Transferred " + transferamount + " to " + name[ri]);
                Console.WriteLine("Your Current balance: " + balance[senderIndex]);
            }
        }

        public void fixed_deposit(int index)
        {
            Console.Write("Enter the Fixed Deposit amount: ");
            int fdamount = int.Parse(Console.ReadLine());
            Console.Write("Enter the Month: ");
            int month = int.Parse(Console.ReadLine());

            if (fdamount > balance[index])
            {
                Console.WriteLine("Insufficient balance ");
            }
            else
            {
                int fd_interest = (fdamount * month * 7) / 100;
                int maturity = fdamount + fd_interest;
                balance[index] = balance[index] - fdamount;
                Console.WriteLine("Fixed Deposit Successfully ");
                Console.WriteLine("FD Amount: " + fdamount);
                Console.WriteLine("Duration: " + month + " months");
                Console.WriteLine("Interest Rate (7%/month): " + fd_interest);
                Console.WriteLine("Maturity Amount: " + maturity);
                Console.WriteLine("Remaining Balance: " + balance[index]);
            }
        }
    }
}