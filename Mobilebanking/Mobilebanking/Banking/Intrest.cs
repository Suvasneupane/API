using System;
using System.Collections.Generic;
using System.Text;

namespace Mobilebanking.Banking
{
    public class Intrest : Transcation
    {
        public int month;

        public void saving_interest(int index)
        {
            Console.Write("Enter the month : ");
            month = int.Parse(Console.ReadLine());
            int s_interest = (balance[index] * month * 3) / 100;
            Console.WriteLine("Saving Interest: " + s_interest);
        }

        public void loan_interest()
        {
            Console.WriteLine("Loan Interest: " + l_interest);
        }

        public void fd_interest()
        {
            Console.Write("Enter the FD amount: ");
            int fdamt = int.Parse(Console.ReadLine());
            Console.Write("Enter the month : ");
            month = int.Parse(Console.ReadLine());
            int fd_int = (fdamt * month * 7) / 100;
            Console.WriteLine("Fixed Deposit Interest: " + fd_int);
        }

        public void transfer_interest()
        {
            Console.Write("Enter the Transfer amount: ");
            int tamt = int.Parse(Console.ReadLine());
            double t_charge = (tamt * 1.5) / 100;
            Console.WriteLine("Transfer Service Charge (1.5%): " + t_charge);
        }
    }
}