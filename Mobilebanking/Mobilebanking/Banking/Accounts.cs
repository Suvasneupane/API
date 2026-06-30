using System;
using System.Collections.Generic;
using System.Text;

namespace Mobilebanking.Banking
{
    public class Accounts
    {
        public string[] name = new string[100];
        public int[] age = new int[100];
        public string[] address = new string[100];
        public string[] gender = new string[100];
        public int[] customer_id = new int[100];
        public int[] NID_NO = new int[100];
        public int[] balance = new int[100];
        public string[] username = new string[100];
        public string[] password = new string[100];
        public string[] account_type = new string[100];  // "saving" or "current" per user
        public bool[] hasAccount = new bool[100];     // true if user filled account details
        public int count = 0;
        public int bank_tejori = 99999999;

        public void register()
        {
            Console.Write("Set Username: ");
            username[count] = Console.ReadLine();
            Console.Write("Set Password: ");
            password[count] = Console.ReadLine();
            hasAccount[count] = false;
            Console.WriteLine("Registered Successfully! Please Login.");
            count++;
        }

        public int login()
        {
            Console.Write("Enter Username: ");
            string uname = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            for (int i = 0; i < count; i++)
                if (username[i] == uname && password[i] == pass)
                    return i;

            Console.WriteLine("Invalid Username or Password.");
            return -1;
        }

        public void saving_account(int index)
        {
            Console.WriteLine();
            Console.Write("Name: ");
            name[index] = Console.ReadLine();
            Console.Write("Age: ");
            age[index] = int.Parse(Console.ReadLine());
            Console.Write("Address: ");
            address[index] = Console.ReadLine();
            Console.Write("Enter the Customer_Id: ");
            customer_id[index] = int.Parse(Console.ReadLine());
            Console.Write("Gender (M/F): ");
            gender[index] = Console.ReadLine();
            Console.Write("NID NO : ");
            NID_NO[index] = int.Parse(Console.ReadLine());
            Console.Write("Enter the Initial Balance: ");
            balance[index] = int.Parse(Console.ReadLine());
            account_type[index] = "1";
            hasAccount[index] = true;
            Console.WriteLine("Saving Account opened Successfully !!!!");
        }

        public void current_account(int index)
        {
            Console.WriteLine();
            Console.Write("Name: ");
            name[index] = Console.ReadLine();
            Console.Write("Age: ");
            age[index] = int.Parse(Console.ReadLine());
            Console.Write("Address: ");
            address[index] = Console.ReadLine();
            Console.Write("Gender (M/F): ");
            gender[index] = Console.ReadLine();
            Console.Write("Enter the Customer_Id: ");
            customer_id[index] = int.Parse(Console.ReadLine());
            Console.Write("NID NO : ");
            NID_NO[index] = int.Parse(Console.ReadLine());
            Console.Write("Enter the Initial Balance: ");
            balance[index] = int.Parse(Console.ReadLine());
            account_type[index] = "2";
            hasAccount[index] = true;
            Console.WriteLine("Current Account opened Successfully !!");
        }

        public void show_balance(int index)
        {
            Console.WriteLine("Balance: " + balance[index]);
        }

        public void display(int index)
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + name[index]);
            Console.WriteLine("Age: " + age[index]);
            Console.WriteLine("Address: " + address[index]);
            Console.WriteLine("Gender: " + gender[index]);
            Console.WriteLine("Customer Id: " + customer_id[index]);
            Console.WriteLine("NID NO: " + NID_NO[index]);
            Console.WriteLine("Balance: " + balance[index]);
        }
    }
}