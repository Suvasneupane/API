using Mobilebanking.Banking;

Console.WriteLine("************** Welcome to ABC BANK OF NEPAL !! **************");

Intrest obj = new Intrest();

string option;
do
{
    Console.WriteLine();
    Console.WriteLine("1.Login");
    Console.WriteLine("2.Register");
    Console.WriteLine("3.Exit");
    option = Console.ReadLine();

    if (option == "3") { Console.WriteLine("Thank you for visiting ABC Bank of Nepal."); break; }

    // ---------- REGISTER ----------
    if (option == "2")
    {
        obj.register();
        continue;
    }

    // ---------- LOGIN ----------
    if (option != "1") { Console.WriteLine("Invalid entry."); continue; }

    int a = obj.login();
    if (a == -1) continue;

    Console.WriteLine("Login Successful! Welcome " + obj.username[a]);

    // ---------- ACCOUNT TYPE (only if first time) ----------
    string account_type;
    if (!obj.hasAccount[a])
    {
        Console.WriteLine();
        Console.WriteLine("What type of Account do you want to open ?");
        Console.WriteLine("1.Saving ");
        Console.WriteLine("2.Current ");
        Console.WriteLine("3.Exit");
        account_type = Console.ReadLine();

        if (account_type == "3") { Console.WriteLine("Thank you for visiting ABC Bank of Nepal."); break; }

        if (account_type == "1") obj.saving_account(a);
        else if (account_type == "2") obj.current_account(a);
        else { Console.WriteLine("Invalid entry."); continue; }
    }
    else
    {
        account_type = obj.account_type[a];
        Console.WriteLine("Welcome back " + obj.name[a] + "! Your balance: " + obj.balance[a]);
    }

    // ---------- BANKING MENU ----------
    int choice;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("1.Fix Deposit ");
        Console.WriteLine("2.Deposit ");
        Console.WriteLine("3.Withdraw");
        Console.WriteLine("4.Loan ");
        Console.WriteLine("5.Transfer Money");
        Console.WriteLine("6.Show Interest  ");
        Console.WriteLine("7.Show Details  ");
        Console.WriteLine("8.Balance  ");
        Console.WriteLine("9.Exit ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: obj.fixed_deposit(a); break;
            case 2: obj.deposit(a); break;
            case 3: obj.withdraw(a); break;
            case 4: obj.loan(a); break;
            case 5: obj.transfer(a); break;

            case 6:
                int choose;
                if (account_type == "1")
                {
                    Console.WriteLine("1.Saving Intrest ");
                    Console.WriteLine("2.Loan Intrest ");
                    Console.WriteLine("3.FD Intrest ");
                    Console.WriteLine("4.Transfer Intrest");
                    Console.WriteLine("5.Exit ");
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1: obj.saving_interest(a); break;
                        case 2: obj.loan_interest(); break;
                        case 3: obj.fd_interest(); break;
                        case 4: obj.transfer_interest(); break;
                        case 5: Console.WriteLine("Thank you !!!!!"); break;
                        default: Console.WriteLine("Invalid entry "); break;
                    }
                }
                else
                {
                    Console.WriteLine("1.Loan Intrest ");
                    Console.WriteLine("2.FD Intrest ");
                    Console.WriteLine("3.Exit ");
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1: obj.loan_interest(); break;
                        case 2: obj.fd_interest(); break;
                        case 3: Console.WriteLine("Thank you !!!!!"); break;
                        default: Console.WriteLine("Invalid entry "); break;
                    }
                }
                break;

            case 7: obj.display(a); break;
            case 8: obj.show_balance(a); break;
            case 9: Console.WriteLine("Thank You !!!!!!!!!!"); break;
            default: Console.WriteLine("Invalid Entry "); break;
        }

    } while (choice != 9);

} while (true);